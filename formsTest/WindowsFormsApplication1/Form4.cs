using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        void panel1_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
                e.Effect = DragDropEffects.Copy; // Ok
            else
                e.Effect = DragDropEffects.None; // Unknown data
        }

        void panel1_DragDrop(object sender, DragEventArgs e)
        {
            //listBox1.Items.Clear(); ненадо очищать ?

            string[] FileList = (string[])e.Data.GetData(DataFormats.FileDrop, false); // чето непойму че тут делается =)

            foreach (string str in FileList)
                listBox1.Items.Add(testList(str));

            fillClient(FileList);
        }

        void fillClient(string[] filePath)
        {
            string namePost = ("почта");

            int start = filePath[0].LastIndexOf(namePost) + namePost.Length + 1;
            int finish = filePath[0].IndexOf("\\", start) - start;
            comboBox1.Text = filePath[0].Substring(start, finish);
        }

        string testList(string tst)
        {
            return tst.Substring(tst.LastIndexOf("\\") + 1);
        }

        void listBox1_KeyPress(object sender, EventArgs e)
        {
            listBox1.Items.Remove(listBox1.SelectedItem);
        }

        private void listBox1_DoubleClick(object sender, EventArgs e)
        {
            listBox1.Items.Remove(listBox1.SelectedItem);
        }
    }
}
