<?php
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
    session_start();
    include('db.php');

    $search = $_POST['searchbox'];
    $search = $mysqli->real_escape_string($search);
    $db_result = $mysqli->select_db($db_name);

    $search_query = "SELECT * FROM faded";

    if (!$db_result)
    {
        echo "Cannot select database\n";
        trigger_error(mysqli_connect_errno(), E_USER_ERROR);
    }

    $search_result = $mysqli->query($search_query);

    if (!$search_result)
    {
        echo "Failed to execute query!";
        trigger_error(mysqli_connect_errno(), E_USER_ERROR);
    }

    while ($row = mysqli_fetch_assoc($search_result))
    {
        $table = $row[0];
        $search_result_2 = $mysqli->query('SHOW COLUMNS FROM ' . $table);
        $_SESSION['DATE'] = $row['Date'];
        $_SESSION['IP'] = $row['IP'];
        $_SESSION['UID'] = $row['UID'];
        $_SESSION['HWID'] = $row['HWID'];
        $_SESSION['PCNAME'] = $row['PCName'];
    }