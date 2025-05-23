﻿using System.Windows.Forms;

namespace EditorTool
{
    partial class Asset_Editor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Asset_Editor));
            this.loadAssetType = new System.Windows.Forms.ComboBox();
            this.assetList = new System.Windows.Forms.ListBox();
            this.deleteAsset = new System.Windows.Forms.Button();
            this.importAsset = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.refresh = new System.Windows.Forms.Button();
            this.editAsset = new System.Windows.Forms.Button();
            this.modelConfigs = new System.Windows.Forms.GroupBox();
            this.label16 = new System.Windows.Forms.Label();
            this.modelType = new System.Windows.Forms.ComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.model_segmentsize = new System.Windows.Forms.NumericUpDown();
            this.label12 = new System.Windows.Forms.Label();
            this.model_scale = new System.Windows.Forms.NumericUpDown();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.saveAssetConfig = new System.Windows.Forms.Button();
            this.model_rot_z = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.model_rot_y = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.model_rot_x = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.model_world_z = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.model_world_y = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.model_world_x = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.depreciationWarning = new System.Windows.Forms.Label();
            this.modelPreview = new System.Windows.Forms.Integration.ElementHost();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.localisationPreview = new System.Windows.Forms.TextBox();
            this.imagePreview = new System.Windows.Forms.PictureBox();
            this.playSoundPreview = new System.Windows.Forms.Button();
            this.soundPreview = new NAudio.Gui.WaveViewer();
            this.assetUseageGroup = new System.Windows.Forms.GroupBox();
            this.assetUseages = new System.Windows.Forms.ListBox();
            this.soundConfigs = new System.Windows.Forms.GroupBox();
            this.soundLooping = new System.Windows.Forms.CheckBox();
            this.soundPan = new System.Windows.Forms.TrackBar();
            this.label15 = new System.Windows.Forms.Label();
            this.soundPitch = new System.Windows.Forms.TrackBar();
            this.label14 = new System.Windows.Forms.Label();
            this.soundVolume = new System.Windows.Forms.TrackBar();
            this.label1 = new System.Windows.Forms.Label();
            this.saveSoundConfig = new System.Windows.Forms.Button();
            this.groupBox2.SuspendLayout();
            this.modelConfigs.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.model_segmentsize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.model_scale)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imagePreview)).BeginInit();
            this.assetUseageGroup.SuspendLayout();
            this.soundConfigs.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.soundPan)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.soundPitch)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.soundVolume)).BeginInit();
            this.SuspendLayout();
            // 
            // loadAssetType
            // 
            this.loadAssetType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.loadAssetType.FormattingEnabled = true;
            this.loadAssetType.Items.AddRange(new object[] {
            "Models",
            "Images",
            "Sounds",
            "Fonts",
            "Strings",
            "Cubemaps"});
            this.loadAssetType.Location = new System.Drawing.Point(6, 19);
            this.loadAssetType.Name = "loadAssetType";
            this.loadAssetType.Size = new System.Drawing.Size(202, 21);
            this.loadAssetType.TabIndex = 2;
            this.loadAssetType.SelectedIndexChanged += new System.EventHandler(this.loadAssetType_SelectedIndexChanged);
            // 
            // assetList
            // 
            this.assetList.FormattingEnabled = true;
            this.assetList.HorizontalScrollbar = true;
            this.assetList.Location = new System.Drawing.Point(6, 46);
            this.assetList.Name = "assetList";
            this.assetList.Size = new System.Drawing.Size(202, 368);
            this.assetList.TabIndex = 3;
            this.assetList.SelectedIndexChanged += new System.EventHandler(this.assetList_SelectedIndexChanged);
            // 
            // deleteAsset
            // 
            this.deleteAsset.Location = new System.Drawing.Point(108, 418);
            this.deleteAsset.Name = "deleteAsset";
            this.deleteAsset.Size = new System.Drawing.Size(100, 23);
            this.deleteAsset.TabIndex = 4;
            this.deleteAsset.Text = "Delete";
            this.deleteAsset.UseVisualStyleBackColor = true;
            this.deleteAsset.Click += new System.EventHandler(this.deleteAsset_Click);
            // 
            // importAsset
            // 
            this.importAsset.Location = new System.Drawing.Point(6, 418);
            this.importAsset.Name = "importAsset";
            this.importAsset.Size = new System.Drawing.Size(100, 23);
            this.importAsset.TabIndex = 5;
            this.importAsset.Text = "New";
            this.importAsset.UseVisualStyleBackColor = true;
            this.importAsset.Click += new System.EventHandler(this.refreshList_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.refresh);
            this.groupBox2.Controls.Add(this.editAsset);
            this.groupBox2.Controls.Add(this.loadAssetType);
            this.groupBox2.Controls.Add(this.deleteAsset);
            this.groupBox2.Controls.Add(this.assetList);
            this.groupBox2.Controls.Add(this.importAsset);
            this.groupBox2.Location = new System.Drawing.Point(12, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(215, 472);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Asset Browser";
            // 
            // refresh
            // 
            this.refresh.Location = new System.Drawing.Point(108, 443);
            this.refresh.Name = "refresh";
            this.refresh.Size = new System.Drawing.Size(100, 23);
            this.refresh.TabIndex = 7;
            this.refresh.Text = "Refresh";
            this.refresh.UseVisualStyleBackColor = true;
            this.refresh.Click += new System.EventHandler(this.refresh_Click);
            // 
            // editAsset
            // 
            this.editAsset.Location = new System.Drawing.Point(6, 443);
            this.editAsset.Name = "editAsset";
            this.editAsset.Size = new System.Drawing.Size(100, 23);
            this.editAsset.TabIndex = 6;
            this.editAsset.Text = "Edit";
            this.editAsset.UseVisualStyleBackColor = true;
            this.editAsset.Click += new System.EventHandler(this.editAsset_Click);
            // 
            // modelConfigs
            // 
            this.modelConfigs.Controls.Add(this.label16);
            this.modelConfigs.Controls.Add(this.modelType);
            this.modelConfigs.Controls.Add(this.label13);
            this.modelConfigs.Controls.Add(this.model_segmentsize);
            this.modelConfigs.Controls.Add(this.label12);
            this.modelConfigs.Controls.Add(this.model_scale);
            this.modelConfigs.Controls.Add(this.label11);
            this.modelConfigs.Controls.Add(this.label10);
            this.modelConfigs.Controls.Add(this.saveAssetConfig);
            this.modelConfigs.Controls.Add(this.model_rot_z);
            this.modelConfigs.Controls.Add(this.label6);
            this.modelConfigs.Controls.Add(this.model_rot_y);
            this.modelConfigs.Controls.Add(this.label7);
            this.modelConfigs.Controls.Add(this.model_rot_x);
            this.modelConfigs.Controls.Add(this.label8);
            this.modelConfigs.Controls.Add(this.model_world_z);
            this.modelConfigs.Controls.Add(this.label5);
            this.modelConfigs.Controls.Add(this.model_world_y);
            this.modelConfigs.Controls.Add(this.label4);
            this.modelConfigs.Controls.Add(this.model_world_x);
            this.modelConfigs.Controls.Add(this.label3);
            this.modelConfigs.Controls.Add(this.label2);
            this.modelConfigs.Controls.Add(this.label9);
            this.modelConfigs.Location = new System.Drawing.Point(233, 234);
            this.modelConfigs.Name = "modelConfigs";
            this.modelConfigs.Size = new System.Drawing.Size(226, 250);
            this.modelConfigs.TabIndex = 11;
            this.modelConfigs.TabStop = false;
            this.modelConfigs.Text = "Model Configuration";
            this.modelConfigs.Visible = false;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(7, 18);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(73, 13);
            this.label16.TabIndex = 34;
            this.label16.Text = "Model Type";
            // 
            // modelType
            // 
            this.modelType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.modelType.FormattingEnabled = true;
            this.modelType.Location = new System.Drawing.Point(10, 34);
            this.modelType.Name = "modelType";
            this.modelType.Size = new System.Drawing.Size(210, 21);
            this.modelType.TabIndex = 33;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(116, 180);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(84, 13);
            this.label13.TabIndex = 32;
            this.label13.Text = "Segment Size";
            // 
            // model_segmentsize
            // 
            this.model_segmentsize.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.model_segmentsize.Location = new System.Drawing.Point(119, 195);
            this.model_segmentsize.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.model_segmentsize.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.model_segmentsize.Name = "model_segmentsize";
            this.model_segmentsize.Size = new System.Drawing.Size(101, 20);
            this.model_segmentsize.TabIndex = 31;
            this.model_segmentsize.Value = new decimal(new int[] {
            100,
            0,
            0,
            65536});
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(5, 179);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(77, 13);
            this.label12.TabIndex = 30;
            this.label12.Text = "Model Scale";
            // 
            // model_scale
            // 
            this.model_scale.DecimalPlaces = 5;
            this.model_scale.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.model_scale.Location = new System.Drawing.Point(8, 195);
            this.model_scale.Name = "model_scale";
            this.model_scale.Size = new System.Drawing.Size(101, 20);
            this.model_scale.TabIndex = 29;
            this.model_scale.Value = new decimal(new int[] {
            10,
            0,
            0,
            65536});
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(7, 141);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(181, 13);
            this.label11.TabIndex = 28;
            this.label11.Text = "Default starting rotation of this model.";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(7, 81);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(185, 13);
            this.label10.TabIndex = 27;
            this.label10.Text = "Models use this as their initial position.";
            // 
            // saveAssetConfig
            // 
            this.saveAssetConfig.Location = new System.Drawing.Point(145, 221);
            this.saveAssetConfig.Name = "saveAssetConfig";
            this.saveAssetConfig.Size = new System.Drawing.Size(75, 23);
            this.saveAssetConfig.TabIndex = 25;
            this.saveAssetConfig.Text = "Save";
            this.saveAssetConfig.UseVisualStyleBackColor = true;
            this.saveAssetConfig.Click += new System.EventHandler(this.saveAssetConfig_Click);
            // 
            // model_rot_z
            // 
            this.model_rot_z.Location = new System.Drawing.Point(168, 157);
            this.model_rot_z.Name = "model_rot_z";
            this.model_rot_z.Size = new System.Drawing.Size(52, 20);
            this.model_rot_z.TabIndex = 22;
            this.model_rot_z.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.model_rot_z_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(153, 160);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(17, 13);
            this.label6.TabIndex = 23;
            this.label6.Text = "Z:";
            // 
            // model_rot_y
            // 
            this.model_rot_y.Location = new System.Drawing.Point(95, 157);
            this.model_rot_y.Name = "model_rot_y";
            this.model_rot_y.Size = new System.Drawing.Size(52, 20);
            this.model_rot_y.TabIndex = 20;
            this.model_rot_y.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.model_rot_y_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(79, 160);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(17, 13);
            this.label7.TabIndex = 21;
            this.label7.Text = "Y:";
            // 
            // model_rot_x
            // 
            this.model_rot_x.Location = new System.Drawing.Point(21, 157);
            this.model_rot_x.Name = "model_rot_x";
            this.model_rot_x.Size = new System.Drawing.Size(52, 20);
            this.model_rot_x.TabIndex = 19;
            this.model_rot_x.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.model_rot_x_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(7, 126);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(55, 13);
            this.label8.TabIndex = 18;
            this.label8.Text = "Rotation";
            // 
            // model_world_z
            // 
            this.model_world_z.Location = new System.Drawing.Point(168, 97);
            this.model_world_z.Name = "model_world_z";
            this.model_world_z.Size = new System.Drawing.Size(52, 20);
            this.model_world_z.TabIndex = 16;
            this.model_world_z.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.model_world_z_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(153, 100);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(17, 13);
            this.label5.TabIndex = 17;
            this.label5.Text = "Z:";
            // 
            // model_world_y
            // 
            this.model_world_y.Location = new System.Drawing.Point(95, 97);
            this.model_world_y.Name = "model_world_y";
            this.model_world_y.Size = new System.Drawing.Size(52, 20);
            this.model_world_y.TabIndex = 14;
            this.model_world_y.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.model_world_y_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(80, 100);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(17, 13);
            this.label4.TabIndex = 15;
            this.label4.Text = "Y:";
            // 
            // model_world_x
            // 
            this.model_world_x.Location = new System.Drawing.Point(21, 97);
            this.model_world_x.Name = "model_world_x";
            this.model_world_x.Size = new System.Drawing.Size(52, 20);
            this.model_world_x.TabIndex = 12;
            this.model_world_x.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.model_world_x_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 100);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(17, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "X:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(7, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "World Position";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(7, 160);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(17, 13);
            this.label9.TabIndex = 24;
            this.label9.Text = "X:";
            // 
            // depreciationWarning
            // 
            this.depreciationWarning.AutoSize = true;
            this.depreciationWarning.ForeColor = System.Drawing.Color.OrangeRed;
            this.depreciationWarning.Location = new System.Drawing.Point(247, 277);
            this.depreciationWarning.Name = "depreciationWarning";
            this.depreciationWarning.Size = new System.Drawing.Size(199, 117);
            this.depreciationWarning.TabIndex = 14;
            this.depreciationWarning.Text = "WARNING!\r\n\r\nTHIS MODEL WAS IMPORTED WITH\r\nAN OLDER VERSION OF THE ENGINE\r\nTOOLKIT" +
    " AND DOES NOT SUPPORT\r\nNEWLY UPDATED FEATURES.\r\n\r\nIT IS DEPRECIATED AND WILL NOT" +
    "\r\nBE LOADED BY THE ENGINE.";
            this.depreciationWarning.Visible = false;
            // 
            // modelPreview
            // 
            this.modelPreview.Location = new System.Drawing.Point(6, 19);
            this.modelPreview.Name = "modelPreview";
            this.modelPreview.Size = new System.Drawing.Size(214, 133);
            this.modelPreview.TabIndex = 12;
            this.modelPreview.Text = "elementHost1";
            this.modelPreview.Child = null;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.localisationPreview);
            this.groupBox1.Controls.Add(this.imagePreview);
            this.groupBox1.Controls.Add(this.playSoundPreview);
            this.groupBox1.Controls.Add(this.modelPreview);
            this.groupBox1.Controls.Add(this.soundPreview);
            this.groupBox1.Location = new System.Drawing.Point(233, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(226, 159);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Asset Preview";
            // 
            // localisationPreview
            // 
            this.localisationPreview.Location = new System.Drawing.Point(6, 19);
            this.localisationPreview.Multiline = true;
            this.localisationPreview.Name = "localisationPreview";
            this.localisationPreview.ReadOnly = true;
            this.localisationPreview.Size = new System.Drawing.Size(214, 134);
            this.localisationPreview.TabIndex = 18;
            this.localisationPreview.Visible = false;
            // 
            // imagePreview
            // 
            this.imagePreview.Location = new System.Drawing.Point(6, 19);
            this.imagePreview.Name = "imagePreview";
            this.imagePreview.Size = new System.Drawing.Size(215, 133);
            this.imagePreview.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imagePreview.TabIndex = 15;
            this.imagePreview.TabStop = false;
            this.imagePreview.Visible = false;
            // 
            // playSoundPreview
            // 
            this.playSoundPreview.Location = new System.Drawing.Point(167, 129);
            this.playSoundPreview.Name = "playSoundPreview";
            this.playSoundPreview.Size = new System.Drawing.Size(54, 23);
            this.playSoundPreview.TabIndex = 17;
            this.playSoundPreview.Text = "Play";
            this.playSoundPreview.UseVisualStyleBackColor = true;
            this.playSoundPreview.Visible = false;
            this.playSoundPreview.Click += new System.EventHandler(this.playSoundPreview_Click);
            // 
            // soundPreview
            // 
            this.soundPreview.Location = new System.Drawing.Point(6, 19);
            this.soundPreview.Name = "soundPreview";
            this.soundPreview.SamplesPerPixel = 128;
            this.soundPreview.Size = new System.Drawing.Size(215, 133);
            this.soundPreview.StartPosition = ((long)(0));
            this.soundPreview.TabIndex = 16;
            this.soundPreview.Visible = false;
            this.soundPreview.WaveStream = null;
            // 
            // assetUseageGroup
            // 
            this.assetUseageGroup.Controls.Add(this.assetUseages);
            this.assetUseageGroup.Location = new System.Drawing.Point(233, 177);
            this.assetUseageGroup.Name = "assetUseageGroup";
            this.assetUseageGroup.Size = new System.Drawing.Size(226, 51);
            this.assetUseageGroup.TabIndex = 15;
            this.assetUseageGroup.TabStop = false;
            this.assetUseageGroup.Text = "Asset Useages";
            this.assetUseageGroup.Visible = false;
            // 
            // assetUseages
            // 
            this.assetUseages.FormattingEnabled = true;
            this.assetUseages.Location = new System.Drawing.Point(6, 16);
            this.assetUseages.Name = "assetUseages";
            this.assetUseages.Size = new System.Drawing.Size(214, 30);
            this.assetUseages.TabIndex = 0;
            // 
            // soundConfigs
            // 
            this.soundConfigs.Controls.Add(this.soundLooping);
            this.soundConfigs.Controls.Add(this.soundPan);
            this.soundConfigs.Controls.Add(this.label15);
            this.soundConfigs.Controls.Add(this.soundPitch);
            this.soundConfigs.Controls.Add(this.label14);
            this.soundConfigs.Controls.Add(this.soundVolume);
            this.soundConfigs.Controls.Add(this.label1);
            this.soundConfigs.Controls.Add(this.saveSoundConfig);
            this.soundConfigs.Location = new System.Drawing.Point(233, 234);
            this.soundConfigs.Name = "soundConfigs";
            this.soundConfigs.Size = new System.Drawing.Size(226, 250);
            this.soundConfigs.TabIndex = 35;
            this.soundConfigs.TabStop = false;
            this.soundConfigs.Text = "Sound Configuration";
            this.soundConfigs.Visible = false;
            // 
            // soundLooping
            // 
            this.soundLooping.AutoSize = true;
            this.soundLooping.Location = new System.Drawing.Point(6, 194);
            this.soundLooping.Name = "soundLooping";
            this.soundLooping.Size = new System.Drawing.Size(64, 17);
            this.soundLooping.TabIndex = 32;
            this.soundLooping.Text = "Looping";
            this.soundLooping.UseVisualStyleBackColor = true;
            // 
            // soundPan
            // 
            this.soundPan.LargeChange = 1;
            this.soundPan.Location = new System.Drawing.Point(6, 149);
            this.soundPan.Minimum = -10;
            this.soundPan.Name = "soundPan";
            this.soundPan.Size = new System.Drawing.Size(214, 45);
            this.soundPan.TabIndex = 31;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(6, 133);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(26, 13);
            this.label15.TabIndex = 30;
            this.label15.Text = "Pan";
            // 
            // soundPitch
            // 
            this.soundPitch.LargeChange = 1;
            this.soundPitch.Location = new System.Drawing.Point(6, 98);
            this.soundPitch.Minimum = -10;
            this.soundPitch.Name = "soundPitch";
            this.soundPitch.Size = new System.Drawing.Size(214, 45);
            this.soundPitch.TabIndex = 29;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(6, 82);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(31, 13);
            this.label14.TabIndex = 28;
            this.label14.Text = "Pitch";
            // 
            // soundVolume
            // 
            this.soundVolume.Location = new System.Drawing.Point(6, 47);
            this.soundVolume.Name = "soundVolume";
            this.soundVolume.Size = new System.Drawing.Size(214, 45);
            this.soundVolume.TabIndex = 27;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 13);
            this.label1.TabIndex = 26;
            this.label1.Text = "Volume";
            // 
            // saveSoundConfig
            // 
            this.saveSoundConfig.Location = new System.Drawing.Point(145, 221);
            this.saveSoundConfig.Name = "saveSoundConfig";
            this.saveSoundConfig.Size = new System.Drawing.Size(75, 23);
            this.saveSoundConfig.TabIndex = 25;
            this.saveSoundConfig.Text = "Save";
            this.saveSoundConfig.UseVisualStyleBackColor = true;
            this.saveSoundConfig.Click += new System.EventHandler(this.saveSoundConfig_Click);
            // 
            // Asset_Editor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(468, 493);
            this.Controls.Add(this.soundConfigs);
            this.Controls.Add(this.assetUseageGroup);
            this.Controls.Add(this.depreciationWarning);
            this.Controls.Add(this.modelConfigs);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Asset_Editor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Asset Manager";
            this.Load += new System.EventHandler(this.Landing_Load);
            this.groupBox2.ResumeLayout(false);
            this.modelConfigs.ResumeLayout(false);
            this.modelConfigs.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.model_segmentsize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.model_scale)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imagePreview)).EndInit();
            this.assetUseageGroup.ResumeLayout(false);
            this.soundConfigs.ResumeLayout(false);
            this.soundConfigs.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.soundPan)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.soundPitch)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.soundVolume)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox loadAssetType;
        private System.Windows.Forms.ListBox assetList;
        private System.Windows.Forms.Button deleteAsset;
        private System.Windows.Forms.Button importAsset;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox modelConfigs;
        private System.Windows.Forms.Integration.ElementHost modelPreview;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button saveAssetConfig;
        private System.Windows.Forms.TextBox model_rot_z;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox model_rot_y;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox model_rot_x;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox model_world_z;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox model_world_y;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox model_world_x;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.PictureBox imagePreview;
        private NAudio.Gui.WaveViewer soundPreview;
        private System.Windows.Forms.Button playSoundPreview;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.NumericUpDown model_scale;
        private Label label13;
        private NumericUpDown model_segmentsize;
        private Label label10;
        private Label label16;
        private ComboBox modelType;
        private Button editAsset;
        private TextBox localisationPreview;
        private Label depreciationWarning;
        private GroupBox assetUseageGroup;
        private ListBox assetUseages;
        private Button refresh;
        private GroupBox soundConfigs;
        private TrackBar soundVolume;
        private Label label1;
        private Button saveSoundConfig;
        private CheckBox soundLooping;
        private TrackBar soundPan;
        private Label label15;
        private TrackBar soundPitch;
        private Label label14;
    }
}