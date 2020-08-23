using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Bibliotheek_Console.Gui
{
    public partial class Boekenlijst : Form
    {
        
        private User tempUser = new User();

        public Boekenlijst(String famNaam,String voornaam)
        {
            InitializeComponent();
        }
        public Boekenlijst()
        {
        }


        private void AddButton_Click(object sender, EventArgs e)
        {
            BoekToevoegscherm program = new BoekToevoegscherm();
            program.Show();
            this.Hide();
        }

        private void GetItemsButton_Click(object sender, EventArgs e)
        {
            System.Text.StringBuilder sb = new System.Text.StringBuilder();
            foreach (object item in listBoeken.Items)
            {
                sb.Append(item.ToString());
                sb.Append(" ");
            }
            MessageBox.Show(sb.ToString());
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            while (listBoeken.SelectedItems.Count != 0)

            {

                listBoeken.Items.Remove(listBoeken.SelectedItems[0]);

            }
        }

        private void listBoeken_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Boekenlijst_Load(object sender, EventArgs e)
        {
            Boekenlijst br = new Boekenlijst();
            List<Boek> data = Data.ReadWriteCsv.ReadBoekenlijst("TempervilleBenoit.txt");

            foreach (var item in data)
                listBoeken.Items.Add(item.BookTitle + " " + item.BookAuthor + " " + item.ReleaseDate + " " + item.Genre);
                    
        }

        private void ImportButton_Click(object sender, EventArgs e)
        {
            string workingDirectory = Environment.CurrentDirectory;
            OpenFileDialog a = new OpenFileDialog();
            a.InitialDirectory = Directory.GetParent(workingDirectory).Parent.FullName;


            if (a.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    Data.ReadWriteCsv.ReadBoekenlijst(a.FileName);
                }
                catch(DirectoryNotFoundException ex)
                {

                    lblError.Text += ("De file kon niet gevonden worden. Ben je zeker dat de directory bestaat");                   


                }
                catch(FileNotFoundException ex)
                {
                    lblError.Text += ("De file kon niet gevonden worden. Ben je zeker dat de correcte file is geselecteerd (.txt of .csv extension");

                }
                catch (Exception ex)
                {
                    lblError.Text += ("Er is iets foutgelopen: {0}", ex.Message);

                }
                finally
                {
                    lblMessage.Text += ("Inlezen van de data is voltooid");
                }
                
            }
            
            
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            string gebruiker = (()f).txtbox1.Text;
            List<String> MyBooklist = GetAllElements(listBoeken);
            
            using (TextWriter tw = new StreamWriter("SavedList.txt"))
            {
                foreach (String s in MyBooklist)
                    tw.WriteLine(s);
            }
        }

        private static List<string> GetAllElements(ListBox chkList)
        {
            var myBooklist = chkList.Items.Cast<String>().ToList();

            return myBooklist;
        }


    }
}
