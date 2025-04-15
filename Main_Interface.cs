using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConstantlyChangingSystem
{
    public partial class Main_Interface : Form
    {
        public Main_Interface()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        
        }

        private void run_Click(object sender, EventArgs e)
        {
            stop.Enabled = true;
            run.Text = "Продолжить";

        }

        private void stop_Click(object sender, EventArgs e)
        {
            stop.Enabled = false;
            run.Text = "Запустить";
        }
    }
}
