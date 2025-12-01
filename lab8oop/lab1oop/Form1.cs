using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization.Formatters.Binary;
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
            comboBox1.Items.AddRange(Main.Motors.Select(m => m.GetMotorName()).ToArray());
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = comboBox1.SelectedIndex;

            if (index >= 0 && index < Main.Motors.Count)
            {
                var selectedMotor = Main.Motors[index];

                nametext.Text = selectedMotor.Name;
                typetext.Text = selectedMotor.MotorType;
                powertext.Text = selectedMotor.MotorPower.ToString();
                masstext.Text = selectedMotor.Mass.ToString();
                phasestext.Text = selectedMotor.Phases.ToString();
                voltagetext.Text = selectedMotor.Voltage.ToString();
                efficiencytext.Text = selectedMotor.Efficiency.ToString();

            }
        }


        private void Form1_Load(object sender, EventArgs e)
        {
        }
        private void UpdateComboBox()
        {
            comboBox1.Items.Clear();
            comboBox1.Items.AddRange(Main.Motors.Select(m => m.GetMotorName()).ToArray());
            if (comboBox1.Items.Count > 0)
                comboBox1.SelectedIndex = 0;
        }
        private void updatebutton_Click(object sender, EventArgs e)
        {
            int index = comboBox1.SelectedIndex;
            var selectedMotor = Main.Motors.FirstOrDefault(m => m.GetMotorName() == comboBox1.SelectedItem.ToString());

            if (selectedMotor != null)
            {
                string name = "Невідомий двигун";
                if (!string.IsNullOrWhiteSpace(nametext.Text))
                    name = (nametext.Text);
                string type = "Невідомо";
                if (!string.IsNullOrWhiteSpace(typetext.Text))
                    type = (typetext.Text);
                int power = 0;
                if (!string.IsNullOrWhiteSpace(powertext.Text))
                    power = int.Parse(powertext.Text);
                int phases = 0;
                if (!string.IsNullOrWhiteSpace(phasestext.Text))
                    phases = int.Parse(phasestext.Text);
                double mass = 0;
                if (!string.IsNullOrWhiteSpace(masstext.Text))
                    mass = double.Parse(masstext.Text);
                int voltage = 0;
                if (!string.IsNullOrWhiteSpace(voltagetext.Text))
                    voltage = int.Parse(voltagetext.Text);
                int efficiency = 0;
                if (!string.IsNullOrWhiteSpace(efficiencytext.Text))
                    efficiency = int.Parse(efficiencytext.Text);


                selectedMotor.ReplaceValues
                (
                    name,
                    type,
                    power,
                    phases,
                    mass,
                    voltage,
                    efficiency
                );

                comboBox1.Items[index] = name;

                MessageBox.Show("Успішно змінено! Нові значення:\n" + " \n" + selectedMotor.ToString());
            }
        }

        private void buttoninc_Click(object sender, EventArgs e)
        {
            int index = comboBox1.SelectedIndex;
            if (index >= 0)
            {
                var motor = Main.Motors[index];
                int increment = 5;

                motor.IncMass(increment);
                masstext.Text = motor.Mass.ToString();

                MessageBox.Show($"Масу двигуна збільшено на {increment} кг!\n" +
                                $"Нова маса: {motor.Mass.ToString()} кг");
            }
            else
            {
                MessageBox.Show("Оберіть двигун зі списку!");
            }
        }

        private void buttonscale_Click(object sender, EventArgs e)
        {
            int index = comboBox1.SelectedIndex;
            if (index >= 0)
            {
                var motor = Main.Motors[index];
                int factor = 2;

                motor.ScaleEfficiency(ref factor);
                efficiencytext.Text = motor.Efficiency.ToString();

                MessageBox.Show($"ККД двигуна масштабовано!\n" +
                                $"Новий ККД: {motor.Efficiency}%\n");
            }
            else
            {
                MessageBox.Show("Оберіть двигун зі списку!");
            }
        }

        private void buttonsortup_Click(object sender, EventArgs e)
        {
            Main.Motors.Sort();
            string message = "Двигуни відсортовані за потужністю (зростання):\n";

            foreach (var motor in Main.Motors)
            {
                message += $"{motor.Name} = {motor.Power} кВт\n";
            }

            MessageBox.Show(message, "Сортування за зростанням");
            UpdateComboBox();
        }

        private void buttonsortdown_Click(object sender, EventArgs e)
        {
            Main.Motors.Sort((a, b) => b.Power.CompareTo(a.Power));
            string message = "Двигуни відсортовані за потужністю (спадання):\n";

            for (int i = 0; i < Main.Motors.Count; i++)
            {
                message += $"{Main.Motors[i].Name} - {Main.Motors[i].Power} кВт\n";
            }

            MessageBox.Show(message, "Сортування за спаданням");
            UpdateComboBox();
        }

        private void buttonfile_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex < 0)
            {
                MessageBox.Show("Оберіть двигун зі списку!");
                return;
            }

            var motor = Main.Motors[comboBox1.SelectedIndex];

            string pathtxt = "motor_info.txt";
            string pathbin = "motor_binary.bin";

            File.WriteAllText(pathtxt, motor.ToString());
            using (FileStream fs = new FileStream(pathbin, FileMode.Create))
            {
                BinaryFormatter bf = new BinaryFormatter();
                bf.Serialize(fs, motor);
            }

            MessageBox.Show($"Текстовий та бінарний файли створено!\n{Path.GetFullPath(pathtxt)}\n{Path.GetFullPath(pathbin)}");
        }
    }
}
