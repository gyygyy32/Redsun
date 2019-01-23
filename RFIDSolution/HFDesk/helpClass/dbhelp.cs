﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.Common;
using System.Reflection;
using System.Text.RegularExpressions;
//using MySql.Data.MySqlClient;


/// <summary>
/// 通用数据库访问类，封装了对数据库的常见操作
/// 作者：周公
/// 日期：2011-07-18
/// 博客地址：http://blog.csdn.net/zhoufoxcn 或http://zhoufoxcn.blog.51cto.com
/// 说明：(1)任何人都可以免费使用，请尽量保持此段说明。
///      (2)这个版本还不是最终版本，有任何意见或建议请到http://weibo.com/zhoufoxcn处留言。
/// </summary>
public sealed class DbUtility
{
    public string ConnectionString { get; private set; }
    private DbProviderFactory providerFactory;
    /// <summary>
    /// 构造函数
    /// </summary>
    /// <param name="connectionString">数据库连接字符串</param>
    /// <param name="providerType">数据库类型枚举，参见<paramref name="providerType"/></param>
    public DbUtility(string connectionString, DbProviderType providerType)
    {
        ConnectionString = connectionString;
        providerFactory = ProviderFactory.GetDbProviderFactory(providerType);
        if (providerFactory == null)
        {
            throw new ArgumentException("Can't load DbProviderFactory for given value of providerType");
        }
    }
    public DbConnection createConn()
    {
        DbConnection dbconn=
         providerFactory.CreateConnection();
        dbconn.ConnectionString = ConnectionString;
        return dbconn;
    }
    /// <summary>   
    /// 对数据库执行增删改操作，返回受影响的行数。   
    /// </summary>   
    /// <param name="sql">要执行的增删改的SQL语句</param>   
    /// <param name="parameters">执行增删改语句所需要的参数</param>
    /// <returns></returns>  
    public int ExecuteNonQuery(string sql, IList<DbParameter> parameters)
    {
        return ExecuteNonQuery(sql, parameters, CommandType.Text);
    }
    public int ExecuteNonQuery(DbTransaction dbtrans,string sql, IList<DbParameter> parameters)
    {
        return ExecuteNonQuery( dbtrans ,sql, parameters, CommandType.Text);
    }
    /// <summary>   
    /// 对数据库执行增删改操作，返回受影响的行数。   
    /// </summary>   
    /// <param name="sql">要执行的增删改的SQL语句</param>   
    /// <param name="parameters">执行增删改语句所需要的参数</param>
    /// <param name="commandType">执行的SQL语句的类型</param>
    /// <returns></returns>
    public int ExecuteNonQuery(string sql, IList<DbParameter> parameters, CommandType commandType)
    {

        using (DbCommand command = CreateDbCommand(sql, parameters, commandType))
        {
            command.Connection.Open();
            int affectedRows = command.ExecuteNonQuery();
            command.Connection.Close();
            return affectedRows;
        }  
    }
    public  int ExecuteNonQuery  (DbTransaction dbtrans,string sql, IList<DbParameter> parameters, CommandType commandType)
    {

        using (DbCommand command = CreateDbCommand(dbtrans,sql, parameters, commandType))
        {
            //command.Connection.Open();
            
            int affectedRows = command.ExecuteNonQuery();
            //command.Connection.Close();
            return affectedRows;
        }
    }
    /// <summary>   
    /// 执行一个查询语句，返回一个关联的DataReader实例   
    /// </summary>   
    /// <param name="sql">要执行的查询语句</param>   
    /// <param name="parameters">执行SQL查询语句所需要的参数</param>
    /// <returns></returns> 
    public DbDataReader ExecuteReader(string sql, IList<DbParameter> parameters)
    {
        return ExecuteReader(sql, parameters, CommandType.Text);
    }
    /// <summary>   
    /// 执行一个查询语句，返回一个关联的DataReader实例   
    /// </summary>   
    /// <param name="sql">要执行的查询语句</param>   
    /// <param name="parameters">执行SQL查询语句所需要的参数</param>
    /// <param name="commandType">执行的SQL语句的类型</param>
    /// <returns></returns> 
    public DbDataReader ExecuteReader(string sql, IList<DbParameter> parameters, CommandType commandType)
    {
        DbDataReader reader = null;
        DbCommand command = CreateDbCommand(sql, parameters, commandType);
        try
        {
            
            command.Connection.Open();
            reader = command.ExecuteReader(CommandBehavior.CloseConnection);
            //command.Connection.Close();
            return reader;
        }
        catch (Exception ex)
        {
            command.Connection.Close();
            throw new Exception(ex.ToString());
            
        }
        
        
    }
    /// <summary>   
    /// 执行一个查询语句，返回一个包含查询结果的DataTable   
    /// </summary>   
    /// <param name="sql">要执行的查询语句</param>   
    /// <param name="parameters">执行SQL查询语句所需要的参数</param>
    /// <returns></returns>
    public DataTable ExecuteDataTable(string sql, IList<DbParameter> parameters)
    {
        return ExecuteDataTable(sql, parameters, CommandType.Text);
    }
    /// <summary>   
    /// 执行一个查询语句，返回一个包含查询结果的DataTable   
    /// </summary>   
    /// <param name="sql">要执行的查询语句</param>   
    /// <param name="parameters">执行SQL查询语句所需要的参数</param>
    /// <param name="commandType">执行的SQL语句的类型</param>
    /// <returns></returns>
    public DataTable ExecuteDataTable(string sql, IList<DbParameter> parameters, CommandType commandType)
    {
        using (DbCommand command = CreateDbCommand(sql, parameters, commandType))
        {
            using (DbDataAdapter adapter = providerFactory.CreateDataAdapter())
            {
                adapter.SelectCommand = command;
                DataTable data = new DataTable();
                adapter.Fill(data);
                return data;
            }
        }
    }
    /// <summary>   
    /// 执行一个查询语句，返回查询结果的第一行第一列   
    /// </summary>   
    /// <param name="sql">要执行的查询语句</param>   
    /// <param name="parameters">执行SQL查询语句所需要的参数</param>   
    /// <returns></returns>   
    public Object ExecuteScalar(string sql, IList<DbParameter> parameters)
    {
        return ExecuteScalar(sql, parameters, CommandType.Text);
    }

    /// <summary>   
    /// 执行一个查询语句，返回查询结果的第一行第一列   
    /// </summary>   
    /// <param name="sql">要执行的查询语句</param>   
    /// <param name="parameters">执行SQL查询语句所需要的参数</param>   
    /// <param name="commandType">执行的SQL语句的类型</param>
    /// <returns></returns>   
    public Object ExecuteScalar(string sql, IList<DbParameter> parameters, CommandType commandType)
    {
        using (DbCommand command = CreateDbCommand(sql, parameters, commandType))
        {
            command.Connection.Open();
            object result = command.ExecuteScalar();
            command.Connection.Close();
            return result;
        }
    }
    /// <summary>
    /// 创建一个DbCommand对象
    /// </summary>
    /// <param name="sql">要执行的查询语句</param>   
    /// <param name="parameters">执行SQL查询语句所需要的参数</param>
    /// <param name="commandType">执行的SQL语句的类型</param>
    /// <returns></returns>
    private DbCommand CreateDbCommand(string sql, IList<DbParameter> parameters, CommandType commandType)
    {
        DbConnection connection = providerFactory.CreateConnection();
        DbCommand command = providerFactory.CreateCommand();
        connection.ConnectionString = ConnectionString;
        command.CommandText = sql;
        command.CommandType = commandType;
        command.Connection = connection;
        
        if (!(parameters == null || parameters.Count == 0))
        {
            foreach (DbParameter parameter in parameters)
            {
                command.Parameters.Add(parameter);
            }
        }
        return command;
    }

    private  DbCommand CreateDbCommand(DbTransaction dbtrans  ,string sql, IList<DbParameter> parameters, CommandType commandType)
    {
        DbConnection connection = dbtrans.Connection;
        DbCommand command = providerFactory.CreateCommand();

        //connection.ConnectionString = ConnectionString;
        command.CommandText = sql;
        command.CommandType = commandType;
        command.Connection = connection;
        command.Transaction = dbtrans;
        if (!(parameters == null || parameters.Count == 0))
        {
            foreach (DbParameter parameter in parameters)
            {
                command.Parameters.Add(parameter);
                
            }
        }
        return command;
    }

    
    
}
/// <summary>
/// 数据库类型枚举
/// </summary>
public enum DbProviderType : byte
{
    SqlServer,
    MySql,
    SQLite,
    Oracle,
    ODBC,
    OleDb,
    Firebird,
    PostgreSql,
    DB2,
    Informix,
    SqlServerCe
}
/// <summary>
/// DbProviderFactory工厂类
/// </summary>
public class ProviderFactory
{
    private static Dictionary<DbProviderType, string> providerInvariantNames = new Dictionary<DbProviderType, string>();
    private static Dictionary<DbProviderType, DbProviderFactory> providerFactoies = new Dictionary<DbProviderType, DbProviderFactory>(20);
    static ProviderFactory()
    {
        //加载已知的数据库访问类的程序集
        providerInvariantNames.Add(DbProviderType.SqlServer, "System.Data.SqlClient");
        providerInvariantNames.Add(DbProviderType.OleDb, "System.Data.OleDb");
        providerInvariantNames.Add(DbProviderType.ODBC, "System.Data.ODBC");
        providerInvariantNames.Add(DbProviderType.Oracle, "System.Data.OracleClient");
        providerInvariantNames.Add(DbProviderType.MySql, "MySql.Data.MySqlClient");
        providerInvariantNames.Add(DbProviderType.SQLite, "System.Data.SQLite");
        providerInvariantNames.Add(DbProviderType.Firebird, "FirebirdSql.Data.Firebird");
        providerInvariantNames.Add(DbProviderType.PostgreSql, "Npgsql");
        providerInvariantNames.Add(DbProviderType.DB2, "IBM.Data.DB2.iSeries");
        providerInvariantNames.Add(DbProviderType.Informix, "IBM.Data.Informix");
        providerInvariantNames.Add(DbProviderType.SqlServerCe, "System.Data.SqlServerCe");
    }
    /// <summary>
    /// 获取指定数据库类型对应的程序集名称
    /// </summary>
    /// <param name="providerType">数据库类型枚举</param>
    /// <returns></returns>
    public static string GetProviderInvariantName(DbProviderType providerType)
    {
        return providerInvariantNames[providerType];
    }
    /// <summary>
    /// 获取指定类型的数据库对应的DbProviderFactory
    /// </summary>
    /// <param name="providerType">数据库类型枚举</param>
    /// <returns></returns>
    public static DbProviderFactory GetDbProviderFactory(DbProviderType providerType)
    {
        //如果还没有加载，则加载该DbProviderFactory
        if (!providerFactoies.ContainsKey(providerType))
        {
            providerFactoies.Add(providerType, ImportDbProviderFactory(providerType));
        }
        return providerFactoies[providerType];
    }
    /// <summary>
    /// 加载指定数据库类型的DbProviderFactory
    /// </summary>
    /// <param name="providerType">数据库类型枚举</param>
    /// <returns></returns>
    private static DbProviderFactory ImportDbProviderFactory(DbProviderType providerType)
    {
        string providerName = providerInvariantNames[providerType];
        DbProviderFactory factory = null;
        try
        {
            //从全局程序集中查找
            factory = DbProviderFactories.GetFactory(providerName);
        }
        catch (ArgumentException e)
        {
            factory = null;
        }
        return factory;
    }
}

public class Trans : IDisposable
{
    private DbConnection conn;
    private DbTransaction dbTrans;
    public DbConnection DbConnection
    {
        get { return this.conn; }
    }
    public DbTransaction DbTrans
    {
        get { return this.dbTrans; }
    }

    public Trans( DbConnection dbconn)
    {
        conn = dbconn;
        conn.Open();
        dbTrans = conn.BeginTransaction();
    }
    //public Trans(string connectionString)
    //{
    //    conn = DbHelper.CreateConnection(connectionString);
    //    conn.Open();
    //    dbTrans = conn.BeginTransaction();
    //}
    public void Commit()
    {
        dbTrans.Commit();
        this.Colse();
    }

    public void RollBack()
    {
        dbTrans.Rollback();
        this.Colse();
    }

    public void Dispose()
    {
        this.Colse();
    }

    public void Colse()
    {
        if (conn.State == System.Data.ConnectionState.Open)
        {
            conn.Close();
        }
    }
}