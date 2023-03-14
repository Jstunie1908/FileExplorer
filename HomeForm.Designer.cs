
namespace Final_File_Explorer
{
    partial class HomeForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HomeForm));
            this.panelMenu = new System.Windows.Forms.Panel();
            this.panelDisk = new System.Windows.Forms.Panel();
            this.btPC = new System.Windows.Forms.Button();
            this.btPictures = new System.Windows.Forms.Button();
            this.btDocument = new System.Windows.Forms.Button();
            this.btDownload = new System.Windows.Forms.Button();
            this.btDesktop = new System.Windows.Forms.Button();
            this.btHome = new System.Windows.Forms.Button();
            this.btFavorite = new System.Windows.Forms.Button();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.largeImageList = new System.Windows.Forms.ImageList(this.components);
            this.smallImageList = new System.Windows.Forms.ImageList(this.components);
            this.panelTop = new System.Windows.Forms.Panel();
            this.pathUrl = new System.Windows.Forms.TextBox();
            this.btReload = new System.Windows.Forms.Button();
            this.btBack = new System.Windows.Forms.Button();
            this.panelMain = new System.Windows.Forms.Panel();
            this.listView1 = new System.Windows.Forms.ListView();
            this.panelMenu.SuspendLayout();
            this.panelLogo.SuspendLayout();
            this.panelTop.SuspendLayout();
            this.panelMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.panelMenu.Controls.Add(this.panelDisk);
            this.panelMenu.Controls.Add(this.btPC);
            this.panelMenu.Controls.Add(this.btPictures);
            this.panelMenu.Controls.Add(this.btDocument);
            this.panelMenu.Controls.Add(this.btDownload);
            this.panelMenu.Controls.Add(this.btDesktop);
            this.panelMenu.Controls.Add(this.btHome);
            this.panelMenu.Controls.Add(this.btFavorite);
            this.panelMenu.Controls.Add(this.panelLogo);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(200, 561);
            this.panelMenu.TabIndex = 0;
            // 
            // panelDisk
            // 
            this.panelDisk.Location = new System.Drawing.Point(0, 297);
            this.panelDisk.Name = "panelDisk";
            this.panelDisk.Size = new System.Drawing.Size(200, 191);
            this.panelDisk.TabIndex = 7;
            // 
            // btPC
            // 
            this.btPC.FlatAppearance.BorderSize = 0;
            this.btPC.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btPC.Font = new System.Drawing.Font("Microsoft YaHei UI", 8.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btPC.ForeColor = System.Drawing.Color.Gainsboro;
            this.btPC.Image = global::Final_File_Explorer.Properties.Resources.this_pc;
            this.btPC.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btPC.Location = new System.Drawing.Point(-3, 268);
            this.btPC.Name = "btPC";
            this.btPC.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.btPC.Size = new System.Drawing.Size(200, 33);
            this.btPC.TabIndex = 6;
            this.btPC.Text = "  This PC";
            this.btPC.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btPC.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btPC.UseVisualStyleBackColor = true;
            // 
            // btPictures
            // 
            this.btPictures.Dock = System.Windows.Forms.DockStyle.Top;
            this.btPictures.FlatAppearance.BorderSize = 0;
            this.btPictures.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btPictures.Font = new System.Drawing.Font("Microsoft YaHei UI", 8.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btPictures.ForeColor = System.Drawing.Color.Gainsboro;
            this.btPictures.Image = global::Final_File_Explorer.Properties.Resources.picture;
            this.btPictures.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btPictures.Location = new System.Drawing.Point(0, 218);
            this.btPictures.Name = "btPictures";
            this.btPictures.Padding = new System.Windows.Forms.Padding(28, 0, 0, 0);
            this.btPictures.Size = new System.Drawing.Size(200, 33);
            this.btPictures.TabIndex = 5;
            this.btPictures.Text = "  Pictures";
            this.btPictures.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btPictures.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btPictures.UseVisualStyleBackColor = true;
            this.btPictures.Click += new System.EventHandler(this.btPictures_Click);
            // 
            // btDocument
            // 
            this.btDocument.Dock = System.Windows.Forms.DockStyle.Top;
            this.btDocument.FlatAppearance.BorderSize = 0;
            this.btDocument.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btDocument.Font = new System.Drawing.Font("Microsoft YaHei UI", 8.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btDocument.ForeColor = System.Drawing.Color.Gainsboro;
            this.btDocument.Image = global::Final_File_Explorer.Properties.Resources.documents;
            this.btDocument.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btDocument.Location = new System.Drawing.Point(0, 185);
            this.btDocument.Name = "btDocument";
            this.btDocument.Padding = new System.Windows.Forms.Padding(28, 0, 0, 0);
            this.btDocument.Size = new System.Drawing.Size(200, 33);
            this.btDocument.TabIndex = 4;
            this.btDocument.Text = "  Documents";
            this.btDocument.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btDocument.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btDocument.UseVisualStyleBackColor = true;
            this.btDocument.Click += new System.EventHandler(this.btDocument_Click);
            // 
            // btDownload
            // 
            this.btDownload.Dock = System.Windows.Forms.DockStyle.Top;
            this.btDownload.FlatAppearance.BorderSize = 0;
            this.btDownload.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btDownload.Font = new System.Drawing.Font("Microsoft YaHei UI", 8.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btDownload.ForeColor = System.Drawing.Color.Gainsboro;
            this.btDownload.Image = global::Final_File_Explorer.Properties.Resources.down_arrow;
            this.btDownload.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btDownload.Location = new System.Drawing.Point(0, 152);
            this.btDownload.Name = "btDownload";
            this.btDownload.Padding = new System.Windows.Forms.Padding(28, 0, 0, 0);
            this.btDownload.Size = new System.Drawing.Size(200, 33);
            this.btDownload.TabIndex = 3;
            this.btDownload.Text = "  Downloads";
            this.btDownload.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btDownload.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btDownload.UseVisualStyleBackColor = true;
            this.btDownload.Click += new System.EventHandler(this.btDownload_Click);
            // 
            // btDesktop
            // 
            this.btDesktop.Dock = System.Windows.Forms.DockStyle.Top;
            this.btDesktop.FlatAppearance.BorderSize = 0;
            this.btDesktop.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btDesktop.Font = new System.Drawing.Font("Microsoft YaHei UI", 8.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btDesktop.ForeColor = System.Drawing.Color.Gainsboro;
            this.btDesktop.Image = global::Final_File_Explorer.Properties.Resources.laptop;
            this.btDesktop.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btDesktop.Location = new System.Drawing.Point(0, 119);
            this.btDesktop.Name = "btDesktop";
            this.btDesktop.Padding = new System.Windows.Forms.Padding(28, 0, 0, 0);
            this.btDesktop.Size = new System.Drawing.Size(200, 33);
            this.btDesktop.TabIndex = 2;
            this.btDesktop.Text = "  Desktop";
            this.btDesktop.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btDesktop.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btDesktop.UseVisualStyleBackColor = true;
            this.btDesktop.Click += new System.EventHandler(this.btDesktop_Click);
            // 
            // btHome
            // 
            this.btHome.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.btHome.Dock = System.Windows.Forms.DockStyle.Top;
            this.btHome.FlatAppearance.BorderSize = 0;
            this.btHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btHome.Font = new System.Drawing.Font("Microsoft YaHei UI", 8.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btHome.ForeColor = System.Drawing.Color.Gainsboro;
            this.btHome.Image = global::Final_File_Explorer.Properties.Resources.home;
            this.btHome.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btHome.Location = new System.Drawing.Point(0, 86);
            this.btHome.Name = "btHome";
            this.btHome.Padding = new System.Windows.Forms.Padding(28, 0, 0, 0);
            this.btHome.Size = new System.Drawing.Size(200, 33);
            this.btHome.TabIndex = 1;
            this.btHome.Text = "  Home";
            this.btHome.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btHome.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btHome.UseVisualStyleBackColor = false;
            this.btHome.Click += new System.EventHandler(this.btHome_Click);
            // 
            // btFavorite
            // 
            this.btFavorite.Dock = System.Windows.Forms.DockStyle.Top;
            this.btFavorite.FlatAppearance.BorderSize = 0;
            this.btFavorite.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btFavorite.Font = new System.Drawing.Font("Microsoft YaHei UI", 8.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btFavorite.ForeColor = System.Drawing.Color.Gainsboro;
            this.btFavorite.Image = global::Final_File_Explorer.Properties.Resources.star__1_;
            this.btFavorite.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btFavorite.Location = new System.Drawing.Point(0, 53);
            this.btFavorite.Name = "btFavorite";
            this.btFavorite.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.btFavorite.Size = new System.Drawing.Size(200, 33);
            this.btFavorite.TabIndex = 0;
            this.btFavorite.Text = "  Favorite";
            this.btFavorite.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btFavorite.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btFavorite.UseVisualStyleBackColor = true;
            // 
            // panelLogo
            // 
            this.panelLogo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(58)))));
            this.panelLogo.Controls.Add(this.label1);
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(200, 53);
            this.panelLogo.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.LightGray;
            this.label1.Location = new System.Drawing.Point(47, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "File Explorer";
            // 
            // largeImageList
            // 
            this.largeImageList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("largeImageList.ImageStream")));
            this.largeImageList.TransparentColor = System.Drawing.Color.Transparent;
            this.largeImageList.Images.SetKeyName(0, "hard-drive (4).png");
            this.largeImageList.Images.SetKeyName(1, "icons8-doc-file-48.png");
            this.largeImageList.Images.SetKeyName(2, "icons8-exe-48.png");
            this.largeImageList.Images.SetKeyName(3, "icons8-file-48.png");
            this.largeImageList.Images.SetKeyName(4, "icons8-folder-48.png");
            this.largeImageList.Images.SetKeyName(5, "icons8-image-48.png");
            this.largeImageList.Images.SetKeyName(6, "icons8-musical-notes-48.png");
            this.largeImageList.Images.SetKeyName(7, "icons8-pdf-48.png");
            this.largeImageList.Images.SetKeyName(8, "icons8-video-file-48.png");
            // 
            // smallImageList
            // 
            this.smallImageList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("smallImageList.ImageStream")));
            this.smallImageList.TransparentColor = System.Drawing.Color.Transparent;
            this.smallImageList.Images.SetKeyName(0, "exe.png");
            this.smallImageList.Images.SetKeyName(1, "doc.png");
            this.smallImageList.Images.SetKeyName(2, "folder.png");
            this.smallImageList.Images.SetKeyName(3, "documents (1).png");
            this.smallImageList.Images.SetKeyName(4, "music-sheet.png");
            this.smallImageList.Images.SetKeyName(5, "picture (1).png");
            this.smallImageList.Images.SetKeyName(6, "pdf.png");
            this.smallImageList.Images.SetKeyName(7, "video-file.png");
            // 
            // panelTop
            // 
            this.panelTop.Controls.Add(this.pathUrl);
            this.panelTop.Controls.Add(this.btReload);
            this.panelTop.Controls.Add(this.btBack);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Location = new System.Drawing.Point(200, 0);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(769, 53);
            this.panelTop.TabIndex = 1;
            // 
            // pathUrl
            // 
            this.pathUrl.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pathUrl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.pathUrl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pathUrl.Font = new System.Drawing.Font("Microsoft YaHei UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pathUrl.ForeColor = System.Drawing.Color.DarkGray;
            this.pathUrl.Location = new System.Drawing.Point(70, 13);
            this.pathUrl.Name = "pathUrl";
            this.pathUrl.ReadOnly = true;
            this.pathUrl.Size = new System.Drawing.Size(687, 24);
            this.pathUrl.TabIndex = 2;
            // 
            // btReload
            // 
            this.btReload.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btReload.FlatAppearance.BorderSize = 0;
            this.btReload.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btReload.Image = global::Final_File_Explorer.Properties.Resources.reload__2_;
            this.btReload.Location = new System.Drawing.Point(31, 14);
            this.btReload.Name = "btReload";
            this.btReload.Size = new System.Drawing.Size(33, 23);
            this.btReload.TabIndex = 1;
            this.btReload.UseVisualStyleBackColor = true;
            this.btReload.Click += new System.EventHandler(this.btReload_Click);
            // 
            // btBack
            // 
            this.btBack.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btBack.FlatAppearance.BorderSize = 0;
            this.btBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btBack.Image = global::Final_File_Explorer.Properties.Resources.arrow_left;
            this.btBack.Location = new System.Drawing.Point(6, 14);
            this.btBack.Name = "btBack";
            this.btBack.Size = new System.Drawing.Size(27, 23);
            this.btBack.TabIndex = 0;
            this.btBack.UseVisualStyleBackColor = true;
            this.btBack.Click += new System.EventHandler(this.btBack_Click);
            // 
            // panelMain
            // 
            this.panelMain.Controls.Add(this.listView1);
            this.panelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMain.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panelMain.ForeColor = System.Drawing.Color.LightGray;
            this.panelMain.Location = new System.Drawing.Point(200, 53);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(769, 508);
            this.panelMain.TabIndex = 2;
            // 
            // listView1
            // 
            this.listView1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.listView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listView1.ForeColor = System.Drawing.Color.LightGray;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(0, 0);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(769, 508);
            this.listView1.TabIndex = 0;
            this.listView1.TileSize = new System.Drawing.Size(3, 5);
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.ItemSelectionChanged += new System.Windows.Forms.ListViewItemSelectionChangedEventHandler(this.listViewMain_ItemSelectionChanged);
            this.listView1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.listViewMain_MouseDoubleClick);
            // 
            // HomeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.ClientSize = new System.Drawing.Size(969, 561);
            this.Controls.Add(this.panelMain);
            this.Controls.Add(this.panelTop);
            this.Controls.Add(this.panelMenu);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "HomeForm";
            this.Text = "File Explorer";
            this.panelMenu.ResumeLayout(false);
            this.panelLogo.ResumeLayout(false);
            this.panelLogo.PerformLayout();
            this.panelTop.ResumeLayout(false);
            this.panelTop.PerformLayout();
            this.panelMain.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Button btFavorite;
        private System.Windows.Forms.Panel panelLogo;
        private System.Windows.Forms.Button btPC;
        private System.Windows.Forms.Button btPictures;
        private System.Windows.Forms.Button btDocument;
        private System.Windows.Forms.Button btDownload;
        private System.Windows.Forms.Button btDesktop;
        private System.Windows.Forms.Button btHome;
        private System.Windows.Forms.ImageList largeImageList;
        private System.Windows.Forms.Panel panelDisk;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ImageList smallImageList;
        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.TextBox pathUrl;
        private System.Windows.Forms.Button btReload;
        private System.Windows.Forms.Button btBack;
        private System.Windows.Forms.Panel panelMain;
        private System.Windows.Forms.ListView listView1;
    }
}

