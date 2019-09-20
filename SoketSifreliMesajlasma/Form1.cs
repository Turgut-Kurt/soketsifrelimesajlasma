using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Sockets;
using System.Net;
using System.Security.Cryptography;
namespace SoketSifreliMesajlasma
{
    public partial class AnaForm : Form
    {
        static string metin;
        static string metin2;
        public bool disable = false;
        Socket sck;
        EndPoint epBenim, epUzak;
        byte[] buffer;
        public AnaForm()
        {
            InitializeComponent();
        }
        private void AnaForm_Load(object sender, EventArgs e)
        {
            sck = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp);//soket tipi ve protokol tipi belirlenir
            sck.SetSocketOption(SocketOptionLevel.Socket, SocketOptionName.ReuseAddress, true);//.socket tüm udp ve tcp baglantıları için geçerlidir.kullanımdaki soketin bu adrese baglı olmasını sağlar.
            TxtBenimIP.Text = IPAdresim();
            TxtUzakIP.Text = IPAdresim();
        }
        private void BtnBaglan_Click(object sender, EventArgs e)
        {
            epBenim = new IPEndPoint(IPAddress.Parse(TxtBenimIP.Text), Convert.ToInt32(TxtBenimPort.Text));//ağ uç noktası olarak ip ve port bilgilerinin numarasını temsil eder.
            sck.Bind(epBenim);//endpoint tipinden bir nesne olarak ilişkilendirilir.
            epUzak = new IPEndPoint(IPAddress.Parse(TxtUzakIP.Text), Convert.ToInt32(TxtUzakPort.Text));
            sck.Connect(epUzak);//baglantı kurar
            buffer = new byte[1500];
            sck.BeginReceiveFrom(buffer, 0, buffer.Length, SocketFlags.None, ref epUzak, new AsyncCallback(SoketGelenMesaj), buffer);
            //alınan verileri için depolama//depolamanın nereden başlayacağı//nereye kadar depolanacağı//verinn kaynağının adresini//gelen veriyi//durumbilgilerini içeren dizi
            GidenMesaj.Enabled = true;
            BtnSifrele.Enabled = true;
            BtnTemizle.Enabled = true;
            BtnSifreCoz.Enabled = true;
            BtnGonder.Enabled = true;
            BtnBaglan.Enabled = false;
            GidenMesajSifreli.Enabled = true;
        }
        private void BtnSifrele_Click(object sender, EventArgs e)
        {
            metin = GidenMesaj.Text;
            byte[] veri = Encoding.UTF8.GetBytes(metin);
            string anahtar = "12345678";
            byte[] key = StringToByte(anahtar);
            byte[] enc = Sifrele(veri, key);
            GidenMesajSifreli.Text = Convert.ToBase64String(enc);
        }
        private void BtnTemizle_Click(object sender, EventArgs e)
        {
            GidenMesaj.Text = "";
            GidenMesajSifreli.Text = "";
            GelenMesaj.Text = "";
            GelenMesajSifreli.Text = "";
        }
        private void BtnSifreCoz_Click(object sender, EventArgs e)
        {
            metin2 = GelenMesajSifreli.Text;
            byte[] veri2 = Convert.FromBase64String(metin2);
            string anahtar2 = "12345678";
            byte[] key2 = StringToByte(anahtar2);
            byte[] dec = Sifrecoz(veri2, key2);
            GelenMesaj.Text = getString(dec);
            LstbxGenelKonusma.Items.Add("GELEN**********" + GelenMesaj.Text + "**********" + GelenMesajSifreli.Text);
            GelenMesajSifreli.Text = "";
        }
        private void BtnGonder_Click(object sender, EventArgs e)
        {
            LstbxGenelKonusma.Items.Add("GİDEN**********" + GidenMesaj.Text + "**********" + GidenMesajSifreli.Text);
            UTF8Encoding zEncoding = new UTF8Encoding();
            byte[] gidenMesaj = new byte[1500];
            gidenMesaj = zEncoding.GetBytes(GidenMesajSifreli.Text);
            sck.Send(gidenMesaj);
            GidenMesajSifreli.Text = "";
            GidenMesaj.Text = "";
            GelenMesaj.Text = "";
        }
        public string IPAdresim()
        {
            /*IPHostEntry host;
            host = Dns.GetHostEntry(Dns.GetHostName());
            foreach (IPAddress ip in host.AddressList)
            {
                if (ip.AddressFamily == AddressFamily.InterNetwork)
                {
                    return ip.ToString();
                }
            }
            return "127.0.0.1";*///aslında bu kısımda çalışıyor fakat vmware,virtual box gibi prgram kullananlarda çakışma oluşturuyor
            string ip = null;
            IPHostEntry host;
            host = Dns.GetHostEntry(Dns.GetHostName());
            foreach (IPAddress ipo in host.AddressList)
            {
                if (ipo.AddressFamily.ToString()== "InterNetwork")
                {
                    ip = ipo.ToString();
                }
            }
            return ip;
            
        }
        public static byte[] StringToByte(string deger)
        {
            UnicodeEncoding ByteConverter = new UnicodeEncoding();
            return ByteConverter.GetBytes(deger); //UnicodeEncoding.ASCII.GetBytes(deger); //
        }
        private void SoketGelenMesaj(IAsyncResult zResult)
        {
            try
            {
                byte[] gelenVeri = new byte[1500];
                gelenVeri = (byte[])zResult.AsyncState;//zamanuyumsuz işlem hakkında bilgi içeren bir nesne alır
                ASCIIEncoding zEncoding = new ASCIIEncoding();
                string GelenMesaj = zEncoding.GetString(gelenVeri);
                GelenMesajSifreli.Text = GelenMesaj;
                buffer = new byte[1500];
                sck.BeginReceiveFrom(buffer, 0, buffer.Length, SocketFlags.None, ref epUzak, new AsyncCallback(SoketGelenMesaj), buffer);
            }
            catch (Exception firlat)
            {
                MessageBox.Show(firlat.ToString());
            }
        }
        public static byte[] Sifrele(byte[] veri, byte[] anahtar)
        {
            using (AesCryptoServiceProvider acsp = new AesCryptoServiceProvider())
            {
                acsp.Key = anahtar;
                acsp.Padding = PaddingMode.PKCS7;
                acsp.Mode = CipherMode.ECB;
                ICryptoTransform sifreleyici = acsp.CreateEncryptor();
                return sifreleyici.TransformFinalBlock(veri, 0, veri.Length);
            }
        }
        private static byte[] Sifrecoz(byte[] veri, byte[] anahtar)
        {
            using (AesCryptoServiceProvider acsp = new AesCryptoServiceProvider())
            {
                acsp.Key = anahtar;
                acsp.Padding = PaddingMode.PKCS7;
                acsp.Mode = CipherMode.ECB;
                ICryptoTransform cozucu = acsp.CreateDecryptor();
                return cozucu.TransformFinalBlock(veri, 0, veri.Length);
            }
        }
        private static string getString(byte[] b)
        {
            return Encoding.UTF8.GetString(b);
        }
    }
}
