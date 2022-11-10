using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calculation
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnRun_Click(object sender, EventArgs e)
        {
           String f = tbNumber.Text;
            Console.WriteLine(f.GetType());
            int r=Int32.Parse(f);

            tbNumber2.Text = "" + (r + 2);
        }

       
    }
    }

