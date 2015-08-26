using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace DWS_Lite.lib
{
    class Paths
    {
        public static string SysDir = Path.GetPathRoot(Environment.SystemDirectory);
        public static string ShellCmdLocation = 
            (File.Exists(SysDir + @"Windows\Sysnative\cmd.exe")) ? 
                SysDir + @"Windows\Sysnative\cmd.exe" : SysDir + @"Windows\System32\cmd.exe";
        public static string system32location = 
            (File.Exists(SysDir + @"Windows\Sysnative\cmd.exe")) ? 
                SysDir + @"Windows\System32\" : SysDir + @"Windows\System32\";


    }
}
