using System;
using System.Collections.ObjectModel;
using System.Management.Automation;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {

            //while (true)
            //{
            //    var k = Console.ReadKey(true);
            //    if ((k.Modifiers & ConsoleModifiers.Control) != 0)
            //    {
            //        if ((k.Key & ConsoleKey.C) != 0)
            //        {
            //            break;
            //        }
            //    }
            //}

            string directory = "C:\\IT\\test";

            using (PowerShell powershell = PowerShell.Create())
            {
                // this changes from the user folder that PowerShell starts up with to your git repository
                powershell.AddScript($"cd {directory}");

                powershell.AddScript(@"git init");
                powershell.AddScript(@"git add *");
                powershell.AddScript(@"git commit -m 'git commit from PowerShell in C#'");
                powershell.AddScript(@"git push");

                Collection<PSObject> results = powershell.Invoke();
            }

        }
    }
}
