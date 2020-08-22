using System.Drawing;

namespace Bibliotheek_Console.Gui
{
    partial class Boekenlijst
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
            this.editButton = new System.Windows.Forms.Button();
            this.addButton = new System.Windows.Forms.Button();
            this.deleteButton = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ImportButton = new System.Windows.Forms.Button();
            this.listBoeken = new System.Windows.Forms.ListBox();
            this.lblMessage = new System.Windows.Forms.Label();
            this.lblError = new System.Windows.Forms.Label();
            this.SaveButton = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // editButton
            // 
            this.editButton.Location = new System.Drawing.Point(69, 166);
            this.editButton.Margin = new System.Windows.Forms.Padding(2);
            this.editButton.Name = "editButton";
            this.editButton.Size = new System.Drawing.Size(132, 28);
            this.editButton.TabIndex = 3;
            this.editButton.Text = "Pas boek aan";
            this.editButton.UseVisualStyleBackColor = true;
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(69, 124);
            this.addButton.Margin = new System.Windows.Forms.Padding(2);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(132, 28);
            this.addButton.TabIndex = 2;
            this.addButton.Text = "Voeg boek toe";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // deleteButton
            // 
            this.deleteButton.Location = new System.Drawing.Point(69, 79);
            this.deleteButton.Margin = new System.Windows.Forms.Padding(2);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(132, 28);
            this.deleteButton.TabIndex = 1;
            this.deleteButton.Text = "Verwijder boek";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.SaveButton);
            this.groupBox1.Controls.Add(this.ImportButton);
            this.groupBox1.Controls.Add(this.editButton);
            this.groupBox1.Controls.Add(this.addButton);
            this.groupBox1.Controls.Add(this.deleteButton);
            this.groupBox1.Location = new System.Drawing.Point(516, 56);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(266, 354);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Keuzelijst";
            // 
            // ImportButton
            // 
            this.ImportButton.Location = new System.Drawing.Point(69, 208);
            this.ImportButton.Name = "ImportButton";
            this.ImportButton.Size = new System.Drawing.Size(132, 30);
            this.ImportButton.TabIndex = 6;
            this.ImportButton.Text = "Importeer boekenlijst";
            this.ImportButton.UseVisualStyleBackColor = true;
            this.ImportButton.Click += new System.EventHandler(this.ImportButton_Click);
            // 
            // listBoeken
            // 
            this.listBoeken.BackColor = System.Drawing.Color.LightSkyBlue;
            this.listBoeken.Font = new System.Drawing.Font("Georgia", 12F);
            this.listBoeken.FormattingEnabled = true;
            this.listBoeken.ItemHeight = 18;
            this.listBoeken.Location = new System.Drawing.Point(10, 56);
            this.listBoeken.Margin = new System.Windows.Forms.Padding(2);
            this.listBoeken.Name = "listBoeken";
            this.listBoeken.Size = new System.Drawing.Size(503, 346);
            this.listBoeken.TabIndex = 2;
            this.listBoeken.SelectedIndexChanged += new System.EventHandler(this.listBoeken_SelectedIndexChanged);
            // 
            // lblMessage
            // 
            this.lblMessage.AutoSize = true;
            this.lblMessage.Location = new System.Drawing.Point(103, 9);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(10, 13);
            this.lblMessage.TabIndex = 4;
            this.lblMessage.Text = "-";
            // 
            // lblError
            // 
            this.lblError.AutoSize = true;
            this.lblError.Location = new System.Drawing.Point(103, 31);
            this.lblError.Name = "lblError";
            this.lblError.Size = new System.Drawing.Size(10, 13);
            this.lblError.TabIndex = 5;
            this.lblError.Text = "-";
            // 
            // SaveButton
            // 
            this.SaveButton.Location = new System.Drawing.Point(73, 280);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(127, 40);
            this.SaveButton.TabIndex = 7;
            this.SaveButton.Text = "Boekenlijst opslaan";
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // Boekenlijst
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(790, 427);
            this.Controls.Add(this.lblError);
            this.Controls.Add(this.lblMessage);
            this.Controls.Add(this.listBoeken);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Boekenlijst";
            this.Text = "Boekenlijst + KeuzeMeunu";
            this.Load += new System.EventHandler(this.Boekenlijst_Load);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button editButton;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListBox listBoeken;
        private System.Windows.Forms.Label lblMessage;
        private System.Windows.Forms.Label lblError;
        private System.Windows.Forms.Button ImportButton;
        private System.Windows.Forms.Button SaveButton;
    }
}