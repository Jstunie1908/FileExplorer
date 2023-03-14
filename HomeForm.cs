using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace Final_File_Explorer
{
    public partial class HomeForm : Form
    {
        // Fields
        private Button currentBt;
        private DriveInfo[] driveInfos;
        private string currentDir = "";
        private string currentlySelectedItem;

        public HomeForm()
        {
            InitializeComponent();
            populateHome();
            pathUrl.Text = "  Home";
        }


        // ---------------------------------- Button Favorites Click ----------------------------------
        private void btHome_Click(object sender, EventArgs e)
        {
            pathUrl.Text = "  Home";
            currentDir = "";
            ActivateButton(sender);
            listView1.Clear();
            listView1.LargeImageList = largeImageList;
            listView1.SmallImageList = null;
            listView1.View = View.Tile;
            listView1.TileSize = new System.Drawing.Size(330, 85);

            for (int i = driveInfos.Length - 1; i >= 0; i--)
            {
                // populate List Disk
                string diskName = "Local Disk (" + driveInfos[i].Name.Substring(0, driveInfos[i].Name.Length - 1) + ")";
                ListViewItem item = new ListViewItem(diskName, 0);
                listView1.Items.Add(item);
            }
        }

        private void btDesktop_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);

            string userName = Environment.UserName;
            string dirPath = "C:\\Users\\" + userName + "\\Desktop";
            currentDir = dirPath;
            LoadFileAndDirectories();
        }

        private void btDownload_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);

            string userName = Environment.UserName;
            string dirPath = "C:\\Users\\" + userName + "\\Downloads";
            currentDir = dirPath;
            LoadFileAndDirectories();
        }

        private void btDocument_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);

            string userName = Environment.UserName;
            string dirPath = "C:\\Users\\" + userName + "\\Documents";
            currentDir = dirPath;
            LoadFileAndDirectories();
        }

        private void btPictures_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);

            string userName = Environment.UserName;
            string dirPath = "C:\\Users\\" + userName + "\\Pictures";
            currentDir = dirPath;
            LoadFileAndDirectories();
        }

        public void btDiskClick(object sender, EventArgs e)
        {
            ActivateButton(sender);
            Button bt = (Button)sender;
            string diskText = bt.Text;
            string diskName = diskText.Substring(diskText.IndexOf("(") + 1, 2) + "\\";
            currentDir = diskName;
            LoadFileAndDirectories();
            

        }

        private void btReload_Click(object sender, EventArgs e)
        {
            if(currentDir!="")
            {
                LoadFileAndDirectories();
            }
        }

        private void btBack_Click(object sender, EventArgs e)
        {
            if(currentDir.Length > 3)
            {
                currentDir = currentDir.Substring(0, currentDir.LastIndexOf("\\"));
                if(!currentDir.Contains("\\"))
                {
                    currentDir += "\\";
                }
                LoadFileAndDirectories();
            }
            
        }

        // ------------------------------------- IO Functions -----------------------------------------------------
        public void populateHome()
        {
            driveInfos = DriveInfo.GetDrives();
            for (int i = driveInfos.Length - 1; i >= 0; i--)
            {
                // populate left panel
                Button bt = createBtDisk(driveInfos[i]);
                bt.Click += new System.EventHandler(this.btDiskClick);
                bt.Image = global::Final_File_Explorer.Properties.Resources.hard_drive__1_;
                panelDisk.Controls.Add(bt);

                // populate main panel
                listView1.View = View.Tile;
                listView1.TileSize = new System.Drawing.Size(330, 85);
                listView1.LargeImageList = largeImageList;
                string diskName = "Local Disk (" + driveInfos[i].Name.Substring(0, driveInfos[i].Name.Length - 1) + ")";
                ListViewItem item = new ListViewItem(diskName, 0);
                listView1.Items.Add(item);
            }
        }


        public void LoadFileAndDirectories()
        {
            pathUrl.Text = currentDir;

            // set view to details
            listView1.View = View.Details;
            listView1.AllowColumnReorder = true;
            listView1.FullRowSelect = true;
            listView1.GridLines = false;
            listView1.Sorting = SortOrder.Ascending;

            // add columns
            if (listView1.Columns.Count == 0)
            {
                listView1.Columns.Add("Name", 300, HorizontalAlignment.Left);
                listView1.Columns.Add("Date Modified", 150, HorizontalAlignment.Left);
                listView1.Columns.Add("Type", 150, HorizontalAlignment.Left);
                listView1.Columns.Add("Size", 150, HorizontalAlignment.Left);
            }

            // change image list
            listView1.LargeImageList = null;
            listView1.SmallImageList = smallImageList;
            try
            {
                DirectoryInfo totalDirInfo = new DirectoryInfo(currentDir);
                FileInfo[] files = totalDirInfo.GetFiles(); // get all files

                var dirInfos = new List<System.IO.DirectoryInfo>();
                dirInfos.AddRange(totalDirInfo.GetDirectories("*.*", SearchOption.TopDirectoryOnly).Where(w => (w.Attributes & FileAttributes.Hidden) == 0)); // get all dirs
                string fileExt = "";

                listView1.Items.Clear();

                // add files to listview
                for (int i = 0; i < files.Length; i++)
                {

                    fileExt = files[i].Extension.ToLower();
                    switch (fileExt)
                    {
                        case ".mp3":
                        case ".flac":
                            ListViewItem audioItem = new ListViewItem(files[i].Name, 4);
                            audioItem.SubItems.Add(File.GetLastWriteTime(files[i].FullName).ToString("dd//MM/yy"));
                            audioItem.SubItems.Add("Audio File");
                            audioItem.SubItems.Add(computeFileSize(files[i].Length));
                            listView1.Items.Add(audioItem);
                            break;
                        case ".exe":
                            ListViewItem exeItem = new ListViewItem(files[i].Name, 0);
                            exeItem.SubItems.Add(File.GetLastWriteTime(files[i].FullName).ToString("dd//MM/yy"));
                            exeItem.SubItems.Add("Executable File");
                            exeItem.SubItems.Add(computeFileSize(files[i].Length));
                            listView1.Items.Add(exeItem);
                            break;
                        case ".mp4":
                        case ".mkv":
                        case ".m4a":
                        case ".avi":
                            ListViewItem videoItem = new ListViewItem(files[i].Name, 7);
                            videoItem.SubItems.Add(File.GetLastWriteTime(files[i].FullName).ToString("dd//MM/yy"));
                            videoItem.SubItems.Add("Video File");
                            videoItem.SubItems.Add(computeFileSize(files[i].Length));
                            listView1.Items.Add(videoItem);
                            break;
                        case ".pdf":
                            ListViewItem pdfItem = new ListViewItem(files[i].Name, 6);
                            pdfItem.SubItems.Add(File.GetLastWriteTime(files[i].FullName).ToString("dd//MM/yy"));
                            pdfItem.SubItems.Add("PDF");
                            pdfItem.SubItems.Add(computeFileSize(files[i].Length));
                            listView1.Items.Add(pdfItem);
                            break;
                        case ".doc":
                        case ".docx":
                            ListViewItem wordItem = new ListViewItem(files[i].Name, 1);
                            wordItem.SubItems.Add(File.GetLastWriteTime(files[i].FullName).ToString("dd//MM/yy"));
                            wordItem.SubItems.Add("Word Document");
                            wordItem.SubItems.Add(computeFileSize(files[i].Length));
                            listView1.Items.Add(wordItem);
                            break;
                        case ".png":
                        case ".jpg":
                        case ".jpeg":
                            ListViewItem imgItem = new ListViewItem(files[i].Name, 5);
                            imgItem.SubItems.Add(File.GetLastWriteTime(files[i].FullName).ToString("dd//MM/yy"));
                            imgItem.SubItems.Add("Image File");
                            imgItem.SubItems.Add(computeFileSize(files[i].Length));
                            listView1.Items.Add(imgItem);
                            break;
                        default:
                            ListViewItem defaultItem = new ListViewItem(files[i].Name, 3);
                            defaultItem.SubItems.Add(File.GetLastWriteTime(files[i].FullName).ToString("dd//MM/yy"));
                            defaultItem.SubItems.Add("File");
                            defaultItem.SubItems.Add(computeFileSize(files[i].Length));
                            listView1.Items.Add(defaultItem);
                            break;
                    }

                }

                // add folders to listview
                foreach (var directory in dirInfos)
                {
                    ListViewItem folderItem = new ListViewItem(directory.Name, 2);
                    folderItem.SubItems.Add(File.GetLastWriteTime(directory.FullName).ToString("dd/MM/yy"));
                    folderItem.SubItems.Add("Folder");

                    listView1.Items.Add(folderItem);
                }
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception.ToString());
            }
        }


        // -------------------------------------- ListView Function ----------------------------------------------------------

        // khi double click vào 1 folder thì sẽ duyệt folder đó
        private void listViewMain_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if(listView1.View == View.Tile)
            {
                currentDir = currentlySelectedItem.Substring(currentlySelectedItem.IndexOf("(") + 1, 2) + "\\";
                LoadFileAndDirectories();
            }
            else if (listView1.View == View.Details)
            {
                string tempFilePath;
                if (currentDir[currentDir.Length-1]=='\\')
                {
                    tempFilePath = currentDir + currentlySelectedItem;
                } 
                else
                {
                    tempFilePath = currentDir + "\\" + currentlySelectedItem;
                }
                ;
                // Console.WriteLine(tempFilePath);
                FileAttributes fileAttr = File.GetAttributes(tempFilePath);

                if ((fileAttr & FileAttributes.Directory) == FileAttributes.Directory)
                {
                    currentDir = tempFilePath;
                    LoadFileAndDirectories();
                }
                else
                {
                    Process.Start(tempFilePath);
                }
            }
        }


        private void listViewMain_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            currentlySelectedItem = e.Item.Text;
            // Console.WriteLine(currentlySelectedItem);
        }


        // -------------------------------------- Utility Functions -----------------------------------
        public void ActivateButton(object btnSender)
        {
            if (btnSender != null)
            {
                if (currentBt != btnSender)
                {
                    DisableButton();
                    currentBt = (Button)btnSender;

                    currentBt.ForeColor = Color.White;
                    currentBt.BackColor = Color.FromArgb(215, 7, 151, 250);
                    this.btDownload.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));

                }
            }
        }

        public void DisableButton()
        {
            foreach (Control previousBt in panelMenu.Controls)
            {
                if (previousBt.GetType() == typeof(Button))
                {
                    previousBt.BackColor = Color.FromArgb(51, 51, 76);
                    previousBt.ForeColor = Color.Gainsboro;
                    previousBt.Font = this.btDownload.Font = new System.Drawing.Font("Microsoft YaHei UI", 8.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                }
            }

            foreach (Control previousBt in panelDisk.Controls)
            {
                previousBt.BackColor = Color.FromArgb(51, 51, 76);
                previousBt.ForeColor = Color.Gainsboro;
                previousBt.Font = this.btDownload.Font = new System.Drawing.Font("Microsoft YaHei UI", 8.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            }
        }

        public Button createBtDisk(DriveInfo info)
        {

            Button btDisk = new Button();
            btDisk.Dock = System.Windows.Forms.DockStyle.Top;
            btDisk.FlatAppearance.BorderSize = 0;
            btDisk.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btDisk.Font = new System.Drawing.Font("Microsoft YaHei UI", 8.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            btDisk.ForeColor = System.Drawing.Color.Gainsboro;
            btDisk.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            btDisk.Location = new System.Drawing.Point(0, 405);
            btDisk.Name = "btDiskF";
            btDisk.Padding = new System.Windows.Forms.Padding(25, 0, 0, 0);
            btDisk.Size = new System.Drawing.Size(200, 33);
            btDisk.TabIndex = 10;
            btDisk.Text = "  Local Disk " + '(' + info.Name.Substring(0, info.Name.Length - 1) + ')';
            btDisk.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            btDisk.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            btDisk.UseVisualStyleBackColor = true;

            return btDisk;
        }

        public string computeFileSize(long fileSize)
        {
            string fileSizeInfo;
            if (fileSize > Math.Pow(1024, 3))
            {
                fileSizeInfo = Math.Round(fileSize / Math.Pow(1024, 3), 1).ToString() + " GB";
            }
            else if (fileSize > Math.Pow(1024, 2))
            {
                fileSizeInfo = Math.Round(fileSize / Math.Pow(1024, 2), 1).ToString() + " MB";
            }
            else
            {
                fileSizeInfo = Math.Round(fileSize / 1024.0, 1).ToString() + " KB";
            }
            return fileSizeInfo;
        }

        
    }
}
