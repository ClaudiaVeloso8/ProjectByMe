namespace ProjetoByMe
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            cmd_listEpisode = new Button();
            cmd_createEpisode = new Button();
            cmd_createPatient = new Button();
            cmd_listPatient = new Button();
            dataGridView1 = new DataGridView();
            menuStrip1 = new MenuStrip();
            createPatientToolStripMenuItem = new ToolStripMenuItem();
            createEpisodeToolStripMenuItem = new ToolStripMenuItem();
            exitToolStripMenuItem = new ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // cmd_listEpisode
            // 
            cmd_listEpisode.Font = new Font("Segoe UI", 9F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point);
            cmd_listEpisode.Location = new Point(643, 362);
            cmd_listEpisode.Margin = new Padding(3, 4, 3, 4);
            cmd_listEpisode.Name = "cmd_listEpisode";
            cmd_listEpisode.Size = new Size(134, 52);
            cmd_listEpisode.TabIndex = 7;
            cmd_listEpisode.Text = "&List Episode";
            cmd_listEpisode.UseVisualStyleBackColor = true;
            cmd_listEpisode.Click += cmd_listEpisode_Click;
            // 
            // cmd_createEpisode
            // 
            cmd_createEpisode.Font = new Font("Segoe UI", 9F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point);
            cmd_createEpisode.Location = new Point(643, 256);
            cmd_createEpisode.Margin = new Padding(3, 4, 3, 4);
            cmd_createEpisode.Name = "cmd_createEpisode";
            cmd_createEpisode.Size = new Size(134, 52);
            cmd_createEpisode.TabIndex = 6;
            cmd_createEpisode.Text = "&Create Episode";
            cmd_createEpisode.UseVisualStyleBackColor = true;
            cmd_createEpisode.Click += cmd_createEpisode_Click;
            // 
            // cmd_createPatient
            // 
            cmd_createPatient.Font = new Font("Segoe UI", 9F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point);
            cmd_createPatient.Location = new Point(643, 146);
            cmd_createPatient.Margin = new Padding(3, 4, 3, 4);
            cmd_createPatient.Name = "cmd_createPatient";
            cmd_createPatient.Size = new Size(134, 52);
            cmd_createPatient.TabIndex = 5;
            cmd_createPatient.Text = "&Create Patient";
            cmd_createPatient.UseVisualStyleBackColor = true;
            cmd_createPatient.Click += cmd_createPatient_Click;
            // 
            // cmd_listPatient
            // 
            cmd_listPatient.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            cmd_listPatient.Location = new Point(643, 34);
            cmd_listPatient.Margin = new Padding(3, 4, 3, 4);
            cmd_listPatient.Name = "cmd_listPatient";
            cmd_listPatient.Size = new Size(134, 52);
            cmd_listPatient.TabIndex = 4;
            cmd_listPatient.Text = "&List Patient";
            cmd_listPatient.UseVisualStyleBackColor = true;
            cmd_listPatient.Click += cmd_listPatient_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(27, 57);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(548, 330);
            dataGridView1.TabIndex = 8;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { createPatientToolStripMenuItem, createEpisodeToolStripMenuItem, exitToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 28);
            menuStrip1.TabIndex = 9;
            menuStrip1.Text = "menuStrip1";
            // 
            // createPatientToolStripMenuItem
            // 
            createPatientToolStripMenuItem.Name = "createPatientToolStripMenuItem";
            createPatientToolStripMenuItem.Size = new Size(115, 24);
            createPatientToolStripMenuItem.Text = "Create Patient";
            createPatientToolStripMenuItem.Click += createPatientToolStripMenuItem_Click;
            // 
            // createEpisodeToolStripMenuItem
            // 
            createEpisodeToolStripMenuItem.Name = "createEpisodeToolStripMenuItem";
            createEpisodeToolStripMenuItem.Size = new Size(123, 24);
            createEpisodeToolStripMenuItem.Text = "Create Episode";
            createEpisodeToolStripMenuItem.Click += createEpisodeToolStripMenuItem_Click;
            // 
            // exitToolStripMenuItem
            // 
            exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            exitToolStripMenuItem.Size = new Size(47, 24);
            exitToolStripMenuItem.Text = "Exit";
            exitToolStripMenuItem.Click += exitToolStripMenuItem_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dataGridView1);
            Controls.Add(cmd_listEpisode);
            Controls.Add(cmd_createEpisode);
            Controls.Add(cmd_createPatient);
            Controls.Add(cmd_listPatient);
            Controls.Add(menuStrip1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button cmd_listEpisode;
        private Button cmd_createEpisode;
        private Button cmd_createPatient;
        private Button cmd_listPatient;
        private DataGridView dataGridView1;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem createPatientToolStripMenuItem;
        private ToolStripMenuItem createEpisodeToolStripMenuItem;
        private ToolStripMenuItem exitToolStripMenuItem;
    }
}