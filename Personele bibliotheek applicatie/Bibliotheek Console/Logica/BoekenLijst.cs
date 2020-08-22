using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace Bibliotheek_Console
{
 

    
    class BoekenLijst
    {
        List<Boek> BookList = new List<Boek>();
        public void AddBook(string boekTitel, string boekAuteur,String uitgever, string publicatiedatum, Genre genre) 
        {

            BookList.Add(new Boek(boekTitel, boekAuteur, uitgever, publicatiedatum, genre));
        }
           
        public void DeleteBook(Boek b) { 
            try
            {

                if (BookList.Contains(b))
                {
                    BookList.Remove(b);
                }
            }
            
            catch (Exceptions e)
           
            {
                throw new System.ArgumentException(e.Message);
            }
        }
        public List<Boek> GetBoekenLijst()
        {

            return BookList;

        }
       
        

    }
}
