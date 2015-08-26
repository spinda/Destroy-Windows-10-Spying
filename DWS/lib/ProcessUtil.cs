using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;

namespace DWS_Lite.lib
{
    class ProcessUtil
    {
        private static string StartProcess(string name, string args)
        {
            try
            {
                var proc = new Process
                {
                    StartInfo = new ProcessStartInfo
                    {
                        FileName = name,
                        Arguments = args,
                        UseShellExecute = false,
                        RedirectStandardOutput = true,
                        CreateNoWindow = true,
                        StandardOutputEncoding = Encoding.GetEncoding(866)
                    }
                };
                proc.Start();
                string line = null;
                while (!proc.StandardOutput.EndOfStream)
                {
                    line += "\n" + proc.StandardOutput.ReadLine();
                }
                return line;
            }
            catch (Exception ex)
            {
                //fatalerrors++;
                return ex.ToString();
            }
        }
        public static string RunCmd(string args)
        {
            return StartProcess(Paths.ShellCmdLocation, args);
        }


    }
}
