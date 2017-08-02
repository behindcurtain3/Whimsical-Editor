using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
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
using Whimsical_Editor.Data;

namespace Whimsical_Editor
{
    public partial class MainForm : Form
    {
        public string WorkingDirectory = "";
        public Mod CurrentMod { get; set; }

        public MainForm()
        {
            InitializeComponent();
            Initialize();
        }

        public void Initialize()
        {
            // Setup the working directory
            WorkingDirectory = UserPreferences.Default.WorkingDirectory;
        }
        
        private void quitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Mod File (*.txt)|*.txt";
            openFileDialog.InitialDirectory = WorkingDirectory;
            openFileDialog.Multiselect = false;
            openFileDialog.Title = "Select a mod to open";

            if (openFileDialog.ShowDialog(this) == System.Windows.Forms.DialogResult.OK)
            {
                System.Console.WriteLine(openFileDialog.FileName);

                if (CurrentMod != null)
                    CloseCurrentMod();

                SetCurrentMod(openFileDialog.FileName);
            }
        }

        private void SetCurrentMod(string file)
        {
            if (!File.Exists(file))
                return;

            CurrentMod = JsonConvert.DeserializeObject<Mod>(File.ReadAllText(file));

            modNameTextBox.Text = CurrentMod.Name;
            modIDTextBox.Text = CurrentMod.ID;
            modAuthorTextBox.Text = CurrentMod.Author;
            modDescriptionTextBox.Text = CurrentMod.Description;
        }

        private void CloseCurrentMod()
        {

        }
    }
}
