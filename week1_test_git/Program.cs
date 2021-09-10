using System;
using System.IO;

namespace week1_test_git
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"C:\Users\gian.mario.falchi\OneDrive - Avanade\Desktop\week1 test\week1_test_git";
            FileSystemWatcher fsw = new FileSystemWatcher
            {
                Path = path,
                Filter = "*.txt"
            };
            fsw.EnableRaisingEvents = true;
            fsw.NotifyFilter = NotifyFilters.LastWrite | NotifyFilters.LastAccess | NotifyFilters.DirectoryName | NotifyFilters.FileName;
            fsw.Created += Spese.GestisciNuovoFile;
        }
    }
}
