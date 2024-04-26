using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace sssh
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            cbb2_data_bound();
        }

        private void btn_execute_Click(object sender, EventArgs e)
        {
            string str_option = "";
            str_option = cbb_option.Text.Split('.')[0];
            if (str_option == "1") option1();
            if (str_option == "2") option2();
        }

        private void option1()
        {
            List<string> cmdList = new List<string>()
            {
                "git init",
                "git add *",
                "git commit -m \"first commit\""
            };
            foreach (string cmd in cmdList)
            {
                Execute(cmd);
            }
        }

        private void option2()
        {
            string commandText = "";
            Process.Start("cmd.exe", commandText);
        }

        private void Execute(string commandText)
        {
            Process.Start("cmd.exe", commandText);
        }

        private void cbb1_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbb2_data_bound();
        }

        private void cbb2_data_bound()
        {
            string str_option = cbb1.Text.Split('.')[0];
            if (str_option == "1") set_cbb2_data(new List<string>() { "A1", "A2", "A3" });
            if (str_option == "2") set_cbb2_data(new List<string>() { "B1", "B2", "B3" });
            if (str_option == "3") set_cbb2_data(new List<string>() { "C1", "C2", "C3" });
        }

        private void set_cbb2_data(List<string> dataList)
        {
            cbb2.Items.Clear();
            foreach (string data in dataList)
            {
                cbb2.Items.Add(data);
            }
            cbb2.Text = cbb2.Items[0].ToString();
        }
    }
}
