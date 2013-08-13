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
    $page = $_GET['p'];
    include('./inc/header.php');
    include('./inc/nav.php');

    if ($page == "")
    {
        @include('./pages/login.php');
    }

    switch($page)
    {
        case "login":
            @include('./pages/login.php');
            break;
        case "logout":
            @include('./pages/logout.php');
            break;
        case "failed":
            @include('./pages/failed.php');
            break;
        case "key_failed":
            @include('./pages/key_failed.php');
            break;
        case "acp":
            @include('./pages/acp.php');
            break;
        case "create";
            @include('./pages/create.php');
            break;
        case "created":
            @include('./pages/created.php');
            break;
        case "acp_results":
            @include('./pages/subs/acp_results.php');
            break;
        case "acp_search":
            @include('./pages/subs/acp_search.php');
            break;
        case "acp_control":
            @include('./pages/subs/acp_control.php');
            break;
        case "acp_msg":
            @include('./pages/subs/acp_msg.php');
            break;
        case "log":
            @include('./pages/log.php');
            break;
        case "notadmin":
            @include('./pages/notadmin.php');
            break;
        default:
            @include('./pages/404.php');
            break;
    }

    include('./inc/sidebar.php');
    include('./inc/footer.php');
