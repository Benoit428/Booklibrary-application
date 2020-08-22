using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Forms;

namespace Bibliotheek_Console.Gui
{
    public partial class BoekToevoegscherm : Form
    {
        public BoekToevoegscherm()
        {
            InitializeComponent();
            ddlGenre.DataSource = Enum.GetValues(typeof(Genre));
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void BoekToevoegscherm_Load(object sender, EventArgs e)
        {

        }

        private void txtBoekPublicatiejaar_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }
        private void dropdownGenre_SelectedIndexChanged(object sender, EventArgs e)
        {
            {
                Array genres = Enum.GetValues(typeof(Genre));
                Array.Sort(genres);
                foreach (Genre genre in genres)
                {
                    ddlGenre.Items.Add((genre.ToString(), ((int)genre).ToString()));
                }
            }
        }


        private void BtnVoegToe_Click(object sender, EventArgs e)
        {
            
            var csv = new StringBuilder();
            var titel = txtBoekTitel.Text;
            var jaar = txtBoekPublicatiejaar.Text;
            var auteur = txtBoekAuteur.Text;
            var uitgever = txtBoekUitgeverij;
            var genre = ddlGenre.SelectedItem;
                var newLine = string.Format("{0};{1};{2};{3};{4}", titel, jaar, auteur,uitgever,genre);
                csv.Append(newLine);
                File.AppendAllText(@"...\data.csv", csv.ToString());
            }

        
    }
 }

