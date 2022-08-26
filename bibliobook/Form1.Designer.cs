namespace bibliobook
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
            this.btnInform = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnVisibleInform = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.lblReader = new System.Windows.Forms.Label();
            this.rdbStatus1 = new System.Windows.Forms.RadioButton();
            this.rdbStatus2 = new System.Windows.Forms.RadioButton();
            this.rdbStatus3 = new System.Windows.Forms.RadioButton();
            this.grbStatus = new System.Windows.Forms.GroupBox();
            this.lblBooks = new System.Windows.Forms.Label();
            this.lstBooks = new System.Windows.Forms.ListBox();
            this.chkBook = new System.Windows.Forms.CheckBox();
            this.lblKol = new System.Windows.Forms.Label();
            this.txtKol = new System.Windows.Forms.TextBox();
            this.grbReader = new System.Windows.Forms.GroupBox();
            this.cmbReader = new System.Windows.Forms.ComboBox();
            this.lstInform = new System.Windows.Forms.ListBox();
            this.grbInform = new System.Windows.Forms.GroupBox();
            this.grbStatus.SuspendLayout();
            this.grbReader.SuspendLayout();
            this.grbInform.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnInform
            // 
            this.btnInform.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnInform.Location = new System.Drawing.Point(547, 22);
            this.btnInform.Name = "btnInform";
            this.btnInform.Size = new System.Drawing.Size(189, 23);
            this.btnInform.TabIndex = 0;
            this.btnInform.Text = "Получить";
            this.btnInform.UseVisualStyleBackColor = true;
            this.btnInform.Click += new System.EventHandler(this.btnInform_Click);
            // 
            // btnRemove
            // 
            this.btnRemove.Enabled = false;
            this.btnRemove.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnRemove.Location = new System.Drawing.Point(547, 62);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(188, 23);
            this.btnRemove.TabIndex = 1;
            this.btnRemove.Text = "Удалить строку";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // btnClear
            // 
            this.btnClear.Enabled = false;
            this.btnClear.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnClear.Location = new System.Drawing.Point(546, 102);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(189, 23);
            this.btnClear.TabIndex = 2;
            this.btnClear.Text = "Очистить";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnVisibleInform
            // 
            this.btnVisibleInform.Enabled = false;
            this.btnVisibleInform.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnVisibleInform.Location = new System.Drawing.Point(546, 142);
            this.btnVisibleInform.Name = "btnVisibleInform";
            this.btnVisibleInform.Size = new System.Drawing.Size(187, 23);
            this.btnVisibleInform.TabIndex = 3;
            this.btnVisibleInform.Text = "Скрыть информацию";
            this.btnVisibleInform.UseVisualStyleBackColor = true;
            this.btnVisibleInform.Click += new System.EventHandler(this.btnVisibleInform_Click);
            // 
            // btnExit
            // 
            this.btnExit.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnExit.Location = new System.Drawing.Point(546, 470);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(187, 23);
            this.btnExit.TabIndex = 4;
            this.btnExit.Text = "Выход";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // lblReader
            // 
            this.lblReader.AutoSize = true;
            this.lblReader.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblReader.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblReader.Location = new System.Drawing.Point(43, 31);
            this.lblReader.Name = "lblReader";
            this.lblReader.Size = new System.Drawing.Size(63, 13);
            this.lblReader.TabIndex = 6;
            this.lblReader.Text = "Читатель";
            // 
            // rdbStatus1
            // 
            this.rdbStatus1.AutoSize = true;
            this.rdbStatus1.Checked = true;
            this.rdbStatus1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.rdbStatus1.Location = new System.Drawing.Point(36, 26);
            this.rdbStatus1.Name = "rdbStatus1";
            this.rdbStatus1.Size = new System.Drawing.Size(82, 19);
            this.rdbStatus1.TabIndex = 7;
            this.rdbStatus1.TabStop = true;
            this.rdbStatus1.Text = "Школьник";
            this.rdbStatus1.UseVisualStyleBackColor = true;
            // 
            // rdbStatus2
            // 
            this.rdbStatus2.AutoSize = true;
            this.rdbStatus2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.rdbStatus2.Location = new System.Drawing.Point(36, 51);
            this.rdbStatus2.Name = "rdbStatus2";
            this.rdbStatus2.Size = new System.Drawing.Size(68, 19);
            this.rdbStatus2.TabIndex = 8;
            this.rdbStatus2.Text = "Студент";
            this.rdbStatus2.UseVisualStyleBackColor = true;
            // 
            // rdbStatus3
            // 
            this.rdbStatus3.AutoSize = true;
            this.rdbStatus3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.rdbStatus3.Location = new System.Drawing.Point(36, 77);
            this.rdbStatus3.Name = "rdbStatus3";
            this.rdbStatus3.Size = new System.Drawing.Size(77, 19);
            this.rdbStatus3.TabIndex = 9;
            this.rdbStatus3.Text = "Работник";
            this.rdbStatus3.UseVisualStyleBackColor = true;
            // 
            // grbStatus
            // 
            this.grbStatus.Controls.Add(this.rdbStatus3);
            this.grbStatus.Controls.Add(this.rdbStatus2);
            this.grbStatus.Controls.Add(this.rdbStatus1);
            this.grbStatus.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.grbStatus.Location = new System.Drawing.Point(18, 64);
            this.grbStatus.Name = "grbStatus";
            this.grbStatus.Size = new System.Drawing.Size(189, 132);
            this.grbStatus.TabIndex = 10;
            this.grbStatus.TabStop = false;
            this.grbStatus.Text = "Статус";
            // 
            // lblBooks
            // 
            this.lblBooks.AutoSize = true;
            this.lblBooks.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblBooks.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblBooks.Location = new System.Drawing.Point(230, 64);
            this.lblBooks.Name = "lblBooks";
            this.lblBooks.Size = new System.Drawing.Size(126, 15);
            this.lblBooks.TabIndex = 11;
            this.lblBooks.Text = "Список книг фондов";
            // 
            // lstBooks
            // 
            this.lstBooks.FormattingEnabled = true;
            this.lstBooks.ItemHeight = 15;
            this.lstBooks.Items.AddRange(new object[] {
            "",
            "",
            ""});
            this.lstBooks.Location = new System.Drawing.Point(230, 83);
            this.lstBooks.Name = "lstBooks";
            this.lstBooks.Size = new System.Drawing.Size(223, 109);
            this.lstBooks.TabIndex = 12;
            // 
            // chkBook
            // 
            this.chkBook.AutoSize = true;
            this.chkBook.ForeColor = System.Drawing.SystemColors.ControlText;
            this.chkBook.Location = new System.Drawing.Point(47, 213);
            this.chkBook.Name = "chkBook";
            this.chkBook.Size = new System.Drawing.Size(108, 19);
            this.chkBook.TabIndex = 13;
            this.chkBook.Text = "Книги на руках";
            this.chkBook.UseVisualStyleBackColor = true;
            // 
            // lblKol
            // 
            this.lblKol.AutoSize = true;
            this.lblKol.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblKol.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblKol.Location = new System.Drawing.Point(76, 246);
            this.lblKol.Name = "lblKol";
            this.lblKol.Size = new System.Drawing.Size(108, 15);
            this.lblKol.TabIndex = 14;
            this.lblKol.Text = "Количество дней";
            // 
            // txtKol
            // 
            this.txtKol.Location = new System.Drawing.Point(230, 243);
            this.txtKol.Name = "txtKol";
            this.txtKol.Size = new System.Drawing.Size(223, 23);
            this.txtKol.TabIndex = 15;
            // 
            // grbReader
            // 
            this.grbReader.Controls.Add(this.cmbReader);
            this.grbReader.Controls.Add(this.txtKol);
            this.grbReader.Controls.Add(this.lblKol);
            this.grbReader.Controls.Add(this.chkBook);
            this.grbReader.Controls.Add(this.lstBooks);
            this.grbReader.Controls.Add(this.lblBooks);
            this.grbReader.Controls.Add(this.grbStatus);
            this.grbReader.Controls.Add(this.lblReader);
            this.grbReader.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.grbReader.Location = new System.Drawing.Point(22, 19);
            this.grbReader.Name = "grbReader";
            this.grbReader.Size = new System.Drawing.Size(488, 281);
            this.grbReader.TabIndex = 16;
            this.grbReader.TabStop = false;
            this.grbReader.Text = "Карточка читателя";
            // 
            // cmbReader
            // 
            this.cmbReader.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbReader.FormattingEnabled = true;
            this.cmbReader.Location = new System.Drawing.Point(203, 29);
            this.cmbReader.Name = "cmbReader";
            this.cmbReader.Size = new System.Drawing.Size(265, 23);
            this.cmbReader.Sorted = true;
            this.cmbReader.TabIndex = 16;
            // 
            // lstInform
            // 
            this.lstInform.FormattingEnabled = true;
            this.lstInform.ItemHeight = 15;
            this.lstInform.Location = new System.Drawing.Point(18, 26);
            this.lstInform.Name = "lstInform";
            this.lstInform.Size = new System.Drawing.Size(450, 154);
            this.lstInform.TabIndex = 17;
            // 
            // grbInform
            // 
            this.grbInform.Controls.Add(this.lstInform);
            this.grbInform.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.grbInform.Location = new System.Drawing.Point(22, 313);
            this.grbInform.Name = "grbInform";
            this.grbInform.Size = new System.Drawing.Size(488, 194);
            this.grbInform.TabIndex = 18;
            this.grbInform.TabStop = false;
            this.grbInform.Text = "Информация";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(748, 523);
            this.Controls.Add(this.grbInform);
            this.Controls.Add(this.grbReader);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnVisibleInform);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.btnInform);
            this.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.Name = "Form1";
            this.Text = "Выдача литературы на дом";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.grbStatus.ResumeLayout(false);
            this.grbStatus.PerformLayout();
            this.grbReader.ResumeLayout(false);
            this.grbReader.PerformLayout();
            this.grbInform.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Button btnInform;
        private Button btnRemove;
        private Button btnClear;
        private Button btnVisibleInform;
        private Button btnExit;
        private Label lblReader;
        private RadioButton rdbStatus1;
        private RadioButton rdbStatus2;
        private RadioButton rdbStatus3;
        private GroupBox grbStatus;
        private Label lblBooks;
        private ListBox lstBooks;
        private CheckBox chkBook;
        private Label lblKol;
        private TextBox txtKol;
        private GroupBox grbReader;
        private ListBox lstInform;
        private GroupBox grbInform;
        private ComboBox cmbReader;
    }
}