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
        echo '<center><h2>Search User</h2>';
        echo '<table width="300" border="0" align="center" cellpadding="0" cellspacing="1" bgcolor="#212121">';
            echo '<tr>';
                echo '<form name="form1" method="post" action="?p=acp_results">';
                    echo '<td>';
                    echo '<table width="100%" border="0" cellpadding="3" cellspacing="1" bgcolor="#212121">';
                        echo '<tr>';
                        echo '<td colspan="3"><strong>Search </strong></td>';
                        echo '</tr>';
                        echo '<tr>';
                        echo '<td width="78">UID</td>';
                        echo '<td width="6">:</td>';
                        echo '<td width="294"><input name="searchbox" type="text" id="search"></td>';
                        echo '</tr>';
                        echo '<tr>';
                        echo '<td>&nbsp;</td>';
                        echo '<td>&nbsp;</td>';
                        echo '<td><input type="submit" name="Submit" value="Search"></td>';
                        echo '</tr>';
                    echo '</table>';
                    echo '</td>';
                echo '</form>';
            echo '</tr>';
        echo '</table></center>';
    }