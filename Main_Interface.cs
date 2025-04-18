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
        private Edit_Objects edit_objects;
        private Param_menu param_menu;

        public Main_Interface()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            edit_objects = new Edit_Objects();
            param_menu = new Param_menu();
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

        private void edit_Click(object sender, EventArgs e)
        {
            edit_objects.ShowDialog();
        }

        private void describe_Click(object sender, EventArgs e)
        {
            param_menu.ShowDialog();
        }
    }
}
