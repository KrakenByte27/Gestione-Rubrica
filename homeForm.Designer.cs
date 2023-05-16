namespace Gestione_Rubrica
{
    partial class homeForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            roundedPanel1 = new CustomControls.RoundedPanel();
            grigliaButton = new CustomControls.RJControls.RJButton();
            listBox1 = new ListBox();
            rjButton5 = new CustomControls.RJControls.RJButton();
            aggiungiButton = new CustomControls.RJControls.RJButton();
            label2 = new Label();
            roundedPanel2 = new CustomControls.RoundedPanel();
            rjButton3 = new CustomControls.RJControls.RJButton();
            rjButton2 = new CustomControls.RJControls.RJButton();
            rjButton1 = new CustomControls.RJControls.RJButton();
            actionPanel = new CustomControls.RoundedPanel();
            label3 = new Label();
            roundedPanel1.SuspendLayout();
            roundedPanel2.SuspendLayout();
            actionPanel.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(44, 62, 80);
            label1.Location = new Point(26, 23);
            label1.Margin = new Padding(6, 0, 6, 0);
            label1.Name = "label1";
            label1.Size = new Size(411, 65);
            label1.TabIndex = 0;
            label1.Text = "Gestione Rubrica";
            // 
            // roundedPanel1
            // 
            roundedPanel1.BackColor = Color.FromArgb(230, 225, 225);
            roundedPanel1.BorderColor = Color.White;
            roundedPanel1.Controls.Add(grigliaButton);
            roundedPanel1.Controls.Add(listBox1);
            roundedPanel1.Controls.Add(rjButton5);
            roundedPanel1.Controls.Add(aggiungiButton);
            roundedPanel1.Controls.Add(label2);
            roundedPanel1.Edge = 20;
            roundedPanel1.Location = new Point(9, 143);
            roundedPanel1.Margin = new Padding(6);
            roundedPanel1.Name = "roundedPanel1";
            roundedPanel1.Size = new Size(615, 1054);
            roundedPanel1.TabIndex = 1;
            // 
            // grigliaButton
            // 
            grigliaButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            grigliaButton.BackColor = Color.FromArgb(175, 211, 226);
            grigliaButton.BackgroundColor = Color.FromArgb(175, 211, 226);
            grigliaButton.BorderColor = Color.FromArgb(25, 167, 206);
            grigliaButton.BorderRadius = 10;
            grigliaButton.BorderSize = 2;
            grigliaButton.FlatAppearance.BorderSize = 0;
            grigliaButton.FlatStyle = FlatStyle.Flat;
            grigliaButton.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            grigliaButton.ForeColor = SystemColors.ControlText;
            grigliaButton.Location = new Point(19, 930);
            grigliaButton.Margin = new Padding(6);
            grigliaButton.Name = "grigliaButton";
            grigliaButton.Size = new Size(184, 96);
            grigliaButton.TabIndex = 7;
            grigliaButton.Text = "Griglia";
            grigliaButton.TextColor = SystemColors.ControlText;
            grigliaButton.UseVisualStyleBackColor = false;
            grigliaButton.Click += grigliaButton_Click;
            // 
            // listBox1
            // 
            listBox1.BackColor = Color.FromArgb(204, 200, 200);
            listBox1.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            listBox1.ForeColor = Color.FromArgb(44, 62, 80);
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 41;
            listBox1.Location = new Point(19, 90);
            listBox1.Margin = new Padding(6);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(574, 783);
            listBox1.TabIndex = 6;
            listBox1.SelectedIndexChanged += listacontatti_SelectedIndexChanged;
            // 
            // rjButton5
            // 
            rjButton5.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            rjButton5.BackColor = Color.FromArgb(175, 211, 226);
            rjButton5.BackgroundColor = Color.FromArgb(175, 211, 226);
            rjButton5.BorderColor = Color.FromArgb(25, 167, 206);
            rjButton5.BorderRadius = 10;
            rjButton5.BorderSize = 2;
            rjButton5.FlatAppearance.BorderSize = 0;
            rjButton5.FlatStyle = FlatStyle.Flat;
            rjButton5.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            rjButton5.ForeColor = SystemColors.ControlText;
            rjButton5.Location = new Point(215, 930);
            rjButton5.Margin = new Padding(6);
            rjButton5.Name = "rjButton5";
            rjButton5.Size = new Size(184, 96);
            rjButton5.TabIndex = 5;
            rjButton5.Text = "Rimuovi";
            rjButton5.TextColor = SystemColors.ControlText;
            rjButton5.UseVisualStyleBackColor = false;
            // 
            // aggiungiButton
            // 
            aggiungiButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            aggiungiButton.BackColor = Color.FromArgb(175, 211, 226);
            aggiungiButton.BackgroundColor = Color.FromArgb(175, 211, 226);
            aggiungiButton.BorderColor = Color.FromArgb(25, 167, 206);
            aggiungiButton.BorderRadius = 10;
            aggiungiButton.BorderSize = 2;
            aggiungiButton.FlatAppearance.BorderSize = 0;
            aggiungiButton.FlatStyle = FlatStyle.Flat;
            aggiungiButton.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            aggiungiButton.ForeColor = SystemColors.ControlText;
            aggiungiButton.Location = new Point(412, 930);
            aggiungiButton.Margin = new Padding(6);
            aggiungiButton.Name = "aggiungiButton";
            aggiungiButton.Size = new Size(184, 96);
            aggiungiButton.TabIndex = 4;
            aggiungiButton.Text = "Aggiungi";
            aggiungiButton.TextColor = SystemColors.ControlText;
            aggiungiButton.UseVisualStyleBackColor = false;
            aggiungiButton.Click += aggiungiButton_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.FromArgb(44, 62, 80);
            label2.Location = new Point(19, 21);
            label2.Margin = new Padding(6, 0, 6, 0);
            label2.Name = "label2";
            label2.Size = new Size(252, 51);
            label2.TabIndex = 4;
            label2.Text = "Lista Contatti";
            // 
            // roundedPanel2
            // 
            roundedPanel2.BackColor = Color.FromArgb(230, 225, 225);
            roundedPanel2.BorderColor = Color.White;
            roundedPanel2.Controls.Add(rjButton3);
            roundedPanel2.Controls.Add(rjButton2);
            roundedPanel2.Controls.Add(rjButton1);
            roundedPanel2.Controls.Add(label1);
            roundedPanel2.Edge = 20;
            roundedPanel2.Location = new Point(9, 11);
            roundedPanel2.Margin = new Padding(6);
            roundedPanel2.Name = "roundedPanel2";
            roundedPanel2.Size = new Size(1443, 122);
            roundedPanel2.TabIndex = 2;
            // 
            // rjButton3
            // 
            rjButton3.BackColor = Color.FromArgb(255, 128, 147);
            rjButton3.BackgroundColor = Color.FromArgb(255, 128, 147);
            rjButton3.BorderColor = Color.FromArgb(255, 71, 87);
            rjButton3.BorderRadius = 10;
            rjButton3.BorderSize = 2;
            rjButton3.FlatAppearance.BorderSize = 0;
            rjButton3.FlatStyle = FlatStyle.Flat;
            rjButton3.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            rjButton3.ForeColor = SystemColors.ControlText;
            rjButton3.Location = new Point(1218, 17);
            rjButton3.Margin = new Padding(6);
            rjButton3.Name = "rjButton3";
            rjButton3.Size = new Size(189, 85);
            rjButton3.TabIndex = 3;
            rjButton3.Text = "Esci";
            rjButton3.TextColor = SystemColors.ControlText;
            rjButton3.UseVisualStyleBackColor = false;
            // 
            // rjButton2
            // 
            rjButton2.BackColor = Color.FromArgb(123, 237, 159);
            rjButton2.BackgroundColor = Color.FromArgb(123, 237, 159);
            rjButton2.BorderColor = Color.FromArgb(46, 213, 115);
            rjButton2.BorderRadius = 10;
            rjButton2.BorderSize = 2;
            rjButton2.FlatAppearance.BorderSize = 0;
            rjButton2.FlatStyle = FlatStyle.Flat;
            rjButton2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            rjButton2.ForeColor = SystemColors.ControlText;
            rjButton2.Location = new Point(1018, 17);
            rjButton2.Margin = new Padding(6);
            rjButton2.Name = "rjButton2";
            rjButton2.Size = new Size(189, 85);
            rjButton2.TabIndex = 2;
            rjButton2.Text = "Salva";
            rjButton2.TextColor = SystemColors.ControlText;
            rjButton2.UseVisualStyleBackColor = false;
            // 
            // rjButton1
            // 
            rjButton1.BackColor = Color.FromArgb(175, 211, 226);
            rjButton1.BackgroundColor = Color.FromArgb(175, 211, 226);
            rjButton1.BorderColor = Color.FromArgb(25, 167, 206);
            rjButton1.BorderRadius = 10;
            rjButton1.BorderSize = 2;
            rjButton1.FlatAppearance.BorderSize = 0;
            rjButton1.FlatStyle = FlatStyle.Flat;
            rjButton1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            rjButton1.ForeColor = SystemColors.ControlText;
            rjButton1.Location = new Point(817, 17);
            rjButton1.Margin = new Padding(6);
            rjButton1.Name = "rjButton1";
            rjButton1.Size = new Size(189, 85);
            rjButton1.TabIndex = 1;
            rjButton1.Text = "Apri";
            rjButton1.TextColor = SystemColors.ControlText;
            rjButton1.UseVisualStyleBackColor = false;
            // 
            // actionPanel
            // 
            actionPanel.BackColor = Color.FromArgb(230, 225, 225);
            actionPanel.BorderColor = Color.White;
            actionPanel.Controls.Add(label3);
            actionPanel.Edge = 20;
            actionPanel.Location = new Point(635, 143);
            actionPanel.Margin = new Padding(6);
            actionPanel.Name = "actionPanel";
            actionPanel.Size = new Size(817, 1054);
            actionPanel.TabIndex = 2;
            // 
            // label3
            // 
            label3.Dock = DockStyle.Fill;
            label3.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.FromArgb(44, 62, 80);
            label3.Location = new Point(0, 0);
            label3.Margin = new Padding(6, 0, 6, 0);
            label3.Name = "label3";
            label3.Size = new Size(817, 1054);
            label3.TabIndex = 0;
            label3.Text = "Seleziona un'operazione da eseguire\r\no un contatto da visualizzare o modificare";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // homeForm
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(246, 241, 241);
            ClientSize = new Size(1462, 1205);
            Controls.Add(actionPanel);
            Controls.Add(roundedPanel2);
            Controls.Add(roundedPanel1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(6);
            MaximizeBox = false;
            Name = "homeForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Home";
            Load += homeForm_Load;
            roundedPanel1.ResumeLayout(false);
            roundedPanel1.PerformLayout();
            roundedPanel2.ResumeLayout(false);
            roundedPanel2.PerformLayout();
            actionPanel.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private CustomControls.RoundedPanel roundedPanel1;
        private CustomControls.RoundedPanel roundedPanel2;
        private CustomControls.RoundedPanel actionPanel;
        private CustomControls.RJControls.RJButton rjButton3;
        private CustomControls.RJControls.RJButton rjButton2;
        private CustomControls.RJControls.RJButton rjButton1;
        private Label label2;
        private CustomControls.RJControls.RJButton rjButton5;
        private CustomControls.RJControls.RJButton aggiungiButton;
        private CustomControls.RJControls.RJButton grigliaButton;
        private Label label3;
        public ListBox listBox1;
    }
}