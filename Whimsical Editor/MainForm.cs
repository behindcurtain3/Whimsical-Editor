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
using Whimsical_Editor.Wrappers;

namespace Whimsical_Editor
{
    public partial class MainForm : Form
    {
        public const string EditorName = "Whimsical Editor";
        public const string ProvincesDirectory = "provinces";
        public const string RealmsDirectory = "realms";
        public string WorkingDirectory = "";        
        public Mod CurrentMod { get; set; }

        private Realm SelectedRealm = null;

        public MainForm()
        {
            InitializeComponent();
            Initialize();

            if (!String.IsNullOrEmpty(UserPreferences.Default.LastMod))
                SetCurrentMod(UserPreferences.Default.LastMod);
        }

        public void Initialize()
        {
            // Setup the working directory
            WorkingDirectory = UserPreferences.Default.WorkingDirectory;

            realmsTreeView.NodeMouseClick += new TreeNodeMouseClickEventHandler(realmsTreeView_NodeMouseClick);
            contextRealmRootNew.Click += ContextRealmRootNew_Click;
            menuItemAddRealmFile.Click += MenuItemAddRealmFile_Click;
        }        

        private void SetCurrentMod(string file)
        {
            if (!File.Exists(file))
                return;            

            CurrentMod = JsonConvert.DeserializeObject<Mod>(File.ReadAllText(file));
            CurrentMod.FileName = file;

            WorkingDirectory = Path.GetDirectoryName(file);
            UserPreferences.Default.WorkingDirectory = WorkingDirectory;
            UserPreferences.Default.LastMod = file;
            UserPreferences.Default.Save();

            this.Text = EditorName + " - " + CurrentMod.Name;
            tabControl.Enabled = true;
            tabControl.Visible = true;

            modNameTextBox.Text = CurrentMod.Name;
            modNameTextBox.DataBindings.Add("Text", CurrentMod, "Name");

            modIDTextBox.Text = CurrentMod.ID;
            modIDTextBox.DataBindings.Add("Text", CurrentMod, "ID");

            modAuthorTextBox.Text = CurrentMod.Author;
            modAuthorTextBox.DataBindings.Add("Text", CurrentMod, "Author");

            modDescriptionTextBox.Text = CurrentMod.Description;
            modDescriptionTextBox.DataBindings.Add("Text", CurrentMod, "Description");

            // Setup the provinces tree
            provincesTreeView.Nodes.Clear();

            foreach (string f in Directory.GetFiles(Path.Combine(WorkingDirectory, CurrentMod.Name, ProvincesDirectory), "*.txt"))
            {
                ProvinceJsonFile loadedFile = JsonConvert.DeserializeObject<ProvinceJsonFile>(File.ReadAllText(f));
                loadedFile.FileName = Path.GetFileName(f);

                CurrentMod.Data.ProvinceFiles.Add(loadedFile);
            }

            foreach (ProvinceJsonFile provinceFile in CurrentMod.Data.ProvinceFiles)
            {
                TreeNode root = new TreeNode(provinceFile.FileName);
                root.Expand();
                root.Tag = provinceFile;
                provincesTreeView.Nodes.Add(root);

                BuildProvinceFileTree(root, provinceFile);
            }

            // Setup the realm tree
            realmsTreeView.Nodes.Clear();

            foreach (string f in Directory.GetFiles(Path.Combine(WorkingDirectory, CurrentMod.Name, RealmsDirectory), "*.txt"))
            {
                // Load the file data
                RealmJsonFile loadedFile = JsonConvert.DeserializeObject<RealmJsonFile>(File.ReadAllText(f));
                loadedFile.FileName = Path.GetFileName(f);

                CurrentMod.Data.RealmFiles.Add(loadedFile);
            }            

            foreach(RealmJsonFile realmFile in CurrentMod.Data.RealmFiles)
            {
                TreeNode root = new TreeNode(realmFile.FileName);
                root.Expand();
                root.Tag = realmFile;
                root.ContextMenuStrip = contextMenuRealmRoot;
                realmsTreeView.Nodes.Add(root);

                BuildRealmFileTree(root, realmFile);                
            }
        }

        private void CloseCurrentMod()
        {

        }

        private void SaveMod()
        {
            if (CurrentMod == null)
                return;

            // Save out the province files
            foreach (ProvinceJsonFile file in CurrentMod.Data.ProvinceFiles)
            {
                string filePath = Path.Combine(WorkingDirectory, CurrentMod.Name, ProvincesDirectory, file.FileName);
                File.WriteAllText(filePath, JsonConvert.SerializeObject(file));
            }

            foreach (RealmJsonFile file in CurrentMod.Data.RealmFiles)
            {
                string filePath = Path.Combine(WorkingDirectory, CurrentMod.Name, RealmsDirectory, file.FileName);
                File.WriteAllText(filePath, JsonConvert.SerializeObject(file));
            }

            // Save out the actual mod file itself
            string modFile = CurrentMod.FileName;
            File.WriteAllText(modFile, JsonConvert.SerializeObject(CurrentMod));
        }

        private T LoadJsonObjectFile<T>(string file)
        {
            file = Path.Combine(WorkingDirectory, file);

            if (!File.Exists(file))
                return default(T);

            return JsonConvert.DeserializeObject<T>(File.ReadAllText(file));
        }

        private void BuildProvinceFileTree(TreeNode root, ProvinceJsonFile file)
        {
            root.Nodes.Clear();

            // Add a subnode for each realm in the file
            foreach (Province p in file.Provinces.OrderBy(x => x.ID))
            {
                TreeNode node = new TreeNode(p.ToString());
                node.Tag = p;
                root.Nodes.Add(node);
                p.Node = node;
            }
        }

        private void BuildRealmFileTree(TreeNode root, RealmJsonFile file)
        {
            root.Nodes.Clear();

            // Add a subnode for each realm in the file
            foreach (Realm r in file.Realms.OrderBy(x => x.ID))
            {
                TreeNode node = new TreeNode(r.ToString());
                node.Tag = r;
                root.Nodes.Add(node);
                r.Node = node;
            }
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

        #region Mouseclick events

        private void realmsTreeView_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            TreeNode selectedNode = e.Node;

            // Don't do this on a right-click
            if (e.Button == System.Windows.Forms.MouseButtons.Right)
                return;

            if (e.Node.Tag is RealmJsonFile)
                return;

            SelectedRealm = (Realm) e.Node.Tag;
            
            if(SelectedRealm != null)
            {
                selectedRealmID.Text = SelectedRealm.ID.ToString();
                selectedRealmID.DataBindings.Clear();
                selectedRealmID.DataBindings.Add("Text", SelectedRealm, "ID");                

                selectedRealmName.Text = SelectedRealm.Name;
                selectedRealmName.DataBindings.Clear();
                selectedRealmName.DataBindings.Add("Text", SelectedRealm, "Name");

                selectedRealmRank.Text = SelectedRealm.Rank;
                selectedRealmRank.DataBindings.Clear();
                selectedRealmRank.DataBindings.Add("Text", SelectedRealm, "Rank");

                selectedRealmR.Text = SelectedRealm.R.ToString();
                selectedRealmR.DataBindings.Clear();
                selectedRealmR.DataBindings.Add("Text", SelectedRealm, "R");

                selectedRealmG.Text = SelectedRealm.G.ToString();
                selectedRealmG.DataBindings.Clear();
                selectedRealmG.DataBindings.Add("Text", SelectedRealm, "G");

                selectedRealmB.Text = SelectedRealm.B.ToString();
                selectedRealmB.DataBindings.Clear();
                selectedRealmB.DataBindings.Add("Text", SelectedRealm, "B");

                SelectedRealm.PropertyChanged += SelectedRealm_PropertyChanged;
            }

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
                if (CurrentMod != null)
                    CloseCurrentMod();

                SetCurrentMod(openFileDialog.FileName);
            }
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveMod();
        }

        private void ContextRealmRootNew_Click(object sender, EventArgs e)
        {
            TreeNode selectedNode = realmsTreeView.SelectedNode;

            if (selectedNode.Tag is Realm)
                selectedNode = selectedNode.Parent;

            RealmJsonFile file = (RealmJsonFile)selectedNode.Tag;
            Realm r = new Realm() { ID = 0, Name = "New Realm" };

            file.Realms.Add(r);

            BuildRealmFileTree(selectedNode, file);
        }

        private void MenuItemAddRealmFile_Click(object sender, EventArgs e)
        {
            NewRealmFileForm realm = new NewRealmFileForm();
            DialogResult result = realm.ShowDialog();

            if(result == DialogResult.OK)
            {
                RealmJsonFile file = new RealmJsonFile();
                file.FileName = realm.realmFileNameText.Text;

                CurrentMod.Data.RealmFiles.Add(file);

                TreeNode root = new TreeNode(file.FileName);
                root.Tag = file;
                root.ContextMenuStrip = contextMenuRealmRoot;
                realmsTreeView.Nodes.Add(root);
            }
        }

        #endregion

        #region Data change events

        private void SelectedRealm_PropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            Realm realm = (Realm)sender;

            switch (e.PropertyName)
            {
                case "ID":
                case "Name":
                    if(realm.Node != null)
                        realm.Node.Text = realm.ToString();
                    break;
            }
        }

        #endregion
    }
}
