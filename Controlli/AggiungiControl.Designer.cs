namespace Gestione_Rubrica
{
    partial class AggiungiControl
    {
        /// <summary> 
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Pulire le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione componenti

        /// <summary> 
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare 
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            rjButton7 = new CustomControls.RJControls.RJButton();
            salvaButton = new CustomControls.RJControls.RJButton();
            noteTextBox = new CustomControls.RJControls.RJTextBox();
            label12 = new Label();
            capTextBox = new CustomControls.RJControls.RJTextBox();
            label13 = new Label();
            cittaTextBox = new CustomControls.RJControls.RJTextBox();
            label10 = new Label();
            indirizzoTextBox = new CustomControls.RJControls.RJTextBox();
            label11 = new Label();
            datanascitaTextBox = new CustomControls.RJControls.RJTextBox();
            label8 = new Label();
            emailTextBox = new CustomControls.RJControls.RJTextBox();
            label9 = new Label();
            cellulareTextBox = new CustomControls.RJControls.RJTextBox();
            label6 = new Label();
            telefonoTextBox = new CustomControls.RJControls.RJTextBox();
            label7 = new Label();
            cognomeTextBox = new CustomControls.RJControls.RJTextBox();
            label5 = new Label();
            nomeTextBox = new CustomControls.RJControls.RJTextBox();
            label4 = new Label();
            label3 = new Label();
            SuspendLayout();
            // 
            // rjButton7
            // 
            rjButton7.BackColor = Color.FromArgb(255, 128, 147);
            rjButton7.BackgroundColor = Color.FromArgb(255, 128, 147);
            rjButton7.BorderColor = Color.FromArgb(255, 71, 87);
            rjButton7.BorderRadius = 10;
            rjButton7.BorderSize = 2;
            rjButton7.FlatAppearance.BorderSize = 0;
            rjButton7.FlatStyle = FlatStyle.Flat;
            rjButton7.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            rjButton7.ForeColor = SystemColors.ControlText;
            rjButton7.Location = new Point(405, 928);
            rjButton7.Margin = new Padding(6);
            rjButton7.Name = "rjButton7";
            rjButton7.Size = new Size(384, 85);
            rjButton7.TabIndex = 30;
            rjButton7.Text = "Azzera Campi";
            rjButton7.TextColor = SystemColors.ControlText;
            rjButton7.UseVisualStyleBackColor = false;
            // 
            // salvaButton
            // 
            salvaButton.BackColor = Color.FromArgb(123, 237, 159);
            salvaButton.BackgroundColor = Color.FromArgb(123, 237, 159);
            salvaButton.BorderColor = Color.FromArgb(46, 213, 115);
            salvaButton.BorderRadius = 10;
            salvaButton.BorderSize = 2;
            salvaButton.FlatAppearance.BorderSize = 0;
            salvaButton.FlatStyle = FlatStyle.Flat;
            salvaButton.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold, GraphicsUnit.Point);
            salvaButton.ForeColor = SystemColors.ControlText;
            salvaButton.Location = new Point(405, 785);
            salvaButton.Margin = new Padding(6);
            salvaButton.Name = "salvaButton";
            salvaButton.Size = new Size(384, 130);
            salvaButton.TabIndex = 29;
            salvaButton.Text = "Salva";
            salvaButton.TextColor = SystemColors.ControlText;
            salvaButton.UseVisualStyleBackColor = false;
            salvaButton.Click += salvaButton_Click;
            // 
            // noteTextBox
            // 
            noteTextBox.BackColor = Color.FromArgb(218, 235, 242);
            noteTextBox.BorderColor = Color.FromArgb(170, 210, 227);
            noteTextBox.BorderFocusColor = Color.FromArgb(25, 167, 206);
            noteTextBox.BorderRadius = 10;
            noteTextBox.BorderSize = 2;
            noteTextBox.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            noteTextBox.ForeColor = Color.FromArgb(64, 64, 64);
            noteTextBox.Location = new Point(6, 698);
            noteTextBox.Margin = new Padding(7, 9, 7, 9);
            noteTextBox.Multiline = true;
            noteTextBox.Name = "noteTextBox";
            noteTextBox.Padding = new Padding(19, 15, 19, 15);
            noteTextBox.PasswordChar = false;
            noteTextBox.PlaceholderColor = Color.DarkGray;
            noteTextBox.PlaceholderText = "...";
            noteTextBox.Size = new Size(384, 316);
            noteTextBox.TabIndex = 51;
            noteTextBox.Texts = "";
            noteTextBox.UnderlinedStyle = false;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label12.ForeColor = Color.FromArgb(44, 62, 80);
            label12.Location = new Point(6, 644);
            label12.Margin = new Padding(6, 0, 6, 0);
            label12.Name = "label12";
            label12.Size = new Size(91, 45);
            label12.TabIndex = 50;
            label12.Text = "Note";
            // 
            // capTextBox
            // 
            capTextBox.BackColor = Color.FromArgb(218, 235, 242);
            capTextBox.BorderColor = Color.FromArgb(170, 210, 227);
            capTextBox.BorderFocusColor = Color.FromArgb(25, 167, 206);
            capTextBox.BorderRadius = 10;
            capTextBox.BorderSize = 2;
            capTextBox.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            capTextBox.ForeColor = Color.FromArgb(64, 64, 64);
            capTextBox.Location = new Point(405, 698);
            capTextBox.Margin = new Padding(7, 9, 7, 9);
            capTextBox.Multiline = false;
            capTextBox.Name = "capTextBox";
            capTextBox.Padding = new Padding(19, 15, 19, 15);
            capTextBox.PasswordChar = false;
            capTextBox.PlaceholderColor = Color.DarkGray;
            capTextBox.PlaceholderText = "00118";
            capTextBox.Size = new Size(384, 67);
            capTextBox.TabIndex = 49;
            capTextBox.Texts = "";
            capTextBox.UnderlinedStyle = false;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label13.ForeColor = Color.FromArgb(44, 62, 80);
            label13.Location = new Point(405, 644);
            label13.Margin = new Padding(6, 0, 6, 0);
            label13.Name = "label13";
            label13.Size = new Size(79, 45);
            label13.TabIndex = 48;
            label13.Text = "CAP";
            // 
            // cittaTextBox
            // 
            cittaTextBox.BackColor = Color.FromArgb(218, 235, 242);
            cittaTextBox.BorderColor = Color.FromArgb(170, 210, 227);
            cittaTextBox.BorderFocusColor = Color.FromArgb(25, 167, 206);
            cittaTextBox.BorderRadius = 10;
            cittaTextBox.BorderSize = 2;
            cittaTextBox.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            cittaTextBox.ForeColor = Color.FromArgb(64, 64, 64);
            cittaTextBox.Location = new Point(405, 559);
            cittaTextBox.Margin = new Padding(7, 9, 7, 9);
            cittaTextBox.Multiline = false;
            cittaTextBox.Name = "cittaTextBox";
            cittaTextBox.Padding = new Padding(19, 15, 19, 15);
            cittaTextBox.PasswordChar = false;
            cittaTextBox.PlaceholderColor = Color.DarkGray;
            cittaTextBox.PlaceholderText = "Roma";
            cittaTextBox.Size = new Size(384, 67);
            cittaTextBox.TabIndex = 47;
            cittaTextBox.Texts = "";
            cittaTextBox.UnderlinedStyle = false;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label10.ForeColor = Color.FromArgb(44, 62, 80);
            label10.Location = new Point(405, 506);
            label10.Margin = new Padding(6, 0, 6, 0);
            label10.Name = "label10";
            label10.Size = new Size(86, 45);
            label10.TabIndex = 46;
            label10.Text = "Città";
            // 
            // indirizzoTextBox
            // 
            indirizzoTextBox.BackColor = Color.FromArgb(218, 235, 242);
            indirizzoTextBox.BorderColor = Color.FromArgb(170, 210, 227);
            indirizzoTextBox.BorderFocusColor = Color.FromArgb(25, 167, 206);
            indirizzoTextBox.BorderRadius = 10;
            indirizzoTextBox.BorderSize = 2;
            indirizzoTextBox.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            indirizzoTextBox.ForeColor = Color.FromArgb(64, 64, 64);
            indirizzoTextBox.Location = new Point(6, 559);
            indirizzoTextBox.Margin = new Padding(7, 9, 7, 9);
            indirizzoTextBox.Multiline = false;
            indirizzoTextBox.Name = "indirizzoTextBox";
            indirizzoTextBox.Padding = new Padding(19, 15, 19, 15);
            indirizzoTextBox.PasswordChar = false;
            indirizzoTextBox.PlaceholderColor = Color.DarkGray;
            indirizzoTextBox.PlaceholderText = "Via Bianchi 1";
            indirizzoTextBox.Size = new Size(384, 67);
            indirizzoTextBox.TabIndex = 45;
            indirizzoTextBox.Texts = "";
            indirizzoTextBox.UnderlinedStyle = false;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label11.ForeColor = Color.FromArgb(44, 62, 80);
            label11.Location = new Point(6, 506);
            label11.Margin = new Padding(6, 0, 6, 0);
            label11.Name = "label11";
            label11.Size = new Size(140, 45);
            label11.TabIndex = 44;
            label11.Text = "Indirizzo";
            // 
            // datanascitaTextBox
            // 
            datanascitaTextBox.BackColor = Color.FromArgb(218, 235, 242);
            datanascitaTextBox.BorderColor = Color.FromArgb(170, 210, 227);
            datanascitaTextBox.BorderFocusColor = Color.FromArgb(25, 167, 206);
            datanascitaTextBox.BorderRadius = 10;
            datanascitaTextBox.BorderSize = 2;
            datanascitaTextBox.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            datanascitaTextBox.ForeColor = Color.FromArgb(64, 64, 64);
            datanascitaTextBox.Location = new Point(405, 416);
            datanascitaTextBox.Margin = new Padding(7, 9, 7, 9);
            datanascitaTextBox.Multiline = false;
            datanascitaTextBox.Name = "datanascitaTextBox";
            datanascitaTextBox.Padding = new Padding(19, 15, 19, 15);
            datanascitaTextBox.PasswordChar = false;
            datanascitaTextBox.PlaceholderColor = Color.DarkGray;
            datanascitaTextBox.PlaceholderText = "GG/MM/AAAA";
            datanascitaTextBox.Size = new Size(384, 67);
            datanascitaTextBox.TabIndex = 43;
            datanascitaTextBox.Texts = "";
            datanascitaTextBox.UnderlinedStyle = false;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label8.ForeColor = Color.FromArgb(44, 62, 80);
            label8.Location = new Point(405, 363);
            label8.Margin = new Padding(6, 0, 6, 0);
            label8.Name = "label8";
            label8.Size = new Size(228, 45);
            label8.TabIndex = 42;
            label8.Text = "Data di nascita";
            // 
            // emailTextBox
            // 
            emailTextBox.BackColor = Color.FromArgb(218, 235, 242);
            emailTextBox.BorderColor = Color.FromArgb(170, 210, 227);
            emailTextBox.BorderFocusColor = Color.FromArgb(25, 167, 206);
            emailTextBox.BorderRadius = 10;
            emailTextBox.BorderSize = 2;
            emailTextBox.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            emailTextBox.ForeColor = Color.FromArgb(64, 64, 64);
            emailTextBox.Location = new Point(6, 416);
            emailTextBox.Margin = new Padding(7, 9, 7, 9);
            emailTextBox.Multiline = false;
            emailTextBox.Name = "emailTextBox";
            emailTextBox.Padding = new Padding(19, 15, 19, 15);
            emailTextBox.PasswordChar = false;
            emailTextBox.PlaceholderColor = Color.DarkGray;
            emailTextBox.PlaceholderText = "email@dominio.it";
            emailTextBox.Size = new Size(384, 67);
            emailTextBox.TabIndex = 41;
            emailTextBox.Texts = "";
            emailTextBox.UnderlinedStyle = false;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label9.ForeColor = Color.FromArgb(44, 62, 80);
            label9.Location = new Point(6, 363);
            label9.Margin = new Padding(6, 0, 6, 0);
            label9.Name = "label9";
            label9.Size = new Size(96, 45);
            label9.TabIndex = 40;
            label9.Text = "Email";
            // 
            // cellulareTextBox
            // 
            cellulareTextBox.BackColor = Color.FromArgb(218, 235, 242);
            cellulareTextBox.BorderColor = Color.FromArgb(170, 210, 227);
            cellulareTextBox.BorderFocusColor = Color.FromArgb(25, 167, 206);
            cellulareTextBox.BorderRadius = 10;
            cellulareTextBox.BorderSize = 2;
            cellulareTextBox.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            cellulareTextBox.ForeColor = Color.FromArgb(64, 64, 64);
            cellulareTextBox.Location = new Point(405, 271);
            cellulareTextBox.Margin = new Padding(7, 9, 7, 9);
            cellulareTextBox.Multiline = false;
            cellulareTextBox.Name = "cellulareTextBox";
            cellulareTextBox.Padding = new Padding(19, 15, 19, 15);
            cellulareTextBox.PasswordChar = false;
            cellulareTextBox.PlaceholderColor = Color.DarkGray;
            cellulareTextBox.PlaceholderText = "XXX XXX XXXX";
            cellulareTextBox.Size = new Size(384, 67);
            cellulareTextBox.TabIndex = 39;
            cellulareTextBox.Texts = "";
            cellulareTextBox.UnderlinedStyle = false;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label6.ForeColor = Color.FromArgb(44, 62, 80);
            label6.Location = new Point(405, 218);
            label6.Margin = new Padding(6, 0, 6, 0);
            label6.Name = "label6";
            label6.Size = new Size(143, 45);
            label6.TabIndex = 38;
            label6.Text = "Cellulare";
            // 
            // telefonoTextBox
            // 
            telefonoTextBox.BackColor = Color.FromArgb(218, 235, 242);
            telefonoTextBox.BorderColor = Color.FromArgb(170, 210, 227);
            telefonoTextBox.BorderFocusColor = Color.FromArgb(25, 167, 206);
            telefonoTextBox.BorderRadius = 10;
            telefonoTextBox.BorderSize = 2;
            telefonoTextBox.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            telefonoTextBox.ForeColor = Color.FromArgb(64, 64, 64);
            telefonoTextBox.Location = new Point(6, 271);
            telefonoTextBox.Margin = new Padding(7, 9, 7, 9);
            telefonoTextBox.Multiline = false;
            telefonoTextBox.Name = "telefonoTextBox";
            telefonoTextBox.Padding = new Padding(19, 15, 19, 15);
            telefonoTextBox.PasswordChar = false;
            telefonoTextBox.PlaceholderColor = Color.DarkGray;
            telefonoTextBox.PlaceholderText = "XXX XXX XXXX";
            telefonoTextBox.Size = new Size(384, 67);
            telefonoTextBox.TabIndex = 37;
            telefonoTextBox.Texts = "";
            telefonoTextBox.UnderlinedStyle = false;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label7.ForeColor = Color.FromArgb(44, 62, 80);
            label7.Location = new Point(6, 218);
            label7.Margin = new Padding(6, 0, 6, 0);
            label7.Name = "label7";
            label7.Size = new Size(142, 45);
            label7.TabIndex = 36;
            label7.Text = "Telefono";
            // 
            // cognomeTextBox
            // 
            cognomeTextBox.BackColor = Color.FromArgb(218, 235, 242);
            cognomeTextBox.BorderColor = Color.FromArgb(170, 210, 227);
            cognomeTextBox.BorderFocusColor = Color.FromArgb(25, 167, 206);
            cognomeTextBox.BorderRadius = 10;
            cognomeTextBox.BorderSize = 2;
            cognomeTextBox.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            cognomeTextBox.ForeColor = Color.FromArgb(64, 64, 64);
            cognomeTextBox.Location = new Point(405, 130);
            cognomeTextBox.Margin = new Padding(7, 9, 7, 9);
            cognomeTextBox.Multiline = false;
            cognomeTextBox.Name = "cognomeTextBox";
            cognomeTextBox.Padding = new Padding(19, 15, 19, 15);
            cognomeTextBox.PasswordChar = false;
            cognomeTextBox.PlaceholderColor = Color.DarkGray;
            cognomeTextBox.PlaceholderText = "Rossi";
            cognomeTextBox.Size = new Size(384, 67);
            cognomeTextBox.TabIndex = 35;
            cognomeTextBox.Texts = "";
            cognomeTextBox.UnderlinedStyle = false;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label5.ForeColor = Color.FromArgb(44, 62, 80);
            label5.Location = new Point(405, 77);
            label5.Margin = new Padding(6, 0, 6, 0);
            label5.Name = "label5";
            label5.Size = new Size(160, 45);
            label5.TabIndex = 34;
            label5.Text = "Cognome";
            // 
            // nomeTextBox
            // 
            nomeTextBox.BackColor = Color.FromArgb(218, 235, 242);
            nomeTextBox.BorderColor = Color.FromArgb(170, 210, 227);
            nomeTextBox.BorderFocusColor = Color.FromArgb(25, 167, 206);
            nomeTextBox.BorderRadius = 10;
            nomeTextBox.BorderSize = 2;
            nomeTextBox.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            nomeTextBox.ForeColor = Color.FromArgb(64, 64, 64);
            nomeTextBox.Location = new Point(6, 130);
            nomeTextBox.Margin = new Padding(7, 9, 7, 9);
            nomeTextBox.Multiline = false;
            nomeTextBox.Name = "nomeTextBox";
            nomeTextBox.Padding = new Padding(19, 15, 19, 15);
            nomeTextBox.PasswordChar = false;
            nomeTextBox.PlaceholderColor = Color.DarkGray;
            nomeTextBox.PlaceholderText = "Mario";
            nomeTextBox.Size = new Size(384, 67);
            nomeTextBox.TabIndex = 33;
            nomeTextBox.Texts = "";
            nomeTextBox.UnderlinedStyle = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = Color.FromArgb(44, 62, 80);
            label4.Location = new Point(6, 77);
            label4.Margin = new Padding(6, 0, 6, 0);
            label4.Name = "label4";
            label4.Size = new Size(108, 45);
            label4.TabIndex = 32;
            label4.Text = "Nome";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.FromArgb(44, 62, 80);
            label3.Location = new Point(6, 9);
            label3.Margin = new Padding(6, 0, 6, 0);
            label3.Name = "label3";
            label3.Size = new Size(257, 51);
            label3.TabIndex = 31;
            label3.Text = "Dati Contatto";
            // 
            // AggiungiControl
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(230, 225, 225);
            Controls.Add(rjButton7);
            Controls.Add(salvaButton);
            Controls.Add(noteTextBox);
            Controls.Add(label12);
            Controls.Add(capTextBox);
            Controls.Add(label13);
            Controls.Add(cittaTextBox);
            Controls.Add(label10);
            Controls.Add(indirizzoTextBox);
            Controls.Add(label11);
            Controls.Add(datanascitaTextBox);
            Controls.Add(label8);
            Controls.Add(emailTextBox);
            Controls.Add(label9);
            Controls.Add(cellulareTextBox);
            Controls.Add(label6);
            Controls.Add(telefonoTextBox);
            Controls.Add(label7);
            Controls.Add(cognomeTextBox);
            Controls.Add(label5);
            Controls.Add(nomeTextBox);
            Controls.Add(label4);
            Controls.Add(label3);
            Margin = new Padding(6);
            Name = "AggiungiControl";
            Size = new Size(799, 1022);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private CustomControls.RJControls.RJButton rjButton7;
        private CustomControls.RJControls.RJButton salvaButton;
        private CustomControls.RJControls.RJTextBox noteTextBox;
        private Label label12;
        private CustomControls.RJControls.RJTextBox capTextBox;
        private Label label13;
        private CustomControls.RJControls.RJTextBox cittaTextBox;
        private Label label10;
        private CustomControls.RJControls.RJTextBox indirizzoTextBox;
        private Label label11;
        private CustomControls.RJControls.RJTextBox datanascitaTextBox;
        private Label label8;
        private CustomControls.RJControls.RJTextBox emailTextBox;
        private Label label9;
        private CustomControls.RJControls.RJTextBox cellulareTextBox;
        private Label label6;
        private CustomControls.RJControls.RJTextBox telefonoTextBox;
        private Label label7;
        private CustomControls.RJControls.RJTextBox cognomeTextBox;
        private Label label5;
        private CustomControls.RJControls.RJTextBox nomeTextBox;
        private Label label4;
        private Label label3;
    }
}
