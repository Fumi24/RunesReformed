﻿namespace RunesReformed1._1
{
    partial class RunesReformed
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RunesReformed));
            this.Champbox = new System.Windows.Forms.ComboBox();
            this.Pagebox = new System.Windows.Forms.ComboBox();
            this.Champlbl = new System.Windows.Forms.Label();
            this.Rolelbl = new System.Windows.Forms.Label();
            this.Pagelbl = new System.Windows.Forms.Label();
            this.Runebtn = new System.Windows.Forms.Button();
            this.DeleteCheck = new System.Windows.Forms.CheckBox();
            this.Githublink = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // Champbox
            // 
            this.Champbox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.Champbox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.Champbox.FormattingEnabled = true;
            this.Champbox.Location = new System.Drawing.Point(100, 12);
            this.Champbox.Name = "Champbox";
            this.Champbox.Size = new System.Drawing.Size(192, 21);
            this.Champbox.TabIndex = 0;
            this.Champbox.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // Pagebox
            // 
            this.Pagebox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Pagebox.FormattingEnabled = true;
            this.Pagebox.Location = new System.Drawing.Point(100, 39);
            this.Pagebox.Name = "Pagebox";
            this.Pagebox.Size = new System.Drawing.Size(192, 21);
            this.Pagebox.TabIndex = 1;
            // 
            // Champlbl
            // 
            this.Champlbl.AutoSize = true;
            this.Champlbl.Location = new System.Drawing.Point(12, 15);
            this.Champlbl.Name = "Champlbl";
            this.Champlbl.Size = new System.Drawing.Size(54, 13);
            this.Champlbl.TabIndex = 3;
            this.Champlbl.Text = "Champion";
            this.Champlbl.Click += new System.EventHandler(this.label1_Click);
            // 
            // Rolelbl
            // 
            this.Rolelbl.AutoSize = true;
            this.Rolelbl.Location = new System.Drawing.Point(12, 42);
            this.Rolelbl.Name = "Rolelbl";
            this.Rolelbl.Size = new System.Drawing.Size(32, 13);
            this.Rolelbl.TabIndex = 4;
            this.Rolelbl.Text = "Page";
            // 
            // Pagelbl
            // 
            this.Pagelbl.AutoSize = true;
            this.Pagelbl.Location = new System.Drawing.Point(12, 69);
            this.Pagelbl.Name = "Pagelbl";
            this.Pagelbl.Size = new System.Drawing.Size(0, 13);
            this.Pagelbl.TabIndex = 5;
            // 
            // Runebtn
            // 
            this.Runebtn.Location = new System.Drawing.Point(100, 66);
            this.Runebtn.Name = "Runebtn";
            this.Runebtn.Size = new System.Drawing.Size(192, 23);
            this.Runebtn.TabIndex = 6;
            this.Runebtn.Text = "Set Runes";
            this.Runebtn.UseVisualStyleBackColor = true;
            this.Runebtn.Click += new System.EventHandler(this.Runebtn_Click);
            // 
            // DeleteCheck
            // 
            this.DeleteCheck.AutoSize = true;
            this.DeleteCheck.Location = new System.Drawing.Point(12, 95);
            this.DeleteCheck.Name = "DeleteCheck";
            this.DeleteCheck.Size = new System.Drawing.Size(122, 17);
            this.DeleteCheck.TabIndex = 8;
            this.DeleteCheck.Text = "Delete Current Page";
            this.DeleteCheck.UseVisualStyleBackColor = true;
            this.DeleteCheck.CheckedChanged += new System.EventHandler(this.DeleteCheck_CheckedChanged);
            // 
            // Githublink
            // 
            this.Githublink.AutoSize = true;
            this.Githublink.Location = new System.Drawing.Point(12, 71);
            this.Githublink.Name = "Githublink";
            this.Githublink.Size = new System.Drawing.Size(38, 13);
            this.Githublink.TabIndex = 11;
            this.Githublink.TabStop = true;
            this.Githublink.Text = "Github";
            this.Githublink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.Githublink_LinkClicked);
            // 
            // RunesReformed
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(304, 122);
            this.Controls.Add(this.Githublink);
            this.Controls.Add(this.DeleteCheck);
            this.Controls.Add(this.Runebtn);
            this.Controls.Add(this.Pagelbl);
            this.Controls.Add(this.Rolelbl);
            this.Controls.Add(this.Champlbl);
            this.Controls.Add(this.Pagebox);
            this.Controls.Add(this.Champbox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "RunesReformed";
            this.Text = "RunesReformed";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_Close);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox Champbox;
        private System.Windows.Forms.ComboBox Pagebox;
        private System.Windows.Forms.Label Champlbl;
        private System.Windows.Forms.Label Rolelbl;
        private System.Windows.Forms.Label Pagelbl;
        private System.Windows.Forms.Button Runebtn;
        private System.Windows.Forms.CheckBox DeleteCheck;
        private System.Windows.Forms.LinkLabel Githublink;
    }
}

