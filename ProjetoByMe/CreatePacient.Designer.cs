namespace ProjetoByMe
{
    partial class CreatePacient
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CreatePacient));
            lbl_sns = new Label();
            text_address = new TextBox();
            lbl_nif = new Label();
            lbl_postalCodeFull = new Label();
            text_town = new TextBox();
            text_Locality = new TextBox();
            text_ProcessNumber = new TextBox();
            lbl_town = new Label();
            lbl_address = new Label();
            lbl_postalCodeID = new Label();
            lbl_locality = new Label();
            text_postalCodeFull = new TextBox();
            lbl_postalArea = new Label();
            lbl_postalCode = new Label();
            text_PostalCodeId = new TextBox();
            lbl_processNumber = new Label();
            lbl_birthDate = new Label();
            llb_sex = new Label();
            text_fax = new TextBox();
            lbl_email = new Label();
            text_email = new TextBox();
            text_sex = new TextBox();
            text_name = new TextBox();
            text_OtherID = new TextBox();
            lbl_otherTelephone = new Label();
            text_ID = new TextBox();
            llb_Name = new Label();
            lbl_ID = new Label();
            lbl_fax = new Label();
            lbl_mobile = new Label();
            lbl_telephone = new Label();
            Grid = new DataGridView();
            lbl_OtherID = new Label();
            cmd_clear = new Button();
            cmd_exit = new Button();
            cmd_list = new Button();
            cmd_changeData = new Button();
            cmd_delete = new Button();
            cmd_submit = new Button();
            maskedTextBox_nif = new MaskedTextBox();
            maskedTextBox_sns = new MaskedTextBox();
            maskedTextBox_birthDate = new MaskedTextBox();
            maskedTextBox_mobile = new MaskedTextBox();
            maskedTextBox_telephone = new MaskedTextBox();
            maskedTextBox_otherTelephone = new MaskedTextBox();
            maskedTextBox_postalCode = new MaskedTextBox();
            maskedTextBox_postalArea = new MaskedTextBox();
            ((System.ComponentModel.ISupportInitialize)Grid).BeginInit();
            SuspendLayout();
            // 
            // lbl_sns
            // 
            lbl_sns.AutoSize = true;
            lbl_sns.Location = new Point(759, 85);
            lbl_sns.Name = "lbl_sns";
            lbl_sns.Size = new Size(46, 20);
            lbl_sns.TabIndex = 81;
            lbl_sns.Text = "SNS *";
            // 
            // text_address
            // 
            text_address.Location = new Point(108, 355);
            text_address.Name = "text_address";
            text_address.Size = new Size(399, 27);
            text_address.TabIndex = 80;
            // 
            // lbl_nif
            // 
            lbl_nif.AutoSize = true;
            lbl_nif.Location = new Point(541, 88);
            lbl_nif.Name = "lbl_nif";
            lbl_nif.Size = new Size(41, 20);
            lbl_nif.TabIndex = 79;
            lbl_nif.Text = "NIF *";
            // 
            // lbl_postalCodeFull
            // 
            lbl_postalCodeFull.AutoSize = true;
            lbl_postalCodeFull.Location = new Point(12, 432);
            lbl_postalCodeFull.Name = "lbl_postalCodeFull";
            lbl_postalCodeFull.Size = new Size(114, 20);
            lbl_postalCodeFull.TabIndex = 77;
            lbl_postalCodeFull.Text = "Postal Code Full";
            // 
            // text_town
            // 
            text_town.Location = new Point(831, 417);
            text_town.Name = "text_town";
            text_town.Size = new Size(149, 27);
            text_town.TabIndex = 76;
            // 
            // text_Locality
            // 
            text_Locality.Location = new Point(618, 421);
            text_Locality.Name = "text_Locality";
            text_Locality.Size = new Size(131, 27);
            text_Locality.TabIndex = 74;
            // 
            // text_ProcessNumber
            // 
            text_ProcessNumber.Location = new Point(647, 9);
            text_ProcessNumber.Name = "text_ProcessNumber";
            text_ProcessNumber.Size = new Size(125, 27);
            text_ProcessNumber.TabIndex = 73;
            // 
            // lbl_town
            // 
            lbl_town.AutoSize = true;
            lbl_town.Location = new Point(774, 420);
            lbl_town.Name = "lbl_town";
            lbl_town.Size = new Size(54, 20);
            lbl_town.TabIndex = 72;
            lbl_town.Text = "Town *";
            // 
            // lbl_address
            // 
            lbl_address.AutoSize = true;
            lbl_address.Location = new Point(20, 362);
            lbl_address.Name = "lbl_address";
            lbl_address.Size = new Size(72, 20);
            lbl_address.TabIndex = 71;
            lbl_address.Text = "Address *";
            // 
            // lbl_postalCodeID
            // 
            lbl_postalCodeID.AutoSize = true;
            lbl_postalCodeID.Location = new Point(281, 428);
            lbl_postalCodeID.Name = "lbl_postalCodeID";
            lbl_postalCodeID.Size = new Size(106, 20);
            lbl_postalCodeID.TabIndex = 70;
            lbl_postalCodeID.Text = "Postal Code ID";
            // 
            // lbl_locality
            // 
            lbl_locality.AutoSize = true;
            lbl_locality.Location = new Point(541, 425);
            lbl_locality.Name = "lbl_locality";
            lbl_locality.Size = new Size(60, 20);
            lbl_locality.TabIndex = 69;
            lbl_locality.Text = "Locality";
            // 
            // text_postalCodeFull
            // 
            text_postalCodeFull.Location = new Point(132, 425);
            text_postalCodeFull.Name = "text_postalCodeFull";
            text_postalCodeFull.Size = new Size(125, 27);
            text_postalCodeFull.TabIndex = 68;
            // 
            // lbl_postalArea
            // 
            lbl_postalArea.AutoSize = true;
            lbl_postalArea.Location = new Point(745, 358);
            lbl_postalArea.Name = "lbl_postalArea";
            lbl_postalArea.Size = new Size(83, 20);
            lbl_postalArea.TabIndex = 67;
            lbl_postalArea.Text = "Postal Area";
            // 
            // lbl_postalCode
            // 
            lbl_postalCode.AutoSize = true;
            lbl_postalCode.Location = new Point(525, 362);
            lbl_postalCode.Name = "lbl_postalCode";
            lbl_postalCode.Size = new Size(87, 20);
            lbl_postalCode.TabIndex = 65;
            lbl_postalCode.Text = "Postal Code";
            // 
            // text_PostalCodeId
            // 
            text_PostalCodeId.Location = new Point(393, 425);
            text_PostalCodeId.Name = "text_PostalCodeId";
            text_PostalCodeId.Size = new Size(125, 27);
            text_PostalCodeId.TabIndex = 64;
            // 
            // lbl_processNumber
            // 
            lbl_processNumber.AutoSize = true;
            lbl_processNumber.Location = new Point(525, 12);
            lbl_processNumber.Name = "lbl_processNumber";
            lbl_processNumber.Size = new Size(116, 20);
            lbl_processNumber.TabIndex = 63;
            lbl_processNumber.Text = "Process Number";
            // 
            // lbl_birthDate
            // 
            lbl_birthDate.AutoSize = true;
            lbl_birthDate.Location = new Point(319, 149);
            lbl_birthDate.Name = "lbl_birthDate";
            lbl_birthDate.Size = new Size(86, 20);
            lbl_birthDate.TabIndex = 61;
            lbl_birthDate.Text = "Birht Date *";
            // 
            // llb_sex
            // 
            llb_sex.AutoSize = true;
            llb_sex.Location = new Point(20, 149);
            llb_sex.Name = "llb_sex";
            llb_sex.Size = new Size(42, 20);
            llb_sex.TabIndex = 59;
            llb_sex.Text = "Sex *";
            // 
            // text_fax
            // 
            text_fax.Location = new Point(583, 288);
            text_fax.Name = "text_fax";
            text_fax.Size = new Size(237, 27);
            text_fax.TabIndex = 58;
            // 
            // lbl_email
            // 
            lbl_email.AutoSize = true;
            lbl_email.Location = new Point(20, 288);
            lbl_email.Name = "lbl_email";
            lbl_email.Size = new Size(56, 20);
            lbl_email.TabIndex = 57;
            lbl_email.Text = "Email *";
            // 
            // text_email
            // 
            text_email.Location = new Point(92, 285);
            text_email.Name = "text_email";
            text_email.Size = new Size(380, 27);
            text_email.TabIndex = 56;
            // 
            // text_sex
            // 
            text_sex.Location = new Point(68, 146);
            text_sex.Name = "text_sex";
            text_sex.Size = new Size(137, 27);
            text_sex.TabIndex = 53;
            // 
            // text_name
            // 
            text_name.Location = new Point(85, 81);
            text_name.Name = "text_name";
            text_name.Size = new Size(412, 27);
            text_name.TabIndex = 52;
            // 
            // text_OtherID
            // 
            text_OtherID.Location = new Point(317, 9);
            text_OtherID.Name = "text_OtherID";
            text_OtherID.Size = new Size(40, 27);
            text_OtherID.TabIndex = 51;
            // 
            // lbl_otherTelephone
            // 
            lbl_otherTelephone.AutoSize = true;
            lbl_otherTelephone.Location = new Point(630, 219);
            lbl_otherTelephone.Name = "lbl_otherTelephone";
            lbl_otherTelephone.Size = new Size(119, 20);
            lbl_otherTelephone.TabIndex = 50;
            lbl_otherTelephone.Text = "Other Telephone";
            // 
            // text_ID
            // 
            text_ID.Location = new Point(53, 9);
            text_ID.Name = "text_ID";
            text_ID.Size = new Size(33, 27);
            text_ID.TabIndex = 49;
            // 
            // llb_Name
            // 
            llb_Name.AutoSize = true;
            llb_Name.Location = new Point(20, 81);
            llb_Name.Name = "llb_Name";
            llb_Name.Size = new Size(59, 20);
            llb_Name.TabIndex = 48;
            llb_Name.Text = "Name *";
            // 
            // lbl_ID
            // 
            lbl_ID.AutoSize = true;
            lbl_ID.Location = new Point(12, 15);
            lbl_ID.Name = "lbl_ID";
            lbl_ID.Size = new Size(24, 20);
            lbl_ID.TabIndex = 42;
            lbl_ID.Text = "ID";
            // 
            // lbl_fax
            // 
            lbl_fax.AutoSize = true;
            lbl_fax.Location = new Point(525, 288);
            lbl_fax.Name = "lbl_fax";
            lbl_fax.Size = new Size(30, 20);
            lbl_fax.TabIndex = 47;
            lbl_fax.Text = "Fax";
            // 
            // lbl_mobile
            // 
            lbl_mobile.AutoSize = true;
            lbl_mobile.Location = new Point(20, 222);
            lbl_mobile.Name = "lbl_mobile";
            lbl_mobile.Size = new Size(66, 20);
            lbl_mobile.TabIndex = 46;
            lbl_mobile.Text = "Mobile *";
            // 
            // lbl_telephone
            // 
            lbl_telephone.AutoSize = true;
            lbl_telephone.Location = new Point(317, 222);
            lbl_telephone.Name = "lbl_telephone";
            lbl_telephone.Size = new Size(88, 20);
            lbl_telephone.TabIndex = 45;
            lbl_telephone.Text = "Telephone *";
            // 
            // Grid
            // 
            Grid.BackgroundColor = Color.Peru;
            Grid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            Grid.GridColor = SystemColors.ButtonFace;
            Grid.Location = new Point(46, 495);
            Grid.Name = "Grid";
            Grid.RowHeadersWidth = 51;
            Grid.RowTemplate.Height = 29;
            Grid.Size = new Size(920, 318);
            Grid.TabIndex = 44;
            Grid.CellContentClick += Grid_CellContentClick;
            // 
            // lbl_OtherID
            // 
            lbl_OtherID.AutoSize = true;
            lbl_OtherID.Location = new Point(229, 16);
            lbl_OtherID.Name = "lbl_OtherID";
            lbl_OtherID.Size = new Size(65, 20);
            lbl_OtherID.TabIndex = 43;
            lbl_OtherID.Text = "Other ID";
            // 
            // cmd_clear
            // 
            cmd_clear.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point);
            cmd_clear.Location = new Point(188, 867);
            cmd_clear.Name = "cmd_clear";
            cmd_clear.Size = new Size(94, 29);
            cmd_clear.TabIndex = 88;
            cmd_clear.Text = "&Clear";
            cmd_clear.UseVisualStyleBackColor = true;
            cmd_clear.Click += cmd_clear_Click;
            // 
            // cmd_exit
            // 
            cmd_exit.BackColor = SystemColors.ButtonHighlight;
            cmd_exit.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point);
            cmd_exit.Location = new Point(872, 867);
            cmd_exit.Name = "cmd_exit";
            cmd_exit.Size = new Size(94, 29);
            cmd_exit.TabIndex = 87;
            cmd_exit.Text = "&Exit";
            cmd_exit.UseVisualStyleBackColor = false;
            cmd_exit.Click += cmd_exit_Click;
            // 
            // cmd_list
            // 
            cmd_list.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point);
            cmd_list.Location = new Point(525, 867);
            cmd_list.Name = "cmd_list";
            cmd_list.Size = new Size(94, 29);
            cmd_list.TabIndex = 86;
            cmd_list.Text = "&List";
            cmd_list.UseVisualStyleBackColor = true;
            cmd_list.Click += cmd_list_Click;
            // 
            // cmd_changeData
            // 
            cmd_changeData.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point);
            cmd_changeData.Location = new Point(350, 867);
            cmd_changeData.Name = "cmd_changeData";
            cmd_changeData.Size = new Size(94, 29);
            cmd_changeData.TabIndex = 85;
            cmd_changeData.Text = "&Change Data";
            cmd_changeData.UseVisualStyleBackColor = true;
            cmd_changeData.Click += cmd_changeData_Click;
            // 
            // cmd_delete
            // 
            cmd_delete.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point);
            cmd_delete.Location = new Point(695, 867);
            cmd_delete.Name = "cmd_delete";
            cmd_delete.Size = new Size(94, 29);
            cmd_delete.TabIndex = 84;
            cmd_delete.Text = "&Delete";
            cmd_delete.UseVisualStyleBackColor = true;
            cmd_delete.Click += cmd_delete_Click;
            // 
            // cmd_submit
            // 
            cmd_submit.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point);
            cmd_submit.Location = new Point(46, 867);
            cmd_submit.Name = "cmd_submit";
            cmd_submit.Size = new Size(94, 29);
            cmd_submit.TabIndex = 83;
            cmd_submit.Text = "&Submit";
            cmd_submit.UseVisualStyleBackColor = true;
            cmd_submit.Click += cmd_submit_Click;
            // 
            // maskedTextBox_nif
            // 
            maskedTextBox_nif.Location = new Point(595, 81);
            maskedTextBox_nif.Mask = "000000000";
            maskedTextBox_nif.Name = "maskedTextBox_nif";
            maskedTextBox_nif.Size = new Size(133, 27);
            maskedTextBox_nif.TabIndex = 89;
            // 
            // maskedTextBox_sns
            // 
            maskedTextBox_sns.Location = new Point(811, 85);
            maskedTextBox_sns.Mask = "000000000000";
            maskedTextBox_sns.Name = "maskedTextBox_sns";
            maskedTextBox_sns.Size = new Size(138, 27);
            maskedTextBox_sns.TabIndex = 90;
            maskedTextBox_sns.MaskInputRejected += maskedTextBox1_MaskInputRejected;
            // 
            // maskedTextBox_birthDate
            // 
            maskedTextBox_birthDate.Location = new Point(411, 212);
            maskedTextBox_birthDate.Mask = "999-000-000";
            maskedTextBox_birthDate.Name = "maskedTextBox_birthDate";
            maskedTextBox_birthDate.Size = new Size(159, 27);
            maskedTextBox_birthDate.TabIndex = 91;
            // 
            // maskedTextBox_mobile
            // 
            maskedTextBox_mobile.Location = new Point(98, 219);
            maskedTextBox_mobile.Mask = "999-000-000";
            maskedTextBox_mobile.Name = "maskedTextBox_mobile";
            maskedTextBox_mobile.Size = new Size(159, 27);
            maskedTextBox_mobile.TabIndex = 92;
            // 
            // maskedTextBox_telephone
            // 
            maskedTextBox_telephone.Location = new Point(411, 142);
            maskedTextBox_telephone.Mask = "00/00/0000";
            maskedTextBox_telephone.Name = "maskedTextBox_telephone";
            maskedTextBox_telephone.Size = new Size(159, 27);
            maskedTextBox_telephone.TabIndex = 93;
            maskedTextBox_telephone.ValidatingType = typeof(DateTime);
            // 
            // maskedTextBox_otherTelephone
            // 
            maskedTextBox_otherTelephone.Location = new Point(759, 215);
            maskedTextBox_otherTelephone.Mask = "999-000-0000";
            maskedTextBox_otherTelephone.Name = "maskedTextBox_otherTelephone";
            maskedTextBox_otherTelephone.Size = new Size(159, 27);
            maskedTextBox_otherTelephone.TabIndex = 94;
            // 
            // maskedTextBox_postalCode
            // 
            maskedTextBox_postalCode.Location = new Point(618, 355);
            maskedTextBox_postalCode.Mask = "0000-999";
            maskedTextBox_postalCode.Name = "maskedTextBox_postalCode";
            maskedTextBox_postalCode.Size = new Size(110, 27);
            maskedTextBox_postalCode.TabIndex = 95;
            // 
            // maskedTextBox_postalArea
            // 
            maskedTextBox_postalArea.Location = new Point(834, 351);
            maskedTextBox_postalArea.Mask = "0000-999";
            maskedTextBox_postalArea.Name = "maskedTextBox_postalArea";
            maskedTextBox_postalArea.Size = new Size(115, 27);
            maskedTextBox_postalArea.TabIndex = 96;
            // 
            // CreatePacient
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.WindowFrame;
            ClientSize = new Size(1037, 963);
            Controls.Add(maskedTextBox_postalArea);
            Controls.Add(maskedTextBox_postalCode);
            Controls.Add(maskedTextBox_otherTelephone);
            Controls.Add(maskedTextBox_telephone);
            Controls.Add(maskedTextBox_mobile);
            Controls.Add(maskedTextBox_birthDate);
            Controls.Add(maskedTextBox_sns);
            Controls.Add(maskedTextBox_nif);
            Controls.Add(cmd_clear);
            Controls.Add(cmd_exit);
            Controls.Add(cmd_list);
            Controls.Add(cmd_changeData);
            Controls.Add(cmd_delete);
            Controls.Add(cmd_submit);
            Controls.Add(lbl_sns);
            Controls.Add(text_address);
            Controls.Add(lbl_nif);
            Controls.Add(lbl_postalCodeFull);
            Controls.Add(text_town);
            Controls.Add(text_Locality);
            Controls.Add(text_ProcessNumber);
            Controls.Add(lbl_town);
            Controls.Add(lbl_address);
            Controls.Add(lbl_postalCodeID);
            Controls.Add(lbl_locality);
            Controls.Add(text_postalCodeFull);
            Controls.Add(lbl_postalArea);
            Controls.Add(lbl_postalCode);
            Controls.Add(text_PostalCodeId);
            Controls.Add(lbl_processNumber);
            Controls.Add(lbl_birthDate);
            Controls.Add(llb_sex);
            Controls.Add(text_fax);
            Controls.Add(lbl_email);
            Controls.Add(text_email);
            Controls.Add(text_sex);
            Controls.Add(text_name);
            Controls.Add(text_OtherID);
            Controls.Add(lbl_otherTelephone);
            Controls.Add(text_ID);
            Controls.Add(llb_Name);
            Controls.Add(lbl_ID);
            Controls.Add(lbl_fax);
            Controls.Add(lbl_mobile);
            Controls.Add(lbl_telephone);
            Controls.Add(Grid);
            Controls.Add(lbl_OtherID);
            DoubleBuffered = true;
            ForeColor = SystemColors.ActiveCaption;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "CreatePacient";
            Text = "Create Pacient";
            Load += CreatePacient_Load;
            ((System.ComponentModel.ISupportInitialize)Grid).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label lbl_sns;
        private TextBox text_address;
        private Label lbl_nif;
        private Label lbl_postalCodeFull;
        private TextBox text_town;
        private TextBox text_Locality;
        private TextBox text_ProcessNumber;
        private Label lbl_town;
        private Label lbl_address;
        private Label lbl_postalCodeID;
        private Label lbl_locality;
        private TextBox text_postalCodeFull;
        private Label lbl_postalArea;
        private Label lbl_postalCode;
        private TextBox text_PostalCodeId;
        private Label lbl_processNumber;
        private Label lbl_birthDate;
        private Label llb_sex;
        private TextBox text_fax;
        private Label lbl_email;
        private TextBox text_email;
        private TextBox text_sex;
        private TextBox text_name;
        private TextBox text_OtherID;
        private Label lbl_otherTelephone;
        private TextBox text_ID;
        private Label llb_Name;
        private Label lbl_ID;
        private Label lbl_fax;
        private Label lbl_mobile;
        private Label lbl_telephone;
        private DataGridView Grid;
        private Label lbl_OtherID;
        private Button cmd_clear;
        private Button cmd_exit;
        private Button cmd_list;
        private Button cmd_changeData;
        private Button cmd_delete;
        private Button cmd_submit;
        private MaskedTextBox maskedTextBox_nif;
        private MaskedTextBox maskedTextBox_sns;
        private MaskedTextBox maskedTextBox_birthDate;
        private MaskedTextBox maskedTextBox_mobile;
        private MaskedTextBox maskedTextBox_telephone;
        private MaskedTextBox maskedTextBox_otherTelephone;
        private MaskedTextBox maskedTextBox_postalCode;
        private MaskedTextBox maskedTextBox_postalArea;
    }
}