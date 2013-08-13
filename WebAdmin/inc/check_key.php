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
    include ('db.php');

    $user = $_POST['userbox'];
    $pass = $_POST['passbox'];
    $key = $_POST['keybox'];

    $user = $mysqli->real_escape_string($user);
    $pass = $mysqli->real_escape_string($pass);
    $key = $mysqli->real_escape_string($key);

    $hash_pass = sha1($salt.$pass);
    $db_result = $mysqli->select_db($db_name);

    $user_query = "INSERT INTO `$tbl_accounts` (username, password, access, hwid, ip, pcname, info) VALUES ('" . $user . "','" . $hash_pass . "','2','','0.0.0.0','','new')";
    $key_query = "SELECT * FROM `$tbl_key` WHERE `key` = '" . $key . "'";
    $drop_query = "DELETE FROM `$tbl_key` WHERE `key` = '" . $key . "'";
    $log_query = "INSERT INTO `" . $tbl_log ."` ('Date', 'UID', 'IP', 'Action') VALUES('date', '" . $user . "', 'date3', 'Web Creation')";

    if (!$db_result)
    {
        echo "Cannot select database\n";
        trigger_error(mysqli_connect_errno(), E_USER_ERROR);
    }

    $key_result = $mysqli->query($key_query);

    if (!$key_result)
    {
        echo "Failed to execute!";
        trigger_error(mysqli_connect_errno(), E_USER_ERROR);
    }

    if (mysqli_num_rows($key_result))
    {
        $_SESSION['userbox'] = $user;
        $mysqli->query($user_query);
        $mysqli->query($drop_query);
        $mysqli->query($log_query);
        if (!$key_result || !$user_query || !$log_query)
        {
            echo "Failed to execute!";
            trigger_error(mysqli_connect_errno(), E_USER_ERROR);
        }
        else
            header('Location:../index.php?p=created');
    }
    else
        header('Location:../index.php?p=key_failed');

    $mysqli->close();