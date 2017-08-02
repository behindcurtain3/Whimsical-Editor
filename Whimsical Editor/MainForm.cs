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

            WorkingDirectory = Path.GetDirectoryName(file);
            UserPreferences.Default.WorkingDirectory = WorkingDirectory;
            UserPreferences.Default.Save();

            CurrentMod = JsonConvert.DeserializeObject<Mod>(File.ReadAllText(file));

            modNameTextBox.Text = CurrentMod.Name;
            modIDTextBox.Text = CurrentMod.ID;
            modAuthorTextBox.Text = CurrentMod.Author;
            modDescriptionTextBox.Text = CurrentMod.Description;

            modProvinceFilesListBox.Items.AddRange(CurrentMod.ProvinceFiles.ToArray());
            modRealmFilesListBox.Items.AddRange(CurrentMod.RealmFiles.ToArray());
            modLocalizationFilesListBox.Items.AddRange(CurrentMod.LocalizationFiles.ToArray());

            foreach (string f in CurrentMod.ProvinceFiles)
                CurrentMod.Data.Provinces.AddRange(LoadJsonArrayFile<Province>(f, "provinces"));
        }

        private void CloseCurrentMod()
        {

        }

        private T LoadJsonObjectFile<T>(string file)
        {
            file = Path.Combine(WorkingDirectory, file);

            if (!File.Exists(file))
                return default(T);

            return JsonConvert.DeserializeObject<T>(File.ReadAllText(file));
        }

        private List<T> LoadJsonArrayFile<T>(string file, string key)
        {
            file = Path.Combine(WorkingDirectory, file);

            if (!File.Exists(file))
                return new List<T>();

            JObject json = JObject.Parse(File.ReadAllText(file));
            JArray array = (JArray)json[key];

            List<T> list = new List<T>();
            foreach (var a in array)
            {
                list.Add(a.ToObject<T>());
            }

            return list;
        }
    }
}
