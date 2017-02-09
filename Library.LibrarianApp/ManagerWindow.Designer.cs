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
            this.tabSearch = new System.Windows.Forms.TabPage();
            this.tabCreate = new System.Windows.Forms.TabPage();
            this.label3 = new System.Windows.Forms.Label();
            this.bookGenres = new System.Windows.Forms.ComboBox();
            this.bookRelease = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.lblAuthor = new System.Windows.Forms.Label();
            this.bookAuthor = new System.Windows.Forms.TextBox();
            this.lblTitle = new System.Windows.Forms.Label();
            this.bookTitle = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCreate = new System.Windows.Forms.Button();
            this.tabs.SuspendLayout();
            this.tabCreate.SuspendLayout();
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
            this.tabList.Location = new System.Drawing.Point(4, 39);
            this.tabList.Margin = new System.Windows.Forms.Padding(10);
            this.tabList.Name = "tabList";
            this.tabList.Padding = new System.Windows.Forms.Padding(10);
            this.tabList.Size = new System.Drawing.Size(679, 483);
            this.tabList.TabIndex = 2;
            this.tabList.Text = "List";
            this.tabList.UseVisualStyleBackColor = true;
            // 
            // tabSearch
            // 
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
            this.bookGenres.DataSource = new Library.Core.Models.Genres[] {
        Library.Core.Models.Genres.Comedy,
        Library.Core.Models.Genres.Drama,
        Library.Core.Models.Genres.Horror,
        Library.Core.Models.Genres.Adventure,
        Library.Core.Models.Genres.Historical,
        Library.Core.Models.Genres.Science,
        Library.Core.Models.Genres.Suspense,
        Library.Core.Models.Genres.Thriller,
        Library.Core.Models.Genres.Fantasy};
            this.bookGenres.FormattingEnabled = true;
            this.bookGenres.Items.AddRange(new object[] {
            Library.Core.Models.Genres.Comedy,
            Library.Core.Models.Genres.Drama,
            Library.Core.Models.Genres.Horror,
            Library.Core.Models.Genres.Adventure,
            Library.Core.Models.Genres.Historical,
            Library.Core.Models.Genres.Science,
            Library.Core.Models.Genres.Suspense,
            Library.Core.Models.Genres.Thriller,
            Library.Core.Models.Genres.Fantasy});
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
            // btnCreate
            // 
            this.btnCreate.Location = new System.Drawing.Point(184, 236);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(194, 92);
            this.btnCreate.TabIndex = 10;
            this.btnCreate.Text = "Create";
            this.btnCreate.UseVisualStyleBackColor = true;
            // 
            // ManagerWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(682, 523);
            this.Controls.Add(this.tabs);
            this.Name = "ManagerWindow";
            this.Text = "ManagerWindow";
            this.tabs.ResumeLayout(false);
            this.tabCreate.ResumeLayout(false);
            this.tabCreate.PerformLayout();
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
    }
}

