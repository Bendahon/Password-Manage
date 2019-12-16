using System;
using System.Windows.Forms;
using System.IO;

namespace Password_Manager
{
    static class Program
    {
        /// <summary>
        /// I am a password manager, maybe not an effecient one 
        /// but a simple enough one to not have backdoors :)
        /// </summary>
        [STAThread]

        static void Main()
        {
            CheckInstallation();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
        static private string PGMBaseDirectory()
        {
            return @"C:\Bendahon\PasswordManager\";
        }

        static private string PGMFileDirectory()
        {
            return $@"{PGMBaseDirectory()}\file\";
        }

        static private string PGMBINDirectory()
        {
            return $@"{PGMBaseDirectory()}\bin\";
        }

        static public string EncryptedFileName()
        {
            return $@"Encrypted";
        }

        static public string EncryptedFilePath()
        {
            return $@"{PGMBaseDirectory()}\file\{EncryptedFileName()}";
        }

        static public string ThemeFileName()
        {
            return $@"{PGMBaseDirectory()}\file\theme";
        }
        static public string ProgramName()
        {
            return "Password Manager";
        }
        static public string ProgramVersion()
        {
            return "1.2";
        }
        static public string ProgramNameAndVersion()
        {
            return ProgramName() + " " + ProgramVersion();
        }

        static public void CheckInstallation()
        {
            if (!Directory.Exists(PGMBaseDirectory()))
            {
                Directory.CreateDirectory(PGMBaseDirectory());
            }
            if (!Directory.Exists(PGMFileDirectory()))
            {
                Directory.CreateDirectory(PGMFileDirectory());
            }
            if (!Directory.Exists(PGMBINDirectory()))
            {
                Directory.CreateDirectory(PGMBINDirectory());
            }
            if (!File.Exists(EncryptedFilePath()))
            {
                string DefaultFileString = @"5G2+4uw43mQSCbDLP/PV0jqSKE4ZrhQGn5awSXqTprKj2RzaRirGmOQ+6Keuu9m/n1z/MDsujlpNZk6oseceZjkb1UwX/SbpiIWMKb/9MtKESbMUkKw6lLyFxXqfQNJUbJJT6wrib+cSM8Kx6RgWAXSSYPpacjHQkHxpx7fitP9QqICG5usac6Phgq7k5pgbakS1LeDaH2HyMimzrVo9faPsajvt+467MGy1AN5bo0MVRc8nTCFJlm5eOFHfpWpuPuYP6mvlVJV/b+YmvRmqhg==";
                StreamWriter sw = new StreamWriter(EncryptedFilePath());
                sw.Write(DefaultFileString);
                sw.Close();
            }
            string runningdir = Directory.GetCurrentDirectory();
            if(Directory.GetCurrentDirectory() + @"\" != PGMBINDirectory())
            {
                try
                {
                    File.Copy(Directory.GetCurrentDirectory() + @"\Password Manager.exe", PGMBINDirectory() + "Password Manager.exe");
                }
                catch
                {

                }
            }

        }
    }
}
