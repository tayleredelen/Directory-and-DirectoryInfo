using System;

namespace CSharpFundamentals
{
    class Program
    {
        static void Main(string[] args)
        {
            Directory.CreateDirectory(@"c:\temp\folder1");

            // Directory.GetFiles(path, path search pattern, path search option enumeration);
            var files = Directory.GetFiles(@"c:\projects\CSharpFundamentals", "*.*", SearchOption.AllDirectories);
            foreach (var file in files)
                Console.WriteLine(file);
            
        }
    }
}