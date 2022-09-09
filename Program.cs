// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

using System;

namespace FileIOPracticeProblem
{
    class program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome to AddressBook Problem ");

            String path = @"C:\BridgeLabs\Phase 2\FileIOPracticeProblem\FileIOPracticeProblem\Details.txt";

            PersonDetails fileOperation = new PersonDetails();
            fileOperation.WriteFromStreamWriter(path);
        }
        public static void CheckFilesExists(string path)
        {
            if (File.Exists(path))
            {
                Console.WriteLine("File is exists");
            }
            else
            {
                Console.WriteLine("File is not exists");
            }
        }
        public static void ReadAllLinesFromFile(string path)
        {


            string[] lines;
            lines = File.ReadAllLines(path);

            Console.WriteLine(lines[0]);
            Console.WriteLine(lines[1]);
        }

        public static void ReadAllTextFromFile(string path)
        {
            string line;
            line = File.ReadAllText(path);

            Console.WriteLine(line);
        }
    }
}