﻿namespace Aion_Launcher
{
    partial class SettingsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SettingsForm));
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.ViewButton = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.ServerComboBox = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.trayCheckBox = new System.Windows.Forms.CheckBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.fastStart = new System.Windows.Forms.CheckBox();
            this.ResetSettingsButton = new System.Windows.Forms.Button();
            this.SaveSettingsButton = new System.Windows.Forms.Button();
            this.mainGroupBox = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.languageComboBox = new System.Windows.Forms.ComboBox();
            this.extendedGroupBox = new System.Windows.Forms.GroupBox();
            this.pingCheckBox = new System.Windows.Forms.CheckBox();
            this.RestartCheckBox = new System.Windows.Forms.CheckBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.seperator1 = new Aion_Launcher.Seperator();
            this.mainGroupBox.SuspendLayout();
            this.extendedGroupBox.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Name = "label1";
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            resources.ApplyResources(this.comboBox1, "comboBox1");
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            resources.GetString("comboBox1.Items"),
            resources.GetString("comboBox1.Items1")});
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Name = "label2";
            // 
            // textBox1
            // 
            resources.ApplyResources(this.textBox1, "textBox1");
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Name = "label3";
            // 
            // textBox2
            // 
            resources.ApplyResources(this.textBox2, "textBox2");
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            // 
            // toolTip1
            // 
            this.toolTip1.AutoPopDelay = 0;
            this.toolTip1.InitialDelay = 300;
            this.toolTip1.ReshowDelay = 100;
            // 
            // ViewButton
            // 
            resources.ApplyResources(this.ViewButton, "ViewButton");
            this.ViewButton.Name = "ViewButton";
            this.ViewButton.TabStop = false;
            this.toolTip1.SetToolTip(this.ViewButton, resources.GetString("ViewButton.ToolTip"));
            this.ViewButton.UseVisualStyleBackColor = true;
            this.ViewButton.Click += new System.EventHandler(this.ViewButton_Click);
            // 
            // button1
            // 
            resources.ApplyResources(this.button1, "button1");
            this.button1.Name = "button1";
            this.toolTip1.SetToolTip(this.button1, resources.GetString("button1.ToolTip"));
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // ServerComboBox
            // 
            this.ServerComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            resources.ApplyResources(this.ServerComboBox, "ServerComboBox");
            this.ServerComboBox.FormattingEnabled = true;
            this.ServerComboBox.Items.AddRange(new object[] {
            resources.GetString("ServerComboBox.Items"),
            resources.GetString("ServerComboBox.Items1"),
            resources.GetString("ServerComboBox.Items2"),
            resources.GetString("ServerComboBox.Items3")});
            this.ServerComboBox.Name = "ServerComboBox";
            this.ServerComboBox.SelectedIndexChanged += new System.EventHandler(this.ServerComboBox_SelectedIndexChanged);
            // 
            // label10
            // 
            resources.ApplyResources(this.label10, "label10");
            this.label10.Name = "label10";
            // 
            // label8
            // 
            resources.ApplyResources(this.label8, "label8");
            this.label8.Name = "label8";
            // 
            // textBox3
            // 
            resources.ApplyResources(this.textBox3, "textBox3");
            this.textBox3.Name = "textBox3";
            // 
            // trayCheckBox
            // 
            resources.ApplyResources(this.trayCheckBox, "trayCheckBox");
            this.trayCheckBox.Name = "trayCheckBox";
            this.trayCheckBox.UseVisualStyleBackColor = true;
            // 
            // checkBox1
            // 
            resources.ApplyResources(this.checkBox1, "checkBox1");
            this.checkBox1.Checked = true;
            this.checkBox1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // fastStart
            // 
            resources.ApplyResources(this.fastStart, "fastStart");
            this.fastStart.Name = "fastStart";
            this.fastStart.UseVisualStyleBackColor = true;
            this.fastStart.CheckedChanged += new System.EventHandler(this.fastStart_CheckedChanged);
            // 
            // ResetSettingsButton
            // 
            resources.ApplyResources(this.ResetSettingsButton, "ResetSettingsButton");
            this.ResetSettingsButton.Name = "ResetSettingsButton";
            this.ResetSettingsButton.UseVisualStyleBackColor = true;
            this.ResetSettingsButton.Click += new System.EventHandler(this.ResetSettingsButton_Click);
            // 
            // SaveSettingsButton
            // 
            resources.ApplyResources(this.SaveSettingsButton, "SaveSettingsButton");
            this.SaveSettingsButton.Name = "SaveSettingsButton";
            this.SaveSettingsButton.UseVisualStyleBackColor = true;
            this.SaveSettingsButton.Click += new System.EventHandler(this.SaveSettingsButton_Click);
            // 
            // mainGroupBox
            // 
            this.mainGroupBox.Controls.Add(this.label5);
            this.mainGroupBox.Controls.Add(this.ServerComboBox);
            this.mainGroupBox.Controls.Add(this.languageComboBox);
            this.mainGroupBox.Controls.Add(this.label2);
            this.mainGroupBox.Controls.Add(this.textBox1);
            this.mainGroupBox.Controls.Add(this.label10);
            this.mainGroupBox.Controls.Add(this.label1);
            this.mainGroupBox.Controls.Add(this.ViewButton);
            this.mainGroupBox.Controls.Add(this.textBox3);
            this.mainGroupBox.Controls.Add(this.label8);
            this.mainGroupBox.Controls.Add(this.comboBox1);
            resources.ApplyResources(this.mainGroupBox, "mainGroupBox");
            this.mainGroupBox.Name = "mainGroupBox";
            this.mainGroupBox.TabStop = false;
            // 
            // label5
            // 
            resources.ApplyResources(this.label5, "label5");
            this.label5.Name = "label5";
            // 
            // languageComboBox
            // 
            this.languageComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            resources.ApplyResources(this.languageComboBox, "languageComboBox");
            this.languageComboBox.FormattingEnabled = true;
            this.languageComboBox.Items.AddRange(new object[] {
            resources.GetString("languageComboBox.Items"),
            resources.GetString("languageComboBox.Items1")});
            this.languageComboBox.Name = "languageComboBox";
            this.languageComboBox.SelectedIndexChanged += new System.EventHandler(this.languageComboBox_SelectedIndexChanged);
            // 
            // extendedGroupBox
            // 
            this.extendedGroupBox.Controls.Add(this.pingCheckBox);
            this.extendedGroupBox.Controls.Add(this.RestartCheckBox);
            this.extendedGroupBox.Controls.Add(this.comboBox2);
            this.extendedGroupBox.Controls.Add(this.label4);
            this.extendedGroupBox.Controls.Add(this.trayCheckBox);
            this.extendedGroupBox.Controls.Add(this.label3);
            this.extendedGroupBox.Controls.Add(this.button1);
            this.extendedGroupBox.Controls.Add(this.fastStart);
            this.extendedGroupBox.Controls.Add(this.textBox2);
            this.extendedGroupBox.Controls.Add(this.checkBox1);
            resources.ApplyResources(this.extendedGroupBox, "extendedGroupBox");
            this.extendedGroupBox.Name = "extendedGroupBox";
            this.extendedGroupBox.TabStop = false;
            // 
            // pingCheckBox
            // 
            resources.ApplyResources(this.pingCheckBox, "pingCheckBox");
            this.pingCheckBox.Name = "pingCheckBox";
            this.pingCheckBox.UseVisualStyleBackColor = true;
            // 
            // RestartCheckBox
            // 
            resources.ApplyResources(this.RestartCheckBox, "RestartCheckBox");
            this.RestartCheckBox.Name = "RestartCheckBox";
            this.RestartCheckBox.UseVisualStyleBackColor = true;
            // 
            // comboBox2
            // 
            this.comboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            resources.ApplyResources(this.comboBox2, "comboBox2");
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            resources.GetString("comboBox2.Items"),
            resources.GetString("comboBox2.Items1"),
            resources.GetString("comboBox2.Items2")});
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.Name = "label4";
            // 
            // panel1
            // 
            resources.ApplyResources(this.panel1, "panel1");
            this.panel1.Controls.Add(this.extendedGroupBox);
            this.panel1.Controls.Add(this.mainGroupBox);
            this.panel1.Name = "panel1";
            // 
            // seperator1
            // 
            this.seperator1.BackColor = System.Drawing.Color.Transparent;
            this.seperator1.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.seperator1.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.seperator1.Direction = System.Windows.Forms.Orientation.Horizontal;
            this.seperator1.Image = null;
            resources.ApplyResources(this.seperator1, "seperator1");
            this.seperator1.Name = "seperator1";
            // 
            // SettingsForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.ResetSettingsButton);
            this.Controls.Add(this.seperator1);
            this.Controls.Add(this.SaveSettingsButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SettingsForm";
            this.ShowInTaskbar = false;
            this.Load += new System.EventHandler(this.Settings_Load);
            this.Shown += new System.EventHandler(this.Settings_Shown);
            this.mainGroupBox.ResumeLayout(false);
            this.mainGroupBox.PerformLayout();
            this.extendedGroupBox.ResumeLayout(false);
            this.extendedGroupBox.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button SaveSettingsButton;
        private System.Windows.Forms.Button ViewButton;
        private System.Windows.Forms.Button ResetSettingsButton;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox ServerComboBox;
        private Seperator seperator1;
        private System.Windows.Forms.CheckBox fastStart;
        private System.Windows.Forms.CheckBox trayCheckBox;
        private System.Windows.Forms.GroupBox mainGroupBox;
        private System.Windows.Forms.GroupBox extendedGroupBox;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox RestartCheckBox;
        private System.Windows.Forms.CheckBox pingCheckBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox languageComboBox;
    }
}