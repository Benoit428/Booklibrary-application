using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bibliotheek_Console
{



    public class Boek
    {
        
        public string BookTitle
        {
            get; set;
        }
        public string BookAuthor
        {
            get; set;
        }
        public string BookPublisher
        {
            get; set;
        }
        public int ReleaseDate
        {
            get; set;
        }
        internal Genre Genre { get; set; }

        public Boek(string title, string author, string publisher, int releaseDate, Genre genre)
        {
            BookTitle = title;
            BookAuthor = author;
            BookPublisher = publisher;
            ReleaseDate = releaseDate;
            Genre = genre;
        }

        public Boek()
        {
        }

        public string GetDetails()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine(string.Format("   Titel: {0}", BookTitle));
            sb.AppendLine(string.Format("   Auteur: {0}", BookAuthor));
            sb.AppendLine(string.Format("   Uitgever: {0}", BookPublisher));
            sb.AppendLine(string.Format("   Publicatiedatum: {0}", ReleaseDate));
            sb.AppendLine(string.Format("   Genre: {0}", Genre));
   
          
            return sb.ToString();
        }
        public string ToString()
        {


            return ("Titel van Boek: " + BookTitle + "Auteur: " + "Genre" + Genre + BookAuthor + "Publisher" + BookPublisher + "Publicatiedatum" + ReleaseDate);


        }
    }
}


        


