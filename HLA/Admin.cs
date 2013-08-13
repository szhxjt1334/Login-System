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

namespace HLA
{
    public partial class Admin : Form
    {
        public static string passInfo;
        public static string userInfo;
        string accesslvl;
        string hwidResult;
        bool exists = false;
        bool loggedin = false;
        bool hwid = false;

        public Admin()
        {
            InitializeComponent();
            this.Width = 407;
            this.Height = 131;
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            userInfo = userBox.Text;
            passInfo = passBox.Text;
            if (userInfo == "")
                MessageBox.Show("Please fill in the username field!", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else if (passInfo == "")
                MessageBox.Show("Please fill in the password field!", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
                existcheck();
        }

        #region login process
        public void existcheck()
        {
            string userResult = Database.databaseAccess.GetColumnData(HLlib.ValueType.VALUETYPE_STRING, "accounts", "username", "username", userInfo, true);

            if (string.IsNullOrEmpty(userResult))
                MessageBox.Show("This account does not exist");
            else
            {
                exists = true;
                logincheck();
            }
        }

        private void logincheck()
        {
            passInfo = HLlib.Hash.SHA1(passBox.Text);
            string userResult = Database.databaseAccess.GetColumnData(HLlib.ValueType.VALUETYPE_STRING, "accounts", "username", "username", userInfo, true);
            string passResult = Database.databaseAccess.GetColumnData(HLlib.ValueType.VALUETYPE_STRING, "accounts", "password", "password", passInfo, true);

            if (exists && passInfo == passResult)
            {
                loggedin = true;
                hwidcheck();
            }
            else
                MessageBox.Show("Username or Password is invalid, please try again!", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void hwidcheck()
        {
            string hwidInfo = HLlib.HWID.getHWID().ToString().Replace(" ", "");
            hwidResult = Database.databaseAccess.GetColumnData(HLlib.ValueType.VALUETYPE_STRING, "accounts", "hwid", "username", userInfo, true);

            if (hwidInfo == hwidResult)
            {
                hwid = true;
                complete();
            }
            else
            {
                MessageBox.Show("Your HWID does not match, account is now locked!", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Database.databaseAccess.UpdateUserInfo("accounts", "access", "2", "username", userInfo);
            }
        }

        private void complete()
        {
            if (loggedin && hwid)
            {
                try
                {
                    accesscheck();
                    if (accesslvl == "admin")
                        MessageBox.Show("Welcome, " + userInfo + "!\nYou are logged in as an admin.", "Logged in!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                { MessageBox.Show("Error: " + ex.Message, "Report this error!", MessageBoxButtons.OK, MessageBoxIcon.Error); }

                string[] values = { DateTime.Now.ToString(), HLlib.Functions.getIP(), userInfo, hwidResult, HLlib.Functions.getPCName() };
                Database.databaseAccess.CreateUTable(userInfo);
                Database.databaseAccess.InsertInto(userInfo, values);

                string[] logvalue = { DateTime.Now.ToString(), userInfo, HLlib.Functions.getIP(), "Admin Login" };
                Database.databaseAccess.InsertInto("log", logvalue);

                Database.databaseAccess.UpdateUserInfo("accounts", "ip", HLlib.Functions.getIP(), "username", userInfo);
                Database.databaseAccess.UpdateUserInfo("accounts", "pcname", HLlib.Functions.getPCName(), "username", userInfo);
                Database.databaseAccess.UpdateUserInfo("accounts", "hwid", hwidResult, "username", userInfo);

                AdminMain goAdmin = new AdminMain();
                goAdmin.Show();
                this.Hide();
            }
            else
                MessageBox.Show("Something else went wrong..", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void accesscheck()
        {
            string statusResult = Database.databaseAccess.GetColumnData(HLlib.ValueType.VALUETYPE_INT32, "accounts", "access", "username", userInfo, true);

            if (statusResult == "0")
            {
                accesslvl = "";
                MessageBox.Show("You are banned from the loader!", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }
            else if (statusResult == "1")
            {
                accesslvl = "";
                MessageBox.Show("Your HWID has been locked, ask for a reset.", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }
            else if (statusResult == "2")
                accesslvl = "user";
            else if (statusResult == "3")
                accesslvl = "admin";
            else
            {
                MessageBox.Show("Your access is not recognized.");
                this.Close();
            }
        }
        #endregion
    }
}
