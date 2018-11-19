using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            ftp ftpClient = new ftp(@"ftp://192.168.0.100/", "user-ftp", "1234");
            ftpClient.download("first/pass.txt", @"D:\THERE\new.txt");
        }
    }
}
