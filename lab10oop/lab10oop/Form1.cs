using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab10oop
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;

        }

        private List<Unit> units = new List<Unit>()
        {
            new Unit("Метр", "m", 1),
            new Unit("Сантиметр", "cm", 0.01),
            new Unit("Міліметр", "mm", 0.001),
            new Unit("Фут", "ft", 0.3048),
            new Unit("Дюйм", "in", 0.0254)
        };

        private void Form1_Load(object sender, EventArgs e)
        {
            convertfrom.DropDownStyle = ComboBoxStyle.DropDownList;
            convertto.DropDownStyle = ComboBoxStyle.DropDownList;

            convertfrom.DataSource = new List<Unit>(units);
            convertto.DataSource = new List<Unit>(units);

            convertfrom.SelectedIndex = 0;
            convertto.SelectedIndex = 1;

            result.ReadOnly = true;
            result.Text = "";
        }

        private void конверторToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void проАвтораToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Program.AboutForm.StartPosition = FormStartPosition.Manual;
            Program.AboutForm.Location = this.Location;
            Program.AboutForm.Size = this.Size;

            Program.AboutForm.Show();
            this.Hide();
        }

        private void buttonconvert_Click(object sender, EventArgs e)
        {
            if (!double.TryParse(enter.Text, out double inputValue))
            {
                MessageBox.Show("Введіть коректне число!", "Помилка");
                return;
            }

            Unit fromUnit = (Unit)convertfrom.SelectedItem;
            Unit toUnit = (Unit)convertto.SelectedItem;

            double valueInMeters = inputValue * fromUnit.ToMeters;
            double convertedValue = valueInMeters / toUnit.ToMeters;
            result.Text = convertedValue.ToString("0.###");
        }
    }
}
