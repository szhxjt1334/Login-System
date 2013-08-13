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
    $fourofour = "<div id='content'><h3><center>404 - Failed!</h3></center><BR /><center>This page does not exist!</center></div>";
    $created = "<div id='content'><center><font color='#FF0000'>Account '" . $_SESSION['userbox'] . "' Created!</font><BR />You can now login with the Loader.</center></div>";
    $denied = "<div id='content'><center><h3>Redirecting...</h3><center><BR /><center>You do not have permission to view this page.</center><META HTTP-EQUIV=REFRESH CONTENT='3; ./index.php?p=login'></div>";
    $keydenied = "<div id='content'>Invalid Key!<BR />Please go <a href='?p=login'>back</a> and try again</div>";
    $loginfailed = "<div id='content'><center><h3>Login Failed!</h3></center><BR /><center>Invalid username or password.</center><BR /><BR /><center>Please go <a href='?p=login'>back</a> and try again</center></div>";