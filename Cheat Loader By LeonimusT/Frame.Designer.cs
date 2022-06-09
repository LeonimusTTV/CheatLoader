using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Threading;
using System.Diagnostics;
using System.Globalization;
using System.IO;
using System.Net;
using System.IO.Compression;
using System.Windows;

namespace Cheat_Loader_By_LeonimusT
{
    partial class Frame
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frame));
            this.panel1 = new System.Windows.Forms.Panel();
            this.minimize_button = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.topName = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.infoPanel = new System.Windows.Forms.Panel();
            this.uninstall_button = new System.Windows.Forms.Button();
            this.typelb = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.workinglb = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.localvlb = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.onlinevlb = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.statuslb = new System.Windows.Forms.Label();
            this.lb2 = new System.Windows.Forms.Label();
            this.injectText = new System.Windows.Forms.Label();
            this.injectButton = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.cheatNamelb1 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.infoPanel.SuspendLayout();
            this.panel3.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.panel1.Controls.Add(this.minimize_button);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.topName);
            this.panel1.Location = new System.Drawing.Point(-5, -6);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(710, 28);
            this.panel1.TabIndex = 0;
            // 
            // minimize_button
            // 
            this.minimize_button.BackColor = System.Drawing.Color.Transparent;
            this.minimize_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.minimize_button.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.minimize_button.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.minimize_button.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.minimize_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.minimize_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.minimize_button.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.minimize_button.Location = new System.Drawing.Point(635, 5);
            this.minimize_button.Name = "minimize_button";
            this.minimize_button.Size = new System.Drawing.Size(29, 23);
            this.minimize_button.TabIndex = 2;
            this.minimize_button.Text = "-";
            this.minimize_button.UseVisualStyleBackColor = false;
            this.minimize_button.Click += new System.EventHandler(this.minimize_button_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.Color.Red;
            this.button1.Location = new System.Drawing.Point(655, 5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(29, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "X";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // topName
            // 
            this.topName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.topName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(210)))), ((int)(((byte)(210)))));
            this.topName.Location = new System.Drawing.Point(0, 0);
            this.topName.Name = "topName";
            this.topName.Size = new System.Drawing.Size(710, 28);
            this.topName.TabIndex = 0;
            this.topName.Text = "Cheat Loader";
            this.topName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.topName.MouseDown += new System.Windows.Forms.MouseEventHandler(this.topName_MouseDown);
            this.topName.MouseMove += new System.Windows.Forms.MouseEventHandler(this.topName_MouseMove);
            this.topName.MouseUp += new System.Windows.Forms.MouseEventHandler(this.topName_MouseUp);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(24, 100);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(218, 21);
            this.panel2.TabIndex = 1;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Transparent;
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.ForeColor = System.Drawing.Color.Transparent;
            this.panel4.Location = new System.Drawing.Point(0, 21);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(218, 234);
            this.panel4.TabIndex = 1;
            this.panel4.TabStop = true;
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(210)))), ((int)(((byte)(210)))));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(218, 21);
            this.label1.TabIndex = 1;
            this.label1.Text = "All Cheat";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // listBox1
            // 
            this.listBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.listBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listBox1.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(24, 121);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(218, 234);
            this.listBox1.TabIndex = 4;
            this.listBox1.TabStop = false;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // infoPanel
            // 
            this.infoPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.infoPanel.Controls.Add(this.uninstall_button);
            this.infoPanel.Controls.Add(this.typelb);
            this.infoPanel.Controls.Add(this.label6);
            this.infoPanel.Controls.Add(this.workinglb);
            this.infoPanel.Controls.Add(this.label5);
            this.infoPanel.Controls.Add(this.localvlb);
            this.infoPanel.Controls.Add(this.label4);
            this.infoPanel.Controls.Add(this.onlinevlb);
            this.infoPanel.Controls.Add(this.label3);
            this.infoPanel.Controls.Add(this.statuslb);
            this.infoPanel.Controls.Add(this.lb2);
            this.infoPanel.Controls.Add(this.injectText);
            this.infoPanel.Controls.Add(this.injectButton);
            this.infoPanel.Controls.Add(this.panel3);
            this.infoPanel.Location = new System.Drawing.Point(285, 49);
            this.infoPanel.Name = "infoPanel";
            this.infoPanel.Size = new System.Drawing.Size(369, 378);
            this.infoPanel.TabIndex = 3;
            // 
            // uninstall_button
            // 
            this.uninstall_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(103)))), ((int)(((byte)(103)))));
            this.uninstall_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.uninstall_button.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(103)))), ((int)(((byte)(103)))));
            this.uninstall_button.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(103)))), ((int)(((byte)(103)))));
            this.uninstall_button.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(103)))), ((int)(((byte)(103)))));
            this.uninstall_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.uninstall_button.ForeColor = System.Drawing.SystemColors.Control;
            this.uninstall_button.Location = new System.Drawing.Point(146, 350);
            this.uninstall_button.Name = "uninstall_button";
            this.uninstall_button.Size = new System.Drawing.Size(106, 23);
            this.uninstall_button.TabIndex = 15;
            this.uninstall_button.Text = "Uninstall";
            this.uninstall_button.UseVisualStyleBackColor = false;
            this.uninstall_button.Click += new System.EventHandler(this.uninstall_button_Click);
            // 
            // typelb
            // 
            this.typelb.AutoSize = true;
            this.typelb.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.typelb.Location = new System.Drawing.Point(38, 75);
            this.typelb.Name = "typelb";
            this.typelb.Size = new System.Drawing.Size(35, 13);
            this.typelb.TabIndex = 14;
            this.typelb.Text = "Cheat";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.SystemColors.Control;
            this.label6.Location = new System.Drawing.Point(6, 74);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(40, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "Type : ";
            // 
            // workinglb
            // 
            this.workinglb.AutoSize = true;
            this.workinglb.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.workinglb.Location = new System.Drawing.Point(54, 52);
            this.workinglb.Name = "workinglb";
            this.workinglb.Size = new System.Drawing.Size(25, 13);
            this.workinglb.TabIndex = 12;
            this.workinglb.Text = "Yes";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.SystemColors.Control;
            this.label5.Location = new System.Drawing.Point(6, 51);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Working : ";
            // 
            // localvlb
            // 
            this.localvlb.AutoSize = true;
            this.localvlb.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.localvlb.Location = new System.Drawing.Point(79, 100);
            this.localvlb.Name = "localvlb";
            this.localvlb.Size = new System.Drawing.Size(31, 13);
            this.localvlb.TabIndex = 10;
            this.localvlb.Text = "0.0.1";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.Control;
            this.label4.Location = new System.Drawing.Point(7, 99);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Local Version : ";
            // 
            // onlinevlb
            // 
            this.onlinevlb.AutoSize = true;
            this.onlinevlb.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.onlinevlb.Location = new System.Drawing.Point(84, 125);
            this.onlinevlb.Name = "onlinevlb";
            this.onlinevlb.Size = new System.Drawing.Size(31, 13);
            this.onlinevlb.TabIndex = 8;
            this.onlinevlb.Text = "0.0.1";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.Control;
            this.label3.Location = new System.Drawing.Point(8, 124);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Online Version : ";
            // 
            // statuslb
            // 
            this.statuslb.AutoSize = true;
            this.statuslb.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.statuslb.Location = new System.Drawing.Point(44, 29);
            this.statuslb.Name = "statuslb";
            this.statuslb.Size = new System.Drawing.Size(71, 13);
            this.statuslb.TabIndex = 6;
            this.statuslb.Text = "Undetectable";
            // 
            // lb2
            // 
            this.lb2.AutoSize = true;
            this.lb2.ForeColor = System.Drawing.SystemColors.Control;
            this.lb2.Location = new System.Drawing.Point(6, 28);
            this.lb2.Name = "lb2";
            this.lb2.Size = new System.Drawing.Size(46, 13);
            this.lb2.TabIndex = 5;
            this.lb2.Text = "Status : ";
            // 
            // injectText
            // 
            this.injectText.AutoSize = true;
            this.injectText.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.injectText.Location = new System.Drawing.Point(3, 360);
            this.injectText.Name = "injectText";
            this.injectText.Size = new System.Drawing.Size(16, 13);
            this.injectText.TabIndex = 4;
            this.injectText.Text = "...";
            // 
            // injectButton
            // 
            this.injectButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(103)))), ((int)(((byte)(103)))));
            this.injectButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.injectButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(103)))), ((int)(((byte)(103)))));
            this.injectButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(103)))), ((int)(((byte)(103)))));
            this.injectButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(103)))), ((int)(((byte)(103)))));
            this.injectButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.injectButton.ForeColor = System.Drawing.SystemColors.Control;
            this.injectButton.Location = new System.Drawing.Point(258, 350);
            this.injectButton.Name = "injectButton";
            this.injectButton.Size = new System.Drawing.Size(106, 23);
            this.injectButton.TabIndex = 3;
            this.injectButton.Text = "Cheat not working";
            this.injectButton.UseVisualStyleBackColor = false;
            this.injectButton.Click += new System.EventHandler(this.injectButton_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.panel3.Controls.Add(this.cheatNamelb1);
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(369, 21);
            this.panel3.TabIndex = 2;
            // 
            // cheatNamelb1
            // 
            this.cheatNamelb1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cheatNamelb1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(210)))), ((int)(((byte)(210)))));
            this.cheatNamelb1.Location = new System.Drawing.Point(0, 0);
            this.cheatNamelb1.Name = "cheatNamelb1";
            this.cheatNamelb1.Size = new System.Drawing.Size(369, 21);
            this.cheatNamelb1.TabIndex = 1;
            this.cheatNamelb1.Text = "Osiris";
            this.cheatNamelb1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.Transparent;
            this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel5.Location = new System.Drawing.Point(23, 100);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(220, 256);
            this.panel5.TabIndex = 1;
            this.panel5.TabStop = true;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(103)))), ((int)(((byte)(103)))));
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(103)))), ((int)(((byte)(103)))));
            this.button2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(103)))), ((int)(((byte)(103)))));
            this.button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(103)))), ((int)(((byte)(103)))));
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.ForeColor = System.Drawing.SystemColors.Control;
            this.button2.Location = new System.Drawing.Point(12, 414);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(106, 23);
            this.button2.TabIndex = 15;
            this.button2.Text = "Options";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.notifyIcon1.BalloonTipText = "The application is just hide, to open double click on the tray icon";
            this.notifyIcon1.ContextMenuStrip = this.contextMenuStrip1;
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "Cheat Loader";
            this.notifyIcon1.Visible = true;
            this.notifyIcon1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon1_MouseDoubleClick);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem,
            this.closeToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(104, 48);
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.openToolStripMenuItem.Text = "Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // closeToolStripMenuItem
            // 
            this.closeToolStripMenuItem.Name = "closeToolStripMenuItem";
            this.closeToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.closeToolStripMenuItem.Text = "Close";
            this.closeToolStripMenuItem.Click += new System.EventHandler(this.closeToolStripMenuItem_Click);
            // 
            // Frame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.ClientSize = new System.Drawing.Size(676, 449);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.infoPanel);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel5);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Frame";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cheat Loader By LEØNIMUST";
            this.Load += new System.EventHandler(this.Frame_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.infoPanel.ResumeLayout(false);
            this.infoPanel.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private Panel panel1;
        private Label topName;
        private ListBox listBox1;
        private Panel panel2;
        private Label label1;
        private Panel infoPanel;
        private Panel panel3;
        private Label cheatNamelb1;
        private Button injectButton;
        private Label injectText;
        private Panel panel4;
        private Panel panel5;
        private Button button1;
        private Label lb2;
        private Label statuslb;
        private Label onlinevlb;
        private Label label3;
        private Label localvlb;
        private Label label4;
        private Label workinglb;
        private Label label5;
        private Label typelb;
        private Label label6;
        private Button button2;
        private Button uninstall_button;
        private Button minimize_button;
        private NotifyIcon notifyIcon1;
        private ContextMenuStrip contextMenuStrip1;
        private ToolStripMenuItem closeToolStripMenuItem;
        private ToolStripMenuItem openToolStripMenuItem;
    }
}