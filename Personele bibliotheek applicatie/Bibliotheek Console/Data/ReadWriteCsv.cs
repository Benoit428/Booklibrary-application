using System;
using System.Collections.Generic;
using System.IO;
using Bibliotheek_Console.Properties;

namespace Bibliotheek_Console.Data
{
    class ReadWriteCsv : IDataAccess
    {
        private readonly Dictionary<int, Boek> booklist;

        public static List<Boek> ReadBoekenlijst(String file)
        {

            //  bookTitle, bookAuthor, bookComment, releaseDate, genre));

          

                StreamReader reader = new StreamReader(File.OpenRead(@"../Boekenlijst/" + file));
                List<Boek> boekenLijst = new List<Boek>();
                Boek test = new Boek();
                while (!reader.EndOfStream)
                {
                    string line = reader.ReadLine();
                    if (!String.IsNullOrWhiteSpace(line))
                    {
                        string[] values = line.Split(',');
                        if (values.Length == 4)
                        {

                            //Title,Author,Genre,Height,Publisher

                            test.BookTitle = values[0];
                            test.BookAuthor = values[1];
                            test.ReleaseDate = Int32.Parse(values[2]);
                            test.Genre = (Genre)Enum.Parse(typeof(Genre), values[3]);


                        }
                    }
                }
                reader.Close();
            return boekenLijst;
        }
        public List<Boek> SortedMovieList
        {
            get

            {
                var result = new List<Boek>(booklist.Values);
                result.Sort();
                result.Reverse();
                return result;
            }
        }


    }

}





/*
DateTime dt;
                        if (DateTime.TryParseExact(values[0], "d-MM-yyyy",
                         System.Globalization.CultureInfo.CurrentCulture,
                         System.Globalization.DateTimeStyles.None, out dt))
                        {
                            values[3] = dt.ToString("yyyyMMdd");
                            

                        }

    */




