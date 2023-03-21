namespace WindowsFormPractice
{
    partial class Form1
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtNote = new System.Windows.Forms.TextBox();
            this.btnSelect = new System.Windows.Forms.Button();
            this.btnMessage = new System.Windows.Forms.Button();
            this.grpFonts = new System.Windows.Forms.GroupBox();
            this.rdoGungsuh = new System.Windows.Forms.RadioButton();
            this.rdoGulim = new System.Windows.Forms.RadioButton();
            this.rdoDotum = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.checkItalic = new System.Windows.Forms.CheckBox();
            this.chkUnderline = new System.Windows.Forms.CheckBox();
            this.chkBold = new System.Windows.Forms.CheckBox();
            this.lstLanguages = new System.Windows.Forms.ListBox();
            this.btnListToChecked = new System.Windows.Forms.Button();
            this.btnCheckedToList = new System.Windows.Forms.Button();
            this.cklLanguages = new System.Windows.Forms.CheckedListBox();
            this.txtNote2 = new System.Windows.Forms.TextBox();
            this.btnChecedToTextBox = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.txtNote3 = new System.Windows.Forms.TextBox();
            this.cmbMonth = new System.Windows.Forms.ComboBox();
            this.cmbDay = new System.Windows.Forms.ComboBox();
            this.cmbYear = new System.Windows.Forms.ComboBox();
            this.lblToggle = new System.Windows.Forms.Label();
            this.lblBirthday = new System.Windows.Forms.Label();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.grpFonts.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtNote
            // 
            this.txtNote.Location = new System.Drawing.Point(3, 3);
            this.txtNote.Multiline = true;
            this.txtNote.Name = "txtNote";
            this.txtNote.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtNote.Size = new System.Drawing.Size(485, 183);
            this.txtNote.TabIndex = 2;
            this.txtNote.WordWrap = false;
            // 
            // btnSelect
            // 
            this.btnSelect.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSelect.Location = new System.Drawing.Point(259, 196);
            this.btnSelect.Name = "btnSelect";
            this.btnSelect.Size = new System.Drawing.Size(229, 22);
            this.btnSelect.TabIndex = 4;
            this.btnSelect.Text = "Select";
            this.btnSelect.UseVisualStyleBackColor = true;
            this.btnSelect.Click += new System.EventHandler(this.btnSelect_Click);
            // 
            // btnMessage
            // 
            this.btnMessage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMessage.Location = new System.Drawing.Point(3, 196);
            this.btnMessage.Name = "btnMessage";
            this.btnMessage.Size = new System.Drawing.Size(229, 22);
            this.btnMessage.TabIndex = 5;
            this.btnMessage.Text = "Message";
            this.btnMessage.UseVisualStyleBackColor = true;
            this.btnMessage.Click += new System.EventHandler(this.btnMessage_Click);
            // 
            // grpFonts
            // 
            this.grpFonts.Controls.Add(this.rdoGungsuh);
            this.grpFonts.Controls.Add(this.rdoGulim);
            this.grpFonts.Controls.Add(this.rdoDotum);
            this.grpFonts.Location = new System.Drawing.Point(3, 220);
            this.grpFonts.Name = "grpFonts";
            this.grpFonts.Size = new System.Drawing.Size(229, 210);
            this.grpFonts.TabIndex = 6;
            this.grpFonts.TabStop = false;
            this.grpFonts.Text = "Fonts";
            // 
            // rdoGungsuh
            // 
            this.rdoGungsuh.AutoSize = true;
            this.rdoGungsuh.Location = new System.Drawing.Point(17, 172);
            this.rdoGungsuh.Name = "rdoGungsuh";
            this.rdoGungsuh.Size = new System.Drawing.Size(47, 16);
            this.rdoGungsuh.TabIndex = 2;
            this.rdoGungsuh.TabStop = true;
            this.rdoGungsuh.Text = "궁서";
            this.rdoGungsuh.UseVisualStyleBackColor = true;
            this.rdoGungsuh.CheckedChanged += new System.EventHandler(this.rdoGungsuh_CheckedChanged);
            // 
            // rdoGulim
            // 
            this.rdoGulim.AutoSize = true;
            this.rdoGulim.Location = new System.Drawing.Point(17, 99);
            this.rdoGulim.Name = "rdoGulim";
            this.rdoGulim.Size = new System.Drawing.Size(47, 16);
            this.rdoGulim.TabIndex = 1;
            this.rdoGulim.TabStop = true;
            this.rdoGulim.Text = "굴림";
            this.rdoGulim.UseVisualStyleBackColor = true;
            this.rdoGulim.CheckedChanged += new System.EventHandler(this.rdoGulim_CheckedChanged);
            // 
            // rdoDotum
            // 
            this.rdoDotum.AutoSize = true;
            this.rdoDotum.Location = new System.Drawing.Point(17, 32);
            this.rdoDotum.Name = "rdoDotum";
            this.rdoDotum.Size = new System.Drawing.Size(47, 16);
            this.rdoDotum.TabIndex = 0;
            this.rdoDotum.TabStop = true;
            this.rdoDotum.Text = "돋움";
            this.rdoDotum.UseVisualStyleBackColor = true;
            this.rdoDotum.CheckedChanged += new System.EventHandler(this.rdoDotum_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.checkItalic);
            this.groupBox1.Controls.Add(this.chkUnderline);
            this.groupBox1.Controls.Add(this.chkBold);
            this.groupBox1.Location = new System.Drawing.Point(259, 220);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(229, 210);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Styles";
            // 
            // checkItalic
            // 
            this.checkItalic.AutoSize = true;
            this.checkItalic.Location = new System.Drawing.Point(18, 172);
            this.checkItalic.Name = "checkItalic";
            this.checkItalic.Size = new System.Drawing.Size(50, 16);
            this.checkItalic.TabIndex = 2;
            this.checkItalic.Text = "Italic";
            this.checkItalic.UseVisualStyleBackColor = true;
            this.checkItalic.CheckedChanged += new System.EventHandler(this.checkItalic_CheckedChanged);
            // 
            // chkUnderline
            // 
            this.chkUnderline.AutoSize = true;
            this.chkUnderline.Location = new System.Drawing.Point(18, 100);
            this.chkUnderline.Name = "chkUnderline";
            this.chkUnderline.Size = new System.Drawing.Size(77, 16);
            this.chkUnderline.TabIndex = 1;
            this.chkUnderline.Text = "Underline";
            this.chkUnderline.UseVisualStyleBackColor = true;
            this.chkUnderline.CheckedChanged += new System.EventHandler(this.chkUnderline_CheckedChanged);
            // 
            // chkBold
            // 
            this.chkBold.AutoSize = true;
            this.chkBold.Location = new System.Drawing.Point(18, 31);
            this.chkBold.Name = "chkBold";
            this.chkBold.Size = new System.Drawing.Size(49, 16);
            this.chkBold.TabIndex = 0;
            this.chkBold.Text = "Bold";
            this.chkBold.UseVisualStyleBackColor = true;
            this.chkBold.CheckedChanged += new System.EventHandler(this.chkBold_CheckedChanged);
            // 
            // lstLanguages
            // 
            this.lstLanguages.FormattingEnabled = true;
            this.lstLanguages.ItemHeight = 12;
            this.lstLanguages.Items.AddRange(new object[] {
            "Java",
            "C",
            "C++",
            "C#",
            "Python",
            "Visual Basic .NET",
            "PHP",
            "JavaScript",
            "Ruby",
            "Perl",
            "Rust",
            "Zig",
            "Go",
            "Erlang"});
            this.lstLanguages.Location = new System.Drawing.Point(6, 6);
            this.lstLanguages.Name = "lstLanguages";
            this.lstLanguages.Size = new System.Drawing.Size(207, 184);
            this.lstLanguages.TabIndex = 8;
            // 
            // btnListToChecked
            // 
            this.btnListToChecked.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnListToChecked.Location = new System.Drawing.Point(219, 33);
            this.btnListToChecked.Name = "btnListToChecked";
            this.btnListToChecked.Size = new System.Drawing.Size(58, 58);
            this.btnListToChecked.TabIndex = 9;
            this.btnListToChecked.Text = "▶";
            this.btnListToChecked.UseVisualStyleBackColor = true;
            this.btnListToChecked.Click += new System.EventHandler(this.btnListToChecked_Click);
            // 
            // btnCheckedToList
            // 
            this.btnCheckedToList.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCheckedToList.Location = new System.Drawing.Point(220, 97);
            this.btnCheckedToList.Name = "btnCheckedToList";
            this.btnCheckedToList.Size = new System.Drawing.Size(58, 58);
            this.btnCheckedToList.TabIndex = 10;
            this.btnCheckedToList.Text = "◀";
            this.btnCheckedToList.UseVisualStyleBackColor = true;
            this.btnCheckedToList.Click += new System.EventHandler(this.btnCheckedToList_Click);
            // 
            // cklLanguages
            // 
            this.cklLanguages.CheckOnClick = true;
            this.cklLanguages.FormattingEnabled = true;
            this.cklLanguages.Location = new System.Drawing.Point(283, 6);
            this.cklLanguages.Name = "cklLanguages";
            this.cklLanguages.Size = new System.Drawing.Size(207, 180);
            this.cklLanguages.TabIndex = 11;
            // 
            // txtNote2
            // 
            this.txtNote2.Location = new System.Drawing.Point(6, 196);
            this.txtNote2.Multiline = true;
            this.txtNote2.Name = "txtNote2";
            this.txtNote2.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtNote2.Size = new System.Drawing.Size(272, 240);
            this.txtNote2.TabIndex = 13;
            this.txtNote2.WordWrap = false;
            // 
            // btnChecedToTextBox
            // 
            this.btnChecedToTextBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnChecedToTextBox.Location = new System.Drawing.Point(362, 290);
            this.btnChecedToTextBox.Name = "btnChecedToTextBox";
            this.btnChecedToTextBox.Size = new System.Drawing.Size(58, 58);
            this.btnChecedToTextBox.TabIndex = 14;
            this.btnChecedToTextBox.Text = "◀◀";
            this.btnChecedToTextBox.UseVisualStyleBackColor = true;
            this.btnChecedToTextBox.Click += new System.EventHandler(this.btnChecedToTextBox_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(507, 472);
            this.tabControl1.TabIndex = 15;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.txtNote);
            this.tabPage1.Controls.Add(this.btnMessage);
            this.tabPage1.Controls.Add(this.btnSelect);
            this.tabPage1.Controls.Add(this.grpFonts);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(499, 446);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "chap1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.lstLanguages);
            this.tabPage2.Controls.Add(this.btnChecedToTextBox);
            this.tabPage2.Controls.Add(this.btnListToChecked);
            this.tabPage2.Controls.Add(this.txtNote2);
            this.tabPage2.Controls.Add(this.btnCheckedToList);
            this.tabPage2.Controls.Add(this.cklLanguages);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(499, 446);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "chap2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.btnCalculate);
            this.tabPage3.Controls.Add(this.txtNote3);
            this.tabPage3.Controls.Add(this.cmbMonth);
            this.tabPage3.Controls.Add(this.cmbDay);
            this.tabPage3.Controls.Add(this.cmbYear);
            this.tabPage3.Controls.Add(this.lblToggle);
            this.tabPage3.Controls.Add(this.lblBirthday);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(499, 446);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "chap3";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // txtNote3
            // 
            this.txtNote3.Location = new System.Drawing.Point(8, 62);
            this.txtNote3.Multiline = true;
            this.txtNote3.Name = "txtNote3";
            this.txtNote3.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtNote3.Size = new System.Drawing.Size(488, 347);
            this.txtNote3.TabIndex = 16;
            this.txtNote3.WordWrap = false;
            // 
            // cmbMonth
            // 
            this.cmbMonth.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbMonth.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbMonth.FormattingEnabled = true;
            this.cmbMonth.Location = new System.Drawing.Point(239, 8);
            this.cmbMonth.Name = "cmbMonth";
            this.cmbMonth.Size = new System.Drawing.Size(123, 20);
            this.cmbMonth.TabIndex = 4;
            this.cmbMonth.Text = "월";
            this.cmbMonth.SelectedIndexChanged += new System.EventHandler(this.cmb_ItemOrTextChanged);
            this.cmbMonth.TextChanged += new System.EventHandler(this.cmb_ItemOrTextChanged);
            // 
            // cmbDay
            // 
            this.cmbDay.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbDay.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbDay.FormattingEnabled = true;
            this.cmbDay.Location = new System.Drawing.Point(368, 8);
            this.cmbDay.Name = "cmbDay";
            this.cmbDay.Size = new System.Drawing.Size(123, 20);
            this.cmbDay.TabIndex = 3;
            this.cmbDay.Text = "일";
            this.cmbDay.SelectedIndexChanged += new System.EventHandler(this.cmb_ItemOrTextChanged);
            this.cmbDay.TextChanged += new System.EventHandler(this.cmb_ItemOrTextChanged);
            // 
            // cmbYear
            // 
            this.cmbYear.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbYear.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbYear.FormattingEnabled = true;
            this.cmbYear.Location = new System.Drawing.Point(79, 8);
            this.cmbYear.Name = "cmbYear";
            this.cmbYear.Size = new System.Drawing.Size(154, 20);
            this.cmbYear.TabIndex = 2;
            this.cmbYear.Text = "년(4자)";
            this.cmbYear.SelectedIndexChanged += new System.EventHandler(this.cmb_ItemOrTextChanged);
            this.cmbYear.TextChanged += new System.EventHandler(this.cmb_ItemOrTextChanged);
            // 
            // lblToggle
            // 
            this.lblToggle.AutoSize = true;
            this.lblToggle.Font = new System.Drawing.Font("굴림", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblToggle.Location = new System.Drawing.Point(10, 40);
            this.lblToggle.Name = "lblToggle";
            this.lblToggle.Size = new System.Drawing.Size(45, 19);
            this.lblToggle.TabIndex = 1;
            this.lblToggle.Text = "label";
            // 
            // lblBirthday
            // 
            this.lblBirthday.AutoSize = true;
            this.lblBirthday.Font = new System.Drawing.Font("굴림", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblBirthday.Location = new System.Drawing.Point(10, 9);
            this.lblBirthday.Name = "lblBirthday";
            this.lblBirthday.Size = new System.Drawing.Size(47, 19);
            this.lblBirthday.TabIndex = 0;
            this.lblBirthday.Text = "생일";
            // 
            // btnCalculate
            // 
            this.btnCalculate.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnCalculate.Location = new System.Drawing.Point(0, 418);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(499, 28);
            this.btnCalculate.TabIndex = 17;
            this.btnCalculate.Text = "Calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(507, 472);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.grpFonts.ResumeLayout(false);
            this.grpFonts.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TextBox txtNote;
        private System.Windows.Forms.Button btnSelect;
        private System.Windows.Forms.Button btnMessage;
        private System.Windows.Forms.GroupBox grpFonts;
        private System.Windows.Forms.RadioButton rdoGungsuh;
        private System.Windows.Forms.RadioButton rdoGulim;
        private System.Windows.Forms.RadioButton rdoDotum;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox checkItalic;
        private System.Windows.Forms.CheckBox chkUnderline;
        private System.Windows.Forms.CheckBox chkBold;
        private System.Windows.Forms.ListBox lstLanguages;
        private System.Windows.Forms.Button btnListToChecked;
        private System.Windows.Forms.Button btnCheckedToList;
        private System.Windows.Forms.CheckedListBox cklLanguages;
        private System.Windows.Forms.TextBox txtNote2;
        private System.Windows.Forms.Button btnChecedToTextBox;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Label lblBirthday;
        private System.Windows.Forms.TextBox txtNote3;
        private System.Windows.Forms.ComboBox cmbMonth;
        private System.Windows.Forms.ComboBox cmbDay;
        private System.Windows.Forms.ComboBox cmbYear;
        private System.Windows.Forms.Label lblToggle;
        private System.Windows.Forms.Button btnCalculate;
    }
}

