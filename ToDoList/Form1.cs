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

namespace ToDoList
{
    public partial class Form1 : Form
    {
        List<string> ToDo = new List<string>();
        string path = Path.GetDirectoryName(System.AppDomain.CurrentDomain.BaseDirectory) + "/Resources/ToDoText.txt";

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.AddTaskBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(CheckEnterKeyPress);
            using (StreamReader sr = File.OpenText(path))
            {
                String s = "";

                while ((s = sr.ReadLine()) != null)
                {
                    ToDo.Add(s);
                }
            }
            ReloadChecklist();
        }

        private void ReloadChecklist()
        {
            TaskList.Items.Clear();
            foreach (string s in ToDo)
            {
                TaskList.Items.Add(s);
            }
        }

        private void CheckEnterKeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Return)

            {
                if (AddTaskBox.Text != "")
                {
                    ToDo.Add(AddTaskBox.Text);
                    ReloadChecklist();
                }
            }
        }

        private void AddTaskButton_Click(object sender, EventArgs e)
        {
            if (AddTaskBox.Text != "") {
                ToDo.Add(AddTaskBox.Text);
                ReloadChecklist();
            }
        }

        private void ItemChecked(object sender, ItemCheckEventArgs e)
        {

        }

        private void RemoveItem(object sender, EventArgs e)
        {
            if (ToDo.Count != 0) {
                ToDo.RemoveAt(TaskList.SelectedIndex);
                ReloadChecklist();
            }
        }

        private void OnClosing(object sender, FormClosingEventArgs e)
        {
            using (StreamWriter sw = File.CreateText(path))
            {
                foreach (string s in ToDo)
                {
                    sw.WriteLine(s);
                }
            }
        }

    }
}
