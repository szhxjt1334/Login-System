/*
             _____           ____              
            |   __|_____ _ _|    \ ___ _ _ ___ 
            |   __|     | | |  |  | -_| | |_ -|
            |_____|_|_|_|___|____/|___|\_/|___|
     Copyright (C) 2013 EmuDevs <http://www.emudevs.com/>
 
  This program is free software; you can redistribute it and/or modify it
  under the terms of the GNU General Public License as published by the
  Free Software Foundation; either version 2 of the License, or (at your
  option) any later version.
 
  This program is distributed in the hope that it will be useful, but WITHOUT
  ANY WARRANTY; without even the implied warranty of MERCHANTABILITY or
  FITNESS FOR A PARTICULAR PURPOSE. See the GNU General Public License for
  more details.
 
  You should have received a copy of the GNU General Public License along
  with this program. If not, see <http://www.gnu.org/licenses/>.
*/

using System;
using MySql.Data.MySqlClient;

namespace HLlib
{
    public static class Database
    {
        public static DatabaseAccess databaseAccess = new DatabaseAccess();
    }

    public class DatabaseAccess
    {
        private void CloseConnection(MySqlConnection mySqlConnection)
        {
            if (mySqlConnection != null)
                mySqlConnection.Dispose();
        }

        private MySqlDataReader ExecuteQuery(string query)
        {
            MySqlConnection connection = null;
            MySqlDataReader dataReader = null;
            try
            {
                using (connection = new MySqlConnection(Hash.RunDecryption()))
                {
                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        connection.Open();
                        using (dataReader = command.ExecuteReader())
                        {
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show("Failed to execute data! " + ex.Message, "Error!", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error);
                dataReader.Close();
                CloseConnection(connection);
            }
            finally
            {
                dataReader.Close();
                CloseConnection(connection);
            }
            return dataReader;
        }

        public MySqlDataReader InsertInto(string tableName, string[] values)
        {
            string query = "";
            try
            {
                query = "INSERT INTO `" + tableName + "` VALUES(" + "'" + values[0] + "'";
                for (int i = 1; i < values.Length; ++i)
                    query += ", '" + values[i] + "'";
                    query += ")";
            }
            catch { }
            return ExecuteQuery(query);
        }

        public MySqlDataReader UpdateUserInfo(string tableName, string col, string val, string colTwo, string valTwo)
        {
            string query = "";
            try
            {
                query = "UPDATE " + tableName + " SET " + col + "='" + val + "'" + "WHERE " + colTwo + "='" + valTwo + "'";
            }
            catch { }
            return ExecuteQuery(query);
        }

        public string GetColumnData(ValueType valueType, string tableName, string col, string colTwo, string equalsVal, bool compare)
        {
            MySqlConnection connection = null;
            MySqlDataReader dataReader = null;
            string colData = "";
            try
            {
                string query = "";
                if (compare)
                    query = "SELECT `" + col + "` FROM `" + tableName + "` WHERE `" + colTwo + "`='" + equalsVal + "';";
                else
                    query = "SELECT `" + col + "` FROM `" + tableName + "`";
                using (connection = new MySqlConnection(Hash.RunDecryption()))
                {
                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        connection.Open();
                        command.CommandText = query;
                        using (dataReader = command.ExecuteReader())
                        {
                            while (dataReader.Read())
                            {
                                switch (valueType)
                                {
                                    case ValueType.VALUETYPE_STRING:
                                        colData = dataReader.GetString(0);
                                        break;

                                    case ValueType.VALUETYPE_INT16:
                                        colData = dataReader.GetInt16(0).ToString();
                                        break;

                                    case ValueType.VALUETYPE_INT32:
                                        colData = dataReader.GetInt32(0).ToString();
                                        break;

                                    case ValueType.VALUETYPE_INT64:
                                        colData = dataReader.GetInt64(0).ToString();
                                        break;
                                }
                            }

                            if (dataReader.NextResult())
                            {
                                colData = "";
                                while (dataReader.Read())
                                {
                                    switch (valueType)
                                    {
                                        case ValueType.VALUETYPE_STRING:
                                            colData = dataReader.GetString(0);
                                            break;

                                        case ValueType.VALUETYPE_INT16:
                                            colData = dataReader.GetInt16(0).ToString();
                                            break;

                                        case ValueType.VALUETYPE_INT32:
                                            colData = dataReader.GetInt32(0).ToString();
                                            break;

                                        case ValueType.VALUETYPE_INT64:
                                            colData = dataReader.GetInt64(0).ToString();
                                            break;
                                    }
                                }
                            }
                        }
                    }
                }
            }
            catch
            {
                System.Windows.Forms.MessageBox.Show("Failed to retrieve data!", "Error!", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error);
                dataReader.Close();
                CloseConnection(connection);
            }
            finally
            {
                dataReader.Close();
                CloseConnection(connection);
            }
            return colData;
        }

        public MySqlDataReader DeleteFrom(string tableName, string col, string colEquals)
        {
            string query = "DELETE FROM `" + tableName + "` WHERE `" + col + "`='" + colEquals + "'";
            return ExecuteQuery(query);
        }

        public MySqlDataReader DeleteTable(string tableName)
        {
            string query = "DROP TABLE  `" + tableName + "`";
            return ExecuteQuery(query);
        }

        public MySqlDataReader CreateUTable(string tableName)
        {
            string query = "CREATE TABLE IF NOT EXISTS " + tableName + " (" + "Date VARCHAR(100)," + "IP VARCHAR(30)," + 
                "UID VARCHAR(100)," + "HWID VARCHAR(100)," + "PCName VARCHAR(50));";
            return ExecuteQuery(query);
        }
    }

    public enum ValueType : int
    {
        VALUETYPE_STRING,
        VALUETYPE_INT16,
        VALUETYPE_INT32,
        VALUETYPE_INT64
    }
}
