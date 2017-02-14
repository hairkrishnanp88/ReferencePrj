rters
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace DBScript
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        string primaryKey, updateqry, Insertqry;

        string updateAdd = "";
        string cnString1 = @"Data Source=TeamKonnect\TeamKonnect; Initial Catalog=ERSProSpector; User ID=TeamKonnect; Password=PA33word; Connection Timeout=60000;";

        public void Run(string cnString)
        {
          
            string values, IDValues = "", insqry, upqry;
            int i = 0;
            SqlDataReader myReader;
            SqlConnection mySqlConnection = new SqlConnection();
            SqlConnection mSqlConnection = new SqlConnection();
            SqlCommand mySqlCommand = new SqlCommand();
            SqlCommand msqlCommand = new SqlCommand(); 
            string cnnString = @"Data Source=TeamKonnect\TeamKonnect; Initial Catalog=ERSProSpector; User ID=TeamKonnect; Password=PA33word; Connection Timeout=60000;";
            mSqlConnection = new SqlConnection(cnnString);
            mySqlConnection = new SqlConnection(cnnString);
            mySqlCommand = new SqlCommand("select * from " + textBox1.Text.Trim() , mySqlConnection);

            primaryKey = GetprimaryKey(textBox1.Text.Trim(), cnnString);
            insqry = "";
            mySqlConnection.Open();

            myReader = mySqlCommand.ExecuteReader();
            if (myReader != null)
            {
                while (myReader.Read())
                {// i this variable counts the total number of record
                    i = i + 1;// once a query is written, next it is available
                    // should be empty to build query again
                    updateAdd = "";
                    insqry = "";

                    string celldata = "", coulmenName = "";
                    for (int j = 0; j < myReader.FieldCount; j++)
                    {
                        // this empty at each reader to assign new values
                        // celldata contains data or value of field Like (1,Idrees)
                        // coulmen contain the Name of Cell Like ID,Name
                        if (j > 0)
                        {
                            // this condition is used for "," 
                            //in insert and update query
                            {
                                coulmenName += "," + myReader.GetName(j).ToString();
                                switch (myReader.GetDataTypeName(j).ToString())
                                {
                                    case "bit":
                                        if (myReader[j].ToString().ToLower() == "false")
                                            celldata += ",0";
                                        else if (myReader[j].ToString().ToLower() == "true")
                                            celldata += ",1";
                                        else
                                            celldata += ",NULL";
                                        break;
                                    case "uniqueidentifier":
                                        if (myReader[j].ToString() == "")
                                            celldata += ",NULL";
                                        else
                                            celldata += ",'" + myReader[j].ToString() + "'";
                                        break;
                                    case "datetime":
                                        if (myReader[j].ToString() == "")
                                            celldata += ",NULL";
                                        else
                                            celldata += ",'" + myReader[j].ToString() + "'";
                                        break;

                                    default:

                                        if (myReader.IsDBNull(j))
                                        {
                                            celldata += ",'" + myReader[j].ToString() + "'";
                                        }
                                        else
                                        {
                                            celldata += ",'" + myReader[j].ToString() + "'";
                                        }
                                        break;
                                }

                            }
                        }
                        else
                        {
                            coulmenName += myReader.GetName(j).ToString();
                            switch (myReader.GetDataTypeName(j).ToString())
                            {
                                case "bit":
                                    if (myReader[j].ToString().ToLower() == "false")
                                        celldata += ",0";
                                    else if (myReader[j].ToString().ToLower() == "true")
                                        celldata += ",1";
                                    else
                                        celldata += ",NULL";
                                    break;
                                default:
                                    celldata += ",'" + myReader[j].ToString() + "'";
                                    break;
                            }
                        }
                        if (primaryKey == myReader.GetName(j).ToString())
                        {
                            IDValues = myReader[j].ToString();
                        }
                        if (IDValues != null)
                        {
                            //Generates the update Query
                            upqry = UpdateQuery(coulmenName, celldata,
                      primaryKey, IDValues);
                            updateAdd += upqry;
                            //Generates the Insert Query
                            insqry = InsertQuery(coulmenName, celldata.TrimStart(','), textBox1.Text.Trim());
                        }
                        ThreadStart ts = new ThreadStart(run);
                        Thread thrd = new Thread(ts);
                        // start thread

                        label1.Text = i.ToString();
                    }

                    WriteScripts(textBox1.Text.Trim(), insqry,
             updateAdd, IDValues, primaryKey, i);
                }
                MessageBox.Show("Total number of record in database are=" + i);
            }
        }
        static void run()
        {
            for (int i = 0; i < 10; i++)
            {
                //MessageBox.Show("Sub Thread value is : " + i);
                Thread.Sleep(1000);
            }
            //MessageBox.Show("Good Bye!!!I'm Sub Thread");
        }


        public string GetprimaryKey(string tableName, string cnnString)
        {
            string names, ID = "";
            SqlDataReader mReader;
            SqlConnection mSqlConnection = new SqlConnection();
            SqlCommand mSqlCommand = new SqlCommand();
            string cnString = cnString1;
            mSqlConnection = new SqlConnection(cnString);
            mSqlConnection.Open();	// sp_pkeys is SQL server default store procedure
            // you just pass it only table Name it will return
            // primary key column
            mSqlCommand = new SqlCommand("sp_pkeys", mSqlConnection);
            mSqlCommand.CommandType = CommandType.StoredProcedure;
            mSqlCommand.Parameters.Add("@table_name",
                          SqlDbType.NVarChar).Value = tableName;
            mReader = mSqlCommand.ExecuteReader();
            while (mReader.Read())
            {// the primary key column reside at 4 index
                ID = mReader[3].ToString();
            }
            return ID;
        }


        #region this methods return  ID values to compare for insert or Update
        public void WriteScripts(string tableName, string insertqry,
           string updateqry, string IDvalues, string PrimaryKey, int i)
        {
            string script = "";



            if (i == 1)
            { 

                script += insertqry + "" + Environment.NewLine;

 
                StreamWriter sw = new StreamWriter(@"d:\" + textBox1.Text.Trim() + ".txt", true, Encoding.UTF8);
                sw.Write(script);
                sw.Close();
            }
            else
            {

                script += insertqry + "" + Environment.NewLine;
                 
                StreamWriter sw = new StreamWriter
                        (@"d:\" + textBox1.Text.Trim() + ".txt", true, Encoding.UTF8);
                sw.Write(script);
                sw.Close();
            }
        }
        #endregion

        #region this methods return insert query and update query
        public string InsertQuery(string coulmenName, string celldata, string TableName)
        {
            return Insertqry = "insert into " + TableName +
            "(" + coulmenName + ")values(" + celldata + ")";
        }

        public string UpdateQuery
        (string coulmenName, string celldata, string Name, string Value)
        {
            string IDName, IDValue, Ud = "", name = "", values = "";
            IDName = Name;
            IDValue = Value;
            if (IDName != null)
            {
                int indexcolumn = coulmenName.LastIndexOf(",");
                int indexValues = celldata.LastIndexOf(",");
                if (indexcolumn > 0 && indexValues > 0)
                {
                    coulmenName = coulmenName.Substring(indexcolumn);
                    celldata = celldata.Substring(indexValues);
                    name = coulmenName.Replace(",", "");
                    values = celldata.Replace(",", "");
                    if (name != IDName && values != IDValue)
                    {
                        Ud = name + "=" + values + ",";
                    }
                }
                else
                {
                    name = coulmenName;
                    values = celldata;
                    if (name != IDName && values != IDValue)
                    {
                        Ud = name + "=" + values + ",";
                    }
                }
            }
            return Ud;
        }
        #endregion

        private void button1_Click(object sender, EventArgs e)
        {
            Run(@"Server=tcp:rsfwui14yt.database.windows.net,1433; Database=teamkonnectdb; User ID=ERSCloud@rsfwui14yt; Password=PA33word; Trusted_Connection=False; Encrypt=True; Connection Timeout=30; TrustServerCertificate=True;");
            MessageBox.Show("Complated");
        }
    }
}
