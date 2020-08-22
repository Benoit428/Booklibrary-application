using System;
using System.Collections.Generic;
using System.IO;
using Bibliotheek_Console.Properties;

namespace Bibliotheek_Console.Data
{
    class ReadWriteCsv
    {
        private readonly Dictionary<string, BoekenLijst> storage = new Dictionary<string, BoekenLijst>();


        public DataAccessImplementation()
        {
            storage = new Dictionary<string, Boek>();
        }




        public void ImportBoekenlijst(string fileName)
        {

            //  bookTitle, bookAuthor, bookComment, releaseDate, genre));

            string[] bookList = File.ReadAllLines(fileName);
            foreach (string line in bookList)
            {
                string[] elements = line.Split(';');
                addBook(elements[0].Trim().ToLower(), elements[1], elements[2], Int32.Parse(elements[3]), (Genre)Enum.Parse(elements[4]));
            }

            /*

                StreamReader reader = new StreamReader(File.OpenRead(@"../Boekenlijst/"+ file));
                List<string> boekenLijst = new List<string>();
            Boek test = new Boek();
                while (!reader.EndOfStream)
                {
                    string line = reader.ReadLine();
                    if (!string.IsNullOrWhiteSpace(line))
                    {
                        string[] values = line.Split(',');
                        if (values.Length >= 5)
                        {
                       
                       
                        test.BookTitle = values[0];
                        test.BookAuthor = values[1];
                        test.ReleaseDate = Int32.Parse(values[2]);
                        test.Genre = (Genre)Enum.Parse(typeof(Genre), values[3]);

                        }
                    }
                }
                string[] boekenLijstArr = boekenLijst.ToArray();
         
            }
            */
        }
        public void WriteBoekenLijst(string fileName, string[] bookList)
        {
            string line;
            List<string> boekenLijst = new List<string>();
            System.IO.StreamReader file = new System.IO.StreamReader(fileName);
            while ((line = file.ReadLine()) != null)
            {
                string[] words = line.Split(';');
                listOfPersons.Add(new Boek(words[0], words[1],words[2], Int32.Parse(words[3]), (Genre)Enum.Parse(typeof(Genre), words[4])));
            }

            file.Close();
        }
    }
}













