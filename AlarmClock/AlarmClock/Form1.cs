using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AlarmClock
{
    public partial class Form1 : Form
    {
        string folderTime = "";
        public Form1()
        {
            InitializeComponent();
            CurrentTime.Text = DateTime.Now.ToLongTimeString();
            label1.Text = CurrentTime.Text;
            SelectTime.Text = CurrentTime.Text;

        }

        private void Exit_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        } // закрытие программы

        private void AddTime_Click(object sender, EventArgs e)
        {
            switch (0)
            {
                default:
                    label1.Text = SelectTime.Text;
                    AllTime.Items.Add(label1.Text);
                    

                    break;
            }
        } // при нажатии на клавишу отправлять данные в переменную label
        private void TurnOff_Click(object sender, EventArgs e)
        {
            AllTime.Items.Add(folderTime);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            CurrentTime.Text = DateTime.Now.ToLongTimeString(); // В label помещаем время которое на данный момент (берется из времени системы)

        }
        void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            folderTime = AllTime.SelectedItem.ToString();
            AllTime.Items.Add(folderTime);
            //MessageBox.Show(selectedCountry);
        }

    }
}
