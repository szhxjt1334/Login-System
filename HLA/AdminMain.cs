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
using System.Windows.Forms;
using HLlib;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using MySql.Data.MySqlClient;
using System.Text;

namespace HLA
{
    public partial class AdminMain : Form
    {
        string userText;
        string userControl;
        
        private readonly Random keyRange = new Random();
        private const string keyChars = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ-.=_+][!~?@#$%^&*()1234567890";

        public AdminMain()
        {
            InitializeComponent();
            FillKeyList();
            FillActivityGrid();
            userControl = userBox.Text;
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            FillGrid();
        }

        #region grid filling
        public void FillGrid()
        {
            userText = searchBox.Text;

            MySqlConnection connection = null;
            string query = "SELECT * FROM " + userText + " ORDER BY date DESC;";
            userGrid.DataSource = null;
            userGrid.Rows.Clear(); 

            using (connection = new MySqlConnection(Hash.RunDecryption()))
            {
                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    connection.Open();
                    DataSet dt = new DataSet();
                    MySqlDataAdapter da = new MySqlDataAdapter(command);
                    da.Fill(dt);
                    userGrid.AutoResizeColumns();
                    userGrid.DataSource = dt.Tables[0];
                    userGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
                    connection.Close();
                }
            }
        }

        public void FillKeyList()
        {
            MySqlConnection connection = null;
            string query = "SELECT * FROM `keys`;";
            listGrid.DataSource = null;
            listGrid.Rows.Clear();

            using (connection = new MySqlConnection(Hash.RunDecryption()))
            {
                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    connection.Open();
                    DataSet dt = new DataSet();
                    MySqlDataAdapter da = new MySqlDataAdapter(command);
                    da.Fill(dt);
                    listGrid.AutoResizeColumns();
                    listGrid.DataSource = dt.Tables[0];
                    listGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
                    connection.Close();
                }
            }
        }

        public void FillActivityGrid()
        {
            MySqlConnection connection = null;
            string query = "SELECT * FROM `log` ORDER BY date DESC;";
            activityGrid.DataSource = null;
            activityGrid.Rows.Clear();

            using (connection = new MySqlConnection(Hash.RunDecryption()))
            {
                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    connection.Open();
                    DataSet dt = new DataSet();
                    MySqlDataAdapter da = new MySqlDataAdapter(command);
                    da.Fill(dt);
                    activityGrid.AutoResizeColumns();
                    activityGrid.DataSource = dt.Tables[0];
                    activityGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
                    connection.Close();
                }
            }
        }
        #endregion

        private void genButton_Click(object sender, EventArgs e)
        {
            keyBox.Text = RandomString(20);
        }

        private string RandomString(int size)
        {
            char[] buffer = new char[size];
            for (int i = 0; i < size; i++)
            {
                buffer[i] = keyChars[keyRange.Next(keyChars.Length)];
            }
            return new string(buffer);
        }

        #region user control
        private void addButton_Click(object sender, EventArgs e)
        {
            string keyInfo = keyBox.Text;
            string keyExists = Database.databaseAccess.GetColumnData(HLlib.ValueType.VALUETYPE_STRING, "keys", "key", "key", keyInfo, true);
            if (keyInfo == keyExists)
                MessageBox.Show("This key already exists in the database, please generate another.", "Key Exists!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                string[] keyValue = { keyInfo };
                Database.databaseAccess.InsertInto("keys", keyValue);
            }
        }

        private void resetKeysButton_Click(object sender, EventArgs e)
        {
            FillKeyList();
        }

        private void banButton_Click(object sender, EventArgs e)
        {
            string statusResult = Database.databaseAccess.GetColumnData(HLlib.ValueType.VALUETYPE_INT32, "accounts", "access", "username", userText, true);
            if (statusResult == "0")
                MessageBox.Show("This account is already banned!", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                string[] logvalue = { DateTime.Now.ToString(), Admin.userInfo, HLlib.Functions.getIP(), "Banned " + userControl };
                Database.databaseAccess.InsertInto("log", logvalue);

                Database.databaseAccess.UpdateUserInfo("accounts", "access", "0", "username", userControl);
                MessageBox.Show("This account is now banned!", "Banned!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void unbanButton_Click(object sender, EventArgs e)
        {
            string statusResult = Database.databaseAccess.GetColumnData(HLlib.ValueType.VALUETYPE_INT32, "accounts", "access", "username", userText, true);
            if (statusResult == "0")
            {
                string[] logvalue = { DateTime.Now.ToString(), Admin.userInfo, HLlib.Functions.getIP(), "Unbanned " + userControl };
                Database.databaseAccess.InsertInto("log", logvalue);

                Database.databaseAccess.UpdateUserInfo("accounts", "access", "2", "username", userControl);
                MessageBox.Show("This account is now Unbanned!", "Unbanned!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
                MessageBox.Show("This account is not banned!", "Failed!", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void lockButton_Click(object sender, EventArgs e)
        {
            string statusResult = Database.databaseAccess.GetColumnData(HLlib.ValueType.VALUETYPE_INT32, "accounts", "access", "username", userText, true);
            if (statusResult == "1")
                MessageBox.Show("This account is already locked!", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                string[] logvalue = { DateTime.Now.ToString(), Admin.userInfo, HLlib.Functions.getIP(), "Locked " + userControl };
                Database.databaseAccess.InsertInto("log", logvalue);

                Database.databaseAccess.UpdateUserInfo("accounts", "access", "1", "username", userControl);
                MessageBox.Show("This account is now locked!", "Locked!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void unlockButton_Click(object sender, EventArgs e)
        {
            string statusResult = Database.databaseAccess.GetColumnData(HLlib.ValueType.VALUETYPE_INT32, "accounts", "access", "username", userText, true);
            if (statusResult == "1")
            {
                string[] logvalue = { DateTime.Now.ToString(), Admin.userInfo, HLlib.Functions.getIP(), "Unlocked " + userControl };
                Database.databaseAccess.InsertInto("log", logvalue);

                Database.databaseAccess.UpdateUserInfo("accounts", "access", "2", "username", userControl);
                MessageBox.Show("This account is now Unlocked!", "Unlocked!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
                MessageBox.Show("This account is not locked!", "Failed!", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            string userResult = Database.databaseAccess.GetColumnData(HLlib.ValueType.VALUETYPE_STRING, "accounts", "username", "username", userBox.Text, true);
            var result = MessageBox.Show("Warning: This will remove all related information on " + userBox.Text + "! Would you like to continue?", "Warning!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            switch (result)
            {
                case DialogResult.Yes:
                    if (userResult == userBox.Text)
                    {
                        string[] logvalue = { DateTime.Now.ToString(), Admin.userInfo, HLlib.Functions.getIP(), "Deleted " + userControl };
                        Database.databaseAccess.InsertInto("log", logvalue);

                        Database.databaseAccess.DeleteFrom("accounts", "username", userBox.Text);
                        Database.databaseAccess.DeleteTable(userBox.Text);
                    }
                    else
                        MessageBox.Show("This user does not exist!", "Failed!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
                case DialogResult.No:
                    //do nothing
                    break;
                default:
                    //do nothing
                    break;
            }
        }

        private void resetButton_Click(object sender, EventArgs e)
        {
            string statusResult = Database.databaseAccess.GetColumnData(HLlib.ValueType.VALUETYPE_INT32, "accounts", "access", "username", userText, true);
            if (statusResult == "1")
                Database.databaseAccess.UpdateUserInfo("accounts", "access", "2", "username", userControl);

            Database.databaseAccess.UpdateUserInfo("accounts", "hwid", "", "username", userBox.Text);
            MessageBox.Show(userBox.Text + " has been reset!", "User Reset!", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        #endregion
    }
}
