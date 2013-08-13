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
?>
<table width="300" border="0" align="center" cellpadding="0" cellspacing="1" bgcolor="#212121">
    <tr>
        <form name="form1" method="post" action="./inc/check.php">
            <td>
            <table width="100%" border="0" cellpadding="3" cellspacing="1" bgcolor="#212121">
                <tr>
                    <td colspan="3"><strong>HL Login </strong></td>
                    </tr>
                    <tr>
                    <td width="78">Username</td>
                    <td width="6">:</td>
                    <td width="294"><input name="userbox" type="text" id="user"></td>
                    </tr>
                    <tr>
                    <td>Password</td>
                    <td>:</td>
                    <td><input name="passbox" type="text" id="pass"></td>
                    </tr>
                    <tr>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                    <td><input type="submit" name="Submit" value="Login"></td>
                </tr>
            </table>
            </td>
        </form>
    </tr>
</table>