namespace NGS_PolyCounter
{
    partial class Form1
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.button_Delete = new System.Windows.Forms.Button();
            this.button_Add = new System.Windows.Forms.Button();
            this.button_Save = new System.Windows.Forms.Button();
            this.button_Load = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.listBox_Genes = new System.Windows.Forms.ListBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.button_Restore = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button_Restore);
            this.panel1.Controls.Add(this.button_Delete);
            this.panel1.Controls.Add(this.button_Add);
            this.panel1.Controls.Add(this.button_Save);
            this.panel1.Controls.Add(this.button_Load);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(522, 36);
            this.panel1.TabIndex = 0;
            // 
            // button_Delete
            // 
            this.button_Delete.Location = new System.Drawing.Point(84, 7);
            this.button_Delete.Name = "button_Delete";
            this.button_Delete.Size = new System.Drawing.Size(75, 23);
            this.button_Delete.TabIndex = 3;
            this.button_Delete.Text = "Delete";
            this.button_Delete.UseVisualStyleBackColor = true;
            this.button_Delete.Click += new System.EventHandler(this.button_Delete_Click);
            // 
            // button_Add
            // 
            this.button_Add.Location = new System.Drawing.Point(3, 7);
            this.button_Add.Name = "button_Add";
            this.button_Add.Size = new System.Drawing.Size(75, 23);
            this.button_Add.TabIndex = 2;
            this.button_Add.Text = "Add Gene";
            this.button_Add.UseVisualStyleBackColor = true;
            this.button_Add.Click += new System.EventHandler(this.button_Add_Click);
            // 
            // button_Save
            // 
            this.button_Save.Location = new System.Drawing.Point(319, 7);
            this.button_Save.Name = "button_Save";
            this.button_Save.Size = new System.Drawing.Size(75, 23);
            this.button_Save.TabIndex = 1;
            this.button_Save.Text = "Save";
            this.button_Save.UseVisualStyleBackColor = true;
            this.button_Save.Click += new System.EventHandler(this.button_Save_Click);
            // 
            // button_Load
            // 
            this.button_Load.Location = new System.Drawing.Point(238, 7);
            this.button_Load.Name = "button_Load";
            this.button_Load.Size = new System.Drawing.Size(75, 23);
            this.button_Load.TabIndex = 0;
            this.button_Load.Text = "Load";
            this.button_Load.UseVisualStyleBackColor = true;
            this.button_Load.Click += new System.EventHandler(this.button_Load_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.listBox_Genes);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupBox1.Location = new System.Drawing.Point(0, 36);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(236, 487);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Genes:";
            // 
            // listBox_Genes
            // 
            this.listBox_Genes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBox_Genes.FormattingEnabled = true;
            this.listBox_Genes.Location = new System.Drawing.Point(3, 16);
            this.listBox_Genes.Name = "listBox_Genes";
            this.listBox_Genes.Size = new System.Drawing.Size(230, 468);
            this.listBox_Genes.TabIndex = 0;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.Multiselect = true;
            this.openFileDialog1.RestoreDirectory = true;
            this.openFileDialog1.Title = "Load file";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dataGridView1);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(236, 36);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(286, 487);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Empty";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 16);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(280, 468);
            this.dataGridView1.TabIndex = 2;
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.DefaultExt = "txt";
            this.saveFileDialog1.Filter = "\"Text files\"|*.txt";
            this.saveFileDialog1.RestoreDirectory = true;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 523);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(522, 32);
            this.panel2.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(182, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = " Copyright (C) 2018  Georgi Danovski";
            // 
            // button_Restore
            // 
            this.button_Restore.Location = new System.Drawing.Point(400, 7);
            this.button_Restore.Name = "button_Restore";
            this.button_Restore.Size = new System.Drawing.Size(75, 23);
            this.button_Restore.TabIndex = 4;
            this.button_Restore.Text = "Restore";
            this.button_Restore.UseVisualStyleBackColor = true;
            this.button_Restore.Click += new System.EventHandler(this.button_Restore_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(522, 555);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Name = "Form1";
            this.Text = "NGS_PolyCounter";
            this.panel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button_Save;
        private System.Windows.Forms.Button button_Load;
        private System.Windows.Forms.Button button_Delete;
        private System.Windows.Forms.Button button_Add;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListBox listBox_Genes;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button_Restore;
    }
}

