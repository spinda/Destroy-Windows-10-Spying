using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace DWS_Lite.lib
{
    class FileUtil
    {
        public static void RecreateLogFile(string logfilename)
        {
            try
            {
                if (!File.Exists(logfilename))
                {
                    File.Create(logfilename).Close();
                }
                else
                {
                    File.Delete(logfilename);
                    File.Create(logfilename).Close();
                }
            }
            catch (Exception)
            {

            }
        }
        public static void DeleteFile(string filepath)
        {
            ProcessUtil.RunCmd("/c del /F /Q " + filepath);
        }
    }
}
