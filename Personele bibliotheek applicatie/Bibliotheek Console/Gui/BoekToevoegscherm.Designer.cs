namespace Bibliotheek_Console.Gui
{
    partial class BoekToevoegscherm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.txtBoekTitel = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtBoekUitgeverij = new System.Windows.Forms.Label();
            this.txtBoekPublicatiejaar = new System.Windows.Forms.Label();
            this.txtBoekGenre = new System.Windows.Forms.Label();
            this.txtBoekAuteur = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.BtnVoegToe = new System.Windows.Forms.Button();
            this.ddlGenre = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // txtBoekTitel
            // 
            this.txtBoekTitel.Location = new System.Drawing.Point(75, 109);
            this.txtBoekTitel.Name = "txtBoekTitel";
            this.txtBoekTitel.Size = new System.Drawing.Size(147, 22);
            this.txtBoekTitel.TabIndex = 0;
            this.txtBoekTitel.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(75, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Titel";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(75, 134);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Auteur";
            // 
            // txtBoekUitgeverij
            // 
            this.txtBoekUitgeverij.AutoSize = true;
            this.txtBoekUitgeverij.Location = new System.Drawing.Point(75, 181);
            this.txtBoekUitgeverij.Name = "txtBoekUitgeverij";
            this.txtBoekUitgeverij.Size = new System.Drawing.Size(59, 17);
            this.txtBoekUitgeverij.TabIndex = 5;
            this.txtBoekUitgeverij.Text = "Uitgevrij";
            // 
            // txtBoekPublicatiejaar
            // 
            this.txtBoekPublicatiejaar.AutoSize = true;
            this.txtBoekPublicatiejaar.Location = new System.Drawing.Point(72, 239);
            this.txtBoekPublicatiejaar.Name = "txtBoekPublicatiejaar";
            this.txtBoekPublicatiejaar.Size = new System.Drawing.Size(93, 17);
            this.txtBoekPublicatiejaar.TabIndex = 6;
            this.txtBoekPublicatiejaar.Text = "Publicatiejaar";
            this.txtBoekPublicatiejaar.Click += new System.EventHandler(this.txtBoekPublicatiejaar_Click);
            // 
            // txtBoekGenre
            // 
            this.txtBoekGenre.AutoSize = true;
            this.txtBoekGenre.Location = new System.Drawing.Point(75, 284);
            this.txtBoekGenre.Name = "txtBoekGenre";
            this.txtBoekGenre.Size = new System.Drawing.Size(48, 17);
            this.txtBoekGenre.TabIndex = 7;
            this.txtBoekGenre.Text = "Genre";
            // 
            // txtBoekAuteur
            // 
            this.txtBoekAuteur.Location = new System.Drawing.Point(75, 154);
            this.txtBoekAuteur.Name = "txtBoekAuteur";
            this.txtBoekAuteur.Size = new System.Drawing.Size(144, 22);
            this.txtBoekAuteur.TabIndex = 8;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(75, 201);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(144, 22);
            this.textBox3.TabIndex = 9;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(75, 259);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(144, 22);
            this.textBox4.TabIndex = 10;
            this.textBox4.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(72, 48);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(231, 17);
            this.label7.TabIndex = 13;
            this.label7.Text = "Geef hier informatie in van uw boek";
            // 
            // BtnVoegToe
            // 
            this.BtnVoegToe.Location = new System.Drawing.Point(90, 342);
            this.BtnVoegToe.Name = "BtnVoegToe";
            this.BtnVoegToe.Size = new System.Drawing.Size(129, 49);
            this.BtnVoegToe.TabIndex = 15;
            this.BtnVoegToe.Text = "Voeg boek toe";
            this.BtnVoegToe.UseVisualStyleBackColor = true;
            this.BtnVoegToe.Click += new System.EventHandler(this.BtnVoegToe_Click);
            // 
            // ddlGenre
            // 
            this.ddlGenre.FormattingEnabled = true;
            this.ddlGenre.Items.AddRange(new object[] {
            ""});
            this.ddlGenre.Location = new System.Drawing.Point(78, 304);
            this.ddlGenre.Name = "ddlGenre";
            this.ddlGenre.Size = new System.Drawing.Size(136, 24);
            this.ddlGenre.TabIndex = 16;
            this.ddlGenre.SelectedIndexChanged += new System.EventHandler(this.dropdownGenre_SelectedIndexChanged);
            // 
            // BoekToevoegscherm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ddlGenre);
            this.Controls.Add(this.BtnVoegToe);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.txtBoekAuteur);
            this.Controls.Add(this.txtBoekGenre);
            this.Controls.Add(this.txtBoekPublicatiejaar);
            this.Controls.Add(this.txtBoekUitgeverij);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtBoekTitel);
            this.Name = "BoekToevoegscherm";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.BoekToevoegscherm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtBoekTitel;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label txtBoekUitgeverij;
        private System.Windows.Forms.Label txtBoekPublicatiejaar;
        private System.Windows.Forms.Label txtBoekGenre;
        private System.Windows.Forms.TextBox txtBoekAuteur;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button BtnVoegToe;
        private System.Windows.Forms.ComboBox ddlGenre;
    }
}