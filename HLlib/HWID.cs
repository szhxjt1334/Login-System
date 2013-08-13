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

using System;
using System.Management;

namespace HLlib
{
    public static class HWID
    {
        static string hwid_str;
        static string ram;
        static string ramid;
        static string cpu;
        static string mobo;
        static string moboid;
        static string cpuid;
        static string hddid;
        static string hddstr;

        public static string getHWID()
        {
            ramID();
            cpuID();
            moboID();
            hddID();
            hwid_str = ramid + "-" + cpuid + "-" + moboid + "-" + hddstr;
            return hwid_str;
        }

        static void cpuID()
        {
            ManagementObjectCollection mbsList = null;
            ManagementObjectSearcher mbs = new ManagementObjectSearcher("Select * From Win32_processor");
            mbsList = mbs.Get();

            foreach (ManagementObject mo in mbsList)
            {
                cpu = mo["ProcessorID"].ToString();
                cpuid = cpu.Substring(cpu.Length - 10);
            }
        }

        static void moboID()
        {
            ManagementObjectSearcher mos = new ManagementObjectSearcher("SELECT * FROM Win32_BaseBoard");
            ManagementObjectCollection moc = mos.Get();

            foreach (ManagementObject mo in moc)
            {
                mobo = (string)mo["SerialNumber"];
                moboid = mobo.Substring(mobo.Length - 10);
            }
        }

        static string hddID()
        {
            ManagementObjectSearcher searcher = new ManagementObjectSearcher("SELECT * FROM Win32_PhysicalMedia");

            foreach (ManagementObject wmi_HD in searcher.Get())
            {
                if (wmi_HD["SerialNumber"] != null)
                    hddid = (string)wmi_HD["SerialNumber"].ToString();

                hddstr = hddid.Substring(hddid.Length - 14);

            }
            return string.Empty;
        }

        static void ramID()
        {
            ManagementObjectSearcher mor = new ManagementObjectSearcher("SELECT * FROM Win32_PhysicalMemory");
            ManagementObjectCollection mok = mor.Get();

            foreach (ManagementObject morm in mok)
            {
                ram = (string)morm["PartNumber"];
                ramid = ram.Substring(ram.Length - 10);
            }
        }
    }
}
