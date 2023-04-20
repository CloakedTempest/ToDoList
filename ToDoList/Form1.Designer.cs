namespace ToDoList
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.AddTaskBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.AddTaskButton = new System.Windows.Forms.Button();
            this.TaskList = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // AddTaskBox
            // 
            this.AddTaskBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.AddTaskBox.Location = new System.Drawing.Point(285, 39);
            this.AddTaskBox.Name = "AddTaskBox";
            this.AddTaskBox.Size = new System.Drawing.Size(241, 21);
            this.AddTaskBox.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.label1.Location = new System.Drawing.Point(206, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 15);
            this.label1.TabIndex = 4;
            this.label1.Text = "Task to add:";
            // 
            // AddTaskButton
            // 
            this.AddTaskButton.Location = new System.Drawing.Point(542, 39);
            this.AddTaskButton.Name = "AddTaskButton";
            this.AddTaskButton.Size = new System.Drawing.Size(75, 23);
            this.AddTaskButton.TabIndex = 5;
            this.AddTaskButton.Text = "Add Task";
            this.AddTaskButton.UseVisualStyleBackColor = true;
            this.AddTaskButton.Click += new System.EventHandler(this.AddTaskButton_Click);
            // 
            // TaskList
            // 
            this.TaskList.FormattingEnabled = true;
            this.TaskList.Location = new System.Drawing.Point(209, 96);
            this.TaskList.Name = "TaskList";
            this.TaskList.ScrollAlwaysVisible = true;
            this.TaskList.Size = new System.Drawing.Size(408, 290);
            this.TaskList.TabIndex = 6;
            this.TaskList.DoubleClick += new System.EventHandler(this.RemoveItem);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.TaskList);
            this.Controls.Add(this.AddTaskButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.AddTaskBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.OnClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox AddTaskBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button AddTaskButton;
        private System.Windows.Forms.ListBox TaskList;
    }
}

