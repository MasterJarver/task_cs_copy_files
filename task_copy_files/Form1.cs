using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace task_copy_files
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void from_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog dialog = new FolderBrowserDialog();
            if(dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                text_from.Text = dialog.SelectedPath;
                fromPath = dialog.SelectedPath;
                fromDirName = new DirectoryInfo(dialog.SelectedPath).Name;
            }
        }

        private void to_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog dialog = new FolderBrowserDialog();
            if(dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                text_to.Text = dialog.SelectedPath;
                toPath = dialog.SelectedPath;
                toDirName = new DirectoryInfo(dialog.SelectedPath).Name;
            }
        }

        async private void copy_Click(object sender, EventArgs e)
        {
            progressBar1.Value = 0;
            listBox1.Items.Clear();
            // string[] files = Directory.GetFiles(@"C:\1", "*.txt"); // получаем список всех файлов
            string[] files = Directory.GetFiles(fromPath, "*");
            directoryForCopy = Directory.CreateDirectory(toPath + @"\" + fromDirName).FullName;
            int qt = files.Length;
            progressBar1.Maximum = qt; // устанавливаем максимальное значение прогресс бара по кол. файлов
            for(int i = 0; i < qt; i++)
            {
                // string fl = files[i];
                string fileName = Path.GetFileName(files[i]);
                file_name.Text = "File Name: " + fileName;
                File.Copy(files[i], directoryForCopy + @"\" + fileName, true);
                progressBar1.Value++;
                listBox1.Items.Add(fileName);
                await Task.Delay(1000); // test
            }
        }
        private string fromDirName; // имя папки, которую нужно копировать
        private string fromPath; // путь к папке, которую нужно копировать
        private string toDirName; // имя папки в которую нужно копировать
        private string toPath; // путь к папке в которую нужно копировать
        private string directoryForCopy; // путь к папке, в которую нужно копировать файлы
    }
}
