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
        List<string> completedList = new List<string>();
        string path1 = System.IO.Directory.GetParent(System.IO.Directory.GetParent(Environment.CurrentDirectory).ToString()).ToString() + "/Resources/ToDoText.txt";
        string path2 = System.IO.Directory.GetParent(System.IO.Directory.GetParent(Environment.CurrentDirectory).ToString()).ToString() + "/Resources/CompleText.txt";

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.AddTaskBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(CheckEnterKeyPress);
            using (StreamReader sr = File.OpenText(path1))
            {
                String s = "";

                while ((s = sr.ReadLine()) != null)
                {
                    ToDo.Add(s);
                }
            }
            using (StreamReader sr = File.OpenText(path2))
            {
                String s = "";

                while ((s = sr.ReadLine()) != null)
                {
                    completedList.Add(s);
                }
            }
            ReloadChecklist();
            ReloadCompList();
        }

        private void ReloadChecklist()
        {
            TaskList.Items.Clear();
            foreach (string s in ToDo)
            {
                TaskList.Items.Add(s);
            }
        }
        private void ReloadCompList()
        {
            CompTaskBox.Items.Clear();
            foreach (string s in completedList)
            {
                CompTaskBox.Items.Add(s);
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
        private void RemoveItem(object sender, EventArgs e)
        {
            if (ToDo.Count != 0) {
                ToDo.RemoveAt(TaskList.SelectedIndex);
                ReloadChecklist();
            }
        }

        private void OnClosing(object sender, FormClosingEventArgs e)
        {
            using (StreamWriter sw = File.CreateText(path1))
            {
                foreach (string s in ToDo)
                {
                    sw.WriteLine(s);
                }
            }
            using (StreamWriter sw = File.CreateText(path2))
            {
                foreach (string s in completedList)
                {
                    sw.WriteLine(s);
                }
            }
        }

        private void ClickInComp(object sender, MouseEventArgs e)
        {
            if (TaskList.SelectedItem != null)
            {
                completedList.Add((string)TaskList.SelectedItem);
                ReloadCompList();
                ToDo.RemoveAt(TaskList.SelectedIndex);
                ReloadChecklist();
            }
        }

        private void ClearCompButton_Click(object sender, EventArgs e)
        {
            completedList.Clear();
            ReloadCompList();
        }

        private void ClearCompButton_Enter(object sender, EventArgs e)
        {
            ClearCompButton.BackColor = Color.OrangeRed;
        }

        private void ClearCompButton_Leave(object sender, EventArgs e)
        {
            ClearCompButton.BackColor = Color.MistyRose;
        }
    }
}
