﻿using System;
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
                from_path = dialog.SelectedPath;
                from_dir_name = new System.IO.DirectoryInfo(dialog.SelectedPath).Name;
            }
        }

        private void to_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog dialog = new FolderBrowserDialog();
            if(dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                text_to.Text = dialog.SelectedPath;
                to_path = dialog.SelectedPath;
                to_dir_name = new System.IO.DirectoryInfo(dialog.SelectedPath).Name;
            }
        }

        async private void copy_Click(object sender, EventArgs e)
        {
            // string[] files = Directory.GetFiles(@"C:\1", "*.txt"); // получаем список всех файлов
            string[] files = Directory.GetFiles(from_path, "*");
            Directory.CreateDirectory(to_path + @"\" + from_dir_name);
            int qt = files.Length;

            progressBar1.Maximum = qt; // устанавливаем максимальное значение прогресс бара по кол. файлов
            for(int i = 0; i < qt; i++)
            {
                file_name.Text = "File: " + files[i];
                progressBar1.Value++;
                await Task.Delay(1000);
            }
        }
        private string from_dir_name; // имя папки, которую нужно копировать
        private string from_path; // путь к папке, которую нужно копировать
        private string to_dir_name; // имя папки в которую нужно копировать
        private string to_path; // путь к папке в которую нужно копировать
    }
}
