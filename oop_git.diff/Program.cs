using System;
using System.IO;

namespace compare_files_assignment
{
    class Program
    {
       public static void Main()
        {
            bool x = Compare_files.Compare();
            //program uses compaes bool value to output answer to user
            if (x == true)
            {
                Console.WriteLine("the two strings are equal");
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("the two files are not equal");
                Console.ReadLine();
            }
            Console.WriteLine("please press enter to exit");
            Console.ReadLine();
        }
    }
}
