using System;
using System.Timers;
using System.IO;
using System.Net;
using System.Threading.Tasks.Dataflow;

namespace ConsoleApp1
{
    class Program
    {
        static Timer timer;
        static ftp ftpClient = new ftp(@"ftp://10.31.179.0/", "user-ftp", "1234");
        static void Main(string[] args)
        
        {
            timer = new Timer(5000);
            timer.Elapsed += TimerTick;
            timer.Start();
            Console.ReadLine(); 
            
        }

        static private void TimerTick(Object source, ElapsedEventArgs e)
        {
            /*if (System.IO.File.Exists(@"D:\unifolder\first\pass1.txt"))
            {
                Console.WriteLine("exist");
                timer.Stop();
            }

            else if (DateTime.Now.Subtract(date1).TotalMinutes < 1)
            {
                Console.WriteLine("downloading...");
                ftpClient.download("first/pass.txt", @"D:\THERE\downloads\new.txt");
            }

            else
            {
                Console.WriteLine("end");
                timer.Stop();
            }*/
            DownloadFilesFromRemoteServer();
            
        }

        static private void DownloadFilesFromRemoteServer()
        {
            DateTime date1 = DateTime.Now;
            DateTime date2 = date1.AddMinutes(30);
            if (date2.Subtract(DateTime.Now).TotalMinutes < 30)
            {
            }
        }
    }
}
