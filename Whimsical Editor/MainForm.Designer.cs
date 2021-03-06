﻿namespace Whimsical_Editor
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.nationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.provinceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.characterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.resourceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.quitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.modDescriptionTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.modAuthorTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.modIDTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.modNameTextBox = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.selectedRealmB = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.selectedRealmG = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.selectedRealmR = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.selectedRealmRank = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.selectedRealmName = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.selectedRealmID = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.realmsTreeView = new System.Windows.Forms.TreeView();
            this.contextMenuRealmTree = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.menuItemAddRealmFile = new System.Windows.Forms.ToolStripMenuItem();
            this.tabPage6 = new System.Windows.Forms.TabPage();
            this.provincesTreeView = new System.Windows.Forms.TreeView();
            this.contextMenuRealmRoot = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.contextRealmRootNew = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.realmButtonAddProvince = new System.Windows.Forms.Button();
            this.selectedRealmProvincesListBox = new System.Windows.Forms.ListBox();
            this.realmButtonRemoveProvince = new System.Windows.Forms.Button();
            this.selectedRealmAllProvincesList = new System.Windows.Forms.ListBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.menuStrip1.SuspendLayout();
            this.tabControl.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.contextMenuRealmTree.SuspendLayout();
            this.tabPage6.SuspendLayout();
            this.contextMenuRealmRoot.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusStrip
            // 
            this.statusStrip.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.statusStrip.Location = new System.Drawing.Point(0, 1032);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Padding = new System.Windows.Forms.Padding(0, 0, 14, 0);
            this.statusStrip.Size = new System.Drawing.Size(2004, 22);
            this.statusStrip.TabIndex = 0;
            this.statusStrip.Text = "statusStrip1";
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(2004, 40);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem,
            this.openToolStripMenuItem,
            this.saveToolStripMenuItem,
            this.toolStripSeparator2,
            this.quitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(64, 36);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.modToolStripMenuItem,
            this.toolStripSeparator1,
            this.nationToolStripMenuItem,
            this.provinceToolStripMenuItem,
            this.characterToolStripMenuItem,
            this.resourceToolStripMenuItem});
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.Size = new System.Drawing.Size(259, 38);
            this.newToolStripMenuItem.Text = "New";
            // 
            // modToolStripMenuItem
            // 
            this.modToolStripMenuItem.Name = "modToolStripMenuItem";
            this.modToolStripMenuItem.Size = new System.Drawing.Size(215, 38);
            this.modToolStripMenuItem.Text = "Mod";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(212, 6);
            // 
            // nationToolStripMenuItem
            // 
            this.nationToolStripMenuItem.Name = "nationToolStripMenuItem";
            this.nationToolStripMenuItem.Size = new System.Drawing.Size(215, 38);
            this.nationToolStripMenuItem.Text = "Nation";
            // 
            // provinceToolStripMenuItem
            // 
            this.provinceToolStripMenuItem.Name = "provinceToolStripMenuItem";
            this.provinceToolStripMenuItem.Size = new System.Drawing.Size(215, 38);
            this.provinceToolStripMenuItem.Text = "Province";
            // 
            // characterToolStripMenuItem
            // 
            this.characterToolStripMenuItem.Name = "characterToolStripMenuItem";
            this.characterToolStripMenuItem.Size = new System.Drawing.Size(215, 38);
            this.characterToolStripMenuItem.Text = "Character";
            // 
            // resourceToolStripMenuItem
            // 
            this.resourceToolStripMenuItem.Name = "resourceToolStripMenuItem";
            this.resourceToolStripMenuItem.Size = new System.Drawing.Size(215, 38);
            this.resourceToolStripMenuItem.Text = "Resource";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.openToolStripMenuItem.Size = new System.Drawing.Size(259, 38);
            this.openToolStripMenuItem.Text = "Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(259, 38);
            this.saveToolStripMenuItem.Text = "Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(256, 6);
            // 
            // quitToolStripMenuItem
            // 
            this.quitToolStripMenuItem.Name = "quitToolStripMenuItem";
            this.quitToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
            this.quitToolStripMenuItem.Size = new System.Drawing.Size(259, 38);
            this.quitToolStripMenuItem.Text = "Exit";
            this.quitToolStripMenuItem.Click += new System.EventHandler(this.quitToolStripMenuItem_Click);
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog1";
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabPage1);
            this.tabControl.Controls.Add(this.tabPage2);
            this.tabControl.Controls.Add(this.tabPage6);
            this.tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl.Enabled = false;
            this.tabControl.Location = new System.Drawing.Point(0, 40);
            this.tabControl.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(2004, 992);
            this.tabControl.TabIndex = 2;
            this.tabControl.Visible = false;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.Transparent;
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Location = new System.Drawing.Point(8, 39);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPage1.Size = new System.Drawing.Size(1988, 945);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Mod Details";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.modDescriptionTextBox);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.modAuthorTextBox);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.modIDTextBox);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.modNameTextBox);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupBox1.Location = new System.Drawing.Point(4, 4);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Size = new System.Drawing.Size(746, 937);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Mod Information";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(36, 183);
            this.label4.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(126, 25);
            this.label4.TabIndex = 8;
            this.label4.Text = "Description:";
            // 
            // modDescriptionTextBox
            // 
            this.modDescriptionTextBox.Location = new System.Drawing.Point(206, 177);
            this.modDescriptionTextBox.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.modDescriptionTextBox.Multiline = true;
            this.modDescriptionTextBox.Name = "modDescriptionTextBox";
            this.modDescriptionTextBox.Size = new System.Drawing.Size(494, 300);
            this.modDescriptionTextBox.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(36, 138);
            this.label3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 25);
            this.label3.TabIndex = 6;
            this.label3.Text = "Author:";
            // 
            // modAuthorTextBox
            // 
            this.modAuthorTextBox.Location = new System.Drawing.Point(206, 133);
            this.modAuthorTextBox.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.modAuthorTextBox.Name = "modAuthorTextBox";
            this.modAuthorTextBox.Size = new System.Drawing.Size(494, 31);
            this.modAuthorTextBox.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 96);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 25);
            this.label1.TabIndex = 4;
            this.label1.Text = "ID:";
            // 
            // modIDTextBox
            // 
            this.modIDTextBox.Location = new System.Drawing.Point(206, 90);
            this.modIDTextBox.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.modIDTextBox.Name = "modIDTextBox";
            this.modIDTextBox.Size = new System.Drawing.Size(494, 31);
            this.modIDTextBox.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(36, 54);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Name:";
            // 
            // modNameTextBox
            // 
            this.modNameTextBox.Location = new System.Drawing.Point(206, 46);
            this.modNameTextBox.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.modNameTextBox.Name = "modNameTextBox";
            this.modNameTextBox.Size = new System.Drawing.Size(494, 31);
            this.modNameTextBox.TabIndex = 3;
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.Transparent;
            this.tabPage2.Controls.Add(this.groupBox2);
            this.tabPage2.Controls.Add(this.realmsTreeView);
            this.tabPage2.Location = new System.Drawing.Point(8, 39);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPage2.Size = new System.Drawing.Size(1988, 945);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Realms";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.groupBox5);
            this.groupBox2.Controls.Add(this.groupBox4);
            this.groupBox2.Controls.Add(this.groupBox3);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(578, 4);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox2.Size = new System.Drawing.Size(1406, 937);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Realm Details";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.selectedRealmB);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.selectedRealmG);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.selectedRealmR);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Location = new System.Drawing.Point(42, 259);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox3.Size = new System.Drawing.Size(558, 162);
            this.groupBox3.TabIndex = 6;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Color";
            // 
            // selectedRealmB
            // 
            this.selectedRealmB.Location = new System.Drawing.Point(144, 104);
            this.selectedRealmB.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.selectedRealmB.Name = "selectedRealmB";
            this.selectedRealmB.Size = new System.Drawing.Size(124, 31);
            this.selectedRealmB.TabIndex = 11;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(36, 108);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(32, 25);
            this.label10.TabIndex = 10;
            this.label10.Text = "B:";
            // 
            // selectedRealmG
            // 
            this.selectedRealmG.Location = new System.Drawing.Point(144, 67);
            this.selectedRealmG.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.selectedRealmG.Name = "selectedRealmG";
            this.selectedRealmG.Size = new System.Drawing.Size(124, 31);
            this.selectedRealmG.TabIndex = 9;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(36, 69);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(34, 25);
            this.label9.TabIndex = 8;
            this.label9.Text = "G:";
            // 
            // selectedRealmR
            // 
            this.selectedRealmR.Location = new System.Drawing.Point(144, 31);
            this.selectedRealmR.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.selectedRealmR.Name = "selectedRealmR";
            this.selectedRealmR.Size = new System.Drawing.Size(124, 31);
            this.selectedRealmR.TabIndex = 7;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(36, 33);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(33, 25);
            this.label8.TabIndex = 0;
            this.label8.Text = "R:";
            // 
            // selectedRealmRank
            // 
            this.selectedRealmRank.Location = new System.Drawing.Point(182, 112);
            this.selectedRealmRank.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.selectedRealmRank.Name = "selectedRealmRank";
            this.selectedRealmRank.Size = new System.Drawing.Size(296, 31);
            this.selectedRealmRank.TabIndex = 5;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(34, 113);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(68, 25);
            this.label7.TabIndex = 4;
            this.label7.Text = "Rank:";
            // 
            // selectedRealmName
            // 
            this.selectedRealmName.Location = new System.Drawing.Point(182, 73);
            this.selectedRealmName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.selectedRealmName.Name = "selectedRealmName";
            this.selectedRealmName.Size = new System.Drawing.Size(296, 31);
            this.selectedRealmName.TabIndex = 3;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(34, 77);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(74, 25);
            this.label6.TabIndex = 2;
            this.label6.Text = "Name:";
            // 
            // selectedRealmID
            // 
            this.selectedRealmID.Location = new System.Drawing.Point(182, 37);
            this.selectedRealmID.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.selectedRealmID.Name = "selectedRealmID";
            this.selectedRealmID.Size = new System.Drawing.Size(296, 31);
            this.selectedRealmID.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(34, 40);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 25);
            this.label5.TabIndex = 0;
            this.label5.Text = "ID:";
            // 
            // realmsTreeView
            // 
            this.realmsTreeView.ContextMenuStrip = this.contextMenuRealmTree;
            this.realmsTreeView.Dock = System.Windows.Forms.DockStyle.Left;
            this.realmsTreeView.Location = new System.Drawing.Point(4, 4);
            this.realmsTreeView.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.realmsTreeView.Name = "realmsTreeView";
            this.realmsTreeView.Size = new System.Drawing.Size(574, 937);
            this.realmsTreeView.TabIndex = 0;
            // 
            // contextMenuRealmTree
            // 
            this.contextMenuRealmTree.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.contextMenuRealmTree.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuItemAddRealmFile});
            this.contextMenuRealmTree.Name = "contextMenuRealmTree";
            this.contextMenuRealmTree.Size = new System.Drawing.Size(275, 40);
            // 
            // menuItemAddRealmFile
            // 
            this.menuItemAddRealmFile.Name = "menuItemAddRealmFile";
            this.menuItemAddRealmFile.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.R)));
            this.menuItemAddRealmFile.Size = new System.Drawing.Size(274, 36);
            this.menuItemAddRealmFile.Text = "Add File...";
            // 
            // tabPage6
            // 
            this.tabPage6.BackColor = System.Drawing.Color.Transparent;
            this.tabPage6.Controls.Add(this.provincesTreeView);
            this.tabPage6.Location = new System.Drawing.Point(8, 39);
            this.tabPage6.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPage6.Name = "tabPage6";
            this.tabPage6.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPage6.Size = new System.Drawing.Size(1988, 918);
            this.tabPage6.TabIndex = 2;
            this.tabPage6.Text = "Provinces";
            // 
            // provincesTreeView
            // 
            this.provincesTreeView.Dock = System.Windows.Forms.DockStyle.Left;
            this.provincesTreeView.Location = new System.Drawing.Point(4, 4);
            this.provincesTreeView.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.provincesTreeView.Name = "provincesTreeView";
            this.provincesTreeView.Size = new System.Drawing.Size(574, 910);
            this.provincesTreeView.TabIndex = 1;
            // 
            // contextMenuRealmRoot
            // 
            this.contextMenuRealmRoot.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.contextMenuRealmRoot.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.contextRealmRootNew});
            this.contextMenuRealmRoot.Name = "contextMenuRealmRoot";
            this.contextMenuRealmRoot.Size = new System.Drawing.Size(206, 40);
            // 
            // contextRealmRootNew
            // 
            this.contextRealmRootNew.Name = "contextRealmRootNew";
            this.contextRealmRootNew.Size = new System.Drawing.Size(205, 36);
            this.contextRealmRootNew.Text = "Add Realm";
            // 
            // groupBox4
            // 
            this.groupBox4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBox4.Controls.Add(this.realmButtonRemoveProvince);
            this.groupBox4.Controls.Add(this.selectedRealmAllProvincesList);
            this.groupBox4.Controls.Add(this.selectedRealmProvincesListBox);
            this.groupBox4.Controls.Add(this.realmButtonAddProvince);
            this.groupBox4.Location = new System.Drawing.Point(42, 429);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox4.Size = new System.Drawing.Size(562, 482);
            this.groupBox4.TabIndex = 7;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Provinces";
            // 
            // realmButtonAddProvince
            // 
            this.realmButtonAddProvince.Location = new System.Drawing.Point(234, 106);
            this.realmButtonAddProvince.Name = "realmButtonAddProvince";
            this.realmButtonAddProvince.Size = new System.Drawing.Size(100, 43);
            this.realmButtonAddProvince.TabIndex = 1;
            this.realmButtonAddProvince.Text = ">>";
            this.realmButtonAddProvince.UseVisualStyleBackColor = true;
            this.realmButtonAddProvince.Click += new System.EventHandler(this.realmButtonAddProvince_Click);
            // 
            // selectedRealmProvincesListBox
            // 
            this.selectedRealmProvincesListBox.Dock = System.Windows.Forms.DockStyle.Right;
            this.selectedRealmProvincesListBox.FormattingEnabled = true;
            this.selectedRealmProvincesListBox.ItemHeight = 25;
            this.selectedRealmProvincesListBox.Location = new System.Drawing.Point(368, 28);
            this.selectedRealmProvincesListBox.Name = "selectedRealmProvincesListBox";
            this.selectedRealmProvincesListBox.Size = new System.Drawing.Size(190, 450);
            this.selectedRealmProvincesListBox.TabIndex = 2;
            // 
            // realmButtonRemoveProvince
            // 
            this.realmButtonRemoveProvince.Location = new System.Drawing.Point(234, 174);
            this.realmButtonRemoveProvince.Name = "realmButtonRemoveProvince";
            this.realmButtonRemoveProvince.Size = new System.Drawing.Size(100, 46);
            this.realmButtonRemoveProvince.TabIndex = 3;
            this.realmButtonRemoveProvince.Text = "<<";
            this.realmButtonRemoveProvince.UseVisualStyleBackColor = true;
            this.realmButtonRemoveProvince.Click += new System.EventHandler(this.realmButtonRemoveProvince_Click);
            // 
            // selectedRealmAllProvincesList
            // 
            this.selectedRealmAllProvincesList.Dock = System.Windows.Forms.DockStyle.Left;
            this.selectedRealmAllProvincesList.FormattingEnabled = true;
            this.selectedRealmAllProvincesList.ItemHeight = 25;
            this.selectedRealmAllProvincesList.Location = new System.Drawing.Point(4, 28);
            this.selectedRealmAllProvincesList.Name = "selectedRealmAllProvincesList";
            this.selectedRealmAllProvincesList.Size = new System.Drawing.Size(200, 450);
            this.selectedRealmAllProvincesList.TabIndex = 3;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.label5);
            this.groupBox5.Controls.Add(this.selectedRealmID);
            this.groupBox5.Controls.Add(this.label6);
            this.groupBox5.Controls.Add(this.selectedRealmRank);
            this.groupBox5.Controls.Add(this.selectedRealmName);
            this.groupBox5.Controls.Add(this.label7);
            this.groupBox5.Location = new System.Drawing.Point(42, 60);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(558, 192);
            this.groupBox5.TabIndex = 8;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Basic Information";
            // 
            // MainForm
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2004, 1054);
            this.Controls.Add(this.tabControl);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Whimsical Editor";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tabControl.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.contextMenuRealmTree.ResumeLayout(false);
            this.tabPage6.ResumeLayout(false);
            this.contextMenuRealmRoot.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem nationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem provinceToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem characterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem resourceToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem quitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox modIDTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox modNameTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox modDescriptionTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox modAuthorTextBox;
        private System.Windows.Forms.TreeView realmsTreeView;
        private System.Windows.Forms.TabPage tabPage6;
        private System.Windows.Forms.TreeView provincesTreeView;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox selectedRealmB;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox selectedRealmG;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox selectedRealmR;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox selectedRealmRank;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox selectedRealmName;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox selectedRealmID;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuRealmRoot;
        private System.Windows.Forms.ToolStripMenuItem contextRealmRootNew;
        private System.Windows.Forms.ContextMenuStrip contextMenuRealmTree;
        private System.Windows.Forms.ToolStripMenuItem menuItemAddRealmFile;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button realmButtonRemoveProvince;
        private System.Windows.Forms.ListBox selectedRealmProvincesListBox;
        private System.Windows.Forms.Button realmButtonAddProvince;
        private System.Windows.Forms.ListBox selectedRealmAllProvincesList;
        private System.Windows.Forms.GroupBox groupBox5;
    }
}

