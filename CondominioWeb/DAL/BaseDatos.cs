using Microsoft.Practices.EnterpriseLibrary.Data;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;
using System.Web;

namespace CondominioWeb.DAL
{
    public class BaseDatos
    {
        public static DataTable ExecuteDataTable(string pName, params Object[] args)
        {
            Database db = DatabaseFactory.CreateDatabase("MiConexion");

            DbCommand command = db.GetStoredProcCommand(pName, args);
            command.CommandTimeout = 0;
            DataTable dt = new DataTable();
            dt.Load(db.ExecuteReader(command));
            return dt;
        }
        public static DataTable ExecuteDataTable(string pQuery)
        {
            Database db = DatabaseFactory.CreateDatabase("MiConexion");
            DataTable dt = new DataTable();
            dt.Load(db.ExecuteReader(db.GetSqlStringCommand(pQuery)));
            return dt;
        }
        public static DataSet ExecuteDataSet(string pName, params Object[] args)
        {
            Database db = DatabaseFactory.CreateDatabase("MiConexion");
            System.Data.Common.DbCommand command = db.GetStoredProcCommand(pName, args);
            command.CommandTimeout = 0;
            return db.ExecuteDataSet(command);
        }
        public static DataSet ExecuteDataSet(string pQuery)
        {
            Database db = DatabaseFactory.CreateDatabase("MiConexion");
            DbCommand command = db.GetSqlStringCommand(pQuery);
            return db.ExecuteDataSet(command);
        }
        public static int ExecuteSql(string pQuery)
        {
            Database db = DatabaseFactory.CreateDatabase("MiConexion");
            return db.ExecuteNonQuery(db.GetSqlStringCommand(pQuery));
        }
        public static int ExecuteSqlIdentity(string pName, params object[] args)
        {
            Database db = DatabaseFactory.CreateDatabase("MiConexion");
            DbCommand command = db.GetStoredProcCommand(pName, args);
            db.ExecuteNonQuery(command);
            return int.Parse(db.GetParameterValue(command, command.Parameters[args.Length].ParameterName).ToString());
        }
        public static string ExecuteSqlIdentityPK(string pName, params object[] args)
        {
            Database db = DatabaseFactory.CreateDatabase("MiConexion");
            DbCommand command = db.GetStoredProcCommand(pName, args);
            db.ExecuteNonQuery(command);
            return db.GetParameterValue(command, command.Parameters[args.Length].ParameterName).ToString();
        }
        public static int ExecuteSql(string pQuery, params Object[] args)
        {
            Database db = DatabaseFactory.CreateDatabase("MiConexion");
            return db.ExecuteNonQuery(pQuery, args);
        }
        public static object ExecuteScalar(string pQuery)
        {
            Database db = DatabaseFactory.CreateDatabase("MiConexion");
            return db.ExecuteScalar(db.GetSqlStringCommand(pQuery));
        }
        public static bool ExecuteExisteEnBD(string pQuery)
        {
            return ExecuteScalar(pQuery) != null;
        }

        public static KeyValuePair<int, string> ExecuteSqlIdentityWithError(string pName, params object[] args)
        {
            //penultimo=@id, ultimo: @error
            KeyValuePair<int, string> result = new KeyValuePair<int, string>();
            Database db = DatabaseFactory.CreateDatabase("MiConexion");
            DbCommand command = db.GetStoredProcCommand(pName, args);
            db.ExecuteNonQuery(command);
            int auxId = 0;
            var paramId = db.GetParameterValue(command, command.Parameters[args.Length - 1].ParameterName);
            if (paramId != DBNull.Value) auxId = int.Parse(paramId.ToString());
            result = new KeyValuePair<int, string>(auxId, db.GetParameterValue(command, command.Parameters[args.Length].ParameterName).ToString());
            return result;
        }
    }
}