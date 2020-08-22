using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bibliotheek_Console
{
    public class User
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
            get; set;
        }
        public User(string voornaam, string familienaam, string adres, int leeftijd)
        {
            Voornaam = voornaam;
            Familienaam = familienaam;
            Adres = adres;
            Leeftijd = leeftijd;

        }

        public User(string voornaam, string familienaam)
        {
            Voornaam = voornaam;
            Familienaam = familienaam;
        
        }
        public User()
        {
        }
        public virtual string GetDetails()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine(string.Format(" Familienaam: {0}", Familienaam));
            sb.AppendLine(string.Format(" Voornaam: {0}", Voornaam));
            sb.AppendLine(string.Format(" Leeftijd: {0}", Leeftijd));
            sb.AppendLine(string.Format(" Adres: {0}", Adres));
   
            return sb.ToString();
        }

    }
    public enum Rol { Bibliothecaris, ITBeheerder, Admin, Beheerder };


    public class AdminUser:User
    {
        public readonly Rol _rol;
        public AdminUser(string voornaam, string familienaam, Rol rol) : base(voornaam, familienaam)
        {
            Rol = rol;

        }
        public Rol Rol
        
            { get; private set; }
    
      
        public override string GetDetails()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine(string.Format(" Familienaam: {0}", Familienaam));
            sb.AppendLine(string.Format(" Voornaam: {0}", Voornaam));
            sb.AppendLine(string.Format(" Leeftijd: {0}", Leeftijd));
            sb.AppendLine(string.Format(" Adres: {0}", Adres));
            sb.AppendLine(string.Format(" Functie: {0}", Rol));

            return sb.ToString();
        }

    }

}

