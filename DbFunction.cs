using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Data;
using System.Configuration;
using System.Collections.Specialized;
using System.Data.Common;
using System.Configuration.Provider;

/// <summary>
/// Summary description for DbFunction
/// </summary>
public class DbFunction
{
    private const string connStringName = "dbconnection";
    private const string parmPrefix = "@";
    SqlConnection connection;
    SqlDataAdapter adapter;
    DataTable dTable;
    SqlCommand command;
    SqlDataReader dr;

    public static string strcon = System.Configuration.ConfigurationManager.ConnectionStrings["sqlcon"].ToString();

    public DbFunction()
    { }

    public SqlConnection OpenConnection()
    {
        connection = new SqlConnection(strcon);
        if (connection.State == ConnectionState.Closed)
            connection.Open();
        return (connection);
    }

    public void InitialiseComponents()
    {
        adapter = new SqlDataAdapter();
        command = new SqlCommand();
        dTable = new DataTable();
    }

    public void DisposeComponents()
    {
        adapter.Dispose();
        command.Dispose();
    }

    public void CloseConnection()
    {
        if (connection.State == ConnectionState.Open)
        {
            connection.Close();
            connection.Dispose();
        }
    }

    public DataTable ExecuteDTQuery(SqlCommand command)
    {
        InitialiseComponents();
        OpenConnection();
        command.Connection = connection;
        adapter.SelectCommand = command;
        adapter.Fill(dTable);
        CloseConnection();
        adapter.Dispose();
        return (dTable);
    }

    public SqlDataReader ExecuteDataReaderQuery()
    {
        InitialiseComponents();
        OpenConnection();
        command.Connection = connection;
        dr = command.ExecuteReader(CommandBehavior.CloseConnection);
        CloseConnection();
        return dr;
    }

    public string ExecuteScalar(string svlQuery)
    {
        string svlReturn;
        InitialiseComponents();
        OpenConnection();
        command.Connection = connection;
        command.CommandText = svlQuery;
        adapter.SelectCommand = command;
        svlReturn = adapter.SelectCommand.ExecuteScalar() == null ? "" : adapter.SelectCommand.ExecuteScalar().ToString();
        CloseConnection();
        return (svlReturn);
    }

    public string ExecuteScalar(SqlCommand command)
    {
        string svlReturn;
        InitialiseComponents();
        OpenConnection();
        command.Connection = connection;
        adapter.SelectCommand = command;
        svlReturn = adapter.SelectCommand.ExecuteScalar() == null ? "" : adapter.SelectCommand.ExecuteScalar().ToString();
        adapter.Dispose();
        CloseConnection();
        return (svlReturn);
    }

    public string ExecuteScalar(string sp_name, string ParameterName, string Value)
    {
        SqlCommand Cmd = new SqlCommand();
        Cmd.CommandType = CommandType.StoredProcedure;
        Cmd.CommandText = sp_name;
        if (!string.IsNullOrEmpty(ParameterName))
            Cmd.Parameters.AddWithValue(ParameterName, Value);
        return ExecuteScalar(Cmd);
    }

    public bool ExecuteNonQuery(string svlQuery)
    {
        int Result;
        InitialiseComponents();
        OpenConnection();
        command.Connection = connection;
        command.CommandText = svlQuery;
        Result = command.ExecuteNonQuery();
        CloseConnection();
        command.Dispose();
        return ((Result == 0) ? false : true);
    }

    public bool ExecuteNonQuery(SqlCommand command)
    {
        int Result;
        InitialiseComponents();
        OpenConnection();
        command.Connection = connection;
        Result = command.ExecuteNonQuery();
        CloseConnection();
        return ((Result == 0) ? false : true);
    }

    public static bool ExecuteNonQuerys(string sp_name, StringDictionary ParameterNameValues)
    {
        string connectionString = ConfigurationManager.ConnectionStrings[connStringName].ConnectionString;
        DbProviderFactory factory = DbProviderFactories.GetFactory(ConfigurationManager.ConnectionStrings[connStringName].ProviderName);
        using (DbConnection connection = factory.CreateConnection())
        {
            connection.ConnectionString = connectionString;
            connection.Open();
            using (DbCommand command = connection.CreateCommand())
            {
                command.CommandType = CommandType.StoredProcedure;
                command.CommandText = sp_name;
                if (ParameterNameValues != null)
                {
                    foreach (string ParameterName in ParameterNameValues.Keys)
                    {
                        string ParameterValue = ParameterNameValues[ParameterName];
                        if (!string.IsNullOrEmpty(ParameterName))
                        {
                            DbParameter parameter = factory.CreateParameter();
                            parameter.ParameterName = string.Concat(parmPrefix, ParameterName);
                            parameter.Value = ParameterValue;
                            command.Parameters.Add(parameter);
                        }
                    }
                }
                int num = command.ExecuteNonQuery();
                return (num != 0);
            }
        }
    }
}
