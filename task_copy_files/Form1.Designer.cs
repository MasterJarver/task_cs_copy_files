namespace task_copy_files
{
    partial class MainForm
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
            this.from = new System.Windows.Forms.Button();
            this.to = new System.Windows.Forms.Button();
            this.text_from = new System.Windows.Forms.TextBox();
            this.text_to = new System.Windows.Forms.TextBox();
            this.copy = new System.Windows.Forms.Button();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.file_name = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // from
            // 
            this.from.Location = new System.Drawing.Point(501, 23);
            this.from.Name = "from";
            this.from.Size = new System.Drawing.Size(75, 23);
            this.from.TabIndex = 0;
            this.from.Text = "From";
            this.from.UseVisualStyleBackColor = true;
            this.from.Click += new System.EventHandler(this.from_Click);
            // 
            // to
            // 
            this.to.Location = new System.Drawing.Point(501, 94);
            this.to.Name = "to";
            this.to.Size = new System.Drawing.Size(75, 23);
            this.to.TabIndex = 1;
            this.to.Text = "To";
            this.to.UseVisualStyleBackColor = true;
            this.to.Click += new System.EventHandler(this.to_Click);
            // 
            // text_from
            // 
            this.text_from.Location = new System.Drawing.Point(12, 23);
            this.text_from.Name = "text_from";
            this.text_from.Size = new System.Drawing.Size(483, 20);
            this.text_from.TabIndex = 2;
            // 
            // text_to
            // 
            this.text_to.Location = new System.Drawing.Point(12, 94);
            this.text_to.Name = "text_to";
            this.text_to.Size = new System.Drawing.Size(483, 20);
            this.text_to.TabIndex = 3;
            // 
            // copy
            // 
            this.copy.Location = new System.Drawing.Point(256, 334);
            this.copy.Name = "copy";
            this.copy.Size = new System.Drawing.Size(75, 23);
            this.copy.TabIndex = 4;
            this.copy.Text = "Copy";
            this.copy.UseVisualStyleBackColor = true;
            this.copy.Click += new System.EventHandler(this.copy_Click);
            // 
            // progressBar1
            // 
            this.progressBar1.BackColor = System.Drawing.SystemColors.Control;
            this.progressBar1.Location = new System.Drawing.Point(12, 305);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(564, 23);
            this.progressBar1.TabIndex = 5;
            // 
            // file_name
            // 
            this.file_name.AutoSize = true;
            this.file_name.Location = new System.Drawing.Point(443, 120);
            this.file_name.Name = "file_name";
            this.file_name.Size = new System.Drawing.Size(52, 13);
            this.file_name.TabIndex = 6;
            this.file_name.Text = "file_name";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 120);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(144, 179);
            this.dataGridView1.TabIndex = 7;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(588, 369);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.file_name);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.copy);
            this.Controls.Add(this.text_to);
            this.Controls.Add(this.text_from);
            this.Controls.Add(this.to);
            this.Controls.Add(this.from);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Task C# Copy Files";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button from;
        private System.Windows.Forms.Button to;
        private System.Windows.Forms.TextBox text_from;
        private System.Windows.Forms.TextBox text_to;
        private System.Windows.Forms.Button copy;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Label file_name;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}

