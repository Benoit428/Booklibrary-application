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
    public partial class Aanmaakscherm : Form
    
    {
        public Aanmaakscherm()
        {
            InitializeComponent();
            Directory.SetCurrentDirectory(@"..\");
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            
          string famNaam = txtNaam.Text; 
          string voornaam = txtVoornaam.Text;

            User localUser = new User(famNaam,voornaam);
         //   int leeftijd = int.Parse(txtLeeftijd.Text);
            if (File.Exists(($@"..\Gebruikers\{famNaam}{voornaam}.txt")))
            {
                this.labelError.Text = $"De gebruiker {famNaam}{voornaam} bestaat al";
            }
            else
            {
                using (StreamWriter tw = new StreamWriter($@"..\Bibliotheek console\Gebruikers\{famNaam}{voornaam}.txt"))
                {
                    tw.Write("");
                }


                this.labelError.Text = $"u bent correct ingelogd";
                Boekenlijst program = new Boekenlijst(famNaam,voornaam);
                program.Show();
                this.Hide();
            }
        }

        private void Aanmaakscherm_Load(object sender, EventArgs e)
        {

        }
    }
}

    

