using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LAB_PARALL_15_05_2024
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
           
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
        }

        public Color CircleColor
        {
            get
            {
                if (radioButton1.Checked) return Color.Black;
                if (radioButton2.Checked) return Color.Gray;
                if (radioButton3.Checked) return Color.Red;
                if (radioButton4.Checked) return Color.Green;
                if (radioButton5.Checked) return Color.Yellow;
                if (radioButton6.Checked) return Color.Blue;
                return Color.Cyan;

            }
            set
            {
                if (value == Color.Black) radioButton1.Checked = true;
                if (value == Color.Gray) radioButton2.Checked = true;
                if (value == Color.Red) radioButton3.Checked = true;
                if (value == Color.Yellow) radioButton4.Checked = true;
                if (value == Color.Green) radioButton5.Checked = true;
                if (value == Color.Blue) radioButton6.Checked = true;
            }
        }
    }
}
