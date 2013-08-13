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

        $log = $_POST['searchbox'];
        $log = $mysqli->real_escape_string($log);
        $db_result = $mysqli->select_db($db_name);

        $log_query = "SELECT * FROM `" . $tbl_log . "`";

        if (!$db_result)
        {
            echo "Cannot select database\n";
            trigger_error(mysqli_connect_errno(), E_USER_ERROR);
        }

        $log_result = $mysqli->query($log_query);

        if (!$log_result)
        {
            echo "Failed to execute query!";
            trigger_error(mysqli_connect_errno(), E_USER_ERROR);
        }

        while($row = mysqli_fetch_row($log_result))
        {
            if(mysqli_num_rows($log_result))
            {
                echo '<div id="content">';
                echo '<table cellpadding="0" cellspacing="0" class="db-table">';
                echo '<tr><th>Date</th><th>UID</th><th>IP</th><th>Action</th></tr>';
                while($row2 = mysqli_fetch_row($log_result)) {
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