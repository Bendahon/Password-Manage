using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Password_Manager
{
    public partial class FrmAbout : Form
    {
        public FrmAbout()
        {
            InitializeComponent();
            LoadTheForm();
            LoadTheme();
        }

        string EncryptedFile = Program.EncryptedFilePath();
        string ThemeFile = Program.ThemeFileName();

        private void LoadTheForm()
        {
            this.Text = Program.ProgramNameAndVersion();
            lblVersionNumber.Text = Program.ProgramVersion();
            lblProgramName.Text = Program.ProgramName();
            lblProductDescShort.Text = "Simple password manager";
        }

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
                else if (CurrentTheme == "DARK")
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
            this.BackColor = BackGroundColour;

            Color ButtonColour = Color.FromArgb(126, 214, 223);
            Color ButtonTextColour = Color.Black;
            btnOk.BackColor = ButtonColour;

            btnOk.ForeColor = ButtonTextColour;

            btnOk.FlatAppearance.BorderSize = 1;
        }
        private void SetDarkTheme()
        {
            Color BackGroundColour = Color.FromArgb(83, 92, 104);
            this.BackColor = BackGroundColour;

            Color ButtonColour = Color.FromArgb(76, 74, 72);
            Color ButtonTextColour = Color.LightSteelBlue;
            btnOk.BackColor = ButtonColour;

            btnOk.ForeColor = ButtonTextColour;

            btnOk.FlatAppearance.BorderSize = 0;

        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
