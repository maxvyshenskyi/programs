using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab1oop
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            comboBox1.Items.AddRange(Main.Motors.Select(m => m.Name).ToArray());
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            var selectedMotor = Main.Motors.FirstOrDefault(m => m.Name == comboBox1.SelectedItem.ToString());

            if (selectedMotor != null)
            {
                label1.Text = selectedMotor.GetName();
                label2.Text = selectedMotor.GetType();
                label3.Text = selectedMotor.GetPower();
                label4.Text = selectedMotor.GetPhases();
                label5.Text = selectedMotor.GetMass();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            var selectedMotor = Main.Motors.FirstOrDefault(m => m.Name == comboBox1.SelectedItem.ToString());

            if (selectedMotor != null)
            { 
                selectedMotor.SetType(textBox1.Text);
     
                MessageBox.Show("Успішно змінено! Нові значення:\n" + " \n" + selectedMotor.ToString());
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var selectedMotor = Main.Motors.FirstOrDefault(m => m.Name == comboBox1.SelectedItem.ToString());

            if (selectedMotor != null)
            {
                int getpower = int.Parse(textBox2.Text);
                selectedMotor.SetPower(getpower);

                MessageBox.Show("Успішно змінено! Нові значення:\n" + " \n" + selectedMotor.ToString());
            }
        }
    }
}
