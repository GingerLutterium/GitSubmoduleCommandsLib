using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GitSubmoduleCommandsLib
{
    public class SubmoduleCommands
    {
        List<string> list = new List<string>();
        public void SubmoduleCommandGit(string command_git)
        {
            ProcessStartInfo info = new ProcessStartInfo();
            info.FileName = "cmd.exe";
            info.Verb = "runas";
            info.Arguments = $"git submodule {command_git}";
            info.WindowStyle = ProcessWindowStyle.Normal;
            info.UseShellExecute = true;
            info.CreateNoWindow = false;
            Process.Start(info);
        }
    }
}
