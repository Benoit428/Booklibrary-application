using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bibliotheek_Console
{
    class User
    {
        public string Voornaam
        {
            get; set;
        }
        public string Familienaam
        {
            get; set;
        }
        public string Adres
        {
            get; set;
        }
        public int Leeftijd
        {
            get; private set;
        }

        public User(string voornaam, string familienaam)
        {
            Voornaam = voornaam;
            Familienaam = familienaam;
        
        }
        public User()
        {

        }
        public string GetDetails()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine(string.Format(" Familienaam: {0}", Familienaam));
            sb.AppendLine(string.Format(" Voornaam: {0}", Voornaam));
            sb.AppendLine(string.Format(" Leeftijd: {0}", Leeftijd));
            sb.AppendLine(string.Format(" Adres: {0}", Adres));
   
            return sb.ToString();
        }
    }

}

