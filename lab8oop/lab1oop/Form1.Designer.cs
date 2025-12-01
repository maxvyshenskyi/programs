namespace lab1oop
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
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.nametext = new System.Windows.Forms.TextBox();
            this.updatebutton = new System.Windows.Forms.Button();
            this.typetext = new System.Windows.Forms.TextBox();
            this.powertext = new System.Windows.Forms.TextBox();
            this.masstext = new System.Windows.Forms.TextBox();
            this.phasestext = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.voltagetext = new System.Windows.Forms.TextBox();
            this.efficiencytext = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.buttoninc = new System.Windows.Forms.Button();
            this.buttonscale = new System.Windows.Forms.Button();
            this.buttonsortup = new System.Windows.Forms.Button();
            this.buttonsortdown = new System.Windows.Forms.Button();
            this.buttonfile = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(29, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Назва:";
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.ItemHeight = 20;
            this.comboBox1.Location = new System.Drawing.Point(33, 12);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(349, 28);
            this.comboBox1.TabIndex = 1;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(29, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 24);
            this.label2.TabIndex = 2;
            this.label2.Text = "Тип:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(29, 117);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(118, 24);
            this.label3.TabIndex = 3;
            this.label3.Text = "Потужність:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(29, 183);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(103, 24);
            this.label4.TabIndex = 4;
            this.label4.Text = "К-сть фаз:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(29, 151);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 24);
            this.label5.TabIndex = 5;
            this.label5.Text = "Вага:";
            // 
            // nametext
            // 
            this.nametext.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.nametext.Location = new System.Drawing.Point(170, 53);
            this.nametext.Name = "nametext";
            this.nametext.Size = new System.Drawing.Size(212, 26);
            this.nametext.TabIndex = 7;
            // 
            // updatebutton
            // 
            this.updatebutton.Location = new System.Drawing.Point(170, 277);
            this.updatebutton.Name = "updatebutton";
            this.updatebutton.Size = new System.Drawing.Size(212, 30);
            this.updatebutton.TabIndex = 8;
            this.updatebutton.Text = "Оновити";
            this.updatebutton.UseVisualStyleBackColor = true;
            this.updatebutton.Click += new System.EventHandler(this.updatebutton_Click);
            // 
            // typetext
            // 
            this.typetext.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.typetext.Location = new System.Drawing.Point(170, 85);
            this.typetext.Name = "typetext";
            this.typetext.Size = new System.Drawing.Size(212, 26);
            this.typetext.TabIndex = 10;
            // 
            // powertext
            // 
            this.powertext.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.powertext.Location = new System.Drawing.Point(170, 119);
            this.powertext.Name = "powertext";
            this.powertext.Size = new System.Drawing.Size(212, 26);
            this.powertext.TabIndex = 12;
            // 
            // masstext
            // 
            this.masstext.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.masstext.Location = new System.Drawing.Point(170, 149);
            this.masstext.Name = "masstext";
            this.masstext.Size = new System.Drawing.Size(212, 26);
            this.masstext.TabIndex = 13;
            // 
            // phasestext
            // 
            this.phasestext.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.phasestext.Location = new System.Drawing.Point(170, 183);
            this.phasestext.Name = "phasestext";
            this.phasestext.Size = new System.Drawing.Size(212, 26);
            this.phasestext.TabIndex = 14;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(388, 151);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(28, 24);
            this.label7.TabIndex = 15;
            this.label7.Text = "кг";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.Location = new System.Drawing.Point(388, 117);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(41, 24);
            this.label8.TabIndex = 16;
            this.label8.Text = "кВт";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(29, 219);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(88, 24);
            this.label6.TabIndex = 17;
            this.label6.Text = "Напруга:";
            // 
            // voltagetext
            // 
            this.voltagetext.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.voltagetext.Location = new System.Drawing.Point(170, 217);
            this.voltagetext.Name = "voltagetext";
            this.voltagetext.Size = new System.Drawing.Size(212, 26);
            this.voltagetext.TabIndex = 18;
            // 
            // efficiencytext
            // 
            this.efficiencytext.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.efficiencytext.Location = new System.Drawing.Point(170, 249);
            this.efficiencytext.Name = "efficiencytext";
            this.efficiencytext.Size = new System.Drawing.Size(212, 26);
            this.efficiencytext.TabIndex = 19;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.Location = new System.Drawing.Point(29, 249);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(53, 24);
            this.label9.TabIndex = 20;
            this.label9.Text = "ККД:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label10.Location = new System.Drawing.Point(388, 219);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(22, 24);
            this.label10.TabIndex = 21;
            this.label10.Text = "В";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label11.Location = new System.Drawing.Point(388, 251);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(25, 24);
            this.label11.TabIndex = 22;
            this.label11.Text = "%";
            // 
            // buttoninc
            // 
            this.buttoninc.Location = new System.Drawing.Point(422, 150);
            this.buttoninc.Name = "buttoninc";
            this.buttoninc.Size = new System.Drawing.Size(55, 30);
            this.buttoninc.TabIndex = 23;
            this.buttoninc.Text = "+5 кг";
            this.buttoninc.UseVisualStyleBackColor = true;
            this.buttoninc.Click += new System.EventHandler(this.buttoninc_Click);
            // 
            // buttonscale
            // 
            this.buttonscale.Location = new System.Drawing.Point(422, 248);
            this.buttonscale.Name = "buttonscale";
            this.buttonscale.Size = new System.Drawing.Size(55, 30);
            this.buttonscale.TabIndex = 24;
            this.buttonscale.Text = "x2";
            this.buttonscale.UseVisualStyleBackColor = true;
            this.buttonscale.Click += new System.EventHandler(this.buttonscale_Click);
            // 
            // buttonsortup
            // 
            this.buttonsortup.Location = new System.Drawing.Point(408, 11);
            this.buttonsortup.Name = "buttonsortup";
            this.buttonsortup.Size = new System.Drawing.Size(186, 30);
            this.buttonsortup.TabIndex = 25;
            this.buttonsortup.Text = "Список за потужністю(зростання)";
            this.buttonsortup.UseVisualStyleBackColor = true;
            this.buttonsortup.Click += new System.EventHandler(this.buttonsortup_Click);
            // 
            // buttonsortdown
            // 
            this.buttonsortdown.Location = new System.Drawing.Point(408, 47);
            this.buttonsortdown.Name = "buttonsortdown";
            this.buttonsortdown.Size = new System.Drawing.Size(186, 30);
            this.buttonsortdown.TabIndex = 26;
            this.buttonsortdown.Text = "Список за потужністю(спадання)";
            this.buttonsortdown.UseVisualStyleBackColor = true;
            this.buttonsortdown.Click += new System.EventHandler(this.buttonsortdown_Click);
            // 
            // buttonfile
            // 
            this.buttonfile.Location = new System.Drawing.Point(170, 313);
            this.buttonfile.Name = "buttonfile";
            this.buttonfile.Size = new System.Drawing.Size(212, 30);
            this.buttonfile.TabIndex = 27;
            this.buttonfile.Text = "Зберегти у файли";
            this.buttonfile.UseVisualStyleBackColor = true;
            this.buttonfile.Click += new System.EventHandler(this.buttonfile_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImage = global::lab1oop.Properties.Resources.background;
            this.ClientSize = new System.Drawing.Size(605, 346);
            this.Controls.Add(this.buttonfile);
            this.Controls.Add(this.buttonsortdown);
            this.Controls.Add(this.buttonsortup);
            this.Controls.Add(this.buttonscale);
            this.Controls.Add(this.buttoninc);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.efficiencytext);
            this.Controls.Add(this.voltagetext);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.phasestext);
            this.Controls.Add(this.masstext);
            this.Controls.Add(this.powertext);
            this.Controls.Add(this.typetext);
            this.Controls.Add(this.updatebutton);
            this.Controls.Add(this.nametext);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Електродвигуни";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox nametext;
        private System.Windows.Forms.Button updatebutton;
        private System.Windows.Forms.TextBox typetext;
        private System.Windows.Forms.TextBox powertext;
        private System.Windows.Forms.TextBox masstext;
        private System.Windows.Forms.TextBox phasestext;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox voltagetext;
        private System.Windows.Forms.TextBox efficiencytext;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button buttoninc;
        private System.Windows.Forms.Button buttonscale;
        private System.Windows.Forms.Button buttonsortup;
        private System.Windows.Forms.Button buttonsortdown;
        private System.Windows.Forms.Button buttonfile;
    }
}

