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
    public partial class SelectFunction : Form
    {
        public SelectFunction()
        {
            InitializeComponent();
        }

        private void SelectFunction_Load(object sender, EventArgs e)
        {
            FillDatabaseName();
            radioButton1.Checked = true;

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

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            radioButton2.Checked = false;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            radioButton1.Checked = false;
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
        int ColumnNameParameter = 3;
        private void btnReaderCode_Click(object sender, EventArgs e)
        {
            string strReaderContent = string.Empty;
            string strWhileloopContent = string.Empty;
            string strmobjList = string.Empty;
            string strmobjTable = string.Empty;
            string strmReturnObj = string.Empty;
            string strmSQLParameter = string.Empty;
            string strReaderParameter = string.Empty;


            strmSQLParameter = "SqlParameter[] sqlparams = {";
            if (radioButton1.Checked == true)
            {
                int rowCount = DataGridColumnName.Rows.Count;
                strmobjList = " mobjList" + cmbTableName.Text;
                strmobjTable = cmbTableName.Text + " mobj" + cmbTableName.Text + "= new " + cmbTableName.Text.Trim() + "();" + Environment.NewLine;
                strmReturnObj = strmobjList;
                strWhileloopContent += strmobjTable;

                for (int i = 0; i < rowCount; i++)
                {
                    if (Convert.ToBoolean(DataGridColumnName.Rows[i].Cells[ColumnNameParameter].Value) == true)
                    {
                        DbType dd = GetDbTypeByName(DataGridColumnName.Rows[i].Cells[ColumnNameDataType].Value.ToString());
                        if (dd == DbType.AnsiString)
                            dd = DbType.String;
                        strmSQLParameter += "new SqlParameter(" + "\"@" + DataGridColumnName.Rows[i].Cells[ColumnNameCellValue].Value + "\"" + ",(object)" + " p" + DataGridColumnName.Rows[i].Cells[ColumnNameCellValue].Value + "??(object)DBNull.Value), " + Environment.NewLine;

                        strReaderParameter += dd + " p" + DataGridColumnName.Rows[i].Cells[ColumnNameCellValue].Value + ",";
                        strmSQLParameter += "";
                    }
                    if (Convert.ToBoolean(DataGridColumnName.Rows[i].Cells[0].Value) == true)
                    {
                        DbType dd = GetDbTypeByName(DataGridColumnName.Rows[i].Cells[ColumnNameDataType].Value.ToString());
                        strWhileloopContent += Environment.NewLine + " mobj" + cmbTableName.Text + "." + DataGridColumnName.Rows[i].Cells[ColumnNameCellValue].Value + "= (reader[\"" + DataGridColumnName.Rows[i].Cells[ColumnNameCellValue].Value + "\"].ToString() == string.Empty" + EmptyDataType(dd.ToString()) + "\"" + DataGridColumnName.Rows[i].Cells[ColumnNameCellValue].Value + "\"" + "].ToString());";
                    }
                }

                strReaderContent = " internal List<" + cmbTableName.Text + "> List" + cmbTableName.Text + "(" + strReaderParameter.TrimEnd(',') + ")" + Environment.NewLine + "{" + Environment.NewLine;
                strReaderContent += "List<" + cmbTableName.Text + ">" + strmobjList + "=new List<" + cmbTableName.Text + ">" + "();";


                //strmobj.Add(objNotification);
            }
            else
            {
                int rowCount = DataGridColumnName.Rows.Count;
                strmobjList = " mobj" + cmbTableName.Text;
                strmReturnObj = strmobjList;
                for (int i = 0; i < rowCount; i++)
                {
                    if (Convert.ToBoolean(DataGridColumnName.Rows[i].Cells[ColumnNameParameter].Value) == true)
                    {
                        DbType dd = GetDbTypeByName(DataGridColumnName.Rows[i].Cells[ColumnNameDataType].Value.ToString());
                        if (dd == DbType.AnsiString)
                            dd = DbType.String;

                        strmSQLParameter += Environment.NewLine + "new SqlParameter(" + "\"@" + DataGridColumnName.Rows[i].Cells[ColumnNameCellValue].Value + "\"" + ",(object)" + " p" + DataGridColumnName.Rows[i].Cells[ColumnNameCellValue].Value + "??(object)DBNull.Value), ";
                        strReaderParameter += dd + " p" + DataGridColumnName.Rows[i].Cells[ColumnNameCellValue].Value + ",";
                    }
                    if (Convert.ToBoolean(DataGridColumnName.Rows[i].Cells[0].Value) == true)
                    {
                        DbType dd = GetDbTypeByName(DataGridColumnName.Rows[i].Cells[ColumnNameDataType].Value.ToString());
                        strWhileloopContent += Environment.NewLine + strmobjList + "." + DataGridColumnName.Rows[i].Cells[ColumnNameCellValue].Value + "= (reader[\"" + DataGridColumnName.Rows[i].Cells[ColumnNameCellValue].Value + "\"].ToString() == string.Empty" + EmptyDataType(dd.ToString()) + "\"" + DataGridColumnName.Rows[i].Cells[ColumnNameCellValue].Value + "\"" + "].ToString());";
                        // string mreplace="(DateTime)(reader["+"\"" + DataGridColumnName.Rows[i].Cells[ColumnNameCellValue].Value + "\"" + "].ToString());";

                        //strWhileloopContent.Replace(mreplace.Replace("\"", " "), "(DateTime)(reader[" + "\"" + DataGridColumnName.Rows[i].Cells[ColumnNameCellValue].Value + "\"" + "]");
                    }
                }
                strmSQLParameter = strmSQLParameter.TrimEnd(',');
                strReaderContent = " internal " + cmbTableName.Text + " Get" + cmbTableName.Text + "(" + strReaderParameter.TrimEnd(',') + ")" + Environment.NewLine + "{" + Environment.NewLine;
                strReaderContent += cmbTableName.Text + strmobjList + "=new " + cmbTableName.Text + "();";
            }
            strReaderContent += Environment.NewLine + strmSQLParameter + "};" + Environment.NewLine + "using (SqlDataReader reader = SqlHelper.ExecuteReader(strcon," + "\"" + txtProcedureName.Text + "\"" + " ))" + Environment.NewLine + "{" + Environment.NewLine + "if (reader.HasRows)" + Environment.NewLine + "{" + Environment.NewLine + "while (reader.Read())" + Environment.NewLine + "{" + strWhileloopContent.Replace("AnsiString", "string") + Environment.NewLine + "}" + Environment.NewLine + "}" + Environment.NewLine + "}" + Environment.NewLine + "return" + strmReturnObj + ";" + "}" + Environment.NewLine;





            textBox1.Text = strReaderContent;
        }
        public static string EmptyDataType(string dd)
        {
            string strValue = string.Empty;
            switch (dd)
            {
                case "int":
                    strValue = ")?0 : Convert.ToInt32(reader[";
                    break;
                case "Byte":
                    strValue = ")?0 : Convert.ToInt16(reader[";
                    break;
                case "Int32":
                    strValue = ")?0 : Convert.ToInt32(reader[";
                    break;
                case "Int64":
                    strValue = ")?0 : Convert.ToInt64(reader[";
                    break;
                case "Boolean":
                    strValue = ")?false : Convert.ToBoolean(reader[";
                    break;
                case "Guid":
                    strValue = ")?Guid.Empty : Guid.Parse(reader[";
                    break;
                case "AnsiString":
                    strValue = ")? string.Empty : (string)(reader[";
                    break;
                case "DateTime":
                    strValue = ")? DateTime.UtcNow : (DateTime)(reader[";
                    break;

            }
            return strValue;

        }
        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private System.Data.DbType GetDbTypeByName(string typeName)
        {
            if (typeName == "numeric")
                typeName = "Decimal";
            System.Data.SqlDbType sqlDbType = (SqlDbType)Enum.Parse(typeof(SqlDbType), typeName, true);

            SqlParameter paraConver = new SqlParameter();
            paraConver.SqlDbType = sqlDbType;
            return paraConver.DbType;
        }

        private void btnDisplay_Click(object sender, EventArgs e)
        {
            int rowCount = DataGridColumnName.Rows.Count;
            for (int i = 0; i <= rowCount - 1; i++)
            {
                DataGridColumnName.Rows[i].Cells[0].Value = true;
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form ff = new Form1();
            ff.Show();
            this.Hide();
        }

    }
}
