using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace ConstantlyChangingSystem
{
    public partial class Param_menu : Form
    {
        public Param_menu()
        {
            InitializeComponent();
        }

        private void Param_menu_Load(object sender, EventArgs e)
        {
            g_param_list.Items.Clear();
            foreach (string i in Object_Base.Values_Type)
            {
                g_param_list.Items.Add(i);
            }
        }

        private void add_g_param_Click(object sender, EventArgs e)
        {
            if (param_names.Text != "")
            {
                File.AppendAllText("parameters.txt", param_names.Text+'\n');
                g_param_list.Items.Add(param_names.Text);
                Object_Base.Values_Type.Add(param_names.Text);
            }
        }

        private void del_g_param_Click(object sender, EventArgs e)
        {
            if (g_param_list.SelectedItems.Count > 0)
            {
                string res = "";

                Object_Base.Values_Type.RemoveAt(g_param_list.SelectedIndex);
                g_param_list.Items.RemoveAt(g_param_list.SelectedIndex);

                foreach (string type in Object_Base.Values_Type)
                {
                    res += type + '\n'; 
                }
                File.WriteAllText("parameters.txt", res);
            }
        }
    }
}
