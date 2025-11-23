using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PGSysX.Anahaw
{
    public static class PrereqChecker
    {
        // Checks Common Install Paths for Putty
        public static bool IsPuttyInstalled()
        {
            return File.Exists(@"C:\Program Files\PuTTY\putty.exe") ||
                   File.Exists(@"C:\Program Files (x86)\PuTTY\putty.exe");
        }

        // Checks Common Install Paths for WinSCP
        public static bool IsWinSCPInstalled()
        {
            return File.Exists(@"C:\Program Files (x86)\WinSCP\WinSCP.exe") ||
                   File.Exists(@"C:\Program Files\WinSCP\WinSCP.exe");
        }

        // Checks if ChromeDriver exists in the CURRENT Application folder
        public static bool IsChromeDriverPresent()
        {
            string appPath = AppDomain.CurrentDomain.BaseDirectory;
            return File.Exists(Path.Combine(appPath, "chromedriver.exe"));
        }

        // Checks if Python is in the System PATH
        public static bool IsPythonInstalled()
        {
            try
            {
                System.Diagnostics.Process process = new System.Diagnostics.Process();
                process.StartInfo.FileName = "cmd.exe";
                process.StartInfo.Arguments = "/c where python"; // Checks PATH
                process.StartInfo.CreateNoWindow = true;
                process.StartInfo.RedirectStandardOutput = true;
                process.StartInfo.UseShellExecute = false;
                process.Start();
                string output = process.StandardOutput.ReadToEnd();
                process.WaitForExit();

                // If 'where' returns a path ending in python.exe, it exists
                return !string.IsNullOrWhiteSpace(output) && output.Contains("python.exe");
            }
            catch
            {
                return false;
            }
        }
    }
}
