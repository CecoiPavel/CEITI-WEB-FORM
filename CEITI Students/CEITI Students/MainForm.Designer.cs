namespace CEITI_Students
{
    partial class MainForm
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            contextMenuStrip1 = new ContextMenuStrip(components);
            menuStrip1 = new MenuStrip();
            acasăToolStripMenuItem = new ToolStripMenuItem();
            listaElevilorToolStripMenuItem = new ToolStripMenuItem();
            adaugăElevToolStripMenuItem = new ToolStripMenuItem();
            ieșireToolStripMenuItem = new ToolStripMenuItem();
            mainDisplayPanel = new Panel();
            panel1 = new Panel();
            dataGridView1 = new DataGridView();
            CEITI = new PictureBox();
            menuStrip1.SuspendLayout();
            mainDisplayPanel.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)CEITI).BeginInit();
            SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            resources.ApplyResources(contextMenuStrip1, "contextMenuStrip1");
            contextMenuStrip1.ImageScalingSize = new Size(32, 32);
            contextMenuStrip1.Name = "contextMenuStrip1";
            // 
            // menuStrip1
            // 
            resources.ApplyResources(menuStrip1, "menuStrip1");
            menuStrip1.ImageScalingSize = new Size(32, 32);
            menuStrip1.Items.AddRange(new ToolStripItem[] { acasăToolStripMenuItem, listaElevilorToolStripMenuItem, adaugăElevToolStripMenuItem, ieșireToolStripMenuItem });
            menuStrip1.Name = "menuStrip1";
            // 
            // acasăToolStripMenuItem
            // 
            resources.ApplyResources(acasăToolStripMenuItem, "acasăToolStripMenuItem");
            acasăToolStripMenuItem.Name = "acasăToolStripMenuItem";
            acasăToolStripMenuItem.Click += acasăToolStripMenuItem_Click;
            // 
            // listaElevilorToolStripMenuItem
            // 
            resources.ApplyResources(listaElevilorToolStripMenuItem, "listaElevilorToolStripMenuItem");
            listaElevilorToolStripMenuItem.Name = "listaElevilorToolStripMenuItem";
            listaElevilorToolStripMenuItem.Click += listaElevilorToolStripMenuItem_Click;
            // 
            // adaugăElevToolStripMenuItem
            // 
            resources.ApplyResources(adaugăElevToolStripMenuItem, "adaugăElevToolStripMenuItem");
            adaugăElevToolStripMenuItem.Name = "adaugăElevToolStripMenuItem";
            adaugăElevToolStripMenuItem.Click += adaugăElevToolStripMenuItem_Click;
            // 
            // ieșireToolStripMenuItem
            // 
            resources.ApplyResources(ieșireToolStripMenuItem, "ieșireToolStripMenuItem");
            ieșireToolStripMenuItem.Name = "ieșireToolStripMenuItem";
            ieșireToolStripMenuItem.Click += ieșireToolStripMenuItem_Click;
            // 
            // mainDisplayPanel
            // 
            resources.ApplyResources(mainDisplayPanel, "mainDisplayPanel");
            mainDisplayPanel.Controls.Add(panel1);
            mainDisplayPanel.Name = "mainDisplayPanel";
            // 
            // panel1
            // 
            resources.ApplyResources(panel1, "panel1");
            panel1.Controls.Add(dataGridView1);
            panel1.Controls.Add(CEITI);
            panel1.Name = "panel1";
            // 
            // dataGridView1
            // 
            resources.ApplyResources(dataGridView1, "dataGridView1");
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowTemplate.Height = 41;
            // 
            // CEITI
            // 
            resources.ApplyResources(CEITI, "CEITI");
            CEITI.Name = "CEITI";
            CEITI.TabStop = false;
            // 
            // MainForm
            // 
            resources.ApplyResources(this, "$this");
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(mainDisplayPanel);
            Controls.Add(menuStrip1);
            Name = "MainForm";
            Load += MainForm_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            mainDisplayPanel.ResumeLayout(false);
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)CEITI).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private ContextMenuStrip contextMenuStrip1;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem acasăToolStripMenuItem;
        private ToolStripMenuItem listaElevilorToolStripMenuItem;
        private ToolStripMenuItem adaugăElevToolStripMenuItem;
        private ToolStripMenuItem ieșireToolStripMenuItem;
        private Panel mainDisplayPanel;
        private Panel panel1;
        private DataGridView dataGridView1;
        private PictureBox CEITI;
    }
}