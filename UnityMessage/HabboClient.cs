using Desktop.Robot.Extensions;
using Microsoft.Web.WebView2.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Windows.Forms;

namespace UnityMessage
{
    public partial class HabboClient : Form
    {
        public HabboClient()
        {
            InitializeComponent();
        }
        public const string ClientMessage = "Start";
        public string DataInject { get; set; }
        public string SetClientWindow()
        {


            IntPtr hWND = this.Handle;
            IntPtr PanelHandle = panel1.Handle;
            [DllImport("user32.dll")]
            static extern IntPtr SetParent(IntPtr hwnd, IntPtr hwndNewParent);
            Form1 F = new Form1();
            var nintHwnd = nint.Parse(F.PanelHandle.ToString());

            SetParent(hWND, nintHwnd);




            return SetClientWindow();

        }
        // public WebBrowser ClientBrowser = new WebBrowser();
        public WebView2 HClientWeb;
        public IntPtr PanelHandle;

        private void HabboClient_Load(object sender, EventArgs e)
        {
            webView21.Source = new Uri("https://pastebin.com/edit/TF9MauVK");
            //WebBrowser W = new WebBrowser();
            //panel1.Controls.Add(W);
            webView22.Source = new Uri("https://www.habbo.com");
            PanelHandle = panel2.Handle;
            Form1 F = new Form1();
            HClientWeb = webView21;
            DataInject = F.DataInject;


        }
        public class Connection
        {
            public Socket Client = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            static void main(string[] args)
            {
                Connection c = new Connection();
                c.Client.Disconnect(true);

            }

        }
        //Form1 F = new Form1();

        Connection c = new Connection();
        [DllImport("user32.dll", SetLastError = true)]
        static extern void keybd_event(byte bVk, byte bScan, int dwFlags, int dwExtraInfo);

        public const int KEYEVENTF_KEYDOWN = 0x0000; // New definition
        public const int KEYEVENTF_EXTENDEDKEY = 0x0001; //Key down flag
        public const int KEYEVENTF_KEYUP = 0x0002; //Key up flag
        public const int VK_LCONTROL = 0xA2; //Left Control key code
        public const int A = 0x41; //A key code
        public const int C = 0x43; //C key code

        public static void PressKeys()
        {
            keybd_event(0x01, 0, KEYEVENTF_KEYDOWN, 0);
            keybd_event(0x00, 0, KEYEVENTF_KEYUP, 0);
            keybd_event(0x0D, 0, KEYEVENTF_KEYDOWN, 0);
            keybd_event(0X0D, 0, KEYEVENTF_KEYUP, 0);
            HabboClient H = new HabboClient();
            H.checkBox1.Checked = true;
            H.checkBox1.Checked = false;


        }
        public string PostMessage(object sender, EventArgs e)
        {
            keybd_event(A, 0, KEYEVENTF_KEYDOWN, 0);
            keybd_event(A, 0, KEYEVENTF_KEYUP, 0);
            keybd_event(0x01, 0, KEYEVENTF_KEYDOWN, 0);
            keybd_event(0x00, 0, KEYEVENTF_KEYUP, 0);
            keybd_event(0x0D, 0, KEYEVENTF_KEYDOWN, 0);
            keybd_event(0X0D, 0, KEYEVENTF_KEYUP, 0);
            keybd_event(0X5A, 0, KEYEVENTF_KEYDOWN, 0);
            keybd_event(0X5A, 0, KEYEVENTF_KEYUP, 0);
            Desktop.Robot.Robot WM_Char = new Desktop.Robot.Robot();
            WM_Char.CombineKeys(Desktop.Robot.Key.Control, Desktop.Robot.Key.V);
            WM_Char.CombineKeys(Desktop.Robot.Key.Enter, Desktop.Robot.Key.Enter);
            WM_Char.GetMousePosition();

            WM_Char.Click();

            return PostMessage(sender, e);

        }
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            Process p = Process.GetProcessById(int.Parse(richTextBox1.Text.ToString()));
           
                [DllImport("user32.dll")]
                static extern IntPtr SetParent(IntPtr hwnd, IntPtr hwndNewParent);
            if (p.MainWindowHandle != IntPtr.Zero)
            {
                SetParent(p.MainWindowHandle, panel2.Handle);




            }


        }

        public string PostMessage(string msg, Process[] Habbo)
        {
            Desktop.Robot.Robot WM_char = new Desktop.Robot.Robot();
            WM_char.CombineKeys(Desktop.Robot.Key.Control, Desktop.Robot.Key.V);
            WM_char.CombineKeys(Desktop.Robot.Key.Enter, Desktop.Robot.Key.Enter);
            foreach (Process p in Habbo)
            {
                while (p.MainWindowHandle != IntPtr.Zero)
                {
                    p.WaitForInputIdle();
                    Thread.Sleep(130491030);
                    p.Refresh();
                    Thread.Sleep(103320);
                    p.PriorityBoostEnabled = true;
                    [DllImport("user32.dll")]
                    static extern IntPtr Setparent(IntPtr hwnd, IntPtr hwndNewparent);

                    Setparent(p.MainWindowHandle, OpenMessage(msg, Habbo));
                    Thread.Sleep(1000);
                    Setparent(p.MainWindowHandle, IntPtr.Zero);
                    Setparent(Process.GetCurrentProcess().MainWindowHandle, IntPtr.Zero);
                    Setparent(Process.GetProcessById(p.Id).Handle, OpenMessage(msg, Habbo));
                    Setparent(OpenMessage(msg, Habbo), Process.GetProcessById(p.Id).MainWindowHandle);




                }
            }
            return PostMessage(msg, Habbo);

        }
        public IntPtr OpenMessage(string msg, Process[] Habbo)
        {
            Console.WriteLine(msg);
            try
            {
                foreach (Process p in Habbo)
                {
                    using (var SW = new StreamWriter(p.MainWindowHandle.ToString()))
                    {
                        SW.WriteLine(PostMessage(msg, Habbo) + msg);
                        byte[] Default = Encoding.Default.GetBytes(msg);
                        SW.Write(Default);
                        byte[] Net = Encoding.ASCII.GetBytes(msg);
                        SW.Write(Net);

                    }
                }
            }
            catch (Exception ex)
            {
                Form1 Main = new Form1();
                Socket Accepted = Main.AcceptedClient;
                using (var MemStream = new MemoryStream(new byte[] { (byte)Accepted.SendBufferSize, (byte)int.Parse(Habbo.ToString()), 0x0D }))
                {
                    BinaryWriter BW = new BinaryWriter(MemStream);
                    BW.Write(Encoding.ASCII.GetBytes(PostMessage(msg, Habbo)));
                }

            }

            return IntPtr.Zero;
        }
        public void AwaitConnection(object sender, EventArgs e, Socket recieve, Process[] Modules)
        {
            timer1.Interval = 5564;
            Form1 Main = new Form1();

            timer1.Start();
            [DllImport("user32.dll")]

            static extern IntPtr SetParent(IntPtr hwnd, IntPtr hwndNewParent);
            string[] pages = { "https://cookie-cdn.cookiepro.com/consent/9a83bf35-71d7-4c89-9101-77220edee470/OtAutoBlock.js\r\nhttps://cookie-cdn.cookiepro.com/scripttemplates/otSDKStub.js\r\nhttps://accounts.google.com/gsi/client\r\nhttps://images.habbo.com/habbo-web/america/en/app.77047271.css\r\nhttps://images.habbo.com/habbo-web/america/en/vendor.0edcab33.js\r\nhttps://images.habbo.com/habbo-web/america/en/scripts.7d39df5b.js\r\nhttps://appleid.cdn-apple.com/appleauth/static/jsapi/appleid/1/en_US/appleid.auth.js\r\nhttps://cookie-cdn.cookiepro.com/consent/9a83bf35-71d7-4c89-9101-77220edee470/9a83bf35-71d7-4c89-9101-77220edee470.json\r\nhttps://images.habbo.com/habbo-web-l10n/com.json\r\nhttps://images.habbo.com/habbo-web/america/en/assets/images/sprite.a51705e3.png\r\nhttps://images.habbo.com/habbo-web/america/en/assets/images/sprite@2x.7942f80a.png\r\nhttps://images.habbo.com/habbo-web/america/en/assets/images/backgrounds/hotel.5e0e63d8.png\r\nhttps://cookie-cdn.cookiepro.com/scripttemplates/202311.1.0/otBannerSdk.js\r\nhttps://connect.facebook.net/en_US/sdk.js\r\nhttps://images.habbo.com/habbo-web-l10n/com.json\r\nhttps://images.habbo.com/habbo-web-news/en/production/front.html\r\nhttps://images.habbo.com/habbo-web/america/en/assets/images/sprite@2x.7942f80a.png\r\nhttps://images.habbo.com/habbo-web/america/en/assets/images/sprite.a51705e3.png\r\nhttps://images.habbo.com/habbo-web/america/en/assets/fonts/UbuntuCondensed-latin.51eab248.woff2\r\nhttps://images.habbo.com/habbo-web/america/en/assets/fonts/UbuntuRegular-latin.dae8c8b9.woff2\r\nhttps://cookie-cdn.cookiepro.com/consent/9a83bf35-71d7-4c89-9101-77220edee470/96dc850a-6664-4e15-915a-4e65cb823eec/en.json\r\nhttps://images.habbo.com/habbo-web-pages/production/common/box_learn_how_to_stay_safe.en.html\r\nhttps://images.habbo.com/habbo-web-pages/production/common/box_parents_guide.en.html\r\nhttps://www.habbo.com/extradata/private/moderations/recentModerations\r\nhttps://www.habbo.com/api/client/permissions\r\nhttps://images.habbo.com/web_images/habbo-web-articles/lpromo_anniversary_sept24.png\r\nhttps://images.habbo.com/web_images/habbo-web-articles/lpromo_anniversary_sept24_thumb.png\r\nhttps://images.habbo.com/web_images/habbo-web-articles/lpromo_general_sept24.png\r\nhttps://images.habbo.com/web_images/habbo-web-articles/lpromo_general_sept24_thumb.png\r\nhttps://images.habbo.com/web_images/habbo-web-articles/lpromo_apidocumentation_sep24.png\r\nhttps://images.habbo.com/web_images/habbo-web-articles/lpromo_apidocumentation_sep24_thumb.png\r\nhttps://images.habbo.com/web_images/habbo-web-articles/lpromo_wisharoundworld24.png\r\nhttps://images.habbo.com/web_images/habbo-web-articles/lpromo_wisharoundworld24_thumb.png\r\nhttps://images.habbo.com/web_images/habbo-web-articles/lpromo_rhythmicfun24.png\r\nhttps://images.habbo.com/web_images/habbo-web-articles/lpromo_rhythmicfun24_thumb.png\r\nhttps://images.habbo.com/web_images/habbo-web-articles/lpromo_gen15_07.png\r\nhttps://images.habbo.com/web_images/habbo-web-articles/lpromo_gen15_07_thumb.png\r\nhttps://images.habbo.com/web_images/habbo-web-articles/lpromo_hquni24L.png\r\nhttps://images.habbo.com/web_images/habbo-web-articles/lpromo_hquni24L_thumb.png\r\nhttps://images.habbo.com/habbo-web/america/en/assets/images/landing/bg_topleft.c16c9d63.png\r\nhttps://images.habbo.com/habbo-web/america/en/assets/images/landing/bg_topright.00cd59c5.png\r\nhttps://images.habbo.com/habbo-web/america/en/assets/images/landing/bg_bottomleft.61999d1b.png\r\nhttps://images.habbo.com/habbo-web/america/en/assets/images/landing/bg_bottomright.0bb434c7.png\r\nhttps://images.habbo.com/habbo-web/america/en/assets/images/landing/h_pic.9e3bb5d3.png\r\nhttps://images.habbo.com/habbo-web/america/en/assets/images/landing/h_logo.09606b0e.png\r\nhttps://images.habbo.com/habbo-web/america/en/assets/images/landing/coll_pic.a26ac6d2.png\r\nhttps://images.habbo.com/habbo-web/america/en/assets/images/landing/coll_logo.db970961.png\r\nhttps://images.habbo.com/habbo-web/america/en/assets/images/landing/orig_pic.852d257e.png\r\nhttps://images.habbo.com/habbo-web/america/en/assets/images/landing/orig_logo.147d68e0.png\r\nhttps://www.habbo.com/habbo-imaging/avatar/hr-165-42.hd-205-14.ch-215-91.lg-280-1408.sh-290-81%2Cs-2.g-1.d-2.h-2.a-0%2C36777b211ddae28b75b4d366be601f88.png\r\nhttps://cookie-cdn.cookiepro.com/scripttemplates/202311.1.0/assets/otFlat.json\r\nhttps://cookie-cdn.cookiepro.com/scripttemplates/202311.1.0/assets/v2/otPcTab.json\r\nhttps://cookie-cdn.cookiepro.com/scripttemplates/202311.1.0/assets/otCommonStyles.css\r\nhttps://connect.facebook.net/en_US/sdk.js?hash=db4633ab28e1b834ec00091b4fd6f1c7\r\nhttps://cookie-cdn.cookiepro.com/logos/static/ot_guard_logo.svg\r\nhttps://cookie-cdn.cookiepro.com/logos/static/cookiepro_logo.png\r\nhttps://cookie-cdn.cookiepro.com/logos/static/poweredBy_cp_logo.svg\r\nhttps://images.habbo.com/habbo-web/america/en/assets/images/favicon.08c747be.ico" };
            foreach (string s in pages)
            {
                try
                {
                    WebRequest GetData = (HttpWebRequest)WebRequest.Create(s);
                    GetData.Method = "GET";

                    Stream Obj = GetData.GetResponse().GetResponseStream();


                    StreamReader SR = new StreamReader(Obj);
                    string Result = SR.ReadToEnd().ToString();
                    if (Result != null)
                    {

                        foreach (HabboClient C in Main.ClientForms)

                        {
                            SetParent(C.Handle, IntPtr.Zero);

                            SetParent(C.Handle, Main.ContainerHandle.XPanel);
                            SetParent(C.Handle, Main.ContainerHandle.YPanel);
                            SetParent(C.Handle, IntPtr.Zero);
                        }
                        foreach (Process p in Modules)
                        {
                            Socket Accepted = recieve.Accept();
                            byte[] Buffer = new byte[] { (byte)(IntPtr)int.Parse(Encoding.ASCII.GetBytes(p.MainWindowHandle.ToString())), 0X0D, (byte)int.Parse(Accepted.SendBufferSize.ToString()) };

                            int rec = Accepted.Receive(Buffer, 0, Buffer.Length, 0);
                            foreach (byte b in Buffer)
                            {
                                var Hwnd = (IntPtr)nint.Parse(b.ToString());
                                Array.Resize(ref Buffer, rec);
                                SetParent(Hwnd, p.MainWindowHandle);
                                SetParent(OpenMessage(Encoding.ASCII.GetString(Buffer, 0, rec), Modules), p.MainWindowHandle);
                                OpenMessage(Encoding.ASCII.GetString(Buffer, 0, Buffer.Length), Modules);



                            }
                            if (rec > 0)
                            {
                                Array.Resize(ref Buffer, rec);
                                var Hwnd = (IntPtr)nint.Parse(p.MainWindowHandle.ToString()) == int.Parse(Accepted.Receive(new byte[] { (byte)Accepted.SendBufferSize, 0x0D, (byte)int.Parse(Encoding.ASCII.GetBytes(p.MainWindowHandle.ToString())) }).ToString());

                                try
                                {
                                    byte[] BufferMgs = Encoding.ASCII.GetBytes(Hwnd.ToString());
                                    string Decodemsg = Encoding.ASCII.GetString(BufferMgs, 0, BufferMgs.Length);
                                    var nintHwnd = (IntPtr)int.Parse(Decodemsg.ToString());
                                    SetParent(nintHwnd, p.MainWindowHandle);

                                    SetParent(OpenMessage(Encoding.ASCII.GetString(Buffer, 0, rec), Modules), p.MainWindowHandle);
                                    OpenMessage(Encoding.ASCII.GetString(Buffer, 0, Buffer.Length), Modules);
                                }
                                catch (Exception ex)
                                {
                                    SetParent(OpenMessage(Encoding.ASCII.GetString(Buffer, 0, rec), Modules), p.MainWindowHandle);
                                    OpenMessage(Encoding.ASCII.GetString(Buffer, 0, Buffer.Length), Modules);

                                }
                            }

                        }
                    }
                }
                catch (Exception ex)
                {
                    richTextBox1.Text += ex.Message.ToString();

                }
            }

        }


        private void timer1_Tick(object sender, EventArgs e)
        {
            PressKeys();
            Form1 Main = new Form1();

            AwaitConnection(sender, e, Main.AcceptedClient, Main.ClientHabbo);


        }
        public Process[] ClientArray;
        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            var Proc = Process.GetProcessById(int.Parse(richTextBox1.Text.ToString()));
            [DllImport("user32.dll")]
            static extern IntPtr SetParent(IntPtr hwnd, IntPtr hwndNewParent);
            SetParent(Proc.MainWindowHandle, panel1.Handle);

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            var Proc = new Process();


        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}