using StoreProcedure.Class;
using StoreProcedure.Class.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StoreProcedure
{
    public partial class JavascriptValidation : Form
    {
        public JavascriptValidation()
        {
            InitializeComponent();
        }

        private void JavascriptValidation_Load(object sender, EventArgs e)
        {
            FillDatabaseName();
        }
        SqlConnection con = new SqlConnection(ConfigurationManager.AppSettings["conn"].ToString());
        int ColumnNameCellValue = 5;
        int ColumnNameDataType = 6;
        private void FillDatabaseName()
        {
            cmbDatabasename.DataSource = GetDatabasename();
            cmbDatabasename.DisplayMember = "name";
            cmbDatabasename.ValueMember = "name";
        }
        private List<DataBase> GetDatabasename()
        {
            List<DataBase> objDblist = new List<DataBase>();
            con.Open();
            SqlCommand cmd = new SqlCommand("SELECT name FROM master..sysdatabases ORDER BY name", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    DataBase objDb = new DataBase();
                    objDb.name = (reader["Name"] == DBNull.Value) ? "" : (string)reader["Name"];
                    objDblist.Add(objDb);
                }
            }
            con.Close();
            return objDblist;
        }

        private void cmbDatabasename_SelectedIndexChanged(object sender, EventArgs e)
        {
            List<information_schema> objlistTableName = FillTableName();
            cmbTableName.DataSource = objlistTableName;
            cmbTableName.DisplayMember = "TABLE_NAME";
            cmbTableName.ValueMember = "TABLE_NAME";
        }
        private List<information_schema> FillTableName()
        {
            List<information_schema> objDblist = new List<information_schema>();
            con.Open();
            SqlCommand cmd = new SqlCommand("SELECT * FROM information_schema.tables WHERE TABLE_CATALOG='" + cmbDatabasename.Text + "' AND TABLE_TYPE='BASE TABLE' ORDER BY TABLE_NAME", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    information_schema objDb = new information_schema();
                    objDb.TABLE_CATALOG = (reader["TABLE_CATALOG"] == DBNull.Value) ? "" : (string)reader["TABLE_CATALOG"];
                    objDb.TABLE_NAME = (reader["TABLE_NAME"] == DBNull.Value) ? "" : (string)reader["TABLE_NAME"];
                    objDb.TABLE_TYPE = (reader["TABLE_TYPE"] == DBNull.Value) ? "" : (string)reader["TABLE_TYPE"];

                    objDblist.Add(objDb);
                }
            }
            con.Close();
            return objDblist;
        }

        private void cmbTableName_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataGridColumnName.DataSource = FillTableColumnName();

            DataGridColumnName.AutoGenerateColumns = false;
        }
        private List<TableColumnNames> FillTableColumnName()
        {
            List<TableColumnNames> objDblist = new List<TableColumnNames>();
            objDblist.Clear();
            con.Open();
            SqlCommand cmd = new SqlCommand("SELECT c.name ColumnName,t.Name AS DataType FROM sys.columns AS c JOIN sys.types AS t ON c.user_type_id=t.user_type_id WHERE OBJECT_NAME(c.OBJECT_ID) ='" + cmbTableName.Text + "'", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    TableColumnNames objDb = new TableColumnNames();
                    objDb.DataType = (reader["DataType"] == DBNull.Value) ? "" : (string)reader["DataType"];
                    objDb.ColumnName = (reader["ColumnName"] == DBNull.Value) ? "" : (string)reader["ColumnName"];
                    objDblist.Add(objDb);
                }
            }
            con.Close();
            return objDblist;
        }

        private void btnRequired_Click(object sender, EventArgs e)
        {
            int rowCount = DataGridColumnName.Rows.Count;
            for (int i = 0; i <= rowCount - 1; i++)
            {
                DataGridColumnName.Rows[i].Cells[0].Value = true;
            }
        }

        private void btnReaderCode_Click(object sender, EventArgs e)
        {
            string ErrorMsgLabel = "lblerrmsg";
            string JavascriptContent = string.Empty;
            string pageControlID = string.Empty;
            JavascriptContent = "function Validation() {" + Environment.NewLine;

            if (cmbPageControl.Text == "Master Page")
            {
                pageControlID = txtPageID.Text.Trim();
            }
            if (pageControlID != string.Empty)
                pageControlID += "_".Replace("__", "_");

            string strEmailValidaion = string.Empty;
            strEmailValidaion = "var reg = /^([A-Za-z0-9_\\-\\.])+\\@([A-Za-z0-9_\\-\\.])+\\.([A-Za-z]{2,4})$/;";


            JavascriptContent += "document.getElementById(\"" + pageControlID + ErrorMsgLabel + "\"" + ").innerHTML = \"" + "\";" + Environment.NewLine + strEmailValidaion + Environment.NewLine;


            int rowCount = DataGridColumnName.Rows.Count;


            for (int i = 0; i < rowCount; i++)
            {
                if (Convert.ToBoolean(DataGridColumnName.Rows[i].Cells[1].Value) == true)
                {
                    JavascriptContent += " var txt" + DataGridColumnName.Rows[i].Cells[ColumnNameCellValue].Value + "=document.getElementById(\"" + pageControlID + "txt" + DataGridColumnName.Rows[i].Cells[ColumnNameCellValue].Value + "\"" + ").value;" + Environment.NewLine + Environment.NewLine;
                    JavascriptContent += "if(txt" + DataGridColumnName.Rows[i].Cells[ColumnNameCellValue].Value + "==" + "\"" + "\"" + ")" + "{" + Environment.NewLine + "document.getElementById(\"" + pageControlID + ErrorMsgLabel + "\"" + ").innerHTML   =" + "\"" + "Please Provide " + DataGridColumnName.Rows[i].Cells[ColumnNameCellValue].Value + "\"" + ";" + Environment.NewLine;


                    JavascriptContent += "document.getElementById(\"" + pageControlID + DataGridColumnName.Rows[i].Cells[ColumnNameCellValue].Value + "\"" + ").focus();" + Environment.NewLine + "}" + Environment.NewLine + Environment.NewLine;

                    if (Convert.ToBoolean(DataGridColumnName.Rows[i].Cells[3].Value) == true)
                    {

                        JavascriptContent += " if (reg.test(" + DataGridColumnName.Rows[i].Cells[ColumnNameCellValue].Value + ") == false)" + "{" + Environment.NewLine + "document.getElementById(\"" + pageControlID + ErrorMsgLabel + "\"" + ").innerHTML   =" + "\"" + "Please provide valid " + DataGridColumnName.Rows[i].Cells[ColumnNameCellValue].Value + "\"" + ";" + Environment.NewLine;

                        JavascriptContent += "document.getElementById(\"" + pageControlID + DataGridColumnName.Rows[i].Cells[ColumnNameCellValue].Value + "\"" + ").focus();" + Environment.NewLine + "}" + Environment.NewLine + Environment.NewLine;
                    }

                }
            }
            textBox1.Text = JavascriptContent + "}" + Environment.NewLine;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int rowCount = DataGridColumnName.Rows.Count;
            for (int i = 0; i <= rowCount - 1; i++)
            {
                DataGridColumnName.Rows[i].Cells[1].Value = true;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int rowCount = DataGridColumnName.Rows.Count;

            string strIDContent = string.Empty;
            for (int i = 0; i < rowCount; i++)
            {
                if (Convert.ToBoolean(DataGridColumnName.Rows[i].Cells[1].Value) == true)
                {
                    // DataGridColumnName.Rows[i].Cells[2].Value = false;
                    strIDContent += "txt" + DataGridColumnName.Rows[i].Cells[ColumnNameCellValue].Value.ToString().ToLower() + Environment.NewLine;
                }
                if (Convert.ToBoolean(DataGridColumnName.Rows[i].Cells[2].Value) == true)
                {
                    //DataGridColumnName.Rows[i].Cells[1].Value = false;
                    strIDContent += "drp" + DataGridColumnName.Rows[i].Cells[ColumnNameCellValue].Value.ToString().ToLower() + Environment.NewLine;
                }
            }
            textBox1.Text = strIDContent;


            textBox1.Text += Environment.NewLine + Environment.NewLine + Environment.NewLine + Environment.NewLine;
            string ErrorMsgLabel = "lblerrmsg";
            string JavascriptContent = string.Empty;
            string pageControlID = string.Empty;
            JavascriptContent = "function Validation() {" + Environment.NewLine;

            if (cmbPageControl.Text == "Master Page")
            {
                pageControlID = txtPageID.Text.Trim();
            }
            if (pageControlID != string.Empty)
                pageControlID += "_".Replace("__", "_");

            string strEmailValidaion = string.Empty;
            strEmailValidaion = "var reg = /^([A-Za-z0-9_\\-\\.])+\\@([A-Za-z0-9_\\-\\.])+\\.([A-Za-z]{2,4})$/;";


            JavascriptContent += "document.getElementById(\"" + pageControlID + ErrorMsgLabel + "\"" + ").innerHTML = \"" + "\";" + Environment.NewLine + strEmailValidaion + Environment.NewLine;


            int rowCount1 = DataGridColumnName.Rows.Count;


            for (int i = 0; i < rowCount1; i++)
            {
                if (Convert.ToBoolean(DataGridColumnName.Rows[i].Cells[1].Value) == true)
                {
                    JavascriptContent += " var txt" + DataGridColumnName.Rows[i].Cells[ColumnNameCellValue].Value + "=document.getElementById(\"" + pageControlID + "txt" + DataGridColumnName.Rows[i].Cells[ColumnNameCellValue].Value + "\"" + ").value;" + Environment.NewLine + Environment.NewLine;
                    JavascriptContent += "if(txt" + DataGridColumnName.Rows[i].Cells[ColumnNameCellValue].Value + "==" + "\"" + "\"" + ")" + "{" + Environment.NewLine + "document.getElementById(\"" + pageControlID + ErrorMsgLabel + "\"" + ").innerHTML   =" + "\"" + "Please Provide " + DataGridColumnName.Rows[i].Cells[ColumnNameCellValue].Value + "\"" + ";" + Environment.NewLine;


                    JavascriptContent += "document.getElementById(\"" + pageControlID + DataGridColumnName.Rows[i].Cells[ColumnNameCellValue].Value + "\"" + ").focus();" + Environment.NewLine + "}" + Environment.NewLine + Environment.NewLine;

                    if (Convert.ToBoolean(DataGridColumnName.Rows[i].Cells[3].Value) == true)
                    {

                        JavascriptContent += " if (reg.test(" + DataGridColumnName.Rows[i].Cells[ColumnNameCellValue].Value + ") == false)" + "{" + Environment.NewLine + "document.getElementById(\"" + pageControlID + ErrorMsgLabel + "\"" + ").innerHTML   =" + "\"" + "Please provide valid " + DataGridColumnName.Rows[i].Cells[ColumnNameCellValue].Value + "\"" + ";" + Environment.NewLine;

                        JavascriptContent += "document.getElementById(\"" + pageControlID + DataGridColumnName.Rows[i].Cells[ColumnNameCellValue].Value + "\"" + ").focus();" + Environment.NewLine + "}" + Environment.NewLine + Environment.NewLine;
                    }

                }
                if (Convert.ToBoolean(DataGridColumnName.Rows[i].Cells[2].Value) == true)
                {
                    JavascriptContent += " var drp" + DataGridColumnName.Rows[i].Cells[ColumnNameCellValue].Value + "=document.getElementById(\"" + pageControlID + "drp" + DataGridColumnName.Rows[i].Cells[ColumnNameCellValue].Value + "\"" + ").value;" + Environment.NewLine + Environment.NewLine;
                    JavascriptContent += "if(drp" + DataGridColumnName.Rows[i].Cells[ColumnNameCellValue].Value + "==" + "\"" + "\"" + ")" + "{" + Environment.NewLine + "document.getElementById(\"" + pageControlID + ErrorMsgLabel + "\"" + ").innerHTML   =" + "\"" + "Please Provide " + DataGridColumnName.Rows[i].Cells[ColumnNameCellValue].Value + "\"" + ";" + Environment.NewLine;


                    JavascriptContent += "document.getElementById(\"" + pageControlID + DataGridColumnName.Rows[i].Cells[ColumnNameCellValue].Value + "\"" + ").focus();" + Environment.NewLine + "}" + Environment.NewLine + Environment.NewLine;

                    if (Convert.ToBoolean(DataGridColumnName.Rows[i].Cells[3].Value) == true)
                    {

                        JavascriptContent += " if (reg.test(" + DataGridColumnName.Rows[i].Cells[ColumnNameCellValue].Value + ") == false)" + "{" + Environment.NewLine + "document.getElementById(\"" + pageControlID + ErrorMsgLabel + "\"" + ").innerHTML   =" + "\"" + "Please provide valid " + DataGridColumnName.Rows[i].Cells[ColumnNameCellValue].Value + "\"" + ";" + Environment.NewLine;

                        JavascriptContent += "document.getElementById(\"" + pageControlID + DataGridColumnName.Rows[i].Cells[ColumnNameCellValue].Value + "\"" + ").focus();" + Environment.NewLine + "}" + Environment.NewLine + Environment.NewLine;
                    }

                }
            }
            textBox1.Text += JavascriptContent + "}" + Environment.NewLine;

            textBox1.Text += Environment.NewLine + Environment.NewLine + Environment.NewLine + Environment.NewLine;
            textBox1.Text += Environment.NewLine + Environment.NewLine + Environment.NewLine + Environment.NewLine;


            string strObjectClassname = string.Empty;
            strObjectClassname = "obj" + cmbTableName.Text;


            string ClassFileContect = cmbTableName.Text + " " + strObjectClassname + " =new " + cmbTableName.Text + "();" + Environment.NewLine;
            string strAssignClass = string.Empty;


            for (int i = 0; i <= rowCount - 1; i++)
            {
                if ((Convert.ToBoolean(DataGridColumnName.Rows[i].Cells[1].Value) == true))
                {
                    string pPrefix = string.Empty;
                    string pSuffix = string.Empty;
                    switch (getConvertstring(DataGridColumnName.Rows[i].Cells[ColumnNameDataType].Value.ToString().ToLower()))
                    {
                        case DbType.Guid:
                            pPrefix = "Guid.Parse(";
                            pSuffix = ")";
                            break;
                        case DbType.DateTime:
                            pPrefix = "DateTime.Parse(";
                            pSuffix = ")";
                            break;
                        case DbType.Decimal:
                            pPrefix = "Decimal.Parse(";
                            pSuffix = ")";
                            break;
                        case DbType.String:
                            pPrefix = "";
                            pSuffix = "";
                            break;
                    }
                    ClassFileContect += Environment.NewLine + strObjectClassname + "." + DataGridColumnName.Rows[i].Cells[ColumnNameCellValue].Value + "=" + pPrefix + "txt" + DataGridColumnName.Rows[i].Cells[ColumnNameCellValue].Value.ToString().ToLower() + ".Text" + pSuffix + ";";
                }
                if ((Convert.ToBoolean(DataGridColumnName.Rows[i].Cells[2].Value) == true))
                {
                    ClassFileContect += Environment.NewLine + strObjectClassname + "." + DataGridColumnName.Rows[i].Cells[ColumnNameCellValue].Value + "=txt" + DataGridColumnName.Rows[i].Cells[ColumnNameCellValue].Value.ToString().ToLower() + ".SelectedValue.ToString();";
                }
            }
            strAssignClass = ClassFileContect;
            textBox1.Text += strAssignClass + Environment.NewLine + " " + strObjectClassname + "=null;";



            textBox1.Text += Environment.NewLine + Environment.NewLine + Environment.NewLine + Environment.NewLine;
            textBox1.Text += Environment.NewLine + Environment.NewLine + Environment.NewLine + Environment.NewLine;



            string strObjectClass = string.Empty;
            strObjectClassname = "obj" + cmbTableName.Text;


            string ClassFile = string.Empty; ClassFile = cmbTableName.Text + " " + strObjectClass + " =new " + cmbTableName.Text + "();" + Environment.NewLine;
            string strAssign = string.Empty;


            for (int i = 0; i <= rowCount - 1; i++)
            {
                if ((Convert.ToBoolean(DataGridColumnName.Rows[i].Cells[1].Value) == true))
                {
                    ClassFile += "txt" + DataGridColumnName.Rows[i].Cells[ColumnNameCellValue].Value.ToString().ToLower() + ".Text=" + strObjectClass + "." + DataGridColumnName.Rows[i].Cells[ColumnNameCellValue].Value + ";" + Environment.NewLine;
                }
                if ((Convert.ToBoolean(DataGridColumnName.Rows[i].Cells[2].Value) == true))
                {
                    ClassFile += "drp" + DataGridColumnName.Rows[i].Cells[ColumnNameCellValue].Value.ToString().ToLower() + ".SelectedValue=" + strObjectClass + "." + DataGridColumnName.Rows[i].Cells[ColumnNameCellValue].Value + ";" + Environment.NewLine;
                }
            }


            strAssign = ClassFileContect;
            textBox1.Text += strAssign + Environment.NewLine + " " + strObjectClassname + "=null;";
        }

        private System.Data.DbType getConvertstring(string p)
        {

            System.Data.SqlDbType sqlDbType = (SqlDbType)Enum.Parse(typeof(SqlDbType), p, true);

            SqlParameter paraConver = new SqlParameter();
            paraConver.SqlDbType = sqlDbType;
            return paraConver.DbType;


        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form f1 = new Form1();
            f1.Show();
        }
    }
}
