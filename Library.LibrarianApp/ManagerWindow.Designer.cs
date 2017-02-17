using Library.Core.Models;
using System;

namespace Library.LibrarianApp
{
    partial class ManagerWindow
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
            this.tabs = new System.Windows.Forms.TabControl();
            this.tabList = new System.Windows.Forms.TabPage();
            this.btnLoad = new System.Windows.Forms.Button();
            this.dgvList = new System.Windows.Forms.DataGridView();
            this.tabSearch = new System.Windows.Forms.TabPage();
            this.tabCreate = new System.Windows.Forms.TabPage();
            this.btnCreate = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.bookGenres = new System.Windows.Forms.ComboBox();
            this.bookRelease = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.lblAuthor = new System.Windows.Forms.Label();
            this.bookAuthor = new System.Windows.Forms.TextBox();
            this.lblTitle = new System.Windows.Forms.Label();
            this.bookTitle = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.SearchPattern = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dgvSearch = new System.Windows.Forms.DataGridView();
            this.tabs.SuspendLayout();
            this.tabList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvList)).BeginInit();
            this.tabSearch.SuspendLayout();
            this.tabCreate.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSearch)).BeginInit();
            this.SuspendLayout();
            // 
            // tabs
            // 
            this.tabs.Controls.Add(this.tabList);
            this.tabs.Controls.Add(this.tabSearch);
            this.tabs.Controls.Add(this.tabCreate);
            this.tabs.ItemSize = new System.Drawing.Size(225, 35);
            this.tabs.Location = new System.Drawing.Point(0, 2);
            this.tabs.Name = "tabs";
            this.tabs.SelectedIndex = 0;
            this.tabs.Size = new System.Drawing.Size(687, 526);
            this.tabs.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tabs.TabIndex = 2;
            // 
            // tabList
            // 
            this.tabList.Controls.Add(this.btnLoad);
            this.tabList.Controls.Add(this.dgvList);
            this.tabList.Location = new System.Drawing.Point(4, 39);
            this.tabList.Margin = new System.Windows.Forms.Padding(10);
            this.tabList.Name = "tabList";
            this.tabList.Padding = new System.Windows.Forms.Padding(10);
            this.tabList.Size = new System.Drawing.Size(679, 483);
            this.tabList.TabIndex = 2;
            this.tabList.Text = "List";
            this.tabList.UseVisualStyleBackColor = true;
            // 
            // btnLoad
            // 
            this.btnLoad.Location = new System.Drawing.Point(8, 373);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(657, 97);
            this.btnLoad.TabIndex = 1;
            this.btnLoad.Text = "Load books";
            this.btnLoad.UseVisualStyleBackColor = true;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // dgvList
            // 
            this.dgvList.AllowUserToAddRows = false;
            this.dgvList.AllowUserToDeleteRows = false;
            this.dgvList.AllowUserToResizeColumns = false;
            this.dgvList.AllowUserToResizeRows = false;
            this.dgvList.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvList.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvList.Location = new System.Drawing.Point(8, 13);
            this.dgvList.Name = "dgvList";
            this.dgvList.Size = new System.Drawing.Size(658, 354);
            this.dgvList.TabIndex = 0;
            // 
            // tabSearch
            // 
            this.tabSearch.Controls.Add(this.dgvSearch);
            this.tabSearch.Controls.Add(this.label4);
            this.tabSearch.Controls.Add(this.SearchPattern);
            this.tabSearch.Controls.Add(this.btnSearch);
            this.tabSearch.Location = new System.Drawing.Point(4, 39);
            this.tabSearch.Name = "tabSearch";
            this.tabSearch.Padding = new System.Windows.Forms.Padding(3);
            this.tabSearch.Size = new System.Drawing.Size(679, 483);
            this.tabSearch.TabIndex = 1;
            this.tabSearch.Text = "Search";
            this.tabSearch.UseVisualStyleBackColor = true;
            // 
            // tabCreate
            // 
            this.tabCreate.Controls.Add(this.btnCreate);
            this.tabCreate.Controls.Add(this.label3);
            this.tabCreate.Controls.Add(this.bookGenres);
            this.tabCreate.Controls.Add(this.bookRelease);
            this.tabCreate.Controls.Add(this.label2);
            this.tabCreate.Controls.Add(this.lblAuthor);
            this.tabCreate.Controls.Add(this.bookAuthor);
            this.tabCreate.Controls.Add(this.lblTitle);
            this.tabCreate.Controls.Add(this.bookTitle);
            this.tabCreate.Controls.Add(this.label1);
            this.tabCreate.Location = new System.Drawing.Point(4, 39);
            this.tabCreate.Name = "tabCreate";
            this.tabCreate.Padding = new System.Windows.Forms.Padding(3);
            this.tabCreate.Size = new System.Drawing.Size(679, 483);
            this.tabCreate.TabIndex = 0;
            this.tabCreate.Text = "Create";
            this.tabCreate.UseVisualStyleBackColor = true;
            // 
            // btnCreate
            // 
            this.btnCreate.Location = new System.Drawing.Point(184, 236);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(194, 92);
            this.btnCreate.TabIndex = 10;
            this.btnCreate.Text = "Create";
            this.btnCreate.UseVisualStyleBackColor = true;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(181, 174);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Genre";
            // 
            // bookGenres
            // 
            this.bookGenres.Location = new System.Drawing.Point(184, 190);
            this.bookGenres.Name = "bookGenres";
            this.bookGenres.Size = new System.Drawing.Size(121, 21);
            this.bookGenres.TabIndex = 8;
            // 
            // bookRelease
            // 
            this.bookRelease.Location = new System.Drawing.Point(184, 138);
            this.bookRelease.Name = "bookRelease";
            this.bookRelease.Size = new System.Drawing.Size(200, 20);
            this.bookRelease.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(181, 122);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Release";
            // 
            // lblAuthor
            // 
            this.lblAuthor.AutoSize = true;
            this.lblAuthor.Location = new System.Drawing.Point(181, 72);
            this.lblAuthor.Name = "lblAuthor";
            this.lblAuthor.Size = new System.Drawing.Size(38, 13);
            this.lblAuthor.TabIndex = 4;
            this.lblAuthor.Text = "Author";
            // 
            // bookAuthor
            // 
            this.bookAuthor.Location = new System.Drawing.Point(184, 88);
            this.bookAuthor.Name = "bookAuthor";
            this.bookAuthor.Size = new System.Drawing.Size(144, 20);
            this.bookAuthor.TabIndex = 3;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Location = new System.Drawing.Point(181, 22);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(27, 13);
            this.lblTitle.TabIndex = 2;
            this.lblTitle.Text = "Title";
            // 
            // bookTitle
            // 
            this.bookTitle.Location = new System.Drawing.Point(184, 38);
            this.bookTitle.Name = "bookTitle";
            this.bookTitle.Size = new System.Drawing.Size(144, 20);
            this.bookTitle.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 23);
            this.label1.TabIndex = 0;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(10, 400);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(657, 67);
            this.btnSearch.TabIndex = 1;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // SearchPattern
            // 
            this.SearchPattern.Location = new System.Drawing.Point(12, 374);
            this.SearchPattern.Name = "SearchPattern";
            this.SearchPattern.Size = new System.Drawing.Size(655, 20);
            this.SearchPattern.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 358);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Search";
            // 
            // dgvSearch
            // 
            this.dgvSearch.AllowUserToAddRows = false;
            this.dgvSearch.AllowUserToDeleteRows = false;
            this.dgvSearch.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSearch.Location = new System.Drawing.Point(10, 10);
            this.dgvSearch.Name = "dgvSearch";
            this.dgvSearch.ReadOnly = true;
            this.dgvSearch.Size = new System.Drawing.Size(656, 338);
            this.dgvSearch.TabIndex = 4;
            // 
            // ManagerWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(682, 523);
            this.Controls.Add(this.tabs);
            this.Name = "ManagerWindow";
            this.Text = "ManagerWindow";
            this.Load += new System.EventHandler(this.ManagerWindow_Load);
            this.tabs.ResumeLayout(false);
            this.tabList.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvList)).EndInit();
            this.tabSearch.ResumeLayout(false);
            this.tabSearch.PerformLayout();
            this.tabCreate.ResumeLayout(false);
            this.tabCreate.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSearch)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TabControl tabs;
        private System.Windows.Forms.TabPage tabList;
        private System.Windows.Forms.TabPage tabCreate;
        private System.Windows.Forms.TabPage tabSearch;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.TextBox bookTitle;
        private System.Windows.Forms.Label lblAuthor;
        private System.Windows.Forms.TextBox bookAuthor;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker bookRelease;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox bookGenres;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.DataGridView dgvList;
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox SearchPattern;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.DataGridView dgvSearch;
    }
}

