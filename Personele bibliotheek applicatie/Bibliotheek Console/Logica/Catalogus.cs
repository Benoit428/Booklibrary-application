using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bibliotheek_Console
{
    class Catalogus
    {
        private SortedList<string, User> Users = new SortedList<string, User>();
        private SortedList<string, BoekenLijst> Books = new SortedList<string, BoekenLijst>();


        public IList<User> Users1

        {
            get { return Users.Values; }
        }

        public void AddUser(User gebruiker)
        {
            try
            {
                Users.Add(gebruiker.Familienaam, gebruiker);
            }
            
            catch (UserException e)
            {
                throw new System.ArgumentException(e.Message);
            }
        }

        public void DeleteUser(User gebruiker)
        {
            try
            {
              
         
                if (Users.ContainsValue(gebruiker))
                    Users.Remove(gebruiker.Familienaam);
            }
            catch (DeleteUserException e)
            {
                throw new System.ArgumentException(e.Message);
            }

        }
    
        }
    }

     
        


        
    

