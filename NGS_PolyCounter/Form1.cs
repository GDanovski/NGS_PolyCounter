using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace NGS_PolyCounter
{
    public partial class Form1 : Form
    {
        SortedDictionary<string, SortedDictionary<string, int>> data;
        public Form1()
        {
            InitializeComponent();

            this.data = new SortedDictionary<string, SortedDictionary<string, int>>();
            this.listBox_Genes.SelectedIndexChanged += listBox_Genes_SelectedIndexChanged;
            LoadGenes();
            LoadDataBase();

            if(listBox_Genes.Items.Count>0)
                listBox_Genes.SelectedItem = listBox_Genes.Items[0];
        }

        private void button_Restore_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.Reset();
            Properties.Settings.Default.Save();

            LoadGenes();
            LoadDataBase();
            dataGridView1.DataSource = null;
        }
        private void button_Save_Click(object sender, EventArgs e)
        {
            saveFileDialog1.FileName = groupBox2.Text;

            if (saveFileDialog1.ShowDialog()== DialogResult.OK)
            {
                string dir = saveFileDialog1.FileName;
                
                ////
                StreamWriter write = new StreamWriter(File.Create(dir));

                string str = "";
                int row = dataGridView1.Rows.Count;
                int cell = dataGridView1.Rows[1].Cells.Count;
                for (int i = 0; i < row; i++)
                {
                    str = "";
                    for (int j = 0; j < cell; j++)
                    {
                        if (dataGridView1.Rows[i].Cells[j].Value == null)
                        {
                            //return directly
                            //return;
                            //or set a value for the empty data
                            dataGridView1.Rows[i].Cells[j].Value = "null";
                        }
                        str += dataGridView1.Rows[i].Cells[j].Value.ToString() + "\t";
                    }
                    write.WriteLine(str);
                }
               
                write.Close();
                write.Dispose();
                ////
                MessageBox.Show("File saved to:\n" + dir);

            }
        }

        private void button_Load_Click(object sender, EventArgs e)
        {
            if(openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string[] dirs = openFileDialog1.FileNames;

                foreach(string dir in dirs)
                    LoadFile(dir);

                DataTableToSettings();
                LoadDataToDataTable();
                MessageBox.Show("File Loaded!");
            }
        }
        private void LoadFile(string dir)
        {
            using (StreamReader sr = new StreamReader(dir))
            {
                sr.ReadLine();
                string[] vals = null;

                string str = sr.ReadLine();
                while (str != null)
                {
                    vals = str.Split(new string[] { "\t" }, StringSplitOptions.None);

                    string[] names = vals[6].Split(new string[] { ";" }, StringSplitOptions.None);

                    foreach (string name in names)
                        if (data.ContainsKey(name))
                        {
                            string polymorph = vals[0] + "_" + vals[1] + "_" + vals[2] + "_" + vals[3] + "_" + vals[4];

                            if (data[name].ContainsKey(polymorph))
                                data[name][polymorph]++;
                            else
                                data[name].Add(polymorph, 1);

                            break;
                        }

                    str = sr.ReadLine();
                }

                vals = null;
            }
            
        }
        private void DataTableToSettings()
        {
           foreach(var gene in data)
           {
                string[] poly = gene.Value.Keys.ToArray();
                int[] vals = gene.Value.Values.ToArray();

                int ind = Properties.Settings.Default.Genes.IndexOf(gene.Key);
                Properties.Settings.Default.Polymorphisms[ind] = string.Join(",", poly);
                Properties.Settings.Default.Values[ind] = string.Join(",", vals);
            }
            Properties.Settings.Default.Save();
        }

        private void button_Add_Click(object sender, EventArgs e)
        {
            AddGeneForm geneForm = new AddGeneForm();
            geneForm.StartPosition = FormStartPosition.CenterScreen;

            geneForm.button1.Click += new EventHandler(delegate (object o, EventArgs a)
            {
                string str = geneForm.textBox1.Text;

                geneForm.Close();

                if (str != "" && !Properties.Settings.Default.Genes.Contains(str))
                {
                    Properties.Settings.Default.Genes.Add(str);
                    Properties.Settings.Default.Polymorphisms.Add("");
                    Properties.Settings.Default.Values.Add("");
                    Properties.Settings.Default.Save();
                    LoadGenes();
                    LoadDataBase();
                }
            });

            geneForm.ShowDialog();
        }
        private void LoadGenes()
        {
            listBox_Genes.Items.Clear();
            listBox_Genes.SuspendLayout();

            foreach (string str in Properties.Settings.Default.Genes)
                if(str!="@")
                    listBox_Genes.Items.Add(str);
            
            listBox_Genes.ResumeLayout();
            listBox_Genes.PerformLayout();
        }

        private void button_Delete_Click(object sender, EventArgs e)
        {
            if (listBox_Genes.SelectedItems.Count == 0) return;

            foreach (string str in listBox_Genes.SelectedItems)
            {
                int ind = Properties.Settings.Default.Genes.IndexOf(str);
                Properties.Settings.Default.Genes.RemoveAt(ind);
                Properties.Settings.Default.Polymorphisms.RemoveAt(ind);
                Properties.Settings.Default.Values.RemoveAt(ind);
            }

            Properties.Settings.Default.Save();
            LoadGenes();
            LoadDataBase();
        }
        private void LoadDataBase()
        {
            data.Clear();
            string[] Polymorphisms;
            string[] Values;

            for (int i = 1; i< Properties.Settings.Default.Genes.Count; i++)
            {
                Polymorphisms = Properties.Settings.Default.Polymorphisms[i].Split(new string[] { "," }, StringSplitOptions.None);
                Values = Properties.Settings.Default.Values[i].Split(new string[] { "," }, StringSplitOptions.None);

                SortedDictionary<string, int> polyData = new SortedDictionary<string, int>();

                for(int j = 0; j<Polymorphisms.Length; j++)
                    if(Polymorphisms[j]!="" && Values[j]!="")
                        polyData.Add(Polymorphisms[j], int.Parse(Values[j]));

                data.Add(Properties.Settings.Default.Genes[i], polyData);
            }


        }
        

        private void listBox_Genes_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadDataToDataTable();
        }
        private void LoadDataToDataTable()
        {
            if (listBox_Genes.Items.Count == 0) return;
            if (listBox_Genes.SelectedItem == null) listBox_Genes.SelectedItem = listBox_Genes.Items[0];

            string gene = (string)listBox_Genes.SelectedItem;

            SortedDictionary<string,int> dict = data[gene];

            groupBox2.Text = gene;

            DataTable dt = new DataTable();
            dt.Columns.Add("Polymorphism");
            dt.Columns.Add("Occurance");

            foreach(KeyValuePair<string,int> pair in dict)
            {
                var row = dt.NewRow();
                row["Polymorphism"] = pair.Key;
                row["Occurance"] = pair.Value;
                dt.Rows.Add(row);
            }

            dataGridView1.DataSource = dt;
        }

    }
}
