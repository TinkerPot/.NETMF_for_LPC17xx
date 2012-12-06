using System;
using System.Collections;
using System.Windows.Forms;
using System.Text;
using System.Text.RegularExpressions;
using System.Configuration;
using System.Runtime.InteropServices;
using System.Reflection;
using Microsoft.NetMicroFramework.Tools.MFDeployTool.Engine;

[assembly: ComVisible(false)]
[assembly: CLSCompliantAttribute(false)]

namespace Microsoft.NetMicroFramework.Tools.MFDeployTool
{
    internal class NativeMethods
    {
        private NativeMethods()
        {
        }

        private const String KERNEL32 = "kernel32.dll";
        internal const uint ATTACH_PARENT_PROCESS = 0x0ffffffff;

        [DllImport(KERNEL32, SetLastError = true, ExactSpelling = true)]
        internal static extern bool AttachConsole(uint dwProcessId);

        [DllImport(KERNEL32, SetLastError = true, ExactSpelling = true)]
        internal static extern bool FreeConsole();

        [DllImport(KERNEL32, SetLastError = true, ExactSpelling = true)]
        internal static extern bool AllocConsole();

    }

    public static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        public static void Main(params string[] args)
        {
            bool fRunUI = true;
            MFPortDefinition transport = null;
            MFPortDefinition transportTinyBooter = null;

            if (args.Length > 0)
            {
                try
                {
                    StringBuilder sb = new StringBuilder();
                    string all_args = "";
                    string error;

                    foreach (string arg in args)
                    {
                        // take care of spaces in path names
                        if (arg.ToUpper().StartsWith(ArgumentParser.Commands.Deploy.ToString().ToUpper() + ArgumentParser.ArgSeparator))
                        {
                            string tmp = arg;
                            // place double quoutes around files
                            tmp = tmp.Replace(ArgumentParser.ArgSeparator.ToString(), ArgumentParser.ArgSeparator + "\"");
                            tmp = tmp.Replace(ArgumentParser.FileSeparator.ToString(), "\"" + ArgumentParser.FileSeparator + "\"");
                            sb.AppendFormat("{0}\"", tmp);
                        }
                        else
                        {
                            sb.AppendFormat("{0} ", arg);
                        }
                    }
                    all_args = sb.ToString().Trim();

                    ArgumentParser parser = new ArgumentParser();
                    // error condition
                    if (!parser.ValidateArgs(all_args, out error))
                    {
                        fRunUI = false;
                        Console.WriteLine(Properties.Resources.ErrorPrefix + error);
                    }
                    // valid command, no UI
                    else if (parser.Command != (ArgumentParser.Commands)(-1))
                    {
                        fRunUI = false;
                        parser.Execute();
                    }
                    // no command, but interface defined, so update UI transport field
                    else if (parser.Interface != null && parser.Interface.Transport != (TransportType)(-1))
                    {
                        transport = parser.Interface;
                        transportTinyBooter = parser.TinybtrInterface;
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine(Properties.Resources.ErrorPrefix + e.Message);
                }
            }

            if (fRunUI)
            {
                NativeMethods.FreeConsole();

                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                Form1 form = new Form1();
                form.Transport = transport;
                form.TransportTinyBooter = transportTinyBooter;
                Application.Run(form);
            }
        }
    }
}