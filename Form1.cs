using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bài_tập_mới
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnthem_Click(object sender, EventArgs e)
        {
            lsbkq.Items.Add(btnthem.Text);
            txtname.Text=string.Empty;

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lsbkq.Items.Add("trần kim anh ");
            lsbkq.Items.Add("lê phước hòa ");
            lsbkq.Items.Add("trần kim giàu ");
            lsbkq.Items.Add("trần kim anh thy ");








        }

        private void btnxoa_Click(object sender, EventArgs e)
        {
            lsbkq.Items.RemoveAt(lsbkq.SelectedIndex);
        }

        private void btnsua_Click(object sender, EventArgs e)
        {
            if (lsbkq.SelectedIndex < 0) return;
            lsbkq.Items[lsbkq.SelectedIndex]=txtname.Text;
        }

        private void lsbkq_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtname.Text = lsbkq.SelectedItem.ToString();
        }
    }
}
