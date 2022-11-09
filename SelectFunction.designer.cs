namespace StoreProcedure
{
    partial class SelectFunction
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SelectFunction));
            this.label2 = new System.Windows.Forms.Label();
            this.cmbTableName = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbDatabasename = new System.Windows.Forms.ComboBox();
            this.DataGridColumnName = new System.Windows.Forms.DataGridView();
            this.Display = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.WHERE = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.OrderBy = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.SPParameter = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.btnReaderCode = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.txtProcedureName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnDisplay = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridColumnName)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 113);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Table Name";
            // 
            // cmbTableName
            // 
            this.cmbTableName.FormattingEnabled = true;
            this.cmbTableName.Location = new System.Drawing.Point(128, 105);
            this.cmbTableName.Name = "cmbTableName";
            this.cmbTableName.Size = new System.Drawing.Size(121, 21);
            this.cmbTableName.TabIndex = 6;
            this.cmbTableName.SelectedIndexChanged += new System.EventHandler(this.cmbTableName_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "DataBase Name";
            // 
            // cmbDatabasename
            // 
            this.cmbDatabasename.FormattingEnabled = true;
            this.cmbDatabasename.Location = new System.Drawing.Point(128, 33);
            this.cmbDatabasename.Name = "cmbDatabasename";
            this.cmbDatabasename.Size = new System.Drawing.Size(121, 21);
            this.cmbDatabasename.TabIndex = 4;
            this.cmbDatabasename.SelectedIndexChanged += new System.EventHandler(this.cmbDatabasename_SelectedIndexChanged);
            // 
            // DataGridColumnName
            // 
            this.DataGridColumnName.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridColumnName.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Display,
            this.WHERE,
            this.OrderBy,
            this.SPParameter});
            this.DataGridColumnName.Location = new System.Drawing.Point(12, 243);
            this.DataGridColumnName.Name = "DataGridColumnName";
            this.DataGridColumnName.Size = new System.Drawing.Size(728, 409);
            this.DataGridColumnName.TabIndex = 8;
            // 
            // Display
            // 
            this.Display.HeaderText = "Display";
            this.Display.Name = "Display";
            // 
            // WHERE
            // 
            this.WHERE.HeaderText = "WHER";
            this.WHERE.Name = "WHERE";
            // 
            // OrderBy
            // 
            this.OrderBy.HeaderText = "OrderBy";
            this.OrderBy.Name = "OrderBy";
            // 
            // SPParameter
            // 
            this.SPParameter.HeaderText = "SPParameter";
            this.SPParameter.Name = "SPParameter";
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(180, 166);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(98, 17);
            this.radioButton1.TabIndex = 9;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "List Of Records";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(305, 166);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(92, 17);
            this.radioButton2.TabIndex = 10;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Single Record";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // btnReaderCode
            // 
            this.btnReaderCode.Location = new System.Drawing.Point(518, 113);
            this.btnReaderCode.Name = "btnReaderCode";
            this.btnReaderCode.Size = new System.Drawing.Size(123, 70);
            this.btnReaderCode.TabIndex = 11;
            this.btnReaderCode.Text = "Reader Write";
            this.btnReaderCode.UseVisualStyleBackColor = true;
            this.btnReaderCode.Click += new System.EventHandler(this.btnReaderCode_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(746, 243);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(500, 409);
            this.textBox1.TabIndex = 12;
            // 
            // txtProcedureName
            // 
            this.txtProcedureName.Location = new System.Drawing.Point(518, 41);
            this.txtProcedureName.Name = "txtProcedureName";
            this.txtProcedureName.Size = new System.Drawing.Size(100, 20);
            this.txtProcedureName.TabIndex = 13;
            this.txtProcedureName.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(381, 44);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 13);
            this.label3.TabIndex = 14;
            this.label3.Text = "Procedurename";
            // 
            // btnDisplay
            // 
            this.btnDisplay.Location = new System.Drawing.Point(61, 201);
            this.btnDisplay.Name = "btnDisplay";
            this.btnDisplay.Size = new System.Drawing.Size(123, 36);
            this.btnDisplay.TabIndex = 15;
            this.btnDisplay.Text = "Display";
            this.btnDisplay.UseVisualStyleBackColor = true;
            this.btnDisplay.Click += new System.EventHandler(this.btnDisplay_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(670, 113);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(123, 70);
            this.btnExit.TabIndex = 16;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(799, 113);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(123, 70);
            this.button1.TabIndex = 17;
            this.button1.Text = "View Form1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // SelectFunction
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1277, 692);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnDisplay);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtProcedureName);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btnReaderCode);
            this.Controls.Add(this.radioButton2);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.DataGridColumnName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmbTableName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbDatabasename);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SelectFunction";
            this.Text = "SelectFunction";
            this.Load += new System.EventHandler(this.SelectFunction_Load);
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
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.Button btnReaderCode;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox txtProcedureName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridViewCheckBoxColumn SPParameter;
        private System.Windows.Forms.Button btnDisplay;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button button1;
    }
}