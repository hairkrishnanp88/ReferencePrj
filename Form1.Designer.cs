namespace StoreProcedure
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.cmbDatabasename = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbTableName = new System.Windows.Forms.ComboBox();
            this.DataGridColumnName = new System.Windows.Forms.DataGridView();
            this.ColumnName = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Dublicate = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Where = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Entity = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.NullableEntity = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.OrderBy = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.btnInsertProc = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtProcedureName = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnSelect = new System.Windows.Forms.Button();
            this.btnInsert = new System.Windows.Forms.Button();
            this.btnEntityGenerate = new System.Windows.Forms.Button();
            this.btnEntity = new System.Windows.Forms.Button();
            this.txtCallfunctionName = new System.Windows.Forms.TextBox();
            this.lblCallFunctionName = new System.Windows.Forms.Label();
            this.btnUpdateFunction = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnSelectFunction = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnSelectProceduew = new System.Windows.Forms.Button();
            this.txtConnectionString = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnAssign = new System.Windows.Forms.Button();
            this.btnReassign = new System.Windows.Forms.Button();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridColumnName)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // cmbDatabasename
            // 
            this.cmbDatabasename.FormattingEnabled = true;
            this.cmbDatabasename.Location = new System.Drawing.Point(125, 13);
            this.cmbDatabasename.Name = "cmbDatabasename";
            this.cmbDatabasename.Size = new System.Drawing.Size(121, 21);
            this.cmbDatabasename.TabIndex = 0;
            this.cmbDatabasename.SelectedIndexChanged += new System.EventHandler(this.cmbDatabasename_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "DataBase Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Table Name";
            // 
            // cmbTableName
            // 
            this.cmbTableName.FormattingEnabled = true;
            this.cmbTableName.Location = new System.Drawing.Point(125, 43);
            this.cmbTableName.Name = "cmbTableName";
            this.cmbTableName.Size = new System.Drawing.Size(121, 21);
            this.cmbTableName.TabIndex = 2;
            this.cmbTableName.SelectedIndexChanged += new System.EventHandler(this.cmbTableName_SelectedIndexChanged);
            // 
            // DataGridColumnName
            // 
            this.DataGridColumnName.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridColumnName.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnName,
            this.Dublicate,
            this.Where,
            this.Entity,
            this.NullableEntity,
            this.OrderBy});
            this.DataGridColumnName.Location = new System.Drawing.Point(10, 235);
            this.DataGridColumnName.Name = "DataGridColumnName";
            this.DataGridColumnName.Size = new System.Drawing.Size(728, 453);
            this.DataGridColumnName.TabIndex = 4;
            this.DataGridColumnName.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridColumnName_CellContentClick);
            // 
            // ColumnName
            // 
            this.ColumnName.HeaderText = "Select";
            this.ColumnName.Name = "ColumnName";
            // 
            // Dublicate
            // 
            this.Dublicate.HeaderText = "Dublicate";
            this.Dublicate.Name = "Dublicate";
            // 
            // Where
            // 
            this.Where.HeaderText = "Where";
            this.Where.Name = "Where";
            // 
            // Entity
            // 
            this.Entity.HeaderText = "EntityGenrate";
            this.Entity.Name = "Entity";
            this.Entity.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // NullableEntity
            // 
            this.NullableEntity.HeaderText = "NullableEntity";
            this.NullableEntity.Name = "NullableEntity";
            // 
            // OrderBy
            // 
            this.OrderBy.HeaderText = "OrderBy";
            this.OrderBy.Name = "OrderBy";
            this.OrderBy.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // btnInsertProc
            // 
            this.btnInsertProc.Location = new System.Drawing.Point(25, 22);
            this.btnInsertProc.Name = "btnInsertProc";
            this.btnInsertProc.Size = new System.Drawing.Size(123, 34);
            this.btnInsertProc.TabIndex = 5;
            this.btnInsertProc.Text = "Insert Procedure";
            this.btnInsertProc.UseVisualStyleBackColor = true;
            this.btnInsertProc.Click += new System.EventHandler(this.btnInsertProc_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(5, 96);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(116, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Prefix Procedure Name";
            // 
            // txtProcedureName
            // 
            this.txtProcedureName.Location = new System.Drawing.Point(125, 96);
            this.txtProcedureName.Name = "txtProcedureName";
            this.txtProcedureName.Size = new System.Drawing.Size(121, 20);
            this.txtProcedureName.TabIndex = 8;
            this.txtProcedureName.Text = "sp";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(766, 235);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(411, 453);
            this.textBox1.TabIndex = 9;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(154, 22);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(144, 34);
            this.btnUpdate.TabIndex = 10;
            this.btnUpdate.Text = "Update Procedure";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnSelect
            // 
            this.btnSelect.Location = new System.Drawing.Point(52, 206);
            this.btnSelect.Name = "btnSelect";
            this.btnSelect.Size = new System.Drawing.Size(75, 23);
            this.btnSelect.TabIndex = 11;
            this.btnSelect.Text = "Select";
            this.btnSelect.UseVisualStyleBackColor = true;
            this.btnSelect.Click += new System.EventHandler(this.btnSelect_Click);
            // 
            // btnInsert
            // 
            this.btnInsert.Location = new System.Drawing.Point(343, 19);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(148, 28);
            this.btnInsert.TabIndex = 12;
            this.btnInsert.Text = "Insert Function";
            this.btnInsert.UseVisualStyleBackColor = true;
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // btnEntityGenerate
            // 
            this.btnEntityGenerate.Location = new System.Drawing.Point(35, 19);
            this.btnEntityGenerate.Name = "btnEntityGenerate";
            this.btnEntityGenerate.Size = new System.Drawing.Size(148, 28);
            this.btnEntityGenerate.TabIndex = 13;
            this.btnEntityGenerate.Text = "Entity Generate";
            this.btnEntityGenerate.UseVisualStyleBackColor = true;
            this.btnEntityGenerate.Click += new System.EventHandler(this.btnEntityGenerate_Click);
            // 
            // btnEntity
            // 
            this.btnEntity.Location = new System.Drawing.Point(365, 206);
            this.btnEntity.Name = "btnEntity";
            this.btnEntity.Size = new System.Drawing.Size(75, 23);
            this.btnEntity.TabIndex = 14;
            this.btnEntity.Text = "Entity";
            this.btnEntity.UseVisualStyleBackColor = true;
            this.btnEntity.Click += new System.EventHandler(this.btnEntity_Click);
            // 
            // txtCallfunctionName
            // 
            this.txtCallfunctionName.Location = new System.Drawing.Point(125, 122);
            this.txtCallfunctionName.Name = "txtCallfunctionName";
            this.txtCallfunctionName.Size = new System.Drawing.Size(121, 20);
            this.txtCallfunctionName.TabIndex = 16;
            this.txtCallfunctionName.Text = "return (SqlHelper.ExecuteNonQuery(strcon,";
            // 
            // lblCallFunctionName
            // 
            this.lblCallFunctionName.AutoSize = true;
            this.lblCallFunctionName.Location = new System.Drawing.Point(5, 122);
            this.lblCallFunctionName.Name = "lblCallFunctionName";
            this.lblCallFunctionName.Size = new System.Drawing.Size(116, 13);
            this.lblCallFunctionName.TabIndex = 15;
            this.lblCallFunctionName.Text = "Prefix Procedure Name";
            // 
            // btnUpdateFunction
            // 
            this.btnUpdateFunction.Location = new System.Drawing.Point(189, 19);
            this.btnUpdateFunction.Name = "btnUpdateFunction";
            this.btnUpdateFunction.Size = new System.Drawing.Size(148, 28);
            this.btnUpdateFunction.TabIndex = 17;
            this.btnUpdateFunction.Text = "Update Function";
            this.btnUpdateFunction.UseVisualStyleBackColor = true;
            this.btnUpdateFunction.Click += new System.EventHandler(this.btnUpdateFunction_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnSelectFunction);
            this.groupBox1.Controls.Add(this.btnEntityGenerate);
            this.groupBox1.Controls.Add(this.btnUpdateFunction);
            this.groupBox1.Controls.Add(this.btnInsert);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(278, 88);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(645, 54);
            this.groupBox1.TabIndex = 18;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Class File Write Code";
            // 
            // btnSelectFunction
            // 
            this.btnSelectFunction.Location = new System.Drawing.Point(497, 19);
            this.btnSelectFunction.Name = "btnSelectFunction";
            this.btnSelectFunction.Size = new System.Drawing.Size(148, 28);
            this.btnSelectFunction.TabIndex = 18;
            this.btnSelectFunction.Text = "View SelectForm";
            this.btnSelectFunction.UseVisualStyleBackColor = true;
            this.btnSelectFunction.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnSelectProceduew);
            this.groupBox2.Controls.Add(this.btnInsertProc);
            this.groupBox2.Controls.Add(this.btnUpdate);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(278, 9);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(460, 71);
            this.groupBox2.TabIndex = 18;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Store Procedure ";
            // 
            // btnSelectProceduew
            // 
            this.btnSelectProceduew.Location = new System.Drawing.Point(304, 21);
            this.btnSelectProceduew.Name = "btnSelectProceduew";
            this.btnSelectProceduew.Size = new System.Drawing.Size(144, 34);
            this.btnSelectProceduew.TabIndex = 11;
            this.btnSelectProceduew.Text = "Select Procedure";
            this.btnSelectProceduew.UseVisualStyleBackColor = true;
            this.btnSelectProceduew.Click += new System.EventHandler(this.btnSelectProceduew_Click);
            // 
            // txtConnectionString
            // 
            this.txtConnectionString.Location = new System.Drawing.Point(125, 70);
            this.txtConnectionString.Name = "txtConnectionString";
            this.txtConnectionString.Size = new System.Drawing.Size(121, 20);
            this.txtConnectionString.TabIndex = 20;
            this.txtConnectionString.TextChanged += new System.EventHandler(this.txtConnectionString_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(5, 70);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 13);
            this.label4.TabIndex = 19;
            this.label4.Text = "ConnectionString";
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(766, 13);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(79, 31);
            this.btnExit.TabIndex = 21;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnAssign
            // 
            this.btnAssign.Location = new System.Drawing.Point(754, 55);
            this.btnAssign.Name = "btnAssign";
            this.btnAssign.Size = new System.Drawing.Size(148, 28);
            this.btnAssign.TabIndex = 22;
            this.btnAssign.Text = "Assign";
            this.btnAssign.UseVisualStyleBackColor = true;
            this.btnAssign.Click += new System.EventHandler(this.btnAssign_Click);
            // 
            // btnReassign
            // 
            this.btnReassign.Location = new System.Drawing.Point(918, 59);
            this.btnReassign.Name = "btnReassign";
            this.btnReassign.Size = new System.Drawing.Size(148, 24);
            this.btnReassign.TabIndex = 23;
            this.btnReassign.Text = "Re Assign";
            this.btnReassign.UseVisualStyleBackColor = true;
            this.btnReassign.Click += new System.EventHandler(this.btnReassign_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1374, 700);
            this.Controls.Add(this.btnReassign);
            this.Controls.Add(this.btnAssign);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.txtConnectionString);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtCallfunctionName);
            this.Controls.Add(this.lblCallFunctionName);
            this.Controls.Add(this.btnEntity);
            this.Controls.Add(this.btnSelect);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.txtProcedureName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.DataGridColumnName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmbTableName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbDatabasename);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataGridColumnName)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbDatabasename;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbTableName;
        private System.Windows.Forms.DataGridView DataGridColumnName;
        private System.Windows.Forms.Button btnInsertProc;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtProcedureName;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnSelect;
        private System.Windows.Forms.Button btnInsert;
        private System.Windows.Forms.Button btnEntityGenerate;
        private System.Windows.Forms.Button btnEntity;
        private System.Windows.Forms.TextBox txtCallfunctionName;
        private System.Windows.Forms.Label lblCallFunctionName;
        private System.Windows.Forms.Button btnUpdateFunction;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtConnectionString;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnSelectFunction;
        private System.Windows.Forms.Button btnSelectProceduew;
        private System.Windows.Forms.DataGridViewCheckBoxColumn ColumnName;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Dublicate;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Where;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Entity;
        private System.Windows.Forms.DataGridViewCheckBoxColumn NullableEntity;
        private System.Windows.Forms.DataGridViewCheckBoxColumn OrderBy;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnAssign;
        private System.Windows.Forms.Button btnReassign;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}

