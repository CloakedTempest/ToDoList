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
            this.CompTaskBox = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.ClearCompButton = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
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
            this.TaskList.Location = new System.Drawing.Point(58, 96);
            this.TaskList.Name = "TaskList";
            this.TaskList.ScrollAlwaysVisible = true;
            this.TaskList.Size = new System.Drawing.Size(408, 290);
            this.TaskList.TabIndex = 6;
            this.TaskList.DoubleClick += new System.EventHandler(this.RemoveItem);
            // 
            // CompTaskBox
            // 
            this.CompTaskBox.FormattingEnabled = true;
            this.CompTaskBox.Location = new System.Drawing.Point(542, 96);
            this.CompTaskBox.Name = "CompTaskBox";
            this.CompTaskBox.Size = new System.Drawing.Size(182, 290);
            this.CompTaskBox.TabIndex = 7;
            this.CompTaskBox.MouseClick += new System.Windows.Forms.MouseEventHandler(this.ClickInComp);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label2.Location = new System.Drawing.Point(206, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 17);
            this.label2.TabIndex = 8;
            this.label2.Text = "Tasks To Do";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label3.Location = new System.Drawing.Point(588, 76);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 17);
            this.label3.TabIndex = 9;
            this.label3.Text = "Tasks Done";
            // 
            // ClearCompButton
            // 
            this.ClearCompButton.BackColor = System.Drawing.Color.MistyRose;
            this.ClearCompButton.Location = new System.Drawing.Point(542, 392);
            this.ClearCompButton.Name = "ClearCompButton";
            this.ClearCompButton.Size = new System.Drawing.Size(182, 23);
            this.ClearCompButton.TabIndex = 10;
            this.ClearCompButton.Text = "Clear Completed Tasks";
            this.ClearCompButton.UseVisualStyleBackColor = false;
            this.ClearCompButton.Click += new System.EventHandler(this.ClearCompButton_Click);
            this.ClearCompButton.MouseEnter += new System.EventHandler(this.ClearCompButton_Enter);
            this.ClearCompButton.MouseLeave += new System.EventHandler(this.ClearCompButton_Leave);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(45, 402);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(431, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Double click to remove an item. Click in the tasks done box to move the selcted i" +
    "tem there";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.ClearCompButton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.CompTaskBox);
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
        private System.Windows.Forms.ListBox CompTaskBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button ClearCompButton;
        private System.Windows.Forms.Label label4;
    }
}

