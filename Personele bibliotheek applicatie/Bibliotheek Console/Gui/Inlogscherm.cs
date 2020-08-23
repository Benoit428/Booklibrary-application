using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Bibliotheek_Console.Gui;

namespace Bibliotheek_Console
{
    public partial class Inlogscherm : Form
    {
        public Inlogscherm()
        {
            InitializeComponent();
            Directory.SetCurrentDirectory(@"..\");
        }

  
        private void btnLogin_Click(object sender, EventArgs e)
        {

            String famNaam = this.txtNaam.Text;
            String voornaam = this.txtVoornaam.Text;
            

                if (File.Exists(($@"../Gebruikers/{famNaam}{voornaam}.txt")))
                {
                    
                    this.labelError.Text = $"gelukt";
                Boekenlijst program = new Boekenlijst(famNaam,voornaam);
                    program.Show();
                    this.Hide();
                }
                else
                {
                    this.labelError.Text = $"De gebruiker {voornaam} {famNaam} bestaat niet";
                }
            }


        private void btnAanmaken_Click(object sender, EventArgs e)
        {
            Aanmaakscherm gebruiker = new Aanmaakscherm();
            gebruiker.Show();
            this.Hide();

        }

        private void Inlogscherm_Load(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }
    }
}
