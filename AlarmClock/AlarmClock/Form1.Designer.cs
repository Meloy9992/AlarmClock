
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
            this.SelectedTime = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // TurnOff
            // 
            this.TurnOff.Location = new System.Drawing.Point(12, 200);
            this.TurnOff.Name = "TurnOff";
            this.TurnOff.Size = new System.Drawing.Size(109, 35);
            this.TurnOff.TabIndex = 0;
            this.TurnOff.Text = "TurnOff";
            this.TurnOff.UseVisualStyleBackColor = true;
            this.TurnOff.Click += new System.EventHandler(this.TurnOff_Click);
            // 
            // Exit
            // 
            this.Exit.Location = new System.Drawing.Point(224, 200);
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
            this.CurrentTime.Location = new System.Drawing.Point(109, 40);
            this.CurrentTime.Name = "CurrentTime";
            this.CurrentTime.Size = new System.Drawing.Size(181, 50);
            this.CurrentTime.TabIndex = 1;
            this.CurrentTime.Text = "CurrentText";
            this.CurrentTime.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.CurrentTime.UseCompatibleTextRendering = true;
            // 
            // SelectedTime
            // 
            this.SelectedTime.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SelectedTime.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.SelectedTime.FormatString = "T";
            this.SelectedTime.FormattingEnabled = true;
            this.SelectedTime.Location = new System.Drawing.Point(76, 90);
            this.SelectedTime.Name = "SelectedTime";
            this.SelectedTime.Size = new System.Drawing.Size(196, 28);
            this.SelectedTime.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(159, 144);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "label1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(347, 259);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.SelectedTime);
            this.Controls.Add(this.CurrentTime);
            this.Controls.Add(this.Exit);
            this.Controls.Add(this.TurnOff);
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
        private System.Windows.Forms.ComboBox SelectedTime;
        private System.Windows.Forms.Label label1;
    }
}

