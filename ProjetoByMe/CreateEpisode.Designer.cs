namespace ProjetoByMe
{
    partial class CreateEpisode
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CreateEpisode));
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            textBox_ID = new TextBox();
            textBox_patientID = new TextBox();
            textBox_episode = new TextBox();
            textBox_module = new TextBox();
            label4 = new Label();
            cmd_submit = new Button();
            cmd_clear = new Button();
            cmd_change = new Button();
            cmd_list = new Button();
            cmd_delete = new Button();
            cmd_exit = new Button();
            Grid = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)Grid).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(21, 30);
            label1.Name = "label1";
            label1.Size = new Size(24, 20);
            label1.TabIndex = 2;
            label1.Text = "ID";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(288, 34);
            label2.Name = "label2";
            label2.Size = new Size(69, 20);
            label2.TabIndex = 3;
            label2.Text = "PatientID";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(21, 108);
            label3.Name = "label3";
            label3.Size = new Size(62, 20);
            label3.TabIndex = 4;
            label3.Text = "Episode";
            // 
            // textBox_ID
            // 
            textBox_ID.Location = new Point(51, 23);
            textBox_ID.Name = "textBox_ID";
            textBox_ID.Size = new Size(55, 27);
            textBox_ID.TabIndex = 6;
            // 
            // textBox_patientID
            // 
            textBox_patientID.Location = new Point(372, 27);
            textBox_patientID.Name = "textBox_patientID";
            textBox_patientID.Size = new Size(63, 27);
            textBox_patientID.TabIndex = 7;
            // 
            // textBox_episode
            // 
            textBox_episode.Location = new Point(94, 108);
            textBox_episode.Multiline = true;
            textBox_episode.Name = "textBox_episode";
            textBox_episode.Size = new Size(481, 107);
            textBox_episode.TabIndex = 8;
            // 
            // textBox_module
            // 
            textBox_module.Location = new Point(94, 273);
            textBox_module.Multiline = true;
            textBox_module.Name = "textBox_module";
            textBox_module.Size = new Size(481, 165);
            textBox_module.TabIndex = 9;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(22, 276);
            label4.Name = "label4";
            label4.Size = new Size(60, 20);
            label4.TabIndex = 10;
            label4.Text = "Module";
            // 
            // cmd_submit
            // 
            cmd_submit.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point);
            cmd_submit.Location = new Point(684, 64);
            cmd_submit.Name = "cmd_submit";
            cmd_submit.Size = new Size(94, 29);
            cmd_submit.TabIndex = 11;
            cmd_submit.Text = "&Submit";
            cmd_submit.UseVisualStyleBackColor = true;
            cmd_submit.Click += cmd_submit_Click;
            // 
            // cmd_clear
            // 
            cmd_clear.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point);
            cmd_clear.Location = new Point(684, 169);
            cmd_clear.Name = "cmd_clear";
            cmd_clear.Size = new Size(94, 29);
            cmd_clear.TabIndex = 12;
            cmd_clear.Text = "&Clear";
            cmd_clear.UseVisualStyleBackColor = true;
            cmd_clear.Click += cmd_clear_Click;
            // 
            // cmd_change
            // 
            cmd_change.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point);
            cmd_change.Location = new Point(684, 289);
            cmd_change.Name = "cmd_change";
            cmd_change.Size = new Size(94, 29);
            cmd_change.TabIndex = 13;
            cmd_change.Text = "&Change";
            cmd_change.UseVisualStyleBackColor = true;
            cmd_change.Click += cmd_change_Click;
            // 
            // cmd_list
            // 
            cmd_list.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point);
            cmd_list.Location = new Point(684, 486);
            cmd_list.Name = "cmd_list";
            cmd_list.Size = new Size(94, 29);
            cmd_list.TabIndex = 14;
            cmd_list.Text = "&List";
            cmd_list.UseVisualStyleBackColor = true;
            cmd_list.Click += cmd_list_Click;
            // 
            // cmd_delete
            // 
            cmd_delete.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point);
            cmd_delete.Location = new Point(684, 578);
            cmd_delete.Name = "cmd_delete";
            cmd_delete.Size = new Size(94, 29);
            cmd_delete.TabIndex = 15;
            cmd_delete.Text = "&Delete";
            cmd_delete.UseVisualStyleBackColor = true;
            cmd_delete.Click += cmd_delete_Click;
            // 
            // cmd_exit
            // 
            cmd_exit.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point);
            cmd_exit.Location = new Point(684, 672);
            cmd_exit.Name = "cmd_exit";
            cmd_exit.Size = new Size(94, 29);
            cmd_exit.TabIndex = 17;
            cmd_exit.Text = "&Exit";
            cmd_exit.UseVisualStyleBackColor = true;
            cmd_exit.Click += cmd_exit_Click;
            // 
            // Grid
            // 
            Grid.BackgroundColor = Color.LightSalmon;
            Grid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            Grid.GridColor = SystemColors.ButtonHighlight;
            Grid.Location = new Point(36, 486);
            Grid.Name = "Grid";
            Grid.RowHeadersWidth = 51;
            Grid.RowTemplate.Height = 29;
            Grid.Size = new Size(618, 215);
            Grid.TabIndex = 18;
            Grid.CellContentClick += dataGridView1_CellContentClick;
            // 
            // CreateEpisode
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.WindowFrame;
            ClientSize = new Size(827, 730);
            Controls.Add(Grid);
            Controls.Add(cmd_exit);
            Controls.Add(cmd_delete);
            Controls.Add(cmd_list);
            Controls.Add(cmd_change);
            Controls.Add(cmd_clear);
            Controls.Add(cmd_submit);
            Controls.Add(label4);
            Controls.Add(textBox_module);
            Controls.Add(textBox_episode);
            Controls.Add(textBox_patientID);
            Controls.Add(textBox_ID);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            ForeColor = SystemColors.ActiveCaption;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "CreateEpisode";
            Text = "CreateEpisode";
            Load += CreateEpisode_Load;
            ((System.ComponentModel.ISupportInitialize)Grid).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox textBox_ID;
        private TextBox textBox_patientID;
        private TextBox textBox_episode;
        private TextBox textBox_module;
        private Label label4;
        private Button cmd_submit;
        private Button cmd_clear;
        private Button cmd_change;
        private Button cmd_list;
        private Button cmd_delete;
        private Button cmd_exit;
        private DataGridView Grid;
    }
}