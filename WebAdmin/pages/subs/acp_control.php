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
?>
<center>
    <h2>User Control</h2>
    <form name="controlform" method="post" action="./pages/subs/acp_info.php">
        <BR /><label>Username</label><BR />
        <input name="userbox" type="text" id="user"><BR /><BR />
        <select name="useroption">
            <option value="Ban">Ban</option>
            <option value="Unban">Unban</option>
            <option value="Lock">Lock</option>
            <option value="Unlock">Unlock</option>
            <option value="Delete">Delete</option>
        </select>
        <input type="submit" value="Submit">
    </form>
</center>