using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Healt_Declaration_Form
{
    public partial class RecordForm : Form
    {
        public RecordForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            OpenFileDialog Read = new OpenFileDialog();

            if (Read.ShowDialog() == DialogResult.OK)
            {
                RecordBox.Text = File.ReadAllText(Read.FileName);
            }
        }
    }
}
