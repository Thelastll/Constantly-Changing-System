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

namespace ConstantlyChangingSystem
{
    public partial class Main_Interface : Form
    {
        private Edit_Objects edit_objects;
        private Param_menu param_menu;
        private int num_of_iter;

        private A a0;
        private A a1;

        public Main_Interface()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            edit_objects = new Edit_Objects();
            param_menu = new Param_menu();
            Object_Base.Values_Type = new List<string>(File.ReadAllLines("parameters.txt"));
        }

        private void run_Click(object sender, EventArgs e)
        {


            if (stop.Enabled) 
            {
                Console.WriteLine("--------------------");
                Run_System.Run(int.Parse(iter_input.Text) < 0 ? (int.Parse(stop_input.Text) != 0 ? int.Parse(stop_input.Text) : 1) : (int.Parse(stop_input.Text) != 0 ? (num_of_iter - int.Parse(stop_input.Text) <= 0 ? num_of_iter : int.Parse(stop_input.Text)) : num_of_iter));
                num_of_iter -= int.Parse(stop_input.Text) != 0 ? int.Parse(stop_input.Text) : num_of_iter;
            }
            else
            {
                stop.Enabled = true;
                stop_input.Enabled = false;
                iter_input.Enabled = false;
                num_of_iter = int.Parse(iter_input.Text);
                run.Text = "Продолжить";

                a0 = new A(new decimal[2] { 1, 2 });
                a1 = new A(new decimal[2] { 3, 4 });

                Run_System.Set(new ObjectCCS[][] { new ObjectCCS[] { a0, a1 }, new ObjectCCS[] { a1, a0 } });
                Console.WriteLine("----------\nIteration " + 0 + "\n----------");
                Run_System.Run();
            }

            if (num_of_iter <= 0 && int.Parse(iter_input.Text) >= 0)
            {
                stop_Click(0, EventArgs.Empty);
            }
        }

        private void stop_Click(object sender, EventArgs e)
        {
            stop.Enabled = false;
            stop_input.Enabled = true;
            iter_input.Enabled = true;
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
