using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ImageFilter
{
    public partial class Form1 : Form
    {
        List<IFilter> filters;
        Bitmap bitmap;
        public Form1()
        {
            InitializeComponent();
            filters = new List<IFilter>()
            {
                new BlackAndWhite(),
                new Negative(),
                new Mirror(),
                new GreenFilter()
            };
            for (int i = 0; i < filters.Count; i++)
                listBox1.Items.Add(filters[i].GetName());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(openFileDialog1.ShowDialog()==DialogResult.OK)
            {
                bitmap = new Bitmap(openFileDialog1.FileName);
                pictureBox1.Image = bitmap;
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int i = listBox1.SelectedIndex;
            if(i>=0)
            {
                bitmap = filters[i].Apply(bitmap);
                pictureBox1.Image = bitmap;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(bitmap!=null)
            {
                if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                    bitmap.Save(saveFileDialog1.FileName);
            }
        }
    }
}
