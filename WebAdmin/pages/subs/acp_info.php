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
    include('../../inc/db.php');

    $option = $_POST['useroption'];
    $user = $_POST['userbox'];
    $_SESSION['selected'] = $option;

    if($user = '')
        echo 'Please enter a username.';
    else
    {
    $option = $mysqli->real_escape_string($option);
    $user = $mysqli->real_escape_string($user);

    $db_result = $mysqli->select_db($db_name);

    $user_query = "SELECT * FROM `" . $tbl_accounts . "` WHERE username = '" . $user . "'";
    $ban_query = "UPDATE `" . $tbl_accounts . "` SET access = '0' WHERE username = '" . $user . "'";
    $lock_query = "UPDATE `" . $tbl_accounts . "` SET access = '1' WHERE username = '" . $user . "'";
    $clear_query = "UPDATE `" . $tbl_accounts . "` SET access = '2' WHERE username = '" . $user . "'";
    $delete_query = "DELETE FROM `" . $tbl_accounts . "` WHERE username = '" . $user . "'";

    $user_result = $mysqli->query($user_query);

    if(!$user_result)
    {
        echo "Failed to execute!";
        trigger_error(mysqli_connect_errno(), E_USER_ERROR);
    }

    $row = mysqli_fetch_assoc($user_result);

    if(!$row['username'] == $user)
        echo "this user does not exist.";
    else
    {
        if($option == 'Ban')
        {
            if($row['access'] == 0)
                echo 'This user is already banned!';
            elseif($row['access'] == 3)
                echo 'You can not ban an administrator';
            else
            {
                $ban_result = $mysqli->query($ban_query);
                if(!$ban_result)
                {
                    echo "Failed to execute!";
                    trigger_error(mysqli_connect_errno(), E_USER_ERROR);
                }
                else
                    echo "User " . $user . ", has been banned.";
            }
        }
        elseif($option == 'Unban')
        {
            if($row['access'] == 2)
                echo 'This user is not banned!';
            elseif($row['access'] == 3)
                echo "You can not change an administrator's access.";
            else
            {
                $clear_result = $mysqli->query($clear_query);
                if(!$clear_result)
                {
                    echo "Failed to execute!";
                    trigger_error(mysqli_connect_errno(), E_USER_ERROR);
                }
                else
                    echo "User " . $user . ", is now Unbanned.";
            }
        }
        elseif($option == 'Lock')
        {
            if($row['access'] == 0)
                echo 'This user is banned, you can not lock the account!';
            elseif($row['access'] == 1)
                echo 'This user is already locked!';
            elseif($row['access'] == 3)
                echo "You can not change an administrator's access.";
            else
            {
                $lock_result = $mysqli->query($lock_query);
                if(!$lock_result)
                {
                    echo "Failed to execute!";
                    trigger_error(mysqli_connect_errno(), E_USER_ERROR);
                }
                else
                    echo "User " . $user . ", is now Locked.";
            }
        }
        elseif($option == 'Unlock')
        {
            if($row['access'] == 0)
                echo 'This user is banned, you can not Unlock the account!';
            elseif($row['access'] == 2)
                echo 'This user is not locked!';
            elseif($row['access'] == 3)
                echo "You can not change an administrator's access.";
            else
            {
                $clear_result = $mysqli->query($clear_query);
                if(!$clear_result)
                {
                    echo "Failed to execute!";
                    trigger_error(mysqli_connect_errno(), E_USER_ERROR);
                }
                else
                    echo "User " . $user . ", is now Unlocked.";
            }
        }
        elseif($option == 'Delete')
        {
            if($row['access'] == 3)
                echo "You can not change an administrator's access.";
            else
            {
                $delete_result = $mysqli->query($delete_query);
                if(!$delete_result)
                {
                    echo "Failed to execute!";
                    trigger_error(mysqli_connect_errno(), E_USER_ERROR);
                }
                else
                    echo "User " . $user . ", has been Deleted.";
            }
        }
        else
            echo 'Something broke.';
    }

    $mysqli->close();
}