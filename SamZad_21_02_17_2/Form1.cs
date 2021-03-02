using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.Reflection;

namespace SamZad_21_02_17_2
{
    public partial class Form1 : Form
    {

        Label lab1 = new Label
        {
            Location = new Point(20, 50),
            Size = new System.Drawing.Size(60, 60),
            AutoSize = true,
            Font = new Font("Arial", 14, FontStyle.Bold),
            Text = "Введите число: "
        };

        Label lab2 = new Label
        {
            Location = new Point(20, 120),
            Size = new System.Drawing.Size(60, 60),
            AutoSize = true,
            Font = new Font("Arial", 14, FontStyle.Bold),
            Text = ""
        };

        TextBox tex1 = new TextBox
        {
            Location = new Point(190, 50),
            Size = new System.Drawing.Size(60, 60),
            AutoSize = true,
            Font = new Font("Arial", 14, FontStyle.Bold),
        };

        Button br1 = new Button
        {
            Location = new Point(250, 250),
            Size = new System.Drawing.Size(60, 60),
            AutoSize = true,
            Font = new Font("Arial", 14, FontStyle.Bold),
            Text = "Обновить"
        };

        public Form1()
        {
            InitializeComponent();
        }

        private void ldt(object sender, EventArgs e)
        {
            Controls.Add(lab1);
            Controls.Add(lab2);
            Controls.Add(tex1);
            Controls.Add(br1);

            tex1.KeyPress += (s, a) =>
            {

                if (!char.IsDigit((char)(a.KeyChar)) && a.KeyChar != ((char)(Keys.Enter)) && (a.KeyChar != (char)(Keys.Delete) && (a.KeyChar != Char.Parse("-")
                && a.KeyChar != (char)(Keys.Back))))
                {
                    a.Handled = true;
                }
                else
                {
                    a.Handled = false;
                }
            };

            tex1.TextChanged += (s, a) =>
            {
                if (tex1.Text.Length == 0 || tex1.Text == "-")
                {
                    lab2.Text = "";
                }
                else
                {
                    lab2.Text = "Последовательность: " + ((Double.Parse(tex1.Text)) - 1) + " ; " + tex1.Text + " ; " + ((Double.Parse(tex1.Text)) + 1);
                }
            };

            br1.Click += (s, a) =>
            {
                this.Update();
            };

        }

    }
}
