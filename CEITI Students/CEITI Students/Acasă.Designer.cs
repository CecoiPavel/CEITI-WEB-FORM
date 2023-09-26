namespace CEITI_Students
{
    partial class Acasă
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Acasă));
            dataGridView1 = new DataGridView();
            CEITI = new PictureBox();
            mainDisplayPanel = new Panel();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)CEITI).BeginInit();
            mainDisplayPanel.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(41, 63);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersWidth = 82;
            dataGridView1.RowTemplate.Height = 41;
            dataGridView1.Size = new Size(494, 93);
            dataGridView1.TabIndex = 0;
            // 
            // CEITI
            // 
            CEITI.Image = (Image)resources.GetObject("CEITI.Image");
            CEITI.ImeMode = ImeMode.NoControl;
            CEITI.Location = new Point(41, 213);
            CEITI.Name = "CEITI";
            CEITI.Size = new Size(494, 299);
            CEITI.TabIndex = 2;
            CEITI.TabStop = false;
            // 
            // mainDisplayPanel
            // 
            mainDisplayPanel.Controls.Add(dataGridView1);
            mainDisplayPanel.Controls.Add(CEITI);
            mainDisplayPanel.Location = new Point(492, 196);
            mainDisplayPanel.Name = "mainDisplayPanel";
            mainDisplayPanel.Size = new Size(580, 578);
            mainDisplayPanel.TabIndex = 4;
            // 
            // Acasă
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1577, 857);
            Controls.Add(mainDisplayPanel);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Acasă";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Acasă";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)CEITI).EndInit();
            mainDisplayPanel.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridView1;
        private PictureBox CEITI;
        private Panel mainDisplayPanel;
    }
}