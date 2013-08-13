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

    $user = $mysqli->real_escape_string($user);
    $pass = $mysqli->real_escape_string($pass);

    $hash_pass = sha1($salt.$pass);
    $db_result = $mysqli->select_db($db_name);

    $user_login_query = "SELECT * FROM `$tbl_accounts` WHERE `username` = '" . $user . "' AND `password` = '" . $hash_pass . "'";

    if (!$db_result)
    {
        echo "Cannot select database\n";
        trigger_error(mysqli_connect_errno(), E_USER_ERROR);
    }

    $user_result = $mysqli->query($user_login_query);

    if (!$user_result)
    {
        echo "Failed to execute!";
        trigger_error(mysqli_connect_errno(), E_USER_ERROR);
    }

    $row = mysqli_num_rows($user_result);

    if ($row != 1)
        header('Location:../index.php?p=failed');
    else
    {
        while ($row = mysqli_fetch_assoc($user_result))
        {
            if ($row['access'] != 3)
                header('Location:../index.php?p=notadmin');
            else
            {
                $_SESSION['loggedin'] = true;
                $_SESSION['userbox'] = $user;
                $_SESSION['admin'] = true;
                header('Location:../index.php?p=acp');
            }
        }
    }

    $mysqli->close();


