using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;

namespace LinuxInput
{
    public class BashShell
    {
        public int RunBashCommand(string cmd, Dictionary<string, string> environmentVariables = null)
        {
            using (var process = new Process())
            {
                process.StartInfo = new ProcessStartInfo
                {
                    FileName = "/bin/bash",
                    Arguments = $"-c \"{cmd}\"",
                    RedirectStandardOutput = true,
                    UseShellExecute = false,
                    CreateNoWindow = true
                };
                if (environmentVariables != null)
                {
                    foreach (var variable in environmentVariables)
                    {
                        process.StartInfo.EnvironmentVariables[variable.Key] = variable.Value;
                    }
                }
                
                process.Start();
                var result = process.StandardOutput.ReadToEnd().Trim('\n').Trim('\r');
                process.WaitForExit();
                return process.Id;
            }
        }
    
        public void RunBashScript(string cmd)
        {
            var process = new Process
            {
                StartInfo = new ProcessStartInfo
                {
                    FileName = "/bin/bash",
                    Arguments = $"-c \"{cmd}\"",
                    RedirectStandardInput = true,
                    RedirectStandardOutput = true,
                    RedirectStandardError = true,
                    UseShellExecute = false,
                    CreateNoWindow = true
                },
                EnableRaisingEvents = true
            };
    
            
            process.Start();
            process.BeginOutputReadLine();
            process.BeginErrorReadLine();
        }
    }
}
