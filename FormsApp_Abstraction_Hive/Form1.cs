using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormsApp_Abstraction_Hive
{
    public partial class Form1 : Form
    {
        private Queen queen;
        public Form1()
        {
            InitializeComponent();
            comboBox_workerBeeJob.SelectedIndex = 0;

            Worker[] workers = new Worker[4];

            workers[0] = new Worker(new string[] { "Nectar collector", "Honey manufacturing" }, 175);
            workers[1] = new Worker(new string[] { "Egg care", "Baby tutoring" }, 114);
            workers[2] = new Worker(new string[] { "Hive maintenance", "Sting patrol" }, 149);
            workers[3] = new Worker(new string[] { "Nectar collector", "Honey manufacturing", "Egg care", "Baby tutoring",
            "Hive maintenance", "Sting patrol"}, 155);

            queen = new Queen(workers, 275);
        }

        private void button_AssignJob_Click(object sender, EventArgs e)
        {
            if (queen.AssignWork(comboBox_workerBeeJob.Text, (int)shifts.Value) == false)
                MessageBox.Show("Для завдання '" + comboBox_workerBeeJob.Text + "' робочих немає", "Матка говорить...");
            else
                MessageBox.Show("Завдання '" + comboBox_workerBeeJob.Text + "' буде виконано через " +
                                shifts.Value + " змін", "Матка говорить...");
        }

        private void button_NextShift_Click(object sender, EventArgs e)
        {
            textBox_Report.Text = queen.WorkTheNextShift();
        }
    }
}
