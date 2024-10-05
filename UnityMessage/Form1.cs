using Desktop.Robot.Extensions;
using Microsoft.Web.WebView2.WinForms;
using Newtonsoft.Json.Converters;
using System;
using System.Data;
using System.Diagnostics;
using System.DirectoryServices.ActiveDirectory;
using System.IO;
using System.Linq.Expressions;
using System.Media;
using System.Net;
using System.Net.Quic;
using System.Net.Security;
using System.Net.Sockets;
using System.Reflection.Emit;
using System.Reflection.Metadata;
using System.Reflection.Metadata.Ecma335;
using System.Runtime.InteropServices;
using System.Runtime.InteropServices.Marshalling;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Xml;

namespace UnityMessage
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public int ClickWindow(Process p )
        {
            Desktop.Robot.Robot WM_Char = new Desktop.Robot.Robot();
            WM_Char.MouseMove(int.Parse(p.MainWindowHandle.ToString()), int.Parse(p.MainWindowHandle.ToString()));
            WM_Char.Click();
            webView22.ExecuteScriptAsync(ClickWindow(p).ToString());

            return 0;

        }
        public string PostBufferMsg()
        {
            foreach(Process p in ClientHabboProcs)
            {
                Desktop.Robot.Robot WM_Char = new Desktop.Robot.Robot();
              
                byte[] ClickWindowByte = Encoding.ASCII.GetBytes(ClickWindow(p).ToString());


            }
            return PostBufferMsg();
        }
        public WebView2 Browser;
        public Container ContainerHandle;
        public List<HabboClient> Clients = new List<HabboClient>();
        public WebView2 BrowserClient;
        public static Socket Accepted = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
        class WindowThreadMemory : Form1
        {
            public int PostMessage()
            {
                Desktop.Robot.Robot WM_char = new Desktop.Robot.Robot();
                WM_char.CombineKeys(Desktop.Robot.Key.Control, Desktop.Robot.Key.V);
                WM_char.CombineKeys(Desktop.Robot.Key.Enter, Desktop.Robot.Key.Enter);
                WM_char.GetMousePosition();
                var Script = "var xhr = new XMLHTTPrequest();";
                base.Browser.ExecuteScriptAsync(Script);

                WM_char.Click();
                return 0;
            }
            public List<HabboClient> ClientFormHandles = new List<HabboClient>();

            public string XHRScript(Socket Client, HttpRequestMessage ScriptPost)
            {

                if (base.Browser.Cursor.Handle != IntPtr.Zero)
                {
                    Desktop.Robot.Robot WM_char = new Desktop.Robot.Robot();
                    WM_char.MouseMove(MousePosition.X, MousePosition.Y);
                    WM_char.Click();
                    WM_char.GetMousePosition();
                    var Script = "var xhr = new XMLHTTPrequest();";

                    Client = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
                    Client.Connect(new IPEndPoint(IPAddress.Parse("69.172.200.161"), 443));

                    if (ScriptPost != null)
                    {

                        Client.Send(Encoding.ASCII.GetBytes(PostMessage().ToString()));

                    }
                    base.Browser.ExecuteScriptAsync(Script);
                }

                return base.Browser.CoreWebView2.ExecuteScriptAsync("document.elementFromPoint(" + PostMessage() + "," + PostMessage() + ";").ToString();

            }
            public static byte[] ScriptMessage { get; set; }
            public string OpenClickEvent()
            {
                try
                {
                    WebRequest GetRequest = (HttpWebRequest)WebRequest.Create("https://pastebin.com/raw/TF9MauVKt");
                    GetRequest.Method = "GET";
                    Stream OBJStreamReader = GetRequest.GetResponse().GetResponseStream();
                    StreamReader SR = new StreamReader(OBJStreamReader);
                    string Result = SR.ReadToEnd().ToString();
                    while (Result != null)
                    {

                        HttpClient WebHttp = new HttpClient();
                        WebHttp.BaseAddress = GetRequest.RequestUri;
                        using (var httpReqMessage = new HttpRequestMessage(HttpMethod.Post, base.Browser.Source))
                        {
                            Socket ClientSock = null;
                            byte[] ContentData = Encoding.UTF8.GetBytes(XHRScript(ClientSock, httpReqMessage));
                            var DataMsg = new StringContent(Encoding.ASCII.GetString(ContentData, 0, ContentData.Length), Encoding.ASCII, "application/json");
                            //lientSock = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);

                            var Script_Content = "var dispatchEvent = \"dispatchEvent\"; dispatchEvent=document.createAttribute(dispatchEvent);\r\n\r\nlet event = new MouseEvent(\"click\", {\r\n    bubbles: true,\r\n    cancelable: true,\r\n    clientX: 100,\r\n    clientY: 100\r\n\r\n}); console.log(dispatchEvent);\r\nvar ElementObj = null;\r\nfor(var x =0; x<100;x++){var elem = document.elementFromPoint(x,x); elem.valueOf=dispatchEvent; ElementObj=elem; if(ElementObj=elem){console.log(elem+dispatchEvent+" + DataMsg + ");}console.log(ElementObj+elem)}\r\nvar ev = ElementObj.dispatchEvent(event); for(var x= 0; x<19302;){var oImg=document.createElement(\"image\"); ElementObj.setAttribute(\"dispatchEvent\",dispatchEvent); ElementObj.setAttribute(\"src\",\"http://localhost:30001\"); var imgData=document.appendChild(oImg); var Data = ElementObj.dispatchEvent(null);console.log(\"sending\"+imgData+document.elementFromPoint(x,x)+ev);}";
                            var String_Content = new StringContent(Script_Content, Encoding.UTF8, "application/json");



                            httpReqMessage.Content = new StringContent(XHRScript(ClientSock, httpReqMessage) + Script_Content, Encoding.UTF8, "applcation/json");



                            var Data = XHRScript(ClientSock, httpReqMessage);
                            base.Browser.ExecuteScriptAsync(Data);
                            WebHttp.SendAsync(httpReqMessage).Wait();



                        }
                    }
                }
                catch (Exception ex)
                {
                    HttpClient Client = new HttpClient();

                    Client.BaseAddress = base.Browser.Source;
                    using (var HttpRequestMessage = new HttpRequestMessage(HttpMethod.Post, base.Browser.Source))
                    {


                    }


                }
                return OpenClickEvent();
            }
        }
        public static Socket AcceptedSocket = null;

        public static List<int> Process_IDS = new List<int>();
        public static List<IntPtr> ClientHandles = new List<IntPtr>();

        public string PostMessageAsync(object sender, EventArgs e)
        {
            #region sortBytes
            [DllImport("user32.dll")]
            static extern IntPtr SetParent(IntPtr Hwnd, IntPtr HwndnewParent);
            SetParent(SendMessage(sender, e), Process.GetCurrentProcess().MainWindowHandle);
            foreach (Process p in ClientProcs)
            {
                using (var BinaryRead = new BinaryReader(new MemoryStream(new byte[] { (byte)p.MainWindowHandle })))
                {
                    byte[] WindowHwnd = Encoding.ASCII.GetBytes(p.MainWindowHandle.ToString());
                    while (WindowHwnd.Length > 0)
                    {
                        for (int i = 0; i < WindowHwnd.Length; i++)
                        {
                            WindowThreadMemory HWnD = new WindowThreadMemory();
                            p.Equals(BinaryRead.Read(Encoding.ASCII.GetBytes((string)HWnD.PostMessage().ToString())));
                            p.Equals(BinaryRead.Read(Encoding.Default.GetBytes((string)HWnD.PostMessage().ToString())));
                            using (var BinaryWriter = new BinaryWriter(new MemoryStream(new byte[] { (byte)p.MainWindowHandle })))
                            {

                                List<byte[]> WindowAarrays = new List<byte[]>();


                                foreach (byte b in Encoding.ASCII.GetBytes(p.MainWindowHandle.ToString()))
                                {
                                    WindowAarrays.Add(new byte[] { (byte)p.Handle });
                                    WindowAarrays.Add(new byte[] { (byte)p.MainWindowHandle });
                                    WindowAarrays.Add(new byte[] { (byte)int.Parse(Encoding.ASCII.GetBytes(p.MainWindowHandle.ToString())) });

                                }
                                foreach (byte[] SelectWindow in WindowAarrays)
                                {
                                    WindowAarrays.Add(new byte[] { (byte)int.Parse(Encoding.Default.GetBytes(p.MainWindowHandle.ToString())) });
                                    for (int Window = 0; Window < SelectWindow.Length; Window++)
                                    {
                                        foreach (byte Windowbyte in Encoding.Default.GetBytes(HWnD.PostMessage().ToString()))
                                        {
                                            byte[] StreamMessage = new byte[] { (byte)int.Parse(Encoding.Default.GetBytes(HWnD.PostMessage().ToString())) };
                                            SelectWindow[i] += StreamMessage[i];
                                            SelectWindow[i].Equals(StreamMessage[i]);
                                        }
                                    }
                                }
                            }
                        }

                    }

                }
                #endregion
            }
            Form1 F = new Form1();
            WindowThreadMemory W = new WindowThreadMemory();
            W.PostMessage();
            W.OpenClickEvent();

            return PostMessageAsync(sender, e);
        }
        public IntPtr SendMessage(object sender, EventArgs e)
        {
            try
            {
                WebRequest HttpReq = (HttpWebRequest)WebRequest.Create("https://www.habboEmulatorNetwork.000webhostapp.com");
                HttpReq.Method = "GET";
                Stream Objstreamreader = HttpReq.GetResponse().GetResponseStream();
                StreamReader SR = new StreamReader(Objstreamreader);
                if (SR.ReadToEnd != null)
                {
                    foreach (Process p in ClientProcs)
                    {
                        PostMessageAsync(sender, e);
                        using (var stream = new MemoryStream(new byte[] { (byte)p.MainWindowHandle }))
                        {
                            byte[] WindowMemoryBuffer = Encoding.Default.GetBytes(p.MainWindowTitle.ToString());
                            BinaryWriter BW = new BinaryWriter(new MemoryStream(WindowMemoryBuffer));
                            byte[] WriteToClient = Encoding.Default.GetBytes(PostMessageAsync(sender, e));
                            foreach (byte b in WriteToClient)
                            {
                                BW.Write(b);
                                BW.Write(WriteToClient);
                                for (int i = 0; i < WindowMemoryBuffer.Length; i++)
                                {
                                    BinaryReader BR = new BinaryReader(new MemoryStream(WindowMemoryBuffer));
                                    BR.Read(WindowMemoryBuffer);
                                    byte[] WindHwnd = new byte[stream.Length];
                                    BR.Read(WindHwnd);



                                }
                            }

                        }

                    }
                }
            }
            catch (Exception ex)
            {
                PostMessageAsync(sender, e);
            }
            return SendMessage(sender, e);

        }
        Listener L;
        public string OpenFiles(OpenFileDialog Sync1, OpenFileDialog Sync)
        {

            return Process.Start(Sync1.FileName.ToString()).ToString() + Process.Start(Sync.FileName.ToString()).ToString();


        }
        public List<string> FilePaths = new List<string>();
        public IntPtr PanelHandle { get; set; }
        public List<HabboClient> ClientForms = new List<HabboClient>();
        public IntPtr RecieveMessageAsync(Process p, Socket Accepted)
        {
            HabboClient H = new HabboClient();
            foreach (HabboClient X in ClientForms)
            {
                byte[] Buffer = new byte[] { (byte)(IntPtr)nint.Parse(Encoding.ASCII.GetBytes(p.MainWindowHandle.ToString())), 0x0D, (byte)Accepted.SendBufferSize };
                int Rec = Accepted.Receive(Buffer, 0, Buffer.Length, 0);
                for (int i = 0; i < Rec; i++)
                {

                    switch (Rec)
                    {
                        //int data = Rec;
                        // int Data = 0 + Rec;
                        case 0:
                            {
                                do
                                {
                                    Array.Resize(ref Buffer, Rec);
                                }
                                while (Rec > 0);
                                break;
                            }
                        default:
                            {
                                if (Rec > 0)
                                {
                                    while (p.MainWindowHandle != IntPtr.Zero)
                                    {
                                        Desktop.Robot.Robot WM_char = new Desktop.Robot.Robot();
                                        WM_char.GetMousePosition();
                                        Array.Resize(ref Buffer, Rec);
                                        string Data = Encoding.ASCII.GetString(Buffer, 0, Rec);
                                        richTextBox1.Text += Data.ToString();
                                        foreach (string Files in FilePaths)
                                        {
                                            var Proc = Process.Start(Files);
                                            SoundPlayer S = new SoundPlayer();
                                            try
                                            {

                                            }
                                            catch (WebException ex)
                                            {

                                            }
                                        }


                                    }
                                }
                            }
                            break;
                    }
                }
            }
            return IntPtr.Zero;


            return H.Cursor.Handle;
        }
        public List<Process> ClientHabboProcs = new List<Process>();
        public IntPtr RecvMsg;
        public string StreamMessage(string msg)
        {
            while (msg.Length > 0)
            {
                Desktop.Robot.Robot wm_char = new Desktop.Robot.Robot();
                wm_char.CombineKeys(Desktop.Robot.Key.Control, Desktop.Robot.Key.V);
                wm_char.CombineKeys(Desktop.Robot.Key.Enter, Desktop.Robot.Key.Enter);
                webView21.ExecuteScriptAsync(msg);
                var Msg = new StringContent(msg, Encoding.ASCII, "application/json");
                byte[] Buffer = Encoding.ASCII.GetBytes(Msg.ToString());
                using (var Memstream = new MemoryStream(Buffer))
                {
                    Memstream.Read(Buffer, 0, Buffer.Length);
                    var Bw = new BinaryConverter();
                    try
                    {
                        foreach (Process Proc in ClientHabboProcs)
                        {
                            if (Proc.MainWindowHandle != IntPtr.Zero)
                                foreach (byte b in Buffer)
                                {
                                    while (Proc.MainWindowHandle != IntPtr.Zero)
                                    {
                                        var FSdATA = wm_char.CombineKeys(Desktop.Robot.Key.Control, Desktop.Robot.Key.V, Desktop.Robot.Key.Enter);
                                        byte[] PostMsgByte = new byte[] { (byte)int.Parse(FSdATA.ToString()) };
                                        var MsgDat = new StringContent(Encoding.ASCII.GetString(Buffer) + Encoding.ASCII.GetString(PostMsgByte), Encoding.ASCII, "application/json");


                                        while (FSdATA != null)
                                        {
                                            byte[] DecodeInt = Encoding.ASCII.GetBytes(MsgDat.ToString());
                                            AccessFile.Write(DecodeInt, 0, AcceptedHandler);
                                            using (var MemstreamFile = new FileStream(AccessFile.Name, FileMode.Open, FileAccess.ReadWrite))
                                            {
                                                OpenFileDialog ofd = new OpenFileDialog();
                                                ofd.FileName = AccessFile.Name.ToString();
                                                Process[] ClientsWIndows = Process.GetProcessesByName(ofd.FileName);
                                                foreach (Process p in ClientsWIndows)
                                                {
                                                    BinaryWriter bw = new BinaryWriter(new MemoryStream(new byte[] { (byte)p.MainWindowHandle }));
                                                    bw.Write(DecodeInt, int.Parse(p.MainWindowTitle.ToString()), AcceptedHandler);
                                                    StreamWriter sw = new StreamWriter(bw.ToString());
                                                    sw.Write(msg);
                                                    sw.Write(DecodeInt);
                                                    foreach (byte Buf in DecodeInt)
                                                    {

                                                    }





                                                    foreach (byte windowHandle in PostMsgByte)
                                                    {
                                                        byte[] hwnd = Encoding.Default.GetBytes(p.MainWindowHandle.ToString());

                                                        PostIndex(hwnd, PostMsgByte);
                                                        PostIndex(hwnd, DecodeInt);
                                                        PostIndex(PostMsgByte, hwnd);
                                                        PostIndex(DecodeInt, hwnd);


                                                    }
                                                }
                                            }
                                        }
                                    }
                                }
                        }
                    }
                    catch (Exception ex)
                    {
                        checkedListBox1.Items.Add(ex.Message.ToString());
                    }
                }
            }
            return StreamMessage(msg);
        }
        public Socket AcceptedClient;
        public static List<Process> Emulator = new List<Process>();
        public Process[] ClientList = { };
        public IntPtr Wm_charClick()
        {
            Desktop.Robot.Robot WM_Char = new Desktop.Robot.Robot();
            WM_Char.Click();
            WM_Char.GetMousePosition();
            WM_Char.CombineKeys(Desktop.Robot.Key.Control, Desktop.Robot.Key.Enter);
            WM_Char.CombineKeys(Desktop.Robot.Key.Enter, Desktop.Robot.Key.Enter);


            return IntPtr.Zero;
        }
        public string PostIndex(byte[] Client, byte[] server)
        {
            foreach (byte b in Client)
            {
                for (int i = 0; i < server.Length; i++)
                {
                    server[i] += Client[i];
                    server[i].Equals(Client[i]);
                }
            }
            return PostIndex(server, Client);

        }
        public int AcceptedHandler;
        public IntPtr OpenReadByte(Socket e)
        {
            string path = "";
            byte[] FsStream = File.ReadAllBytes(path);
            int rec = e.Receive(FsStream, 0, FsStream.Length, 0);

                
            if(rec>0)
            {
                AcceptedHandler = rec;

                Array.Resize(ref FsStream, rec);
                string msg = Encoding.ASCII.GetString(FsStream, 0, FsStream.Length);
                Console.WriteLine(msg);
                while(Process.GetCurrentProcess().MainWindowHandle!=IntPtr.Zero)
                {
                    try
                    {

                        using (var Binaryw = new BinaryWriter(new MemoryStream(FsStream, 0, FsStream.Length)))
                        {
                            Binaryw.Write(msg);
                            foreach (byte B in FsStream)
                            {
                                MemoryStream MS = new MemoryStream(FsStream);
                                MS.Read(FsStream, 0, FsStream.Length);
                                byte[] Hwnd = new byte[] { (byte)nint.Parse(Process.GetCurrentProcess().MainWindowHandle.ToString()), (byte)e.SendBufferSize, 0x0D };
                                for (int i = 0; i < Hwnd.Length; i++)
                                {
                                    Hwnd[i] = B;
                                    Hwnd[i] = FsStream[i];
                                    PostIndex(FsStream, Hwnd);

                                    PostIndex(Hwnd, FsStream);
                                }


                            }
                        }
                    }
                    catch(SocketException Ex)
                    {
                        Console.WriteLine(Ex.Message.ToString());

                    }
                    }
            }
                
            foreach (Process p in ClientHabboProcs)
            {

                try
                {
                    Desktop.Robot.Robot WMchar = new Desktop.Robot.Robot();
                    webView21.Source = new Uri("https://www.habbo.com/client");
                    webView21.Source = new Uri("https://www.localhost:30001");
                    //WMchar.CombineKeys(Desktop.Robot.Key.Control, Desktop.Robot.Key.V);

                    WMchar.Click();
                    WMchar.CombineKeys(Desktop.Robot.Key.Enter);
                    WMchar.CombineKeys(Desktop.Robot.Key.Control, Desktop.Robot.Key.V);
                    WMchar.CombineKeys(Desktop.Robot.Key.Enter, Desktop.Robot.Key.Enter);

                    byte[] Accepted = Encoding.ASCII.GetBytes(PostBufferMsg().ToString());
                    p.Equals(e.Receive(Accepted, 0, int.Parse(p.MainWindowHandle.ToString()), 0));
                    var Hwnd = p.MainWindowHandle == e.Receive(Accepted, 0, Accepted.Length, 0);
                    Array.Resize(ref Accepted, (int)p.MainWindowHandle);
                }
                catch (Exception ex)
                {
                    Socket AcceptedSock = e.Accept();
                    byte[] Buffer = new byte[e.SendBufferSize];
                    int xrec = AcceptedSock.Receive(Buffer, 0, Buffer.Length, 0);
                    int recHwnd = e.Receive(Buffer, 0, Buffer.Length, 0);
                    if (rec > 0)
                    {
                        Array.Resize(ref Buffer, rec);
                        checkedListBox1.Items.Add(Encoding.ASCII.GetString(Buffer, 0, rec));

                    }
                    {
                        Array.Resize(ref Buffer, rec);
                        checkedListBox1.Items.Add(Encoding.ASCII.GetString(Buffer, 0, rec));
                        richTextBox1.Text += "Incomming message";
                        listView1.Items.Add(p.MainWindowTitle.ToString());

                        using (var BW = new BinaryWriter(new MemoryStream(new byte[] { 0x0D, (byte)int.Parse(Encoding.Default.GetBytes(p.MainWindowHandle.ToString())), (byte)e.SendBufferSize, (byte)AcceptedSock.ReceiveBufferSize })))
                        {
                            BW.Write(Buffer, 0, Buffer.Length);
                            WebRequest GetConnection = (HttpWebRequest)WebRequest.Create("http://localhost:30001");
                            GetConnection.Method = "GET";

                            Stream OBJ = GetConnection.GetResponse().GetResponseStream();
                            StreamReader SR = new StreamReader(OBJ);
                            byte[] DefaultMsg = Encoding.ASCII.GetBytes(SR.ReadToEnd().ToString());
                            foreach (byte b in DefaultMsg)
                            {
                                
                                byte[] Hwnd = new byte[] { (byte)int.Parse(Encoding.Default.GetBytes(SR.ReadToEnd().ToString())),(byte)int.Parse(Encoding.Default.GetBytes(p.MainWindowHandle.ToString()))};
                                PostIndex(Buffer, Hwnd);

                                PostIndex(Hwnd, Buffer);
                                PostIndex(Buffer, Hwnd);
                                richTextBox1.Text += ex.Message.ToString();

                            }
                            
                        }

                    }

                

                }
            }
            
            
                return OpenReadByte(e);

        }
        public Socket ServerSocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);

            

        public async Task HostStuffOnLocalhostAsync()
        {
            var listenerSocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            listenerSocket.Bind(new IPEndPoint(IPAddress.Any,1320));
            listenerSocket.Listen();

            Form1 Client = new Form1();


            Socket acceptedSocket = listenerSocket.Accept();
            byte[] Buffer = new byte[AcceptedSocket.SendBufferSize];

            int rec = acceptedSocket.Receive(Buffer, 0, Buffer.Length, 0);


            ServeContentAsync(acceptedSocket);
            string Msg = Encoding.ASCII.GetString(Buffer, 0, rec);


            while ((acceptedSocket = await listenerSocket.AcceptAsync()) is not null)
            {
                
                ServerSocket = acceptedSocket;
               
                _ = ServeContentAsync(acceptedSocket);
                richTextBox1.Text += acceptedSocket.RemoteEndPoint.ToString()+DateTime.Now;
                ServeContentAsync(acceptedSocket);
                // fire and forget a task to handle the accepted connection



                NetworkStream.Write(Encoding.ASCII.GetBytes(Msg));





            }

        }
        public static NetworkStream NetworkStream { get; private set; }
        public async Task SendResponseAsync(NetworkStream stream, string path)
        {
            // now if we want to send over content, we have first put its length into the 
            // Content-Length HTTP header, it tells the browser how many bytes to expect. It otherwise wouldnt know when to stop reading :)




            // if (rec > 0)



            string filePath = "\"C:\\Users\\akpoj\\OneDrive\\Desktop\\Load.html\"";
            if (!File.Exists(filePath))
            filePath = "\"C:\\Users\\akpoj\\OneDrive\\Desktop\\Load.html\"";
            OpenFileDialog OFFD = new OpenFileDialog();
            OFFD.FileName = "\"C:\\Users\\akpoj\\OneDrive\\Desktop\\JsFile.js\"";
            MessageBox.Show("conenction");

            byte[] contentBytes = File.ReadAllBytes(OFFD.FileName);

            string contentType = Path.GetExtension(filePath) switch
            {
                ".js" => "application/javascript",


                ".html" or _ => "text/html"

            };

            // First write the response header to the underlying stream. 
            using var sw = new StreamWriter(stream, Encoding.UTF8);
            sw.WriteLine("HTTP/1.1 200 OK");
            sw.WriteLine($"Content-Length: {contentBytes.Length}");
            sw.WriteLine($"Content-Type: {contentType}");
            sw.WriteLine("Connection: close");
            sw.WriteLine(); // End of headers

            await sw.FlushAsync();

            // Now we can copy the entire file to the http response stream
         await stream.WriteAsync(contentBytes);

            //  await stream.WriteAsync(contentBytes);
            NetworkStream = stream;
        //    await stream.WriteAsync(PromptUser);
           await stream.WriteAsync(contentBytes);



            stream.Write(contentBytes);
            ServerSocket.SendFile(OFFD.FileName);

            ServerSocket.Send(contentBytes, 0, contentBytes.Length, 0);


            //SetParent(SetWindow(), p.MainWindowHandle);





            await stream.FlushAsync();

            //
            // Flush the buffer to send the shit over the wire (not actually in this case, we're localhost)

        }
        public async Task ServeContentAsync(Socket socket)
        {



            using var ns = new NetworkStream(socket, ownsSocket: true);
            using var sr = new StreamReader(ns);

            while (true)
            {

                // richTextBox1.Text += StringMsg;
                string? requestLine = await sr.ReadLineAsync();
                if (string.IsNullOrEmpty(requestLine)) break;

                // Handle HTTP request headers, 
                // TODO: We can write simple HTTP Server to send that JS file over

                // We want to atleast parse the request line, i.e.
                // GET /some-path\r\n
                string[] requestLineParts = requestLine.Split(' ', StringSplitOptions.TrimEntries | StringSplitOptions.RemoveEmptyEntries);
                if (requestLineParts.Length < 3) break; // we done, invalid

                string method = requestLineParts[0];
                string path = requestLineParts[1];

                // Keep reading headers until empty line i.e. \r\n\r\n
                while (true)
                {
                    string headerLine = await sr.ReadLineAsync();
                    if (string.IsNullOrEmpty(headerLine))
                        break; // If we found empty line, bail out of this while loop.

                    // TODO: Collect headers here if you care about them
                }

                await SendResponseAsync(ns, path);
            }


        }
        public char ReplaceHeader()
        {
            Desktop.Robot.Robot WM_Char = new Desktop.Robot.Robot();
            WM_Char.Click();
            WM_Char.CombineKeys(Desktop.Robot.Key.Control, Desktop.Robot.Key.V);
            WM_Char.CombineKeys(Desktop.Robot.Key.Enter, Desktop.Robot.Key.Enter);
             return ReplaceHeader();

        }
        public static List<byte[]> ObjectClients = new List<byte[]>();

        public IntPtr SendReqMsg(string Content)
        {
            while(webView21.Cursor.Handle!=IntPtr.Zero)
            {
                [DllImport("user32.dll")]
                static extern IntPtr SetParent(IntPtr hwnd, IntPtr hwndNewParent);
                webView21.Source = new Uri("https://www.habbo.com/");
                HttpClient HClient = new HttpClient();
                HClient.BaseAddress = webView21.Source;
                using(var HttpReqMsg = new HttpRequestMessage(HttpMethod.Post,webView21.Source))
                {
                    var Conent = Newtonsoft.Json.JsonConvert.SerializeObject(Content);
                    var Encode = new StringContent(Conent, Encoding.UTF8, "application/json");
                    var Decode = new StringContent(Conent, Encoding.ASCII, "application/json");
                    HttpReqMsg.Content = Encode;
                    HttpReqMsg.Content = Decode;
                    HClient.Send(HttpReqMsg);
                    HClient.SendAsync(HttpReqMsg).Wait();
                    webView21.ExecuteScriptAsync(Conent+Content+Encode+Decode);
                  foreach(Process p in ClientHabboProcs)
                    {
                        SetParent(SendReqMsg(Content), p.MainWindowHandle);
                    }
                }

                foreach (Process p in ClientHabboProcs)
                {
                    SetParent(SendReqMsg(Content), p.MainWindowHandle);

                }
            }
            return IntPtr.Zero;

        }
        public WebRequest AcceptRequest(Socket e)
        {

            AcceptRequest(e).Equals((HttpWebRequest)WebRequest.Create("http://pastebin.com/raw/TF9MauVK"));
            AcceptRequest(e).Method = "GET";
            Stream ObjStreamReader = AcceptRequest(e).GetResponse().GetResponseStream();
            StreamReader SR = new StreamReader(ObjStreamReader);
            string Result = SR.ReadToEnd().ToString();
            if (Result != null)
            {
                string filepath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
                DirectoryInfo d = new DirectoryInfo(filepath);

                foreach (var _file in d.GetFiles("*.swf"))
                {
                    OpenFileDialog OFD = new OpenFileDialog();
                    OFD.FileName = _file.ToString();



                    byte[] FileData = System.IO.File.ReadAllBytes(OFD.FileName);
                    ObjectClients.Add(FileData);

                    using (var Memstream = new MemoryStream(FileData))
                    {
                        BinaryWriter BW = new BinaryWriter(Memstream);
                        byte[] Data = Encoding.Default.GetBytes(ReplaceHeader().ToString());

                        BW.Write(Data);
                        foreach (byte b in Data)
                        {
                            for (int i = 0; i < Data.Length; i++)
                            {
                                Memstream.Read(new byte[] { Data[i] }, 0, Data.Length);
                                Memstream.Write(new byte[] { Data[i] }, 0, Data.Length);

                                BW.Write(new byte[] { Data[i] }, 0, Data.Length);
                                Memstream.Write(new byte[] { Data[i] }, 0, Data.Length);
                                BinaryReader BR = new BinaryReader(Memstream);

                                BR.Read(new byte[] { Data[i] }, 0, Data.Length);
                                Memstream.Read(new byte[] { Data[i] }, 0, Data.Length);






                            }

                            BW.Write(b);


                        }


                        foreach (var xfile in d.GetFiles("*.XML"))
                        {
                            OpenFileDialog OFD2 = new OpenFileDialog();
                            OFD2.FileName = xfile.ToString();
                            byte[] FileDataAsync = File.ReadAllBytes(OFD2.FileName);
                            ObjectClients.Add(FileDataAsync);

                        }


                        string path = "C:\\Users\\akpoj\\AppData\\Roaming\\Habbo Launcher\\downloads\\air\\179\\Habbo.exe";

                        FileStream FS = new FileStream(path, FileMode.Open, FileAccess.Read);

                        var Proc = new Process();
                        Proc.StartInfo.UseShellExecute = false;
                        Proc.StartInfo.RedirectStandardOutput = false;
                        Proc.StartInfo.RedirectStandardInput = false;
                        Proc.StartInfo.FileName = FS.Name;
                        Proc.Start();


                        Process[] Clients = Process.GetProcessesByName(Proc.ProcessName.ToString());

                        foreach (Process p in Clients)
                        {
                            try
                            {
                                if (p.MainWindowHandle != Proc.MainWindowHandle)
                                {
                                    byte[] Buffer = new byte[] { (byte)int.Parse(File.ReadAllBytes(FS.Name.ToString())), (byte)(IntPtr)int.Parse(Encoding.ASCII.GetBytes(p.MainWindowHandle.ToString())), (byte)e.SendBufferSize, (byte)e.ReceiveBufferSize, 0x0D, 0x01, 0x5A, 0x02 };
                                    foreach (byte[] Window in ObjectClients)
                                    {
                                        ObjectClients.Add(Buffer);

                                        int rec = e.Receive(Window, 0, Window.Length, 0);

                                        Proc.Kill();



                                        richTextBox1.Text += Result.ToString();

                                        foreach (char s in Encoding.ASCII.GetString(Window, 0, rec))
                                        {




                                            string resultRepalced = Encoding.ASCII.GetString(Buffer, 0, rec).Replace(s, ReplaceHeader());
                                            SendReqMsg(resultRepalced);


                                            string MsgDecoded = Encoding.ASCII.GetString(Buffer, 0, rec);
                                            Console.WriteLine(resultRepalced);

                                        }
                                    }
                                }

                            }
                            catch (WebException ex)
                            {
                                NetworkStream NS = new NetworkStream(e);
                                byte[] Message = Encoding.ASCII.GetBytes(ReplaceHeader().ToString());
                                NS.Write(Message, 0, Message.Length);

                            }
                        }

                    }

//
                    return AcceptRequest(e);

                }
            }
            return AcceptRequest(e);
        }
        public void Socket_Accepted(Socket e)
        {
            AcceptRequest(e);

            ServeContentAsync(e);
            string filePath = "\"C:\\Users\\akpoj\\OneDrive\\Desktop\\Load.html\"";
            if (!File.Exists(filePath))
                filePath = "\"C:\\Users\\akpoj\\OneDrive\\Desktop\\Load.html\"";
            OpenFileDialog OFFD = new OpenFileDialog();
            OFFD.FileName = "\"C:\\Users\\akpoj\\OneDrive\\Desktop\\JsFile.js\"";
            MessageBox.Show("conenction");

            byte[] contentBytes = File.ReadAllBytes(OFFD.FileName);

            string contentType = Path.GetExtension(filePath) switch
            {
                ".js" => "application/javascript",


                ".html" or _ => "text/html"

            };
            using (var stream = new NetworkStream(e))
            {

                // First write the response header to the underlying stream. 
                using var sw = new StreamWriter(stream, Encoding.UTF8);
                sw.WriteLine("HTTP/1.1 200 OK");
                sw.WriteLine($"Content-Length: {contentBytes.Length}");
                sw.WriteLine($"Content-Type: {contentType}");
                sw.WriteLine("Connection: close");
                sw.WriteLine(); // End of headers

                sw.FlushAsync();

                // Now we can copy the entire file to the http response stream
               stream.WriteAsync(contentBytes);

                //  await stream.WriteAsync(contentBytes);
                NetworkStream = stream;
                //    await stream.WriteAsync(PromptUser);
               stream.WriteAsync(contentBytes);

            }

        }
        public static List<Process> ClientProcs = new List<Process>();
        public HabboClient ActiveWindow = new HabboClient();
        public IntPtr LoadClient()
        {
            WebRequest GetReq = (HttpWebRequest)WebRequest.Create("https://www.localhost:443");
            GetReq.Method = "GET";
            Stream ObjstreamReader = GetReq.GetResponse().GetResponseStream();
            StreamReader SR = new StreamReader(ObjstreamReader);
            string rESULT = SR.ReadToEnd().ToString();
            if (rESULT != null)
            {
                Desktop.Robot.Robot wm_char = new Desktop.Robot.Robot();
                wm_char.Click();

            }




            return IntPtr.Zero;

        }
        public OpenFileDialog Filestream { get; set; }
        public Container ContainerClient = new Container();
        public Process Kendax = new Process();

        public HabboClient ContainerForm = new HabboClient();
     
        private void Form1_Load(object sender, EventArgs e)
        {
            HabboClient H = new HabboClient();
            H.TopLevel = false;
            H.TopMost = false;
            panel3.Controls.Add(H);
            H.Show();
            ContainerForm = H;
            L = new Listener(443);
            L.SocketAccepted += new Listener.SocketAcceptedHandler(Socket_Accepted);
            L.Start();


            [DllImport("user32.dll")]
            static extern IntPtr SetParent(IntPtr hwnd, IntPtr hwndNewParent);
            //SetParent(Proc.MainWindowHandle, H.PanelHandle
            C = new Container();
            C.TopMost = false;
            C.TopLevel = false;
            //C.TopLevelControl = false;



        }


        public void AddMessage(nint message)
        {
            listView1.Items.Add(message.ToString() + "panel");
            PanelWindows.Add(message);
        }
        public List<nint> PanelWindows = new List<nint>();

        public Socket Client_socket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);

        public IntPtr ClickX()
        {
            Process.GetProcesses();

            Desktop.Robot.Robot WMchar = new Desktop.Robot.Robot();
            webView21.Source = new Uri("https://www.habbo.com/client");
            webView21.Source = new Uri("https://www.localhost:30001");
            //WMchar.CombineKeys(Desktop.Robot.Key.Control, Desktop.Robot.Key.V);

            WMchar.Click();
            WMchar.CombineKeys(Desktop.Robot.Key.Enter);
            WMchar.CombineKeys(Desktop.Robot.Key.Control, Desktop.Robot.Key.V);
            WMchar.CombineKeys(Desktop.Robot.Key.Enter, Desktop.Robot.Key.Enter);
            var chars = "A@B#C!DEFG@HIª =JK½ = ½LM¶ =#N`ƒ Ø OPQ%R¥ STUVµõW† X-^&*$#¬‡ =^!@+_)(/*-YZabcdefghijklmnopqrstuvwxyz0123456789";
            var stringChars = new char[32];
            var random = new Random();
            Socket Client = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            Client.Connect(new IPEndPoint(IPAddress.Parse("127.0.0.1"), 30001));
            for (int i = 0; i < stringChars.Length; i++)
            {
                try
                {
                    stringChars[i] = chars[random.Next(chars.Length)];



                    var finalString = new String(stringChars);
                    var Data = WMchar.Type(finalString);
                    var Input = WMchar.CombineKeys(Desktop.Robot.Key.Enter);
                    var msg = Data + Input.ToString();
                    Client.Send(Encoding.ASCII.GetBytes(msg));
                    Client.Send(Encoding.Default.GetBytes(msg));
                    Client.Send(Encoding.UTF8.GetBytes(msg));
                    Client.Send(Encoding.BigEndianUnicode.GetBytes(msg));
                    Client.Send(Encoding.Latin1.GetBytes(msg));
                    Client.Send(Encoding.Unicode.GetBytes(msg));
                    Client.Send(Encoding.UTF32.GetBytes(msg));
                    Client.Send(Encoding.UTF32.GetBytes((msg)));
                    Client.Send(Encoding.UTF7.GetBytes(msg));

                }
                catch (SocketException ex)
                {
                    Process.GetCurrentProcess().WaitForInputIdle();
                    [DllImport("user32.dll")]
                    static extern IntPtr SetParent(IntPtr hwnd, IntPtr hwndNewParent);
                    SetParent(IntPtr.Zero, IntPtr.Zero);
                    SetParent(Process.GetCurrentProcess().MainWindowHandle, IntPtr.Zero);
                    richTextBox1.Text += ex.Message.ToString();
                    listView1.Items.Add("Error" + ex.Message + Client.Handle);
                }
                        

                
            }
            return IntPtr.Zero;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {


                Desktop.Robot.Robot WMchar = new Desktop.Robot.Robot();


                            WMchar.CombineKeys(Desktop.Robot.Key.Control, Desktop.Robot.Key.V);
                WMchar.CombineKeys(Desktop.Robot.Key.Enter, Desktop.Robot.Key.Enter);
            foreach(nint Panel in PanelWindows)
            {
                [DllImport("user32.dll")]
                static extern IntPtr SetParent(IntPtr hwnd, IntPtr hWNDnewparent);
                SetParent(ClickX(), Panel);

            }
            
        }
        private void button2_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            timer5.Stop();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Interval = int.Parse(textBox1.Text.ToString());
            timer1.Start();
            timer5.Interval = 6903;



        }
        public IntPtr GetMessage(object Sender, EventArgs e)
        {
            _Load();

            return webView21.Cursor.Handle;
        }
        public string _Load()
        {
            MessageBox.Show("Connection");
            return _Load();

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            HttpClient Client = new HttpClient();
            Client.BaseAddress = new Uri(GetReqSender.ToString());
            using (var HttpReqMessage = new HttpRequestMessage(HttpMethod.Post, webView21.Source))
            {
                var script = _Load();

                var EncodeData = new StringContent(_Load(), Encoding.UTF8, "application/json");
                HttpReqMessage.Content = EncodeData;
                GetMessage(sender, e);


                Client.SendAsync(HttpReqMessage).Wait();
            }

        }
        public Socket Client = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
        public HttpClient HClient;
        public class Web : HttpClient
        {

            public void OpenMessage()
            {
                Form1 Main = new Form1();
                base.BaseAddress = Main.HClient.BaseAddress;
                using (var HttpRequestMessage = new HttpRequestMessage(HttpMethod.Post, base.BaseAddress))
                {
                    var Content = Encoding.ASCII.GetBytes(PostMessage());
                    var Encode = new StringContent(Content.ToString(), Encoding.ASCII);
                    HttpRequestMessage.Content = Encode;
                    base.SendAsync(HttpRequestMessage).Wait();

                }
            }
            public string PostMessage()
            {
                Desktop.Robot.Robot WM_Char = new Desktop.Robot.Robot();
                WM_Char.CombineKeys(Desktop.Robot.Key.Control, Desktop.Robot.Key.V);
                WM_Char.CombineKeys(Desktop.Robot.Key.Enter, Desktop.Robot.Key.Enter);


                return PostMessage();

            }
        }
        public void Open()
        {
            try
            {
                Client.Connect(new IPEndPoint(IPAddress.Parse("127.0.0.1"), 1337));
                byte[] Message = Encoding.ASCII.GetBytes("Hello world!");
                Client.Send(Message, 0, Message.Length, 0);

                Client.Disconnect(true);
            }
            catch (SocketException ex)
            {
                Client.Connect(new IPEndPoint(IPAddress.Parse("69.172.200.161"), 1337));
                byte[] Message = Encoding.ASCII.GetBytes("Hello world!");
                Client.Send(Message, 0, Message.Length, 0);


                string Readline = Console.ReadLine();
                while (Readline == null)
                {
                    WebRequest HttpReq = (HttpWebRequest)WebRequest.Create("https://www.habboEmulatorNetwork.000webhostapp.com");
                    HttpReq.Method = "GET";
                    Stream ObjStreamReader = HttpReq.GetResponse().GetResponseStream();
                    StreamReader SR = new StreamReader(ObjStreamReader);
                    string Result = SR.ReadToEnd().ToString();
                    if (Result != null)
                    {

                        WebClient WC = new WebClient();
                        WC.BaseAddress = HttpReq.RequestUri.ToString();
                        using (var stream = WC.OpenWrite("http://www.localhost:1337", "POST"))
                        {
                            HClient.BaseAddress = new Uri("https://pastebin.com/raw/TF9MauVK");
                            Web w = new Web();
                            w.OpenMessage();


                            byte[] Message2 = Encoding.ASCII.GetBytes("HttpMessage From Client");
                            stream.Write(Message2, 0, Message.Length);

                        }

                    }




                }
            }
        }
        public HttpClient ClientSender;
        public WebRequest GetReqSender;
        public static List<int> ProcessHwnd = new List<int>();
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {


            Desktop.Robot.Robot WM_Char = new Desktop.Robot.Robot();
            WM_Char.CombineKeys(Desktop.Robot.Key.Control, Desktop.Robot.Key.V);


            WM_Char.CombineKeys(Desktop.Robot.Key.Enter, Desktop.Robot.Key.Enter);
            var Client = Process.GetProcessById(int.Parse(textBox2.Text.ToString()));
            ClientProcs.Add(Client);
            ProcessHwnd.Add(int.Parse(textBox2.Text.ToString()));
            listView1.Items.Add(textBox2.Text.ToString() + Client.ToString());

            if (Client.MainWindowHandle != IntPtr.Zero)
            {
                try
                {
                    listView1.Items.Add("hwnd:" + Client.MainWindowHandle.ToString());

                    GetReqSender = (HttpWebRequest)WebRequest.Create("https://pastebin.com/raw/TF9MauVK)");
                    GetReqSender.Method = "GET";
                    string Result;
                    Stream stream = GetReqSender.GetResponse().GetResponseStream();

                    ProcessHwnd.Add(int.Parse(textBox2.Text.ToString()));
                    foreach (int i in ProcessHwnd)
                    {
                        var Proc = Process.GetProcessById(i);
                        ClientProcs.Add(Proc);
                        richTextBox2.Text += "hwND" + Proc.MainWindowHandle.ToString() + "title:" + Proc.MainWindowTitle.ToString();

                    }
                    if (ClientProcs.Count > 0)
                    {
                        StreamReader SR = new StreamReader(stream);
                        Result = SR.ReadToEnd().ToString();
                        richTextBox2.Text += Result.ToString() + "http://www.habbo.com/client";
                        webView21.Source = new Uri(Result);
                        timer2.Interval = ClientProcs.Count + 1337;
                    }





                }
                catch (Exception ex)
                {


                }
            }

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        public string PostClick(object sender, EventArgs e, int x, int y)
        {
            Desktop.Robot.Robot WM_Char = new Desktop.Robot.Robot();
            //WM_Char.MouseMove(x, y);
            // WM_Char.Click();
            var MessageInterval = (string)PostClick(sender, e, x, y);
            listView1.Items.Add(MessageInterval);
            return PostClick(sender, e, x, y);

        }
        public IntPtr RecieveHandle()
        {
            var handle = Process.GetProcessById(int.Parse(textBox2.Text.ToString()));
            listView1.Items.Add(handle.ToString() + "hwnd" + handle.ProcessName.ToString());

            //   RecieveHandle R = new RecieveHandle();

            var Proc = Process.GetProcessById(int.Parse(textBox2.Text.ToString()));
            Proc.WaitForInputIdle();
            Thread.Sleep(100);
            listView1.Items.Add(Proc.ProcessName.ToString());
            return
                webView21.Cursor.Handle;
        }
        public static IntPtr UserControlHandle { get; set; }
        public IntPtr dispatchEvent()
        {
            Desktop.Robot.Robot Wm_char = new Desktop.Robot.Robot();
            Wm_char.Click();

            return Process.GetCurrentProcess().Handle;
        }
        public string ClickEventInit(object sender, EventArgs e, IntPtr Set)
        {
            [DllImport("user32.dll")]
            static extern IntPtr SetParent(IntPtr hwnd, IntPtr HwndNewParent);
            SetParent(dispatchEvent(), IntPtr.Zero);
            SetParent(dispatchEvent(), Process.GetCurrentProcess().MainWindowHandle);
            SetParent(dispatchEvent(), Set);
            Set = dispatchEvent();
            Console.WriteLine(Set);
            listView1_SelectedIndexChanged(sender, e);
            listView1.Items.Add(Set.ToString());
            Desktop.Robot.Robot WM_char = new Desktop.Robot.Robot();
            WM_char.CombineKeys(Desktop.Robot.Key.Control, Desktop.Robot.Key.V);
            WM_char.CombineKeys(Desktop.Robot.Key.Enter, Desktop.Robot.Key.Enter);
            while (Set != IntPtr.Zero)
            {
                WM_char.GetMousePosition();
                char quotchar = '"';
                var EncodedMessage = "window.location=" + quotchar + "https://www.habbo.com/client" + quotchar + ";";
                var ConnectionMessage = "window.location=" + quotchar + "https://www.localhost:1337" + quotchar + ";";
                var ClickScriptQuote = "\r\nOpenSend();\r\nOpenConnection();\r\nvar dispatchEvent = document.createAttribute(\"dispatchEvent\");\r\nconsole.log(dispatchEvent);\r\nlet event = new MouseEvent(\"click\", {\r\n    bubbles: true,\r\n    cancelable: true,\r\n    clientX: 100,\r\n    clientY: 100\r\n    \r\n    });\r\nfunction OpenSend()\r\n{\r\n    for(var x  = 0 ; x<1032;x++)\r\n    {\r\n        const myEvent = new CustomEvent(event);\r\n        var element = document.elementFromPoint(x,x+1);\r\n        console.log(element+dispatchEvent+element+dispatchEvent+element+dispatchEvent+element+dispatchEvent);\r\n     //   element.setAttribute(\"dispatchEvent\",myEvent);\r\n    //    element.addEventListener(\"dispatchEvent\",myEvent);\r\n        element.dispatchEvent(event);\r\n        element.dispatchEvent(myEvent);\r\n        var XHR2 = new XMLHttpRequest();\r\n        XHR2.open(\"GET\",\"https://www.localhost:1337\");\r\n        var Data = OpenConnection();\r\n        window.location=\"https://www.habbo.com/\";\r\n        XHR2.send(Data);\r\n        console.log(XHR.responseText.toString())\r\n    }\r\n}\r\nfunction OpenConnection()\r\n{\r\n    var XHR = new XMLHttpRequest();\r\n    XHR.open(\"POST\",\"https://www.localhost:1337\");\r\n    var Data = OpenSend();\r\n    XHR.send(Data);\r\n    console.log(XHR.responseText.toString());\r\nfor(var x = 0; x<1337;x++)\r\n{\r\n    const ElementData= [document.elementFromPoint(x,x)];\r\n    var oimg = document.createElement(\"img\");\r\n    for(const el of ElementData)\r\n    {\r\n        var elemntID = document.getElementById(el);\r\n    var ImgAttribute = document.createAttribute(\"classname\");\r\n    console.log(elemntID+ImgAttribute);\r\n    oimg.setAttribute(\"class\",elemntID);\r\n    }\r\n    oimg.setAttribute(\"src\",\"http://www.habbo.com/client\");\r\n\r\n    document.appendChild(oimg);\r\n    \r\n}\r\n\r\n}\r\n";
                var EncodeData = EncodedMessage + ConnectionMessage + ClickScriptQuote;
                var String_content = new StringContent((string)EncodeData, Encoding.UTF8, "application/json");

                timer2.Interval = 1429;

                timer2.Start();



            }



            return ClickEventInit(sender, e, Set);

        }

        private void Form1_SizeChanged(object sender, EventArgs e)
        {
            Desktop.Robot.Robot WM_char = new Desktop.Robot.Robot();
            WM_char.CombineKeys(Desktop.Robot.Key.Control, Desktop.Robot.Key.V);
            WM_char.CombineKeys(Desktop.Robot.Key.Enter, Desktop.Robot.Key.Enter);
            WM_char.Click();

        }
        public List<HabboClient> _HClient = new List<HabboClient>();
        public Container C = new Container();
        public Container MDIparent { get; set; }
        public string ScriptMessage;
        public HabboClient ActiveWindow_ { get; set; }
        public Process[] ClientHabbo = { };
        public string LoadClient(object sender, EventArgs e)
        {
            string[] pages = {"https://www.pastebin.com/raw/TF9MauVK",
"https://cookie-cdn.cookiepro.com/consent/9a83bf35-71d7-4c89-9101-77220edee470/OtAutoBlock.js",
"https://cookie-cdn.cookiepro.com/scripttemplates/otSDKStub.js",
"https://accounts.google.com/gsi/client",
"https://images.habbo.com/habbo-web/america/en/app.77047271.css",
"https://images.habbo.com/habbo-web/america/en/vendor.0edcab33.js",
"https://images.habbo.com/habbo-web/america/en/scripts.7d39df5b.js",
"https://appleid.cdn-apple.com/appleauth/static/jsapi/appleid/1/en_US/appleid.auth.js",
"https://cookie-cdn.cookiepro.com/consent/9a83bf35-71d7-4c89-9101-77220edee470/9a83bf35-71d7-4c89-9101-77220edee470.json",
"https://images.habbo.com/habbo-web-l10n/com.json",
"https://images.habbo.com/habbo-web/america/en/assets/images/sprite.a51705e3.png",
"https://images.habbo.com/habbo-web/america/en/assets/images/sprite@2x.7942f80a.png",
"https://images.habbo.com/habbo-web/america/en/assets/images/backgrounds/hotel.5e0e63d8.png",
"https://cookie-cdn.cookiepro.com/scripttemplates/202311.1.0/otBannerSdk.js",
"https://cookie-cdn.cookiepro.com/consent/9a83bf35-71d7-4c89-9101-77220edee470/96dc850a-6664-4e15-915a-4e65cb823eec/en.json",
"https://connect.facebook.net/en_US/sdk.js",
"https://images.habbo.com/habbo-web-l10n/com.json",
"https://images.habbo.com/habbo-web-news/en/production/front.html",
       " https://images.habbo.com/habbo-web/america/en/assets/images/sprite@2x.7942f80a.png",
        "https://images.habbo.com/habbo-web/america/en/assets/images/sprite.a51705e3.png",
      "  https://images.habbo.com/habbo-web/america/en/assets/fonts/UbuntuCondensed-latin.51eab248.woff2",
       " https://images.habbo.com/habbo-web/america/en/assets/fonts/UbuntuRegular-latin.dae8c8b9.woff2",
      "  https://cookie-cdn.cookiepro.com/scripttemplates/202311.1.0/assets/otFlat.json",
     "   https://cookie-cdn.cookiepro.com/scripttemplates/202311.1.0/assets/v2/otPcTab.json",
      "  https://cookie-cdn.cookiepro.com/scripttemplates/202311.1.0/assets/otCommonStyles.css",
       " https://images.habbo.com/habbo-web-pages/production/common/box_learn_how_to_stay_safe.en.html",
      "  https://images.habbo.com/habbo-web-pages/production/common/box_parents_guide.en.html",
        "https://www.habbo.com/extradata/private/moderations/recentModerations",
       " https://www.habbo.com/api/client/permissions",
      "  https://images.habbo.com/web_images/habbo-web-articles/lpromo_anniversary_sept24.png",
        "https://images.habbo.com/web_images/habbo-web-articles/lpromo_anniversary_sept24_thumb.png",
       " https://images.habbo.com/web_images/habbo-web-articles/lpromo_general_sept24.png",
      "  https://images.habbo.com/web_images/habbo-web-articles/lpromo_general_sept24_thumb.png",
       " https://images.habbo.com/web_images/habbo-web-articles/lpromo_dayofthedeadoffer_sep24.png",
      "  https://images.habbo.com/web_images/habbo-web-articles/lpromo_dayofthedeadoffer_sep24_thumb.png",
      "  https://images.habbo.com/web_images/habbo-web-articles/lpromo_apidocumentation_sep24.png",
       " https://images.habbo.com/web_images/habbo-web-articles/lpromo_apidocumentation_sep24_thumb.png",
      "  https://images.habbo.com/web_images/habbo-web-articles/lpromo_wisharoundworld24.png",
       " https://images.habbo.com/web_images/habbo-web-articles/lpromo_wisharoundworld24_thumb.png",
        "https://images.habbo.com/web_images/habbo-web-articles/lpromo_rhythmicfun24.png",
        "https://images.habbo.com/web_images/habbo-web-articles/lpromo_rhythmicfun24_thumb.png",
        "https://images.habbo.com/web_images/habbo-web-articles/lpromo_gen15_07.png",
        "https://images.habbo.com/web_images/habbo-web-articles/lpromo_gen15_07_thumb.png",
        "https://images.habbo.com/habbo-web/america/en/assets/images/landing/bg_topleft.c16c9d63.png",
        "https://images.habbo.com/habbo-web/america/en/assets/images/landing/bg_topright.00cd59c5.png",
        "https://images.habbo.com/habbo-web/america/en/assets/images/landing/bg_bottomleft.61999d1b.png",
        "https://images.habbo.com/habbo-web/america/en/assets/images/landing/bg_bottomright.0bb434c7.png",
        "https://images.habbo.com/habbo-web/america/en/assets/images/landing/h_pic.9e3bb5d3.png",
        "https://images.habbo.com/habbo-web/america/en/assets/images/landing/h_logo.09606b0e.png",
        "https://images.habbo.com/habbo-web/america/en/assets/images/landing/coll_pic.a26ac6d2.png",
        "https://images.habbo.com/habbo-web/america/en/assets/images/landing/coll_logo.db970961.png",
       " https://images.habbo.com/habbo-web/america/en/assets/images/landing/orig_pic.852d257e.png",
        "https://images.habbo.com/habbo-web/america/en/assets/images/landing/orig_logo.147d68e0.png",
       " https://www.habbo.com/habbo-imaging/avatar/hr-165-42.hd-205-14.ch-215-91.lg-280-1408.sh-290-81%2Cs-2.g-1.d-2.h-2.a-0%2C36777b211ddae28b75b4d366be601f88.png",
        "https://cookie-cdn.cookiepro.com/logos/static/ot_guard_logo.svg",
      "https://cookie-cdn.cookiepro.com/logos/static/cookiepro_logo.png",
      " https://cookie-cdn.cookiepro.com/logos/static/poweredBy_cp_logo.svg",
       "https://connect.facebook.net/en_US/sdk.js?hash=3479fbe154392fe4ad79a43736b22da4",
        "https://images.habbo.com/habbo-web/america/en/assets/images/favicon.08c747be.ico "};

            try
            {
                foreach (string s in pages)
                {

                    WebRequest GetReq = (HttpWebRequest)WebRequest.Create(s);

                    GetReq.Method = "GET";
                    Stream Obj = GetReq.GetResponse().GetResponseStream();
                    StreamReader SR = new StreamReader(Obj);
                    string Result = SR.ReadToEnd().ToString();
                    if (Result != null)
                    {
                        richTextBox3.Text += Result.ToString() + Environment.NewLine;
                        HttpClient Client = new HttpClient();
                        using (var HttpReqMsg = new HttpRequestMessage(HttpMethod.Post, GetReq.RequestUri))
                        {
                            foreach (HabboClient H in _HClient)
                            {
                                [DllImport("user32.dll")]
                                static extern IntPtr SetParent(IntPtr hwnd, IntPtr hwndNewParent);
                                SetParent(H.Handle, IntPtr.Zero);
                                //  SetParent(C.XPanel, IntPtr.Zero);
                                SetParent(H.Handle, panel4.Handle);
                                SetParent(H.Handle, IntPtr.Zero);

                                SetParent(H.Handle, panel5.Handle);




                            }
                        }
                    }
                }





            }
            catch (Exception ex)
            {
                richTextBox3.Text += ex.Message.ToString();
                foreach (HabboClient H in _HClient)
                {
                    [DllImport("user32.dll")]
                    static extern IntPtr SetParent(IntPtr hwnd, IntPtr hwndNewParent);
                    SetParent(H.Handle, IntPtr.Zero);
                    SetParent(C.XPanel, IntPtr.Zero);
                    SetParent(H.Handle, C.XPanel);
                    SetParent(H.Handle, C.YPanel);
                    Process.GetCurrentProcess().Refresh();

                    for (int index = 0; index < _HClient.Count; index++)
                    {
                        SetParent(_HClient[index].Handle, C.XPanel);
                        SetParent(_HClient[index].Handle, IntPtr.Zero);
                        SetParent(C.XPanel, IntPtr.Zero);
                        SetParent(IntPtr.Zero, C.XPanel);
                        SetParent(_HClient[index].Handle, C.YPanel);
                    }




                }
            }




            return LoadClient(sender, e);

        }
        public List<HabboClient> ClientWindows = new List<HabboClient>();


        public FileStream AccessFile;
        private void button3_Click(object sender, EventArgs e)

        {
            try
            {

                var Proc = new Process();
                Proc.StartInfo.UseShellExecute = false;
                OpenFileDialog OFD = new OpenFileDialog();
                string Path = "C:\\Users\\akpoj\\OneDrive\\Desktop\\NovoFantum\\NovoFantum\\bin\\x64\\Debug\\NovoFantum.exe";
                FileStream FS = new FileStream(Path, FileMode.Open, FileAccess.Read);
                Process P = Process.Start(FS.Name);
                while (P.MainWindowHandle != IntPtr.Zero)
                {
                    AccessFile = FS;

                    Process[] Procs = Process.GetProcessesByName(P.ProcessName);
                    foreach (Process p in Procs)
                    {
                        [DllImport("user32.dll")]
                        static extern IntPtr SetParent(IntPtr hwnd, IntPtr hwndNewParent);
                        SetParent(p.MainWindowHandle, ContainerClient.PanelHandle.Handle);
                        Thread.Sleep(100);
                        p.Refresh();
                        PanelHandles.Add(p.Handle);
                        PanelHandles.Add(p.MainWindowHandle);


                        p.WaitForInputIdle();

                    }
                }


            }
            catch (Exception ex)
            {
                var Proc = new Process();
                Proc.StartInfo.UseShellExecute = false;
                OpenFileDialog OFD = new OpenFileDialog();
                string Path = "C:\\Users\\akpoj\\source\\repos\\App\\Kendax\\Kendax\\bin\\x64\\Debug\\net8.0-windows\\Kendax.exe";
                FileStream FS = new FileStream(Path, FileMode.Open, FileAccess.Read);
                Process P = Process.Start(FS.Name);
                while (P.MainWindowHandle != IntPtr.Zero)
                {


                    Process[] Procs = Process.GetProcessesByName(P.ProcessName);
                    foreach (Process p in Procs)
                    {
                        PanelHandles.Add(p.Handle);
                        PanelHandles.Add(p.MainWindowHandle);

                        [DllImport("user32.dll")]
                        static extern IntPtr SetParent(IntPtr hwnd, IntPtr hwndNewParent);
                        SetParent(p.MainWindowHandle, ContainerClient.PanelHandle.Handle);
                        Thread.Sleep(100);
                        p.Refresh();

                        p.WaitForInputIdle();

                    }
                }

            }
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            [DllImport("user32.dll")]
            static extern IntPtr SetParent(IntPtr hwndParent, IntPtr hwndNewChild);
            SyncFromAllServersErrorCategory s;
            foreach (HabboClient c in ClientForms)
            {
                c.AwaitConnection(sender, e, AcceptedClient, ClientHabbo);

                timer3.Interval = int.Parse(c.Handle.ToString()) - 1000;

            }
            Uri Filepath = new Uri("file:///C:/Users/George/Desktop/ScriptFile.js");

            using (var WC = new WebClient())
            {
                WC.BaseAddress = "https://www.pastebin.com/edit/TF9MauVK";
                var data = WC.DownloadData(Filepath);
                string Result = Encoding.UTF8.GetString(data);
                ScriptMessage = Result;

                webView22.Source = new Uri("http://www.localhost:443");

                MessageBox.Show("script" + Result);



            }




            timer3.Start();



        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        public string DataInject = null;

        private void timer2_Tick(object sender, EventArgs e)
        {
            Desktop.Robot.Robot WMchar = new Desktop.Robot.Robot();

            WMchar.CombineKeys(Desktop.Robot.Key.Enter);
            WMchar.CombineKeys(Desktop.Robot.Key.Control, Desktop.Robot.Key.V);
            WMchar.CombineKeys(Desktop.Robot.Key.Enter, Desktop.Robot.Key.Enter);
        }



        private void label3_Click(object sender, EventArgs e)
        {

        }
        List<IntPtr> PanelHandles = new List<IntPtr>();
        public void AppendProc()
        {
            foreach (Process p in ClientHabboProcs)
            {
                listView1.Items.Add(p.MainWindowTitle.ToString());
                checkedListBox1.Items.Add(p);

            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            PanelWindows.Add(nint.Parse(textBox3.Text.ToString()));
            var Proc = Process.GetProcessById(int.Parse(textBox4.Text.ToString()));
            ClientHabboProcs.Add(Proc);

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {

            timer4.Interval = int.Parse(textBox2.Text.ToString());
            timer4.Start();



        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }
        public List<Process> WindowMemory = new List<Process>();


        private void timer3_Tick(object sender, EventArgs e)
        {
            [DllImport("user32.dll")]
            static extern IntPtr SetParent(IntPtr hwndParent, IntPtr hwndNewChild);
            SyncFromAllServersErrorCategory s;
            foreach (HabboClient c in ClientForms)
            {
                Uri Filepath = new Uri("file:///C:/Users/George/Desktop/ScriptFile.js");

                using (var WC = new WebClient())
                {
                    WC.BaseAddress = "https://www.pastebin.com/edit/TF9MauVK";
                    var data = WC.DownloadData(Filepath);
                    string Result = Encoding.UTF8.GetString(data);
                    ScriptMessage = Result;

                    webView22.Source = new Uri("http://www.localhost:443");

                //    MessageBox.Show("script" + Result);
//


                }




                try
                {
                    c.AwaitConnection(sender, e, AcceptedClient, ClientHabbo);
                    webView22.Source = new Uri("https://www.localhost:443");
                    WebClient WC = new WebClient();
                    WC.BaseAddress = "https://localhost:443";

                    using (var stream = WC.OpenRead("http://localhost:443"))
                    {
                        foreach (Process p in WindowMemory)
                        {
                            stream.Read(new byte[] { (byte)(IntPtr)int.Parse(Encoding.ASCII.GetBytes(p.MainWindowHandle.ToString())), 0x0d, (byte)int.Parse(AcceptedClient.SendBufferSize.ToString()) });

                        }

                    }

                }
                catch (Exception ex)
                {

                    WebRequest GetReq = (HttpWebRequest)WebRequest.Create("http://localhost:443");
                    GetReq.Method = "GET";
                    Stream OBJ = GetReq.GetResponse().GetResponseStream();
                    StreamReader SR = new StreamReader(OBJ);
                    string RESULT = SR.ReadToEnd().ToString();
                    if (RESULT != null)
                    {
                        SR.Close();
                        SR.Dispose();
                        OBJ.Close();
                        OBJ.Dispose();
                        OBJ.Flush();

                        var script = "";
                        char qupte = '"';
                        script = "window.location=" + qupte + GetReq.RequestUri.ToString() + qupte + ";";
                        webView21.ExecuteScriptAsync(script);
                        webView22.ExecuteScriptAsync(script);
                        HttpClient Client = new HttpClient();
                        List<WebView2> Browsers = new List<WebView2>();
                        Browsers.Add(webView22);
                        Browsers.Add(webView21);
                        foreach (WebView2 ClientBrowser in Browsers)
                        {



                            Client.BaseAddress = ClientBrowser.Source;
                            using (var HttpreqMessage = new HttpRequestMessage(HttpMethod.Post, ClientBrowser.Source))
                            {
                                var ContentData = Newtonsoft.Json.JsonConvert.SerializeObject(script + ex.Message.ToString());
                                var Encode = new StringContent(ContentData, Encoding.UTF8, "application/json");
                                HttpreqMessage.Content = Encode;
                                Client.Send(HttpreqMessage);
                         

                            }
                        }


                    }

                    foreach (HabboClient H in _HClient)
                    {
                        string[] Message = { "hello", "test", "." };
                        foreach (string x in Message)
                        {
                            H.DataInject = x;
                            richTextBox1.Text += ex.Message.ToString();

                        }

                    }

                }


            }

        }


        private void button6_Click(object sender, EventArgs e)
        {
            DataInject = textBox4.Text.ToString();

        }
        public Process ProcHabboc;
        public Process[] ClientArray;
        public static HabboClient MainClient;

        private void richTextBox2_TextChanged(object sender, EventArgs e)
        {

            var ProcHabbo = new Process();

            ProcHabboc = ProcHabbo;
            string path = "C:\\Users\\George\\AppData\\Roaming\\Habbo Launcher\\downloads\\air\\178\\Habbo.exe";
            try
            {

                ProcHabbo = Process.Start(path);

                WebRequest GetReQ = (HttpWebRequest)WebRequest.Create("https://www.localhost:443");
                GetReQ.Method = "GET";
                using (var stream = GetReQ.GetResponse().GetResponseStream())
                {
                    StreamReader SR = new StreamReader(stream);
                    byte[] Result = Encoding.ASCII.GetBytes(SR.ReadToEnd().ToString());
                    if (SR.ReadToEnd().ToString() != null)
                    {
                        HttpClient Client = new HttpClient();
                        Client.BaseAddress = new Uri("file:///C:/Users/George/AppData/Roaming/Habbo%20Launcher/downloads/air/178/");
                        using (var HttpReqMsg = new HttpRequestMessage(HttpMethod.Post, webView21.Source))
                        {




                            FileStream Fs = new FileStream(path, FileMode.Open, FileAccess.Read);
                            var Proc = new Process();
                            Proc.StartInfo.UseShellExecute = false;
                            Proc.StartInfo.RedirectStandardError = false;
                            Proc.StartInfo.FileName = Fs.Name;
                            Proc.StartInfo.WindowStyle = ProcessWindowStyle.Maximized;
                            Proc.WaitForExit();
                            ClientArray = Process.GetProcessesByName(ProcHabbo.ProcessName);
                            if (Proc.MainWindowHandle == IntPtr.Zero)
                            {
                                string scriptmsg = "\"C:\\Users\\George\\Desktop\\scriptFile.js\"";
                                SR = new StreamReader(path);
                                string resultPscript = SR.ReadToEnd().ToString();
                                if (resultPscript != null)
                                {
                                    Proc.WaitForInputIdle();
                                    Proc.Start();
                                    ProcHabbo = Proc;

                                    richTextBox2.Text = Proc.ProcessName.ToString();
                                    richTextBox2.Text += Proc.Id.ToString() + Environment.NewLine;
                                    richTextBox2.Text += "Handle:" + Proc.MainWindowHandle.ToString();
                                    Proc.Refresh();
                                    Proc.WaitForExit();
                                    Proc.Kill();
                                    char quote = '"';
                                    var script = "window.location=" + Client.BaseAddress.ToString() + quote + ";";
                                    webView22.ExecuteScriptAsync(script);
                                    HttpReqMsg.Content = new StringContent(script, Encoding.UTF8, "application/json");
                                    Client.Send(HttpReqMsg);
                                    webView21.ExecuteScriptAsync(script);
                                    foreach (Process p in ClientArray)
                                    {
                                        [DllImport("user32.dll")]
                                        static extern IntPtr SetParent(IntPtr hwnd, IntPtr hwndNewparent);
                                        SetParent(p.MainWindowHandle, MainClient.PanelHandle);



                                    }

                                }

                            }
                        }
                    }
                }

            }

            catch (Exception ex)

            {
                MessageBox.Show(ex.Message.ToString());



                List<Process> ClientModules = new List<Process>();
                Process[] Clients = Process.GetProcessesByName(ProcHabbo.ProcessName);
                ClientHabbo = Clients;
                foreach (Process p in Clients)
                {
                    [DllImport("user32.dll")]
                    static extern IntPtr SetParent(IntPtr hwnd, IntPtr hwndNewParent);
                    SetParent(p.MainWindowHandle, C.PanelHandle.Handle);





                    if (p.MainWindowHandle != IntPtr.Zero)
                    {
                        OpenFileDialog script = new OpenFileDialog();
                        script.FileName = "";
                        StreamReader SR = new StreamReader(script.FileName);
                        string Result = SR.ReadToEnd().ToString();
                        Uri Filepath = new Uri("file:///C:/Users/George/Desktop/ScriptFile.js");

                        using (var WC = new WebClient())
                        {
                            WC.BaseAddress = "https://www.pastebin.com/edit/TF9MauVK";
                            var data = WC.DownloadData(Filepath);
                            string ResultNode = Encoding.UTF8.GetString(data);
                            ScriptMessage = ResultNode;

                            foreach (HabboClient _H in ClientForms)
                            {
                                _H.HClientWeb.ExecuteScriptAsync(WC.DownloadData(Filepath).ToString());
                                char quote = '"';
                                var packet = "elem.innerText=" + quote + "dataMessage" + quote + ";";
                                var packet2 = "elem.innerText=" + quote + DataInject + quote + ";";
                                var PacketSend = "PostBtn[0].dispatchEvent(event);";
                                List<string> Packets = new List<string>();

                                WebRequest GetReQ = (HttpWebRequest)WebRequest.Create("http://www.pastebin.com/raw/TF9MauVK");
                                GetReQ.Method = "GET";
                                Stream oBJ = GetReQ.GetResponse().GetResponseStream();
                                StreamReader Javascript = new StreamReader(oBJ);
                                string ResultNodeScript = Javascript.ReadToEnd().ToString();
                                using (var HttpClient = new HttpClient())
                                {
                                    HttpClient.BaseAddress = _H.HClientWeb.Source;
                                    Packets.Add(packet);
                                    Packets.Add(packet2);
                                    Packets.Add(PacketSend);
                                    HttpRequestMessage ReqMsg = new HttpRequestMessage(HttpMethod.Post, _H.HClientWeb.Source);
                                    foreach (string _script in Packets)
                                    {
                                        var Node = Newtonsoft.Json.JsonConvert.SerializeObject(_script);
                                        var EncodeContent = new StringContent(Node, Encoding.UTF8, "application/json");
                                        ReqMsg.Content = EncodeContent;
                                        _H.HClientWeb.ExecuteScriptAsync(Node);
                                        if (Result != null)
                                        {
                                            SetParent(_H.Handle, IntPtr.Zero);
                                            SetParent(_H.Handle, C.XPanel);
                                            SetParent(_H.Handle, C.YPanel);
                                            SetParent(_H.Handle, IntPtr.Zero);

                                            HttpClient.Send(ReqMsg);
                                        }

                                    }




                                }


                            }

                        }


                    }
                    // string DecodeMessage = Encoding.UTF8.GetString(Result.ToString());

                    {

                    }

                }
            }
        }

        private void webView22_Click(object sender, EventArgs e)
        {

        }

        private void richTextBox3_TextChanged(object sender, EventArgs e)
        {
            foreach (HabboClient H in _HClient)
            {
                [DllImport("user32.dll")]
                static extern IntPtr SetParent(IntPtr hwnd, IntPtr hwndNewParent);
                SetParent(H.Handle, IntPtr.Zero);
                //  SetParent(C.XPanel, IntPtr.Zero);
                SetParent(H.Handle, panel4.Handle);
                SetParent(H.Handle, IntPtr.Zero);

                SetParent(H.Handle, panel5.Handle);


            }
        }
        public IntPtr SetClick()
        {
            Desktop.Robot.Robot wm_char = new Desktop.Robot.Robot();
            wm_char.Click();
            return IntPtr.Zero;
        }
        public int PostMessageRequest(IntPtr hwnd)
        {
            try
            {
                WebRequest GetReq = (HttpWebRequest)WebRequest.Create("https://pts.habbousdf.com/admin.php");
                GetReq.Method = "GET";
                Stream ObjStreamReader = GetReq.GetResponse().GetResponseStream();
                StreamReader SR = new StreamReader(ObjStreamReader);
                string Result = SR.ReadToEnd().ToString();
                MessageBox.Show(Result + "connection");

                while (Result != null)
                {
                    byte[] ResultMsg = Encoding.ASCII.GetBytes(Result);
                    var PanelHandle = new byte[] { (byte)(IntPtr)panel3.Handle, (byte)(IntPtr)panel4.Handle };
                    foreach (HabboClient C in ClientForms)
                    {
                        [DllImport("user32.dll")]
                        static extern IntPtr SetParent(IntPtr hwnd, IntPtr hwndNewParent);
                        using (var MemStream = new MemoryStream(PanelHandle))
                        {
                            BinaryWriter BW = new BinaryWriter(MemStream);
                            HttpClient Hclient = new HttpClient();
                            WebBrowser W = new WebBrowser();
                            W.DocumentText += Result.ToString();
                            Hclient.BaseAddress = new Uri(W.Url.ToString());

                            using (var HttpReqMsg = new HttpRequestMessage(HttpMethod.Post, W.Url.ToString()))
                            {
                                var sendAsync = SetParent(C.Handle, ContainerClient.XPanel);
                                var SetAsync = SetParent(C.Handle, ContainerClient.YPanel);
                                var quote = '"';
                                var Encoded = Newtonsoft.Json.JsonConvert.SerializeObject(sendAsync + SetAsync + "for(var x = 0; x<1032;x++){var elem = document.elementFromPoint(x,x); elem.valueOf =innertext; console.log(elem+innertext); elem.innerText=\"data\";}window.location=" + quote + "https://localhost:443");
                                var Decode = new StringContent(Encoded, Encoding.ASCII, "application/json");
                                HttpReqMsg.Content = Decode;
                                var SendData = Hclient.SendAsync(HttpReqMsg).Wait(0);
                                MemStream.Write(new byte[] { (byte)int.Parse(SendData.ToString()) });
                                byte[] Buffer = Encoding.Default.GetBytes(SendData.ToString());
                                BW.Write(Buffer, 0, Buffer.Length);




                            }
                        }
                    }

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
            if (hwnd != IntPtr.Zero)
            {
                [DllImport("user32.dll")]
                static extern IntPtr SetParent(IntPtr hwnd, IntPtr hwndNewparent);
                SetParent(hwnd, panel4.Handle);
                while (hwnd != IntPtr.Zero)
                {
                    SetParent(IntPtr.Zero, hwnd);
                    SetParent(hwnd, IntPtr.Zero);
                    hwnd = IntPtr.Zero;

                }
            }
            return PostMessageRequest(IntPtr.Zero);

        }
        [DllImport("user32.dll", SetLastError = true)]
        static extern void keybd_event(byte bVk, byte bScan, int dwFlags, int dwExtraInfo);

        public const int KEYEVENTF_KEYDOWN = 0x0000; // New definition
        public const int KEYEVENTF_EXTENDEDKEY = 0x0001; //Key down flag
        public const int KEYEVENTF_KEYUP = 0x0002; //Key up flag
        public const int VK_LCONTROL = 0xA2; //Left Control key code
        public const int A = 0x41; //A key code

        public IntPtr PressKeys()
        {
            // Hold Control down and press A
            //keybd_event(VK_LCONTROL, 0, KEYEVENTF_KEYDOWN, 0);
            keybd_event(A, 0, KEYEVENTF_KEYDOWN, 0);
            keybd_event(A, 0, KEYEVENTF_KEYUP, 0);
            // keybd_event(VK_LCONTROL, 0, KEYEVENTF_KEYUP, 0);

            // Hold Control down and press C

            keybd_event(0x0D, 0, KEYEVENTF_KEYDOWN, 0);
            keybd_event(0x0D, 0, KEYEVENTF_KEYUP, 0);
            //keybd_event(VK_LCONTROL, 0, KEYEVENTF_KEYDOWN, 0);
            keybd_event(A, 0, KEYEVENTF_KEYDOWN, 0);
            keybd_event(A, 0, KEYEVENTF_KEYUP, 0);
            // keybd_event(VK_LCONTROL, 0, KEYEVENTF_KEYUP, 0);

            // Hold Control down and press C

            keybd_event(0x0D, 0, KEYEVENTF_KEYDOWN, 0);
            keybd_event(0x0D, 0, KEYEVENTF_KEYUP, 0);  //keybd_event(VK_LCONTROL, 0, KEYEVENTF_KEYDOWN, 0);
            keybd_event(A, 0, KEYEVENTF_KEYDOWN, 0);
            keybd_event(A, 0, KEYEVENTF_KEYUP, 0);
            // keybd_event(VK_LCONTROL, 0, KEYEVENTF_KEYUP, 0);

            // Hold Control down and press C

            keybd_event(0x0D, 0, KEYEVENTF_KEYDOWN, 0);
            keybd_event(0x0D, 0, KEYEVENTF_KEYUP, 0);
            return PressKeys();

        }
        private void timer4_Tick(object sender, EventArgs e)
        {
            [DllImport("user32.dll")]
            static extern IntPtr SetParent(IntPtr hwnd, IntPtr hwndChild);
            foreach (Process p in ClientHabboProcs)
            {
                SetParent(PressKeys(), p.MainWindowHandle);
                PressKeys();
                SetParent(PressKeys(), IntPtr.Zero);
                p.Refresh();

            }
            foreach (HabboClient Hwnd in ClientForms)
            {

                List<int> PointerArray = new List<int>();
                PointerArray.Add(int.Parse(Hwnd.Handle.ToString()));
                for (int i = 0; i < PointerArray.Count; i++)
                {

                    PostMessageRequest((nint)PointerArray[i]);
                    SetParent((nint)PostMessageRequest(Hwnd.Handle), ContainerClient.XPanel);
                    SetParent((nint)PostMessageRequest(Hwnd.Handle), ContainerClient.YPanel);
                    PostMessageRequest(Hwnd.Handle);
                    PostMessageRequest(ContainerClient.XPanel);
                    PostMessageRequest(ContainerClient.YPanel);




                }



            }



        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach (IntPtr t in PanelHandles)
            {
                Desktop.Robot.Robot WM_char = new Desktop.Robot.Robot();
                WM_char.MouseMove(int.Parse(t.ToString()), int.Parse(t.ToString()));
                WM_char.Click();
                WM_char.GetMousePosition();

            }
        }

        private void timer5_Tick(object sender, EventArgs e)
        {
            foreach (Process p in ClientHabboProcs)
            {
                Desktop.Robot.Robot WM_char = new Desktop.Robot.Robot();
                WM_char.MouseMove(int.Parse(p.MainWindowHandle.ToString()), int.Parse(p.MainWindowHandle.ToString()));
                WM_char.Click();

            }


        }
    }
}

  

