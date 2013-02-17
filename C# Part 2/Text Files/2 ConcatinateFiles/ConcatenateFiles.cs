//Write a program that concatenates two text files into another text file.
using System;
using System.IO;

    class ConcatenateFiles
    {
        static void Main()
        {
            StreamReader file1 = new StreamReader(@"C:\input1.txt");
            StreamReader file2 = new StreamReader(@"C:\input2.txt");
            StreamWriter file = new StreamWriter(@"C:\result.txt");
            string textFile1 = string.Empty;
            string textFile2 = string.Empty;
            string textFile = string.Empty;
            using (file1)
            {
                textFile1 = file1.ReadToEnd();
            }
            using (file2)
            {
                textFile2 = file2.ReadToEnd();
            }
            using (file)
            {
                file.WriteLine(textFile1);
                file.WriteLine(textFile2);
            }
        }
    }

