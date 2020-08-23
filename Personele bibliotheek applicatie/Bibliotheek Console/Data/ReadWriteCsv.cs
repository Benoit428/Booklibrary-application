using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text.RegularExpressions;
using Bibliotheek_Console.Properties;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Linq;

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

                        test.BookTitle = values[0].Trim();
                        test.BookAuthor = values[1].Trim();

                        Int32 value = Int32.Parse(values[2].Trim());
                        //reformat int to DateTime and pass as string
                        DateTime dt;
                        if (DateTime.TryParseExact(value.ToString(), "ddMMyyyy",
                                                  CultureInfo.InvariantCulture,
                                                  DateTimeStyles.None, out dt))
                        {
                            test.ReleaseDate = dt.ToString("dd/MM/yyyy", CultureInfo.InvariantCulture);
                        }



                        test.Genre = (Genre)Enum.Parse(typeof(Genre), values[3]);

                        boekenLijst.Add(test);
                    }
                }
            }
            while (!reader.EndOfStream);



            return boekenLijst;
        }

        readonly string _path = @"..\Boekenlijst\";
        public List<Boek> ReadJson(string file)
        {

            List<Boek> _list = new List<Boek>();
            if (ValidateJSON(file))
            {


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

               
            }
            return _list;
        }
        
        public void WriteJson(List<Boek> _data, string fileJson)
        {

            using StreamWriter file = File.CreateText(_path + fileJson);
            JsonSerializer serializer = new JsonSerializer();
            //serialize object directly into file stream
            serializer.Serialize(file, _data);
        }
        

        public bool ValidateJSON(string fileJson)
        {
            try
            {
                JToken.Parse(fileJson);
                return true;
            }
            catch (JsonReaderException ex)
            {
                Trace.WriteLine(ex);
                return false;
            }
        }
        



        public List<Boek> SortedBookList(List<Boek> _lijst)
        {
            _lijst.Sort();
            _lijst.Reverse();
            return _lijst;

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




