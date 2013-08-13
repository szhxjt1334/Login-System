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
    if(!isset($_SESSION['loggedin']))
        echo $denied;
    else
    {
        include('./inc/db.php');

        $search = $_POST['searchbox'];
        $search = $mysqli->real_escape_string($search);
        $db_result = $mysqli->select_db($db_name);

        $search_query = "SELECT * FROM `" . $search . "`";

        if (!$db_result)
        {
            echo "Cannot select database\n";
            trigger_error(mysqli_connect_errno(), E_USER_ERROR);
        }

        $search_result = $mysqli->query($search_query);

        if (!$search_result == $search)
            echo "<center><font color='red'>This user does not exist, or has not logged in yet!</font></center>";
        else if (!$search_result)
        {
            echo "Failed to execute query!";
            trigger_error(mysqli_connect_errno(), E_USER_ERROR);
        }

        while($row = mysqli_fetch_row($search_result))
        {
            if(mysqli_num_rows($search_result))
            {
                echo '<div id="content">';
                echo '<table cellpadding="0" cellspacing="0" class="db-table">';
                echo '<tr><th>Date</th><th>IP</th><th>UID</th><th>HWID</th><th>PCName</th></tr>';
                while($row2 = mysqli_fetch_row($search_result)) {
                    echo '<tr>';
                    foreach($row2 as $key=>$value) {
                        echo '<td>',$value,'</td>';
                    }
                    echo '</tr>';
                }
                echo '</tbody></table><br>';
                echo '</div>';
            }
        }
    }