using System;
using System.Data;
using System.IO;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;
using System.Drawing;

namespace Password_Manager
{
    public partial class Form1 : Form
    {
        string EncryptedFile = Program.EncryptedFilePath();
        string ThemeFile = Program.ThemeFileName();
        public Form1()
        {
            InitializeComponent();
            this.Text = Program.ProgramNameAndVersion();
            LoadTheme();
        }
        #region Loading encrypted file
        private void btnLoad_Click(object sender, EventArgs e)
        {
            if (GetRowCount() >= 1)
            {
                dgridActivePasswords.DataSource = null;
            }
            ClearLogBox();

            // Load the XML password file
            try
            {
                LoadPrivateFile();
            }
            catch(Exception ex)
            {
                txtLogFile.Text = ex.ToString();
                return;
            }
            // I dont think this does anything except waste some resources
            JumbleThePasswordBox();

            // if we load a valid password box, enable the save box
            DataSet dsActivePasswords = (DataSet)dgridActivePasswords.DataSource;
            if (dsActivePasswords != null)
            {
                btnSave.Enabled = true;
            }
            dsActivePasswords.Dispose();
        }
        private void LoadPrivateFile()
        {
            string DecryptedData = "";
            StreamReader sr = new StreamReader(EncryptedFile);
            string StreamEncrypted = sr.ReadToEnd();
            sr.Close();
            if (txtPassword.Text.Length >= 1)
            {
                DecryptedData = DecryptData(StreamEncrypted, txtPassword.Text);
                //txtLogFile.Text = DecryptedData;
            }
            MemoryStream ms = new MemoryStream(Encoding.UTF8.GetBytes(DecryptedData));
            DataSet ds = new DataSet();
            ds.ReadXml(ms);
            dgridActivePasswords.DataSource = ds;
            dgridActivePasswords.DataMember = "Info";
        }
        #endregion
        #region Saving open file
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (CheckIfInformationCanBeSaved())
            {
                SaveActiveInformation();
            }
        }

        private void SaveActiveInformation()
        {
            ClearLogBox();
            string PrivateXMLData;

            if (GetRowCount() >= 1)
            {
                try
                {
                    // Get an XML readable schema
                    PrivateXMLData = ReadTableDataExtractXML();
                    // if a real schema was returned, save to a file
                    if (PrivateXMLData != "")
                    {
                        SaveEncryptedFile(PrivateXMLData);
                        PrivateXMLData = string.Empty;
                    }
                }
                catch (Exception ex)
                {
                    txtLogFile.Text = ex.ToString();
                }
            }
            else
            {
                return;
            }
        }
        private string ReadTableDataExtractXML()
        {
            // Read the datasource
            DataSet dsActivePasswords = (DataSet)dgridActivePasswords.DataSource;
            if (dsActivePasswords == null)
            {
                MessageBox.Show("object null");
                return "";
            }
            // create the memory stream and convert the passwords to an XML schema
            MemoryStream XMLOutput = new MemoryStream();
            dsActivePasswords.WriteXml(XMLOutput);

            // convert the MemoryStream to a readable text string
            return Encoding.UTF8.GetString(XMLOutput.ToArray());
        }
        private void SaveEncryptedFile(string PrivateData)
        {
            DialogResult dr = MessageBox.Show("Encrypted data is not recoverable", Program.ProgramName(), MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (dr == DialogResult.Ignore)
            {
                MessageBox.Show("Not saved!", Program.ProgramName());
                return;
            }
            else if (dr == DialogResult.OK)
            {
                StreamWriter sw = new StreamWriter(EncryptedFile);
                sw.Write(EncryptData(PrivateData, txtPassword.Text));
                sw.Close();
                MessageBox.Show("Saved!", Program.ProgramName());
            }
            else
            {
                MessageBox.Show("Not saved!", Program.ProgramName());
                return;
            }
            LockTheSystem();
        }

        private bool CheckIfInformationCanBeSaved()
        {
            double count = 1.0;

            if (string.IsNullOrEmpty(txtPassword.Text))
            {
                MessageBox.Show("You must have a valid password", Program.ProgramName());
                return false;
            }

            foreach (DataGridViewRow row in dgridActivePasswords.Rows)
            {
                //MessageBox.Show(row.ToString());
                foreach (DataGridViewCell cell in row.Cells)
                {
                    try
                    {
                        if (cell.Value.ToString().Trim() == "")
                        {
                            int counter = Convert.ToInt32(Math.Floor(count));
                            MessageBox.Show($"Row {counter} in system contains blank data, can't continue", Program.ProgramName());
                            return false;
                        }

                    }
                    catch (Exception EX)
                    {
                        txtLogFile.Text = EX.ToString();
                    }
                    count += 0.25;
                }
            }
            return true;
        }
        #endregion
        #region Lock the system down
        private void btnLock_Click(object sender, EventArgs e)
        {
            LockTheSystem(true);
        }
        private void LockTheSystem(bool b = false)
        {
            ClearLogBox();
            if (GetRowCount() >= 1)
            {
                dgridActivePasswords.DataSource = null;
                dgridActivePasswords.DataSource = null;
                dgridActivePasswords.DataSource = null;
            }
            ClearPasswordBox();
            if (b)
            {
                Application.Exit();
            }
        }
        private void JumbleThePasswordBox()
        {
            this.Enabled = false;
            Random rand = new Random();
            int num = rand.Next(100, 150);
            for(int i = 1; i < num; i++)
            {
                txtPassword.Text = "1";
                //LoadPrivateFile();
                GC.Collect();
            }
            txtPassword.Text = "";
            this.Enabled = true;
        }


        #endregion
        #region Exiting application
        private void btnExit_Click(object sender, EventArgs e)
        {
            ExitApplication();
        }
        private void ExitApplication()
        {
            DialogResult dr = MessageBox.Show("Are you sure you wish to exit?", Program.ProgramName(), MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (dr == DialogResult.Ignore)
            {
                return;
            }
            else if (dr == DialogResult.OK)
            {
                Application.Exit();
            }
            else
            {
                return;
            }

        }
        #endregion
        #region AES encryption and decryption
        private string EncryptData(string DataToEncrypt, string Encryptionkey)
        {
            RijndaelManaged objrij = new RijndaelManaged();
            objrij.Mode = CipherMode.CBC;
            objrij.Padding = PaddingMode.PKCS7; 
            objrij.KeySize = 0x80; 
            objrij.BlockSize = 0x80;   
            byte[] passBytes = Encoding.UTF8.GetBytes(Encryptionkey);  
            byte[] EncryptionkeyBytes = new byte[] { 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00 };
            int len = passBytes.Length;
            if (len > EncryptionkeyBytes.Length)
            {
                len = EncryptionkeyBytes.Length;
            }
            Array.Copy(passBytes, EncryptionkeyBytes, len);
            objrij.Key = EncryptionkeyBytes;
            objrij.IV = EncryptionkeyBytes;
            ICryptoTransform objtransform = objrij.CreateEncryptor();
            byte[] textDataByte = Encoding.UTF8.GetBytes(DataToEncrypt);
            return Convert.ToBase64String(objtransform.TransformFinalBlock(textDataByte, 0, textDataByte.Length));

        }
        private string DecryptData(string EncryptedText, string Encryptionkey)
        {
            RijndaelManaged objrij = new RijndaelManaged();
            objrij.Mode = CipherMode.CBC;
            objrij.Padding = PaddingMode.PKCS7;
            objrij.KeySize = 0x80;
            objrij.BlockSize = 0x80;
            byte[] encryptedTextByte = Convert.FromBase64String(EncryptedText);
            byte[] passBytes = Encoding.UTF8.GetBytes(Encryptionkey);
            byte[] EncryptionkeyBytes = new byte[0x10];
            int len = passBytes.Length;
            if (len > EncryptionkeyBytes.Length)
            {
                len = EncryptionkeyBytes.Length;
            }
            Array.Copy(passBytes, EncryptionkeyBytes, len);
            objrij.Key = EncryptionkeyBytes;
            objrij.IV = EncryptionkeyBytes;
            byte[] TextByte = objrij.CreateDecryptor().TransformFinalBlock(encryptedTextByte, 0, encryptedTextByte.Length);
            return Encoding.UTF8.GetString(TextByte); 
        }
        #endregion
        #region I forgot my password, silly boy
        private void btnDefaultPasswords_Click(object sender, EventArgs e)
        {
            DefaultPasswordFile();
        }
        private void DefaultPasswordFile()
        {
            string DefaultFileString = @"5G2+4uw43mQSCbDLP/PV0jqSKE4ZrhQGn5awSXqTprKj2RzaRirGmOQ+6Keuu9m/n1z/MDsujlpNZk6oseceZjkb1UwX/SbpiIWMKb/9MtKESbMUkKw6lLyFxXqfQNJUbJJT6wrib+cSM8Kx6RgWAXSSYPpacjHQkHxpx7fitP9QqICG5usac6Phgq7k5pgbakS1LeDaH2HyMimzrVo9faPsajvt+467MGy1AN5bo0MVRc8nTCFJlm5eOFHfpWpuPuYP6mvlVJV/b+YmvRmqhg==";

            DialogResult dr = MessageBox.Show("Defaulting will remove all saved passwords and restore default password, Continue?", Program.ProgramName(), MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (dr == DialogResult.Ignore)
            {
                return;
            }
            else if (dr == DialogResult.OK)
            {
                StreamWriter sw = new StreamWriter(EncryptedFile);
                sw.Write(DefaultFileString);
                sw.Close();
                dgridActivePasswords.DataSource = null;
                ClearLogBox();
                ClearPasswordBox();
            }
            else
            {
                return;
            }
            MessageBox.Show("Defaulted password to 1", Program.ProgramName());
        }
        #endregion
        #region Methods
        private int GetRowCount()
        {
            return dgridActivePasswords.Rows.Count;
        }
        private void ClearLogBox()
        {
            txtLogFile.Text = "";
        }
        private void ClearPasswordBox()
        {
            JumbleThePasswordBox();
        }
        #endregion
        #region Check boxes
        private void chckDefaultPassword_CheckedChanged(object sender, EventArgs e)
        {
            btnDefaultPasswords.Enabled = chckDefaultPassword.Checked;
        }
        private void chckViewPassword_CheckedChanged(object sender, EventArgs e)
        {
            btnSeePassword.Enabled = chckViewPassword.Checked;
        }
        #endregion
        #region Misc form stuff
        private void btnSeePassword_MouseEnter(object sender, EventArgs e)
        {
            txtPassword.UseSystemPasswordChar = false;
        }
        private void btnSeePassword_MouseLeave(object sender, EventArgs e)
        {
            txtPassword.UseSystemPasswordChar = true;
        }
        #endregion
        #region Themes
        private void LoadTheme()
        {
            if (File.Exists(ThemeFile))
            {
                StreamReader sr = new StreamReader(ThemeFile);
                string CurrentTheme = sr.ReadToEnd();
                sr.Close();
                if (CurrentTheme == "LIGHT")
                {
                    SetLightTheme();
                }
                else if(CurrentTheme == "DARK")
                {
                    SetDarkTheme();
                }
                else
                {
                    MessageBox.Show("Unknown theme, setting to LIGHT", Program.ProgramName());
                    SetLightTheme();
                }
            }
            else
            {
                StreamWriter sw = new StreamWriter(ThemeFile);
                sw.Write("LIGHT");
                sw.Close();
                LoadTheme();
            }
        }
        private void SetLightTheme()
        {
            Color BackGroundColour = Color.FromArgb(199, 236, 238);
            Color MenuStripTextColour = Color.Black;
            this.BackColor = BackGroundColour;
            menuStrip1.BackColor = BackGroundColour;
            menuStrip1.ForeColor = MenuStripTextColour;

            fileToolStripMenuItem.ForeColor = MenuStripTextColour;
            aboutToolStripMenuItem.ForeColor = MenuStripTextColour;
            darkToolStripMenuItem.ForeColor = MenuStripTextColour;
            exitToolStripMenuItem1.ForeColor = MenuStripTextColour;
            infoToolStripMenuItem.ForeColor = MenuStripTextColour;
            lightToolStripMenuItem.ForeColor = MenuStripTextColour;
            ThemeToolStripMenuItem.ForeColor = MenuStripTextColour;
            exportEncryptedDataToolStripMenuItem.ForeColor = MenuStripTextColour;
            importEncryptedDataToolStripMenuItem.ForeColor = MenuStripTextColour;

            fileToolStripMenuItem.BackColor = BackGroundColour;
            aboutToolStripMenuItem.BackColor = BackGroundColour;
            darkToolStripMenuItem.BackColor = BackGroundColour;
            exitToolStripMenuItem1.BackColor = BackGroundColour;
            infoToolStripMenuItem.BackColor = BackGroundColour;
            lightToolStripMenuItem.BackColor = BackGroundColour;
            ThemeToolStripMenuItem.BackColor = BackGroundColour;
            exportEncryptedDataToolStripMenuItem.BackColor = BackGroundColour;
            importEncryptedDataToolStripMenuItem.BackColor = BackGroundColour;

            lblPasswordBox.ForeColor = MenuStripTextColour;

            Color ButtonColour = Color.FromArgb(126, 214, 223);
            Color ButtonTextColour = Color.Black;
            btnDefaultPasswords.BackColor = ButtonColour;
            btnExit.BackColor = ButtonColour;
            btnLoad.BackColor = ButtonColour;
            btnLock.BackColor = ButtonColour;
            btnSave.BackColor = ButtonColour;
            btnSeePassword.BackColor = ButtonColour;

            btnDefaultPasswords.ForeColor = ButtonTextColour;
            btnExit.ForeColor = ButtonTextColour;
            btnLoad.ForeColor = ButtonTextColour;
            btnLock.ForeColor = ButtonTextColour;
            btnSave.ForeColor = ButtonTextColour;
            btnSeePassword.ForeColor = ButtonTextColour;

            // Set the borders
            btnDefaultPasswords.FlatAppearance.BorderSize = 1;
            btnExit.FlatAppearance.BorderSize = 1;
            btnLoad.FlatAppearance.BorderSize = 1;
            btnLock.FlatAppearance.BorderSize = 1;
            btnSave.FlatAppearance.BorderSize = 1;
            btnSeePassword.FlatAppearance.BorderSize = 1;
        }
        private void SetDarkTheme()
        {
            Color BackGroundColour = Color.FromArgb(83, 92, 104);
            Color MenuStripTextColour = Color.LightSteelBlue;
            this.BackColor = BackGroundColour;
            menuStrip1.BackColor = BackGroundColour;
            menuStrip1.ForeColor = MenuStripTextColour;

            fileToolStripMenuItem.ForeColor = MenuStripTextColour;
            aboutToolStripMenuItem.ForeColor = MenuStripTextColour;
            darkToolStripMenuItem.ForeColor = MenuStripTextColour;
            exitToolStripMenuItem1.ForeColor = MenuStripTextColour;
            infoToolStripMenuItem.ForeColor = MenuStripTextColour;
            lightToolStripMenuItem.ForeColor = MenuStripTextColour;
            ThemeToolStripMenuItem.ForeColor = MenuStripTextColour;
            exportEncryptedDataToolStripMenuItem.ForeColor = MenuStripTextColour;
            importEncryptedDataToolStripMenuItem.ForeColor = MenuStripTextColour;

            fileToolStripMenuItem.BackColor = BackGroundColour;
            aboutToolStripMenuItem.BackColor = BackGroundColour;
            darkToolStripMenuItem.BackColor = BackGroundColour;
            exitToolStripMenuItem1.BackColor = BackGroundColour;
            infoToolStripMenuItem.BackColor = BackGroundColour;
            lightToolStripMenuItem.BackColor = BackGroundColour;
            ThemeToolStripMenuItem.BackColor = BackGroundColour;
            exportEncryptedDataToolStripMenuItem.BackColor = BackGroundColour;
            importEncryptedDataToolStripMenuItem.BackColor = BackGroundColour;

            lblPasswordBox.ForeColor = MenuStripTextColour;

            Color ButtonColour = Color.FromArgb(76, 74, 72);
            Color ButtonTextColour = Color.LightSteelBlue;
            btnDefaultPasswords.BackColor = ButtonColour;
            btnExit.BackColor = ButtonColour;
            btnLoad.BackColor = ButtonColour;
            btnLock.BackColor = ButtonColour;
            btnSave.BackColor = ButtonColour;
            btnSeePassword.BackColor = ButtonColour;

            btnDefaultPasswords.ForeColor = ButtonTextColour;
            btnExit.ForeColor = ButtonTextColour;
            btnLoad.ForeColor = ButtonTextColour; 
            btnLock.ForeColor = ButtonTextColour;
            btnSave.ForeColor = ButtonTextColour;
            btnSeePassword.ForeColor = ButtonTextColour;

            // Set the borders
            btnDefaultPasswords.FlatAppearance.BorderSize = 0;
            btnExit.FlatAppearance.BorderSize = 0;
            btnLoad.FlatAppearance.BorderSize = 0;
            btnLock.FlatAppearance.BorderSize = 0;
            btnSave.FlatAppearance.BorderSize = 0;
            btnSeePassword.FlatAppearance.BorderSize = 0;
        }
        #endregion
        #region Top menu
        private void lightToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StreamWriter sw = new StreamWriter(ThemeFile);
            sw.Write("LIGHT");
            sw.Close();
            SetLightTheme();
        }
        private void darkToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StreamWriter sw = new StreamWriter(ThemeFile);
            sw.Write("DARK");
            sw.Close();
            SetDarkTheme();
        }
        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmAbout fa = new FrmAbout();
            fa.ShowDialog();
        }
        private void exitToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ExitApplication();
        }

        private void exportEncryptedDataToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Get folder output to go to
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            if (fbd.ShowDialog() == DialogResult.OK)
            {
                // Name the file, copy it
                string OutputFile = fbd.SelectedPath + $@"\{Program.EncryptedFileName()}";
                if (DoesFileExist(OutputFile))
                {
                    DialogResult dr = MessageBox.Show("File exists, overwrite?", Program.ProgramName(), MessageBoxButtons.OKCancel);
                    if (dr == DialogResult.OK)
                    {
                        CopyFileAndOverwrite(Program.EncryptedFilePath(), OutputFile);
                    }
                    else
                    {
                        return;
                    }
                }
            }
            MessageBox.Show("Exported!", Program.ProgramName());
        }
        private bool DoesFileExist(string FilePath)
        {
            if (File.Exists(FilePath))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private void CopyFileAndOverwrite(string Source, string Destination)
        {
            File.Copy(Source, Destination, true);
        }

        private void importEncryptedDataToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlgOpen = new OpenFileDialog();
            dlgOpen.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            //dlgOpen.Filter = "APAT Project Files|*.APAT";
            dlgOpen.FilterIndex = 1;
            dlgOpen.ShowDialog();
            MessageBox.Show(dlgOpen.FileName);
            DialogResult dr = MessageBox.Show("Encrypted file exists, overwrite?", Program.ProgramName(), MessageBoxButtons.OKCancel);
            if(dr == DialogResult.OK)
            {
                CopyFileAndOverwrite(dlgOpen.FileName, Program.EncryptedFilePath());
            }
            else
            {
                return;
            }
            MessageBox.Show("Imported, Program doesnt check for proper encryption", Program.ProgramName());

        }

        #endregion
    }
}
