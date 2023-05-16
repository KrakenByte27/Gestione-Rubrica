namespace Gestione_Rubrica
{
    partial class grigliaForm
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
            roundedPanel2 = new CustomControls.RoundedPanel();
            chiudiButton = new CustomControls.RJControls.RJButton();
            label1 = new Label();
            dataGridView1 = new DataGridView();
            roundedPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // roundedPanel2
            // 
            roundedPanel2.BackColor = Color.FromArgb(230, 225, 225);
            roundedPanel2.BorderColor = Color.White;
            roundedPanel2.Controls.Add(chiudiButton);
            roundedPanel2.Controls.Add(label1);
            roundedPanel2.Edge = 20;
            roundedPanel2.Location = new Point(5, 5);
            roundedPanel2.Name = "roundedPanel2";
            roundedPanel2.Size = new Size(777, 57);
            roundedPanel2.TabIndex = 3;
            // 
            // chiudiButton
            // 
            chiudiButton.BackColor = Color.FromArgb(175, 211, 226);
            chiudiButton.BackgroundColor = Color.FromArgb(175, 211, 226);
            chiudiButton.BorderColor = Color.FromArgb(25, 167, 206);
            chiudiButton.BorderRadius = 10;
            chiudiButton.BorderSize = 2;
            chiudiButton.FlatAppearance.BorderSize = 0;
            chiudiButton.FlatStyle = FlatStyle.Flat;
            chiudiButton.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            chiudiButton.ForeColor = SystemColors.ControlText;
            chiudiButton.Location = new Point(656, 8);
            chiudiButton.Name = "chiudiButton";
            chiudiButton.Size = new Size(102, 40);
            chiudiButton.TabIndex = 1;
            chiudiButton.Text = "Chiudi";
            chiudiButton.TextColor = SystemColors.ControlText;
            chiudiButton.UseVisualStyleBackColor = false;
            chiudiButton.Click += chiudiButton_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(44, 62, 80);
            label1.Location = new Point(14, 11);
            label1.Name = "label1";
            label1.Size = new Size(272, 32);
            label1.TabIndex = 0;
            label1.Text = "Visualizzazione Griglia";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(5, 66);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(777, 359);
            dataGridView1.TabIndex = 4;
            // 
            // grigliaForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(246, 241, 241);
            ClientSize = new Size(787, 430);
            Controls.Add(dataGridView1);
            Controls.Add(roundedPanel2);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            Name = "grigliaForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Griglia";
            roundedPanel2.ResumeLayout(false);
            roundedPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private CustomControls.RoundedPanel roundedPanel2;
        private Label label1;
        private CustomControls.RJControls.RJButton chiudiButton;
        private DataGridView dataGridView1;
    }
}