namespace StoreProcedure
{
    partial class JavascriptValidation
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(JavascriptValidation));
            this.label2 = new System.Windows.Forms.Label();
            this.cmbTableName = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbDatabasename = new System.Windows.Forms.ComboBox();
            this.DataGridColumnName = new System.Windows.Forms.DataGridView();
            this.Display = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.WHERE = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.OrderBy = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.EmailValidation = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.btnRequired = new System.Windows.Forms.Button();
            this.btnReaderCode = new System.Windows.Forms.Button();
            this.cmbPageControl = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtPageID = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridColumnName)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Table Name";
            // 
            // cmbTableName
            // 
            this.cmbTableName.FormattingEnabled = true;
            this.cmbTableName.Location = new System.Drawing.Point(121, 39);
            this.cmbTableName.Name = "cmbTableName";
            this.cmbTableName.Size = new System.Drawing.Size(121, 21);
            this.cmbTableName.TabIndex = 10;
            this.cmbTableName.SelectedIndexChanged += new System.EventHandler(this.cmbTableName_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "DataBase Name";
            // 
            // cmbDatabasename
            // 
            this.cmbDatabasename.FormattingEnabled = true;
            this.cmbDatabasename.Location = new System.Drawing.Point(121, 10);
            this.cmbDatabasename.Name = "cmbDatabasename";
            this.cmbDatabasename.Size = new System.Drawing.Size(121, 21);
            this.cmbDatabasename.TabIndex = 8;
            this.cmbDatabasename.SelectedIndexChanged += new System.EventHandler(this.cmbDatabasename_SelectedIndexChanged);
            // 
            // DataGridColumnName
            // 
            this.DataGridColumnName.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridColumnName.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Display,
            this.WHERE,
            this.OrderBy,
            this.EmailValidation});
            this.DataGridColumnName.Location = new System.Drawing.Point(3, 167);
            this.DataGridColumnName.Name = "DataGridColumnName";
            this.DataGridColumnName.Size = new System.Drawing.Size(839, 548);
            this.DataGridColumnName.TabIndex = 12;
            // 
            // Display
            // 
            this.Display.HeaderText = "Validation Required";
            this.Display.Name = "Display";
            // 
            // WHERE
            // 
            this.WHERE.HeaderText = "TextBox";
            this.WHERE.Name = "WHERE";
            // 
            // OrderBy
            // 
            this.OrderBy.HeaderText = "Dropdown";
            this.OrderBy.Name = "OrderBy";
            // 
            // EmailValidation
            // 
            this.EmailValidation.HeaderText = "EmailValidation";
            this.EmailValidation.Name = "EmailValidation";
            // 
            // btnRequired
            // 
            this.btnRequired.Location = new System.Drawing.Point(46, 138);
            this.btnRequired.Name = "btnRequired";
            this.btnRequired.Size = new System.Drawing.Size(75, 23);
            this.btnRequired.TabIndex = 13;
            this.btnRequired.Text = "Reqired";
            this.btnRequired.UseVisualStyleBackColor = true;
            this.btnRequired.Click += new System.EventHandler(this.btnRequired_Click);
            // 
            // btnReaderCode
            // 
            this.btnReaderCode.Location = new System.Drawing.Point(232, 138);
            this.btnReaderCode.Name = "btnReaderCode";
            this.btnReaderCode.Size = new System.Drawing.Size(123, 23);
            this.btnReaderCode.TabIndex = 14;
            this.btnReaderCode.Text = "Validation Code";
            this.btnReaderCode.UseVisualStyleBackColor = true;
            this.btnReaderCode.Click += new System.EventHandler(this.btnReaderCode_Click);
            // 
            // cmbPageControl
            // 
            this.cmbPageControl.FormattingEnabled = true;
            this.cmbPageControl.Items.AddRange(new object[] {
            "Master Page",
            "Normal Page"});
            this.cmbPageControl.Location = new System.Drawing.Point(121, 66);
            this.cmbPageControl.Name = "cmbPageControl";
            this.cmbPageControl.Size = new System.Drawing.Size(121, 21);
            this.cmbPageControl.TabIndex = 15;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 96);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 13);
            this.label3.TabIndex = 17;
            this.label3.Text = "Master Page ID";
            // 
            // txtPageID
            // 
            this.txtPageID.Location = new System.Drawing.Point(121, 93);
            this.txtPageID.Name = "txtPageID";
            this.txtPageID.Size = new System.Drawing.Size(121, 20);
            this.txtPageID.TabIndex = 16;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(848, 167);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(459, 548);
            this.textBox1.TabIndex = 18;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(140, 138);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 19;
            this.button1.Text = "Select";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(371, 138);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(123, 23);
            this.button2.TabIndex = 20;
            this.button2.Text = "ID Generation";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(24, 69);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 13);
            this.label4.TabIndex = 21;
            this.label4.Text = "Page Type";
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(511, 138);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(123, 23);
            this.btnExit.TabIndex = 22;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(575, 37);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(123, 23);
            this.button3.TabIndex = 23;
            this.button3.Text = "Exit";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // JavascriptValidation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1310, 715);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtPageID);
            this.Controls.Add(this.cmbPageControl);
            this.Controls.Add(this.btnReaderCode);
            this.Controls.Add(this.btnRequired);
            this.Controls.Add(this.DataGridColumnName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmbTableName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbDatabasename);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "JavascriptValidation";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "JavascriptValidation";
            this.Load += new System.EventHandler(this.JavascriptValidation_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataGridColumnName)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbTableName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbDatabasename;
        private System.Windows.Forms.DataGridView DataGridColumnName;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Display;
        private System.Windows.Forms.DataGridViewCheckBoxColumn WHERE;
        private System.Windows.Forms.DataGridViewCheckBoxColumn OrderBy;
        private System.Windows.Forms.Button btnRequired;
        private System.Windows.Forms.Button btnReaderCode;
        private System.Windows.Forms.ComboBox cmbPageControl;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtPageID;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.DataGridViewCheckBoxColumn EmailValidation;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button button3;
    }
}