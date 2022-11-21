
namespace StudentDetails
{
    partial class StudentPage
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
            this.lblHeader = new System.Windows.Forms.Label();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.lblLastName = new System.Windows.Forms.Label();
            this.txtAge = new System.Windows.Forms.TextBox();
            this.Age = new System.Windows.Forms.Label();
            this.txtClass = new System.Windows.Forms.TextBox();
            this.lblClass = new System.Windows.Forms.Label();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.lblAddress = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.lblGender = new System.Windows.Forms.Label();
            this.cmbGender = new System.Windows.Forms.ComboBox();
            this.lblDOB = new System.Windows.Forms.Label();
            this.dtpDOB = new System.Windows.Forms.DateTimePicker();
            this.lbleyears = new System.Windows.Forms.Label();
            this.lblFirstNameWarn = new System.Windows.Forms.Label();
            this.lblLastNameWarn = new System.Windows.Forms.Label();
            this.lblGenderWarn = new System.Windows.Forms.Label();
            this.lblDTPWarn = new System.Windows.Forms.Label();
            this.lblAgeWarn = new System.Windows.Forms.Label();
            this.lblHighlight = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblHeader
            // 
            this.lblHeader.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblHeader.AutoSize = true;
            this.lblHeader.Font = new System.Drawing.Font("Times New Roman", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblHeader.Location = new System.Drawing.Point(314, 35);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(117, 46);
            this.lblHeader.TabIndex = 0;
            this.lblHeader.Text = "label1";
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblFirstName.Location = new System.Drawing.Point(18, 126);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(98, 22);
            this.lblFirstName.TabIndex = 1;
            this.lblFirstName.Text = "First Name";
            // 
            // txtFirstName
            // 
            this.txtFirstName.Location = new System.Drawing.Point(154, 112);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.PlaceholderText = "Please enter First Name";
            this.txtFirstName.Size = new System.Drawing.Size(630, 31);
            this.txtFirstName.TabIndex = 2;
           // this.txtFirstName.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txtFirstName_MouseClick);
            this.txtFirstName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtFirstName_KeyPress);
            // 
            // txtLastName
            // 
            this.txtLastName.Location = new System.Drawing.Point(154, 178);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.PlaceholderText = "Please enter Last Name";
            this.txtLastName.Size = new System.Drawing.Size(630, 31);
            this.txtLastName.TabIndex = 4;
            this.txtLastName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtLastName_KeyPress);
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblLastName.Location = new System.Drawing.Point(18, 189);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(94, 22);
            this.lblLastName.TabIndex = 3;
            this.lblLastName.Text = "Last Name";
            // 
            // txtAge
            // 
            this.txtAge.Location = new System.Drawing.Point(625, 322);
            this.txtAge.MaxLength = 2;
            this.txtAge.Name = "txtAge";
            this.txtAge.Size = new System.Drawing.Size(100, 31);
            this.txtAge.TabIndex = 6;
            this.txtAge.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtAge_KeyPress);
            this.txtAge.Leave += new System.EventHandler(this.txtAge_Leave);
            // 
            // Age
            // 
            this.Age.AutoSize = true;
            this.Age.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Age.Location = new System.Drawing.Point(570, 327);
            this.Age.Name = "Age";
            this.Age.Size = new System.Drawing.Size(42, 22);
            this.Age.TabIndex = 5;
            this.Age.Text = "Age";
            // 
            // txtClass
            // 
            this.txtClass.Location = new System.Drawing.Point(154, 378);
            this.txtClass.Name = "txtClass";
            this.txtClass.PlaceholderText = "Please enter class";
            this.txtClass.Size = new System.Drawing.Size(167, 31);
            this.txtClass.TabIndex = 8;
            // 
            // lblClass
            // 
            this.lblClass.AutoSize = true;
            this.lblClass.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblClass.Location = new System.Drawing.Point(18, 379);
            this.lblClass.Name = "lblClass";
            this.lblClass.Size = new System.Drawing.Size(54, 22);
            this.lblClass.TabIndex = 7;
            this.lblClass.Text = "Class";
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(154, 441);
            this.txtAddress.Multiline = true;
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.PlaceholderText = "Please enter address";
            this.txtAddress.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtAddress.Size = new System.Drawing.Size(630, 108);
            this.txtAddress.TabIndex = 10;
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblAddress.Location = new System.Drawing.Point(18, 441);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(76, 22);
            this.lblAddress.TabIndex = 9;
            this.lblAddress.Text = "Address";
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSave.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnSave.Location = new System.Drawing.Point(526, 574);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(118, 30);
            this.btnSave.TabIndex = 11;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCancel.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnCancel.Location = new System.Drawing.Point(666, 574);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(118, 30);
            this.btnCancel.TabIndex = 12;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDelete.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnDelete.Location = new System.Drawing.Point(18, 574);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(118, 30);
            this.btnDelete.TabIndex = 13;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // lblGender
            // 
            this.lblGender.AutoSize = true;
            this.lblGender.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblGender.Location = new System.Drawing.Point(18, 260);
            this.lblGender.Name = "lblGender";
            this.lblGender.Size = new System.Drawing.Size(68, 22);
            this.lblGender.TabIndex = 14;
            this.lblGender.Text = "Gender";
            // 
            // cmbGender
            // 
            this.cmbGender.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbGender.FormattingEnabled = true;
            this.cmbGender.Location = new System.Drawing.Point(154, 244);
            this.cmbGender.Name = "cmbGender";
            this.cmbGender.Size = new System.Drawing.Size(167, 33);
            this.cmbGender.TabIndex = 15;
            this.cmbGender.Validating += new System.ComponentModel.CancelEventHandler(this.cmbGender_Validating);
            // 
            // lblDOB
            // 
            this.lblDOB.AutoSize = true;
            this.lblDOB.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblDOB.Location = new System.Drawing.Point(18, 322);
            this.lblDOB.Name = "lblDOB";
            this.lblDOB.Size = new System.Drawing.Size(117, 22);
            this.lblDOB.TabIndex = 16;
            this.lblDOB.Text = "Date Of Birth";
            // 
            // dtpDOB
            // 
            this.dtpDOB.CustomFormat = "dd/MM/yyyy";
            this.dtpDOB.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDOB.Location = new System.Drawing.Point(154, 312);
            this.dtpDOB.Name = "dtpDOB";
            this.dtpDOB.Size = new System.Drawing.Size(167, 31);
            this.dtpDOB.TabIndex = 17;
            this.dtpDOB.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // lbleyears
            // 
            this.lbleyears.AutoSize = true;
            this.lbleyears.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbleyears.Location = new System.Drawing.Point(732, 328);
            this.lbleyears.Name = "lbleyears";
            this.lbleyears.Size = new System.Drawing.Size(52, 22);
            this.lbleyears.TabIndex = 18;
            this.lbleyears.Text = "years";
            // 
            // lblFirstNameWarn
            // 
            this.lblFirstNameWarn.AutoSize = true;
            this.lblFirstNameWarn.Font = new System.Drawing.Font("Times New Roman", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblFirstNameWarn.ForeColor = System.Drawing.Color.Red;
            this.lblFirstNameWarn.Location = new System.Drawing.Point(154, 151);
            this.lblFirstNameWarn.Name = "lblFirstNameWarn";
            this.lblFirstNameWarn.Size = new System.Drawing.Size(45, 19);
            this.lblFirstNameWarn.TabIndex = 19;
            this.lblFirstNameWarn.Text = "label1";
            this.lblFirstNameWarn.Visible = false;
            // 
            // lblLastNameWarn
            // 
            this.lblLastNameWarn.AutoSize = true;
            this.lblLastNameWarn.Font = new System.Drawing.Font("Times New Roman", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblLastNameWarn.ForeColor = System.Drawing.Color.Red;
            this.lblLastNameWarn.Location = new System.Drawing.Point(154, 217);
            this.lblLastNameWarn.Name = "lblLastNameWarn";
            this.lblLastNameWarn.Size = new System.Drawing.Size(45, 19);
            this.lblLastNameWarn.TabIndex = 20;
            this.lblLastNameWarn.Text = "label1";
            this.lblLastNameWarn.Visible = false;
            // 
            // lblGenderWarn
            // 
            this.lblGenderWarn.AutoSize = true;
            this.lblGenderWarn.Font = new System.Drawing.Font("Times New Roman", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblGenderWarn.ForeColor = System.Drawing.Color.Red;
            this.lblGenderWarn.Location = new System.Drawing.Point(154, 285);
            this.lblGenderWarn.Name = "lblGenderWarn";
            this.lblGenderWarn.Size = new System.Drawing.Size(45, 19);
            this.lblGenderWarn.TabIndex = 21;
            this.lblGenderWarn.Text = "label1";
            this.lblGenderWarn.Visible = false;
            // 
            // lblDTPWarn
            // 
            this.lblDTPWarn.AutoSize = true;
            this.lblDTPWarn.Font = new System.Drawing.Font("Times New Roman", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblDTPWarn.ForeColor = System.Drawing.Color.Red;
            this.lblDTPWarn.Location = new System.Drawing.Point(154, 351);
            this.lblDTPWarn.Name = "lblDTPWarn";
            this.lblDTPWarn.Size = new System.Drawing.Size(45, 19);
            this.lblDTPWarn.TabIndex = 22;
            this.lblDTPWarn.Text = "label1";
            this.lblDTPWarn.Visible = false;
            // 
            // lblAgeWarn
            // 
            this.lblAgeWarn.AutoSize = true;
            this.lblAgeWarn.Font = new System.Drawing.Font("Times New Roman", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblAgeWarn.ForeColor = System.Drawing.Color.Red;
            this.lblAgeWarn.Location = new System.Drawing.Point(623, 356);
            this.lblAgeWarn.Name = "lblAgeWarn";
            this.lblAgeWarn.Size = new System.Drawing.Size(45, 19);
            this.lblAgeWarn.TabIndex = 23;
            this.lblAgeWarn.Text = "label1";
            this.lblAgeWarn.Visible = false;
            // 
            // lblHighlight
            // 
            this.lblHighlight.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblHighlight.AutoSize = true;
            this.lblHighlight.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblHighlight.ForeColor = System.Drawing.Color.Red;
            this.lblHighlight.Location = new System.Drawing.Point(109, 117);
            this.lblHighlight.Name = "lblHighlight";
            this.lblHighlight.Size = new System.Drawing.Size(19, 22);
            this.lblHighlight.TabIndex = 24;
            this.lblHighlight.Text = "*";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(109, 182);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(19, 22);
            this.label1.TabIndex = 25;
            this.label1.Text = "*";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(82, 248);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(19, 22);
            this.label2.TabIndex = 26;
            this.label2.Text = "*";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(125, 307);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(19, 22);
            this.label3.TabIndex = 27;
            this.label3.Text = "*";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.Color.Red;
            this.label4.Location = new System.Drawing.Point(602, 314);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(19, 22);
            this.label4.TabIndex = 28;
            this.label4.Text = "*";
            // 
            // StudentPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(807, 624);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblHighlight);
            this.Controls.Add(this.lblAgeWarn);
            this.Controls.Add(this.lblDTPWarn);
            this.Controls.Add(this.lblGenderWarn);
            this.Controls.Add(this.lblLastNameWarn);
            this.Controls.Add(this.lblFirstNameWarn);
            this.Controls.Add(this.lbleyears);
            this.Controls.Add(this.dtpDOB);
            this.Controls.Add(this.lblDOB);
            this.Controls.Add(this.cmbGender);
            this.Controls.Add(this.lblGender);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtAddress);
            this.Controls.Add(this.lblAddress);
            this.Controls.Add(this.txtClass);
            this.Controls.Add(this.lblClass);
            this.Controls.Add(this.txtAge);
            this.Controls.Add(this.Age);
            this.Controls.Add(this.txtLastName);
            this.Controls.Add(this.lblLastName);
            this.Controls.Add(this.txtFirstName);
            this.Controls.Add(this.lblFirstName);
            this.Controls.Add(this.lblHeader);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "StudentPage";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Load += new System.EventHandler(this.StudentPage_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public System.Windows.Forms.Label lblFirstName;
        public System.Windows.Forms.TextBox txtFirstName;
        public System.Windows.Forms.TextBox txtLastName;
        public System.Windows.Forms.Label lblLastName;
        public System.Windows.Forms.TextBox txtAge;
        public System.Windows.Forms.Label Age;
        public System.Windows.Forms.TextBox txtClass;
        public System.Windows.Forms.Label lblClass;
        public System.Windows.Forms.TextBox txtAddress;
        public System.Windows.Forms.Label lblAddress;
        public System.Windows.Forms.Label lblHeader;
        public System.Windows.Forms.Button btnCancel;
        public System.Windows.Forms.Button btnDelete;
        public System.Windows.Forms.Button btnSave;
        public System.Windows.Forms.Label lblGender;
        private System.Windows.Forms.ComboBox cmbGender;
        public System.Windows.Forms.Label lblDOB;
        private System.Windows.Forms.DateTimePicker dtpDOB;
        public System.Windows.Forms.Label lbleyears;
        public System.Windows.Forms.Label lblFirstNameWarn;
        public System.Windows.Forms.Label lblLastNameWarn;
        public System.Windows.Forms.Label lblGenderWarn;
        public System.Windows.Forms.Label lblDTPWarn;
        public System.Windows.Forms.Label lblAgeWarn;
        public System.Windows.Forms.Label lblHighlight;
        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.Label label2;
        public System.Windows.Forms.Label label3;
        public System.Windows.Forms.Label label4;
    }
}