
namespace AlarmClock
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
            this.components = new System.ComponentModel.Container();
            this.TurnOff = new System.Windows.Forms.Button();
            this.Exit = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.CurrentTime = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.AddTime = new System.Windows.Forms.Button();
            this.SelectTime = new System.Windows.Forms.TextBox();
            this.EnterTime = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.AllTime = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // TurnOff
            // 
            this.TurnOff.Location = new System.Drawing.Point(5, 197);
            this.TurnOff.Name = "TurnOff";
            this.TurnOff.Size = new System.Drawing.Size(109, 35);
            this.TurnOff.TabIndex = 0;
            this.TurnOff.Text = "TurnOff";
            this.TurnOff.UseVisualStyleBackColor = true;
            this.TurnOff.Click += new System.EventHandler(this.TurnOff_Click);
            // 
            // Exit
            // 
            this.Exit.Location = new System.Drawing.Point(235, 197);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(109, 35);
            this.Exit.TabIndex = 0;
            this.Exit.Text = "Exit";
            this.Exit.UseVisualStyleBackColor = true;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // CurrentTime
            // 
            this.CurrentTime.AutoEllipsis = true;
            this.CurrentTime.AutoSize = true;
            this.CurrentTime.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.CurrentTime.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CurrentTime.Location = new System.Drawing.Point(8, 9);
            this.CurrentTime.Name = "CurrentTime";
            this.CurrentTime.Size = new System.Drawing.Size(191, 50);
            this.CurrentTime.TabIndex = 1;
            this.CurrentTime.Text = "CurrentTime";
            this.CurrentTime.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.CurrentTime.UseCompatibleTextRendering = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(147, 146);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 21);
            this.label1.TabIndex = 3;
            this.label1.Text = "label1";
            // 
            // AddTime
            // 
            this.AddTime.Location = new System.Drawing.Point(120, 197);
            this.AddTime.Name = "AddTime";
            this.AddTime.Size = new System.Drawing.Size(109, 35);
            this.AddTime.TabIndex = 4;
            this.AddTime.Text = "AddTime";
            this.AddTime.UseVisualStyleBackColor = true;
            this.AddTime.Click += new System.EventHandler(this.AddTime_Click);
            // 
            // SelectTime
            // 
            this.SelectTime.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.SelectTime.Location = new System.Drawing.Point(5, 62);
            this.SelectTime.Name = "SelectTime";
            this.SelectTime.Size = new System.Drawing.Size(110, 23);
            this.SelectTime.TabIndex = 5;
            // 
            // EnterTime
            // 
            this.EnterTime.AutoSize = true;
            this.EnterTime.Location = new System.Drawing.Point(5, 88);
            this.EnterTime.Name = "EnterTime";
            this.EnterTime.Size = new System.Drawing.Size(110, 15);
            this.EnterTime.TabIndex = 6;
            this.EnterTime.Text = "Время будильника";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(122, 167);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 15);
            this.label2.TabIndex = 7;
            this.label2.Text = "Выбранное время";
            // 
            // AllTime
            // 
            this.AllTime.AllowDrop = true;
            this.AllTime.FormattingEnabled = true;
            this.AllTime.HorizontalScrollbar = true;
            this.AllTime.ItemHeight = 15;
            this.AllTime.Location = new System.Drawing.Point(224, 12);
            this.AllTime.Name = "AllTime";
            this.AllTime.Size = new System.Drawing.Size(120, 94);
            this.AllTime.Sorted = true;
            this.AllTime.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(351, 259);
            this.Controls.Add(this.AllTime);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.EnterTime);
            this.Controls.Add(this.SelectTime);
            this.Controls.Add(this.AddTime);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CurrentTime);
            this.Controls.Add(this.Exit);
            this.Controls.Add(this.TurnOff);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button TurnOff;
        private System.Windows.Forms.Button Exit;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label CurrentTime;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button AddTime;
        private System.Windows.Forms.TextBox SelectTime;
        private System.Windows.Forms.Label EnterTime;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox AllTime;
    }
}

