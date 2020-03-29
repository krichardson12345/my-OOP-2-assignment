using System;
using System.IO;
using System.Collections.Generic;
using System.Text;

namespace compare_files_assignment
{
    class Compare_files
    {
        public static bool Compare()
        {
            //reads in two files
            string[] file_1 = File.ReadAllLines(@"file1.txt");
            Console.WriteLine(file_1[0]);
            string[] file_2 = File.ReadAllLines(@"file2.txt");
            Console.WriteLine(file_2[0]);


            int i;
            //tests the two string arrays against each other and returns a bool if they are/arent
            if (file_1.Length != file_2.Length)
            {
                return false;
            }
            else
            {
                for (i = 0; i < file_1.Length; i++)
                {
                    if (file_1[i] != file_2[i])
                    {
                        return false;
                    }
                }
                return true;
            }
        }
    }
}
