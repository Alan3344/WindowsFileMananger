using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFileMananger
{
    public partial class FileMananger : Form
    {
        //private List<string> btn_Previous = new List<string>();
        //private List<string> btn_Next = new List<string>();
        //private string Btn_Enter { get; set; }
        private string InitFilePath { get; set; }

        public FileMananger()
        {
            InitializeComponent();
            //this.BackgroundImage = ""
            InitFileListview();
            InitFilePath = "C:\\";
            LoadDir(InitFilePath);
        }

        // 调用系统cmd开启一个新的进程
        private void RunCommand(string execName, string command)
        {
            using (Process pc = new Process())
            {
                pc.StartInfo.FileName = execName;
                pc.StartInfo.CreateNoWindow = true;
                pc.StartInfo.RedirectStandardError = true;
                pc.StartInfo.RedirectStandardInput = true;
                pc.StartInfo.RedirectStandardOutput = true;
                pc.StartInfo.UseShellExecute = false;
                pc.Start();
                pc.StandardInput.WriteLine(command);
                pc.StandardInput.WriteLine("exit");
                pc.StandardInput.AutoFlush = true;
                Console.WriteLine(pc.StandardOutput.ReadToEnd());
            }
        }

        private void DeleteListViewItems()
        {
            if (listView_Area.Items.Count > 0)
            {
                foreach (ListViewItem item in listView_Area.Items)
                {
                    item.Remove();
                }
            }
        }


        private void UpdateTextBox(string dirPath)
        {
            tbFilePath.Text = dirPath;
           
            string f1 = tbFilePath.Text;
            string[] f2 = f1.Split(':');
            if (f2.Length == 2 && f2[1] == "") f2[1] = "\\";
            //Console.WriteLine(f2.Length);
            //foreach (string i in f2)
            //{
            //   Console.Write(i + " ");
            //}
            Console.WriteLine();

            Text = "文件管理器 -- " + tbFilePath.Text;
            label_perious.Text = tbFilePath.Text; // 该控件不可见

            tbFilePath.Text = f2[0].ToUpper() + ":" + f2[1];

            if (tbFilePath.Focus())
            {
                tbFilePath.Select(tbFilePath.TextLength, 0);
                tbFilePath.ScrollToCaret();
            }
        }


        public void SetWidgetToolTip(Button w, string text)
        {
            ToolTip tt = new ToolTip();
            tt.ShowAlways = true;
            tt.SetToolTip(w, text);
        }

        // init window
        private void InitFileListview()
        {
            listView_Area.View = View.Details; // 设置显示模式
            listView_Area.FullRowSelect = true; // 整行选中

            // 宽度-2表示自动调整宽度
            listView_Area.Columns.Add("文件名", 300, HorizontalAlignment.Left);
            listView_Area.Columns.Add("修改日期", 230, HorizontalAlignment.Left);
            listView_Area.Columns.Add("类型", 150, HorizontalAlignment.Left);
            listView_Area.Columns.Add("大小", -2, HorizontalAlignment.Left);
            listView_Area.Columns.Add("位置", 300, HorizontalAlignment.Left); // 隐藏列

            //listView1.Items.Add("java study.pdf");
            ListViewItem item1 = new ListViewItem("java study.pdf");
            item1.SubItems.Add("2021-3-7 18:52");
            item1.SubItems.Add("PDF");
            item1.SubItems.Add("192kb");
            //listView1.Items.Add(item1);

            // 创建ImageList, 并添加两个小图标
            ImageList imagelist = new ImageList();
            imagelist.ImageSize = new Size(16, 16);
            imagelist.Images.Add(Properties.myResource.icon_folder);
            imagelist.Images.Add(Properties.myResource.icon_file);

            listView_Area.SmallImageList = imagelist; // 小图标列表,装载ImageList => ListView
            //listView1.ColumnClick 
        }

        // add folder list
        private void addItem(DirectoryInfo dof, int imageIndex)
        {
            ListViewItem item = new ListViewItem(dof.Name, imageIndex);
            item.SubItems.Add(dof.LastWriteTime.ToString("yyyy/MM/dd HH:mm"));
            item.SubItems.Add("文件夹");
            item.SubItems.Add("");
            item.SubItems.Add(dof.FullName);
            listView_Area.Items.Add(item);
        }

        // add file list
        private void addItem(FileInfo dof, int imageIndex)
        {
            ListViewItem item = new ListViewItem(dof.Name, imageIndex);
            item.SubItems.Add(dof.LastWriteTime.ToString("yyyy/MM/dd HH:mm"));
            item.SubItems.Add(dof.Extension.ToUpper() + "文件");
            item.SubItems.Add(dof.Length + " bytes");
            item.SubItems.Add(dof.DirectoryName);
            listView_Area.Items.Add(item);
        }

        // load list UI by folder/file path
        private DirectoryInfo LoadDir(string dirPath)
        {
            dirPath = dirPath.Trim();
            if (dirPath == "") dirPath = InitFilePath;
            if (dirPath.Contains('/')) dirPath.Replace('/', '\\');
            if (Path.GetInvalidFileNameChars().Length != 0) { }
            //Console.WriteLine(Path.GetInvalidFileNameChars().ToString());
           
            try
            {
                DirectoryInfo dir = new DirectoryInfo(dirPath);
                if (dir.Exists)
                {

                    Console.WriteLine(dir.Attributes.ToString());
                    UpdateTextBox(dirPath);
                    DeleteListViewItems();
                    listView_Area.BeginUpdate();
                    DirectoryInfo[] subDirs = dir.GetDirectories();
                    foreach (DirectoryInfo folder in subDirs)
                    {
                        string attr = folder.Attributes.ToString();
                        if (!attr.Contains("System"))  //  && attr.Contains("Hidden") 目录内可能含有Windows隐藏文件,无法访问!!
                        {
                            addItem(folder, 0);
                        }
                    }

                    DirectoryInfo files = new DirectoryInfo(dir.ToString());
                    FileInfo[] fileInfos = files.GetFiles();
                    foreach (FileInfo file in fileInfos)
                    {
                        addItem(file, 1);
                    }
                    listView_Area.EndUpdate();
                    return dir;
                }
                else
                {
                    //MessageBox.Show("文件夹或文件路径不存在!!", "!路径不存在");

                    tbFilePath.Text = label_perious.Text;
                    if (tbFilePath.Focus())
                    {
                        tbFilePath.Select(tbFilePath.TextLength, 0);
                        tbFilePath.ScrollToCaret();
                    }
                    return null;
                }
            }
            catch (Exception e)
            {
                string err = string.Format("系统错误信息:{0}\n无法访问:{1}\n\n\n", e.Message, tbFilePath.Text);
                tbFilePath.Text = InitFilePath;
                LoadDir(tbFilePath.Text);
                MessageBox.Show(err, "!位置不可用");
                return null;
            }
        }

        // 后退
        private void btnPrevious_Click(object sender, EventArgs e)
        {
            label_next.Text = label_perious.Text;
            if (label_perious.Text.EndsWith(":\\")) return;
            string p = new DirectoryInfo(label_perious.Text).Parent.FullName.ToString();
            LoadDir(p);
        }

        // 前进
        private void btnNext_Click(object sender, EventArgs e)
        {
            if (label_next.Text == "") return;
            LoadDir(label_next.Text);
            //Process.Start("cmd"); // 直接打开程序
            //RunCommand("cmd", "ping -c1 google.com");
        }

        // 进入文件目录
        private void btnGoto_Click(object sender, EventArgs e)
        {
            Console.WriteLine("load file path: " + tbFilePath.Text);
            if (tbFilePath.Text.EndsWith(":")) tbFilePath.Text = tbFilePath.Text + "\\";
            LoadDir(tbFilePath.Text);
        }

        private void tbFilePath_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode.ToString() == "Return")
            {
                Console.WriteLine("e.KeyValue: " + e.KeyValue);
                btnGoto_Click(sender, e);
            }
        }


        // Hover tip
        private void btnPrevious_MouseEnter(object sender, EventArgs e)
        {
            this.SetWidgetToolTip(btnPrevious, "后退 (Alt + 向左键)");
        }

        private void btnNext_MouseEnter(object sender, EventArgs e)
        {
            this.SetWidgetToolTip(btnNext, "后退 (Alt + 向右键)");
        }

        private void btnGoto_MouseEnter(object sender, EventArgs e)
        {
            this.SetWidgetToolTip(btnGoto, "进入 (Enter)");
        }

        private void FileMananger_KeyDown(object sender, KeyEventArgs e)
        {
            tbFilePath_KeyDown(sender, e);
            Console.WriteLine("btnGoto_KeyDown <Enter>");
        }

        private void listView_Area_ColumnClick(object sender, ColumnClickEventArgs e)
        {
            Console.WriteLine("选中了 {0} 列", e.Column);
        }

        private void listView_Area_DoubleClick(object sender, EventArgs e)
        {
            if (listView_Area.FocusedItem != null)
            {
                if (listView_Area.SelectedItems.Count > 0)
                {
                    // get current selected row path
                    string current_row_5col_text = listView_Area.FocusedItem.SubItems[4].Text;
                    string currentFilePath = current_row_5col_text + "\\" + listView_Area.FocusedItem.SubItems[0].Text;
                    if (File.Exists(currentFilePath)) // 文件双击直接打开
                    {
                        if (currentFilePath.Contains(" ")) currentFilePath = $"'{currentFilePath}'";
                        Console.WriteLine("file: " + currentFilePath);
                        RunCommand("cmd", currentFilePath);
                    } 
                    else if (Directory.Exists(current_row_5col_text)) // 目录双击直接进入内层
                    {
                        Console.WriteLine("directory: " + current_row_5col_text);
                        LoadDir(current_row_5col_text);
                        label_next.Text = "";
                    }
                }
            }
        }

        // 悬停提示
        private void listView_Area_MouseHover(object sender, EventArgs e)
        {
            foreach (ListViewItem item in listView_Area.Items)
            {
                if (item.Focused)
                {
                    item.ToolTipText = "item.Text";
                }
            }
        }
    }
}
