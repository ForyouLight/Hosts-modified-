using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace com.foryoulight
{
    class Program
    {
        static void Main(string[] args)
        {
            void GetHosts(string Url,string File)
            {
                try
                {
                    HttpWebRequest request = (HttpWebRequest)WebRequest.Create(Url);
                    HttpWebResponse response = request.GetResponse() as HttpWebResponse;
                    Stream responseStream = response.GetResponseStream();
                    Stream stream = new FileStream(File, FileMode.Create);
                    byte[] bArr = new byte[1024];
                    int size = responseStream.Read(bArr, 0, bArr.Length);
                    while (size > 0)
                    {
                        stream.Write(bArr, 0, size);
                        size = responseStream.Read(bArr, 0, bArr.Length);
                    }
                    stream.Close();
                    responseStream.Close();
                }catch(Exception error)
                {
                    Console.WriteLine(error.Message);
                }
            }
            a1: Console.WriteLine("\t\t\t\t\t\tHosts修改巨他妈兼容版\n\n\n\n");
            Console.WriteLine("\t\t\t\t请选择要操作项：\n\n");
            Console.WriteLine("\t\t\t\t1.修改hosts\n");
            Console.WriteLine("\t\t\t\t2.还原hosts\n");
            Console.WriteLine("\t\t\t\t3.退出\n\n\n\n\n");
            Console.Write("\t\t\t\t请选择所要操作的序号:");
            string uinty = Console.ReadLine();
            Console.Clear();
            if (uinty == "1")
            {
                Console.WriteLine("下载并更改Hosts中，请稍后........");
                Console.WriteLine("Copyright © 2016-2018 googlehosts members");
                GetHosts("https://raw.githubusercontent.com/ForyouLight/hosts/master/hosts-files/hosts", @"C:\Windows\System32\drivers\etc\hosts");
                Console.WriteLine("Done");
                Console.WriteLine("按任意键返回");
                Console.ReadKey();
                Console.Clear();
                goto a1;
            }
            else if (uinty == "2")
            {
                Console.WriteLine("还原中。。。。。。");
                GetHosts("https://raw.githubusercontent.com/ForyouLight/null/master/hosts", @"C:\Windows\System32\drivers\etc\hosts");
                Console.WriteLine("Done");
                Console.WriteLine("按任意键返回");
                Console.ReadKey();
                Console.Clear();
                goto a1;
            }
            else if (uinty == "3")
            {
                
            }
            else
            {
                Console.Write("无效的操作，按任意键继续");
                Console.ReadKey();
                Console.Clear();
                goto a1;
            }
      
        }

    }
 }
