using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bibliotheek_Console
{
    public interface IDataAccess
    {
        List<Boek> BookList { get; }


        void ImportBoekenlijst(string fileName);

        void WriteBoekenLijst(string fileName, string[] boekenlijst);

    }
}
