using System.Net.Sockets;
using System.Net;
using System.Diagnostics;
using System.Text;
using System.Runtime.InteropServices;


class Listener
{
    Socket s;

    public bool Listening
    {
        get;
        private set;
    }

    public int Port
    {
        get;
        private set;
    }

    public Listener(int port)
    {
        Port = port;
        s = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
    }

    public void Start()
    {
        if (Listening)
            return;

        s.Bind(new IPEndPoint(0, Port));
        s.Listen(0);

        s.BeginAccept(callback, null);
        Listening = true;
    }

    public void Stop()
    {
        if (!Listening)
            return;

        s.Close();
        s.Dispose();
        s = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
    }
    public static List<Process> ClientHabboProcs = new List<Process>();
    public IntPtr OpenClientRecieveAsync(OpenFileDialog OFD, Process p)
    {
        string path = "C:\\Users\\George\\AppData\\Roaming\\Habbo Launcher\\downloads\\air\\178";
        OFD.FileName = path;
        var Proc = Process.Start(OFD.FileName);
        Proc.StartInfo.FileName = path;
        Proc.StartInfo.RedirectStandardInput = true;
        Proc.StartInfo.RedirectStandardOutput = true;
        Proc.StartInfo.UseShellExecute = false;
        Proc.Start();

        Process[] ClientProcs = Process.GetProcessesByName(Proc.ProcessName.ToString());
        foreach (Process Client in ClientHabboProcs)
        {
            Socket Accepted = s.Accept();
            byte[] Buffer = new byte[] { (byte)(IntPtr)int.Parse(System.Text.Encoding.ASCII.GetBytes(Client.MainWindowHandle.ToString())), 0x0D, (byte)Accepted.SendBufferSize };
            int rec = Accepted.Receive(Buffer, 0, Buffer.Length, 0);
            if (rec > 0)
            {
                Array.Resize(ref Buffer, rec);

                var GetMessage = int.Parse(p.MainWindowHandle.ToString()) == (Accepted.Receive(Buffer, 0, Buffer.Length, 0));
                using (var BinaryWriter = new BinaryWriter(new MemoryStream(new byte[] { (byte)(IntPtr)int.Parse(System.Text.Encoding.ASCII.GetBytes(Client.MainWindowHandle.ToString())), 0x0D, (byte)Accepted.ReceiveBufferSize })))
                {
                    string DecodeMsg = System.Text.Encoding.ASCII.GetString(Buffer, 0, Buffer.Length);
                    BinaryWriter.Write(DecodeMsg);
                    byte[] DecodeValue = Encoding.Default.GetBytes(DecodeMsg);
                    foreach(byte B in DecodeValue)
                    {
                        BinaryWriter.Write(B);
                        byte[] AsciiMessage = Encoding.ASCII.GetBytes(GetMessage.ToString());
                        BinaryWriter.Write(AsciiMessage, 0, AsciiMessage.Length);

                   }
                        
                }



            }


        }

            


        

    
    
        return p.Handle;
    }
    void callback(IAsyncResult ar)
    {
        try
        {
            Socket s = this.s.EndAccept(ar);
            SocketAccepted(s);
            this.s.BeginAccept(callback, null);
            OpenFileDialog OFD = new OpenFileDialog();
            OpenClientRecieveAsync(OFD, Process.GetCurrentProcess());
            for (int i = 0; i < ClientHabboProcs.Count; i++)
            {
                foreach(Process p in ClientHabboProcs)
                {
                    OpenClientRecieveAsync(OFD, p);
                    [DllImport("user32.dll")]
                    static extern IntPtr SetParent(IntPtr hwnd, IntPtr hwndNewparent);
                    SetParent(OpenClientRecieveAsync(OFD, p), p.MainWindowHandle);
                    SetParent(OpenClientRecieveAsync(OFD, p), IntPtr.Zero);
                    SetParent(IntPtr.Zero, p.MainWindowHandle);
                    Console.WriteLine("Posting");
                    

                    
                }


            }
        }

        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
    }
    public delegate void SocketAcceptedHandler(Socket e);
    public event SocketAcceptedHandler SocketAccepted;
}

class SocketAcceptedEventHandler : EventArgs
{
    public Socket Accepted
    {
        get;
        private set;
    }
    public SocketAcceptedEventHandler(Socket s)
    {
        Accepted = s;
    }
}

