using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text.RegularExpressions;
using Bibliotheek_Console.Properties;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Bibliotheek_Console.Data
{
    class ReadWriteCsv : IDataAccess
    {
        //private readonly Dictionary<int, Boek> booklist;

        public static List<Boek> ReadBoekenlijst(String file)
        {
            List<Boek> boekenLijst = new List<Boek>();




           

            Boek test = new Boek();
            using StreamReader reader = new StreamReader(File.OpenRead(@"..\Boekenlijst\" + file));
            
                string? item;
            do
            {
                item = reader.ReadLine();
                if (!String.IsNullOrWhiteSpace(item))
                {
                    string[] values = item.Split(',');
                    if (values.Length == 4)
                    {


                        //Title,Author,Genre,Height,Publisher

                        test.BookTitle = values[0].Trim();
                        test.BookAuthor = values[1].Trim();

                        Int32 value = Int32.Parse(values[2].Trim());
                        //format int to datetime
                        

                        string Day = value.ToString().Substring(0, 2);
                            string Month = value.ToString().Substring(2, 4);
                            string Year = value.ToString().Substring(4, 7);
                            string dateFormat = Day + "/" + Month + "/" + Year;
                            test.ReleaseDate = dateFormat;
                        
                        
                       

                        test.Genre = (Genre)Enum.Parse(typeof(Genre), values[3]);

                        boekenLijst.Add(test);
                    }
                }
            }
            while (!reader.EndOfStream);

                   
            
            return boekenLijst;
        }

        readonly string _path = @"..\Boekenlijst\";
        public  List <Boek> ReadJSON(String file)
        {
    
        List  <Boek> _list = new List<Boek>();

            /* vul boekenlijst aan met data */
            BinaryFormatter formatter = new BinaryFormatter();
            FileStream stream = new FileStream(_path + file, FileMode.OpenOrCreate);
            try
            {
                if (stream.Length > 0)
                {
                    _list = (List<Boek>)formatter.Deserialize(stream);
                }
            }
            catch (SerializationException e)
            {
                Console.WriteLine("Serialisatie nie mogelijk: " + e.Message);
                throw;
            }
            finally
            {
                stream.Close();
            }

            return _list;
        }




        public List<Boek> SortedBookList(List<Boek> lijst)
        {



            lijst.Sort();
            lijst.Reverse();
            return lijst;

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




