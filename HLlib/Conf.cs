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

namespace HLlib
{
    class Conf
    {
        static string hostname = "127.0.0.1";
        static string database = "login";
        static string username = "root";
        static string password = "root";

        #region Crypt String
        public static string configkey = "Data Source=" + hostname + ";Initial Catalog=" + database + ";User Id=" + username + ";Password=" + password + ";";
        #endregion
    }
}
