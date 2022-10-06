
namespace First_Form
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.Add_system_button = new System.Windows.Forms.Button();
            this.welcome_message = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Discord_nick = new System.Windows.Forms.TextBox();
            this.Troll_id = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Troll_nick = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.What_did_troll = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(624, 50);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 23);
            this.dateTimePicker1.TabIndex = 0;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // Add_system_button
            // 
            this.Add_system_button.Location = new System.Drawing.Point(163, 269);
            this.Add_system_button.Name = "Add_system_button";
            this.Add_system_button.Size = new System.Drawing.Size(124, 23);
            this.Add_system_button.TabIndex = 1;
            this.Add_system_button.Text = "add to the system";
            this.Add_system_button.UseVisualStyleBackColor = true;
            this.Add_system_button.Click += new System.EventHandler(this.Add_system_button_Click);
            // 
            // welcome_message
            // 
            this.welcome_message.Dock = System.Windows.Forms.DockStyle.Top;
            this.welcome_message.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.welcome_message.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.welcome_message.Location = new System.Drawing.Point(0, 0);
            this.welcome_message.Name = "welcome_message";
            this.welcome_message.Size = new System.Drawing.Size(857, 47);
            this.welcome_message.TabIndex = 2;
            this.welcome_message.Text = "welcome to my discord troll finder application\r\n";
            this.welcome_message.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.welcome_message.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(128, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "Type your discord nick:";
            // 
            // Discord_nick
            // 
            this.Discord_nick.Location = new System.Drawing.Point(163, 73);
            this.Discord_nick.Name = "Discord_nick";
            this.Discord_nick.Size = new System.Drawing.Size(100, 23);
            this.Discord_nick.TabIndex = 4;
            // 
            // Troll_id
            // 
            this.Troll_id.Location = new System.Drawing.Point(163, 118);
            this.Troll_id.Name = "Troll_id";
            this.Troll_id.Size = new System.Drawing.Size(100, 23);
            this.Troll_id.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 118);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 15);
            this.label1.TabIndex = 5;
            this.label1.Text = "Type the troll\'s id:";
            // 
            // Troll_nick
            // 
            this.Troll_nick.Location = new System.Drawing.Point(163, 166);
            this.Troll_nick.Name = "Troll_nick";
            this.Troll_nick.Size = new System.Drawing.Size(100, 23);
            this.Troll_nick.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 166);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(133, 15);
            this.label3.TabIndex = 7;
            this.label3.Text = "Type troll\'s discord nick:";
            // 
            // What_did_troll
            // 
            this.What_did_troll.Location = new System.Drawing.Point(163, 216);
            this.What_did_troll.Multiline = true;
            this.What_did_troll.Name = "What_did_troll";
            this.What_did_troll.Size = new System.Drawing.Size(413, 33);
            this.What_did_troll.TabIndex = 10;
            this.What_did_troll.TextChanged += new System.EventHandler(this.What_did_troll_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 216);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(141, 15);
            this.label4.TabIndex = 9;
            this.label4.Text = "Write there what did troll:";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 15;
            this.listBox1.Location = new System.Drawing.Point(403, 342);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(120, 94);
            this.listBox1.TabIndex = 12;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(857, 499);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.What_did_troll);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Troll_nick);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Troll_id);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Discord_nick);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.welcome_message);
            this.Controls.Add(this.Add_system_button);
            this.Controls.Add(this.dateTimePicker1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button Add_system_button;
        private System.Windows.Forms.Label welcome_message;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Discord_nick;
        private System.Windows.Forms.TextBox Troll_id;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Troll_nick;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox What_did_troll;
        private System.Windows.Forms.Label label4;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.ListBox listBox1;
    }
}

