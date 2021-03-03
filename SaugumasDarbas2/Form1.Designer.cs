namespace SaugumasDarbas2
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.encryptTextbox = new System.Windows.Forms.TextBox();
            this.Encrypt = new System.Windows.Forms.Button();
            this.descrypt = new System.Windows.Forms.Button();
            this.decryptTextbox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.decryptedTextLabel = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.decriptionResultTextbox = new System.Windows.Forms.TextBox();
            this.label100 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.decryptFileResultTextbox = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.decryptFromFile = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(81, 84);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(161, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Iveskite teksta:";
            // 
            // encryptTextbox
            // 
            this.encryptTextbox.Location = new System.Drawing.Point(85, 111);
            this.encryptTextbox.Name = "encryptTextbox";
            this.encryptTextbox.Size = new System.Drawing.Size(192, 20);
            this.encryptTextbox.TabIndex = 1;
            // 
            // Encrypt
            // 
            this.Encrypt.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Encrypt.Location = new System.Drawing.Point(85, 198);
            this.Encrypt.Name = "Encrypt";
            this.Encrypt.Size = new System.Drawing.Size(122, 38);
            this.Encrypt.TabIndex = 2;
            this.Encrypt.Text = "Encrypt";
            this.Encrypt.UseVisualStyleBackColor = true;
            this.Encrypt.Click += new System.EventHandler(this.Encrypt_Click);
            // 
            // descrypt
            // 
            this.descrypt.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.descrypt.Location = new System.Drawing.Point(458, 198);
            this.descrypt.Name = "descrypt";
            this.descrypt.Size = new System.Drawing.Size(122, 38);
            this.descrypt.TabIndex = 5;
            this.descrypt.Text = "Descrypt";
            this.descrypt.UseVisualStyleBackColor = true;
            this.descrypt.Click += new System.EventHandler(this.descrypt_Click);
            // 
            // decryptTextbox
            // 
            this.decryptTextbox.Location = new System.Drawing.Point(459, 111);
            this.decryptTextbox.Name = "decryptTextbox";
            this.decryptTextbox.Size = new System.Drawing.Size(241, 20);
            this.decryptTextbox.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(455, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(268, 24);
            this.label2.TabIndex = 3;
            this.label2.Text = "Iveskite uzsifruota teksta:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(35, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 13);
            this.label3.TabIndex = 6;
            // 
            // decryptedTextLabel
            // 
            this.decryptedTextLabel.AutoSize = true;
            this.decryptedTextLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.decryptedTextLabel.Location = new System.Drawing.Point(386, 260);
            this.decryptedTextLabel.Name = "decryptedTextLabel";
            this.decryptedTextLabel.Size = new System.Drawing.Size(0, 24);
            this.decryptedTextLabel.TabIndex = 8;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(85, 171);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 11;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(81, 144);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(279, 24);
            this.label6.TabIndex = 13;
            this.label6.Text = "Pasirinkite sifravimo moda";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(455, 144);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(199, 24);
            this.label7.TabIndex = 17;
            this.label7.Text = "Desifravimo  moda";
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(459, 171);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(121, 21);
            this.comboBox2.TabIndex = 15;
            this.comboBox2.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // decriptionResultTextbox
            // 
            this.decriptionResultTextbox.Location = new System.Drawing.Point(458, 276);
            this.decriptionResultTextbox.Name = "decriptionResultTextbox";
            this.decriptionResultTextbox.Size = new System.Drawing.Size(241, 20);
            this.decriptionResultTextbox.TabIndex = 18;
            // 
            // label100
            // 
            this.label100.AutoSize = true;
            this.label100.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label100.Location = new System.Drawing.Point(454, 249);
            this.label100.Name = "label100";
            this.label100.Size = new System.Drawing.Size(143, 24);
            this.label100.TabIndex = 7;
            this.label100.Text = "Decrypted Text:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(78, 32);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(243, 39);
            this.label4.TabIndex = 19;
            this.label4.Text = "ENCRYPTION";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(452, 32);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(243, 39);
            this.label5.TabIndex = 20;
            this.label5.Text = "DECRYPTION";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(78, 257);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(339, 39);
            this.label8.TabIndex = 21;
            this.label8.Text = "DECRYPTION(FILE)";
            // 
            // comboBox3
            // 
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Location = new System.Drawing.Point(85, 358);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(121, 21);
            this.comboBox3.TabIndex = 22;
            this.comboBox3.SelectedIndexChanged += new System.EventHandler(this.comboBox3_SelectedIndexChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(81, 331);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(160, 24);
            this.label9.TabIndex = 23;
            this.label9.Text = "Desifravimo moda";
            // 
            // decryptFileResultTextbox
            // 
            this.decryptFileResultTextbox.Location = new System.Drawing.Point(85, 464);
            this.decryptFileResultTextbox.Name = "decryptFileResultTextbox";
            this.decryptFileResultTextbox.Size = new System.Drawing.Size(241, 20);
            this.decryptFileResultTextbox.TabIndex = 25;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(82, 437);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(143, 24);
            this.label10.TabIndex = 24;
            this.label10.Text = "Decrypted Text:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(82, 296);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(182, 20);
            this.label11.TabIndex = 26;
            this.label11.Text = "Yra du failai. CBC ir ECB";
            // 
            // decryptFromFile
            // 
            this.decryptFromFile.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.decryptFromFile.Location = new System.Drawing.Point(85, 385);
            this.decryptFromFile.Name = "decryptFromFile";
            this.decryptFromFile.Size = new System.Drawing.Size(122, 38);
            this.decryptFromFile.TabIndex = 27;
            this.decryptFromFile.Text = "Descrypt";
            this.decryptFromFile.UseVisualStyleBackColor = true;
            this.decryptFromFile.Click += new System.EventHandler(this.decryptFromFile_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(899, 594);
            this.Controls.Add(this.decryptFromFile);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.decryptFileResultTextbox);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.comboBox3);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.decriptionResultTextbox);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.decryptedTextLabel);
            this.Controls.Add(this.label100);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.descrypt);
            this.Controls.Add(this.decryptTextbox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Encrypt);
            this.Controls.Add(this.encryptTextbox);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox encryptTextbox;
        private System.Windows.Forms.Button Encrypt;
        private System.Windows.Forms.Button descrypt;
        private System.Windows.Forms.TextBox decryptTextbox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label decryptedTextLabel;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.TextBox decriptionResultTextbox;
        private System.Windows.Forms.Label label100;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox decryptFileResultTextbox;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button decryptFromFile;
    }
}

