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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        SqlConnection con = new SqlConnection(ConfigurationManager.AppSettings["conn"].ToString());
        int ColumnNameCellValue = 7;
        int ColumnNameDataType = 8;
        int ColumnNameOrderBy = 5;
        int ColumnNameSelect = 8;
        private void Form1_Load(object sender, EventArgs e)
        {
            FillDatabaseName();
        }

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

        private void btnInsertProc_Click(object sender, EventArgs e)
        {

            string ProcedureName = string.Empty;
            string ProcedureColumnParameter = string.Empty;
            string ProcedureColumnName = string.Empty;
            string TableColumnName = string.Empty;
            string ProcedureContent = string.Empty;
            ProcedureName += txtProcedureName.Text.Trim() + "Insert" + cmbTableName.Text;

            List<StoreProc> objDblist = ListStoreProcedureName();

            string strLowerName = ProcedureName.Trim().ToLower();
            bool isResult = objDblist.FirstOrDefault(t => t.name.ToLower() == strLowerName) != null;
            if (isResult == true)
            {
                ProcedureContent += "CREATE Procedure " + ProcedureName + Environment.NewLine; ;
            }
            else
            {
                ProcedureContent += "ALTER Procedure " + ProcedureName + Environment.NewLine; ;
            }
            int rowCount = DataGridColumnName.Rows.Count;

            for (int i = 0; i < rowCount; i++)
            {
                if (Convert.ToBoolean(DataGridColumnName.Rows[i].Cells[0].Value) == false)
                {

                }
                else
                {
                    TableColumnName += DataGridColumnName.Rows[i].Cells[ColumnNameCellValue].Value + ",";
                    ProcedureColumnName += "@" + DataGridColumnName.Rows[i].Cells[ColumnNameCellValue].Value + ",";
                    ProcedureColumnParameter += "@" + DataGridColumnName.Rows[i].Cells[ColumnNameCellValue].Value + " " + DataGridColumnName.Rows[i].Cells[ColumnNameDataType].Value + ",";

                }
            }
            string strTableColumnName = TableColumnName.TrimEnd(','); ;
            TableColumnName = string.Empty;
            TableColumnName = RemoveCommaAddComma(strTableColumnName);


            string strProcedureColumnName = ProcedureColumnName.TrimEnd(','); ;
            ProcedureColumnName = string.Empty;
            ProcedureColumnName = RemoveCommaAddComma(strProcedureColumnName);



            string strProcedureColumnParameter = ProcedureColumnParameter.TrimEnd(','); ;
            ProcedureColumnParameter = string.Empty;
            ProcedureColumnParameter = RemoveCommaAddComma(strProcedureColumnParameter);



            ProcedureContent += ProcedureColumnParameter.TrimEnd(',') + Environment.NewLine + "AS" + Environment.NewLine + " BEGIN ";

            ProcedureContent += Environment.NewLine + "INSERT INTO " + cmbTableName.Text + " (" + TableColumnName.Remove(TableColumnName.Length - 1) + ") Values (" + ProcedureColumnName.TrimEnd(',') + ")" + Environment.NewLine + "END";
            textBox1.Text = ProcedureContent;
        }

        private List<StoreProc> ListStoreProcedureName()
        {
            List<StoreProc> objDblist = new List<StoreProc>();
            con.Open();
            SqlCommand cmd = new SqlCommand("SELECT name FROM sys.procedures", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    StoreProc objDb = new StoreProc();
                    objDb.name = (reader["name"] == DBNull.Value) ? "" : (string)reader["name"];


                    objDblist.Add(objDb);
                }
            }
            con.Close();
            return objDblist;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {

            string ProcedureName = string.Empty;
            string ProcedureColumnParameter = string.Empty;
            string ProcedureColumnName = string.Empty;
            string ProcedureUpdateColumnName = string.Empty;
            string ProcedureWhereColumnName = string.Empty;
            string TableColumnName = string.Empty;
            string ProcedureContent = string.Empty;
            ProcedureName += txtProcedureName.Text.Trim() + "Update" + cmbTableName.Text;

            List<StoreProc> objDblist = ListStoreProcedureName();

            string strLowerName = ProcedureName.Trim().ToLower();
            bool isResult = objDblist.FirstOrDefault(t => t.name == strLowerName) != null;
            if (isResult == true)
            {
                ProcedureContent += "CREATE Procedure " + ProcedureName + Environment.NewLine; ;
            }
            else
            {
                ProcedureContent += "ALTER Procedure " + ProcedureName + Environment.NewLine; ;
            }
            int rowCount = DataGridColumnName.Rows.Count;

            for (int i = 0; i < rowCount; i++)
            {
                if (Convert.ToBoolean(DataGridColumnName.Rows[i].Cells[0].Value) == true)
                {
                    TableColumnName += DataGridColumnName.Rows[i].Cells[ColumnNameCellValue].Value + ",";
                    ProcedureColumnName += "@" + DataGridColumnName.Rows[i].Cells[ColumnNameCellValue].Value + ",";
                    ProcedureColumnParameter += "@" + DataGridColumnName.Rows[i].Cells[ColumnNameCellValue].Value + " " + DataGridColumnName.Rows[i].Cells[ColumnNameDataType].Value + ",";
                    ProcedureUpdateColumnName += DataGridColumnName.Rows[i].Cells[ColumnNameCellValue].Value + "=@" + DataGridColumnName.Rows[i].Cells[ColumnNameCellValue].Value + " , ";
                }
                if (Convert.ToBoolean(DataGridColumnName.Rows[i].Cells[2].Value) == true)
                {
                    ProcedureWhereColumnName += DataGridColumnName.Rows[i].Cells[ColumnNameCellValue].Value + "=@" + DataGridColumnName.Rows[i].Cells[ColumnNameCellValue].Value + " AND ";
                }

            }

            string strTableColumnName = TableColumnName.TrimEnd(','); ;
            TableColumnName = string.Empty;
            TableColumnName = RemoveCommaAddComma(strTableColumnName);
            string strProcedureColumnName = ProcedureColumnName.TrimEnd(','); ;
            ProcedureColumnName = string.Empty;
            ProcedureColumnName = RemoveCommaAddComma(strProcedureColumnName);



            string strProcedureColumnParameter = ProcedureColumnParameter.TrimEnd(','); ;
            ProcedureColumnParameter = string.Empty;
            ProcedureColumnParameter = RemoveCommaAddComma(strProcedureColumnParameter);


            TableColumnName = TableColumnName.TrimEnd(',');
            TableColumnName = TableColumnName.Replace(Environment.NewLine + ",", "");

            ProcedureContent += ProcedureColumnParameter.TrimEnd(',') + Environment.NewLine + "AS " + Environment.NewLine + "BEGIN ";

            ProcedureContent += Environment.NewLine + "UPDATE " + cmbTableName.Text + " SET " + ProcedureUpdateColumnName.TrimEnd(',') + " WHERE  " + ProcedureWhereColumnName.Replace(" AND ", " ") + "" + Environment.NewLine + "END" + Environment.NewLine;
            textBox1.Text = ProcedureContent;
        }

        private static string RemoveCommaAddComma(string strValue)
        {
            string strTableColumnName = string.Empty;
            string[] strArray = strValue.Split(',');
            int p = 0;
            foreach (string obj in strArray)
            {
                p = p + 1;
                if (p == strArray.Count())
                {
                    strTableColumnName += obj + Environment.NewLine;
                }
                else
                {
                    strTableColumnName += obj + "," + Environment.NewLine;
                }
            }
            return strTableColumnName;
        }

        private void DataGridColumnName_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 2)
            {
                int rowCount = DataGridColumnName.Rows.Count;
                if (Convert.ToBoolean(DataGridColumnName.Rows[e.RowIndex].Cells[e.ColumnIndex].Value) == false)
                {
                    DataGridColumnName.Rows[e.RowIndex].Cells[0].Value = true;
                }
            }
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            int rowCount = DataGridColumnName.Rows.Count;
            for (int i = 0; i <= rowCount - 1; i++)
            {
                DataGridColumnName.Rows[i].Cells[0].Value = true;
            }
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {

            CreateFunction("Insert");




        }

        private void CreateFunction(string functionname)
        {

            string InsertFunctionContent = string.Empty;

            string StoreProcedurename = string.Empty;
            StoreProcedurename = txtProcedureName.Text.Trim() + functionname + cmbTableName.Text;
            string strOjbectName = string.Empty;
            strOjbectName = " p" + cmbTableName.Text + "";
            InsertFunctionContent += " internal bool Insert" + cmbTableName.Text + "(" + cmbTableName.Text + strOjbectName + ")" + Environment.NewLine + "{" + Environment.NewLine + "SqlParameter[] sqlparams = { " + Environment.NewLine;
            string strInsertParameter = string.Empty;

            int rowCount = DataGridColumnName.Rows.Count;

            for (int i = 0; i < rowCount; i++)
            {
                if (Convert.ToBoolean(DataGridColumnName.Rows[i].Cells[0].Value) == true)
                {
                    strInsertParameter += "new SqlParameter(" + "\"@" + DataGridColumnName.Rows[i].Cells[ColumnNameCellValue].Value + "\"" + ",(object)" + strOjbectName + "." + DataGridColumnName.Rows[i].Cells[ColumnNameCellValue].Value + "??(object)DBNull.Value), " + Environment.NewLine;
                }
            }

            string strInsParameter = string.Empty;
            strInsParameter = strInsertParameter.TrimEnd(',');

            textBox1.Text = InsertFunctionContent + strInsParameter + "};" + Environment.NewLine + txtCallfunctionName.Text.Trim() + "\"" + StoreProcedurename + "\", sqlparams) > 0);" + Environment.NewLine + "}";

        }

        private void btnEntity_Click(object sender, EventArgs e)
        {
            int rowCount = DataGridColumnName.Rows.Count;
            for (int i = 0; i <= rowCount - 1; i++)
            {
                DataGridColumnName.Rows[i].Cells[3].Value = true;
            }
        }

        private void btnEntityGenerate_Click(object sender, EventArgs e)
        {

            string strClassFileEntity = string.Empty;
            strClassFileEntity = cmbTableName.Text;


            string ClassFileContect = string.Empty;
            string ClassProperty = string.Empty;

            ClassFileContect += " public class " + strClassFileEntity + Environment.NewLine + "{" + Environment.NewLine;
            int rowCount = DataGridColumnName.Rows.Count;
            for (int i = 0; i <= rowCount - 1; i++)
            {
                if ((Convert.ToBoolean(DataGridColumnName.Rows[i].Cells[3].Value) == true) && (Convert.ToBoolean(DataGridColumnName.Rows[i].Cells[4].Value) == true))
                {
                    DbType dd = GetDbTypeByName(DataGridColumnName.Rows[i].Cells[ColumnNameDataType].Value.ToString());
                    if (dd == DbType.AnsiString)
                        dd = DbType.String;
                    ClassProperty += "public Nullable<" + dd + "> " + DataGridColumnName.Rows[i].Cells[ColumnNameCellValue].Value + " { get; set; }" + Environment.NewLine;
                }
                if (Convert.ToBoolean(DataGridColumnName.Rows[i].Cells[3].Value) == true)
                {
                    DbType dd = GetDbTypeByName(DataGridColumnName.Rows[i].Cells[ColumnNameDataType].Value.ToString());
                    if (dd == DbType.AnsiString)
                        dd = DbType.String;

                    ClassProperty += "public " + datatype(dd.ToString()) + " " + DataGridColumnName.Rows[i].Cells[ColumnNameCellValue].Value + " { get; set; }" + Environment.NewLine;
                }
            }
            ClassFileContect += ClassProperty.Replace("String", "string") + "}" + Environment.NewLine;
            textBox1.Text = ClassFileContect;
            saveFileDialog1.ShowDialog();
            saveFileDialog1.FileName = strClassFileEntity;



            System.IO.StreamWriter objstreamwriter = new System.IO.StreamWriter(saveFileDialog1.FileName + ".cs");
            objstreamwriter.Write(ClassFileContect);
            objstreamwriter.Close();
        }
        public static string datatype(string dd)
        {
            string strDatatype = dd;
            switch (dd)
            {
                case "Boolean": strDatatype = "bool";
                    break;
                case "Byte": strDatatype = "Int16";
                    break;
            }
            return strDatatype;
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

        private void btnUpdateFunction_Click(object sender, EventArgs e)
        {
            if (txtConnectionString.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Please enter connection string");
                return;
            }
            CreateFunction("Update");
        }

        private void txtConnectionString_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form f1 = new SelectFunction();
            f1.Show();
            this.Hide();
        }

        private void btnSelectProceduew_Click(object sender, EventArgs e)
        {
            string ProcedureName = string.Empty;
            string ProcedureColumnParameter = string.Empty;
            string ProcedureColumnName = string.Empty;
            string ProcedureUpdateColumnName = string.Empty;
            string ProcedureWhereColumnName = string.Empty;
            string TableColumnName = string.Empty;
            string ProcedureContent = string.Empty;

            string strOrderBy = string.Empty;


            ProcedureName += txtProcedureName.Text.Trim() + "Select" + cmbTableName.Text;

            List<StoreProc> objDblist = ListStoreProcedureName();

            string strLowerName = ProcedureName.Trim().ToLower();
            bool isResult = objDblist.FirstOrDefault(t => t.name == strLowerName) != null;
            if (isResult == true)
            {
                ProcedureContent += "CREATE Procedure " + ProcedureName + Environment.NewLine; ;
            }
            else
            {
                ProcedureContent += "ALTER Procedure " + ProcedureName + Environment.NewLine; ;
            }
            int rowCount = DataGridColumnName.Rows.Count;

            for (int i = 0; i < rowCount; i++)
            {
                if (Convert.ToBoolean(DataGridColumnName.Rows[i].Cells[0].Value) == true)
                {
                    TableColumnName += DataGridColumnName.Rows[i].Cells[ColumnNameCellValue].Value + ",";
                    ProcedureColumnName += DataGridColumnName.Rows[i].Cells[ColumnNameCellValue].Value + ",";
                    ProcedureColumnParameter += "@" + DataGridColumnName.Rows[i].Cells[ColumnNameCellValue].Value + " " + DataGridColumnName.Rows[i].Cells[ColumnNameDataType].Value + ",";
                    ProcedureUpdateColumnName += DataGridColumnName.Rows[i].Cells[ColumnNameCellValue].Value + "=@" + DataGridColumnName.Rows[i].Cells[ColumnNameCellValue].Value + " , ";
                }
                if (Convert.ToBoolean(DataGridColumnName.Rows[i].Cells[2].Value) == true)
                {
                    ProcedureWhereColumnName += DataGridColumnName.Rows[i].Cells[ColumnNameCellValue].Value + "=@" + DataGridColumnName.Rows[i].Cells[ColumnNameCellValue].Value + " AND ";
                }
                if (Convert.ToBoolean(DataGridColumnName.Rows[i].Cells[5].Value) == true)
                {
                    strOrderBy += "ORDER BY " + DataGridColumnName.Rows[i].Cells[ColumnNameCellValue].Value + " , ";
                }

            }



            TableColumnName = TableColumnName.TrimEnd(',');
            TableColumnName = TableColumnName.Replace(Environment.NewLine + ",", "");

            ProcedureContent += ProcedureColumnParameter.TrimEnd(',') + Environment.NewLine + "AS " + Environment.NewLine + "BEGIN ";

            ProcedureContent += Environment.NewLine + "SELECT " + TableColumnName.TrimEnd(',') + " FROM " + cmbTableName.Text + Environment.NewLine + " WHERE  " + ProcedureWhereColumnName.Replace(" AND ", " ") + " " + strOrderBy + Environment.NewLine + "END";
            textBox1.Text = ProcedureContent;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnAssign_Click(object sender, EventArgs e)
        {
            string strObjectClassname = string.Empty;
            strObjectClassname = "obj" + cmbTableName.Text;


            string ClassFileContect = cmbTableName.Text + " " + strObjectClassname + " =new " + cmbTableName.Text + "();" + Environment.NewLine;
            string strAssignClass = string.Empty;

            int rowCount = DataGridColumnName.Rows.Count;
            for (int i = 0; i <= rowCount - 1; i++)
            {
                if ((Convert.ToBoolean(DataGridColumnName.Rows[i].Cells[0].Value) == true))
                {
                    ClassFileContect += Environment.NewLine + strObjectClassname + "." + DataGridColumnName.Rows[i].Cells[ColumnNameCellValue].Value + "=";
                }
            }
            strAssignClass = ClassFileContect;
            textBox1.Text = strAssignClass + Environment.NewLine + " " + strObjectClassname + "=null;";
        }

        private void btnReassign_Click(object sender, EventArgs e)
        {
            string strObjectClassname = string.Empty;
            strObjectClassname = "obj" + cmbTableName.Text;


            string ClassFileContect = string.Empty; ClassFileContect = cmbTableName.Text + " " + strObjectClassname + " =new " + cmbTableName.Text + "();" + Environment.NewLine;
            string strAssignClass = string.Empty;

            int rowCount = DataGridColumnName.Rows.Count;
            for (int i = 0; i <= rowCount - 1; i++)
            {
                if ((Convert.ToBoolean(DataGridColumnName.Rows[i].Cells[0].Value) == true))
                {
                    ClassFileContect += "=" + strObjectClassname + "." + DataGridColumnName.Rows[i].Cells[ColumnNameCellValue].Value + ";" + Environment.NewLine;
                }
            }


            strAssignClass = ClassFileContect;
            textBox1.Text = strAssignClass + Environment.NewLine + " " + strObjectClassname + "=null;";
        }
    }
}