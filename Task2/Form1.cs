using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            btnOK.Click += BtnOK_Click;
            btnClose.Click += BtnClose_Click;

            this.AcceptButton = btnOK;
            this.CancelButton = btnClose;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void BtnOK_Click(object sender, EventArgs e)
        {
            txtOutput.Clear();

            if (string.IsNullOrWhiteSpace(txtName.Text))
            {
                MessageBox.Show("Будь ласка, введіть ім'я.", "Помилка введення", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtName.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(txtSurname.Text))
            {
                MessageBox.Show("Будь ласка, введіть прізвище.", "Помилка введення", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtSurname.Focus();
                return;
            }

            if (!int.TryParse(txtYear.Text, out int year) || year < 1900 || year > DateTime.Now.Year)
            {
                MessageBox.Show("Введіть коректний рік народження (наприклад, 2005).", "Помилка введення", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtYear.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(txtGroup.Text))
            {
                MessageBox.Show("Будь ласка, введіть групу.", "Помилка введення", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtGroup.Focus();
                return;
            }

            if (!int.TryParse(txtCourse.Text, out int course) || course < 1 || course > 4)
            {
                MessageBox.Show("Введіть коректний курс (від 1 до 4).", "Помилка введення", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtCourse.Focus();
                return;
            }

            txtOutput.Text = "====== АНКЕТА СТУДЕНТА ======\r\n";
            txtOutput.Text += $"Ім'я:            {txtName.Text.Trim()}\r\n";
            txtOutput.Text += $"Прізвище:        {txtSurname.Text.Trim()}\r\n";
            txtOutput.Text += $"Рік народження:  {year}\r\n";
            txtOutput.Text += $"Вік:             {DateTime.Now.Year - year} років\r\n";
            txtOutput.Text += $"Група:           {txtGroup.Text.Trim()}\r\n";
            txtOutput.Text += $"Курс:            {course}\r\n";
            txtOutput.Text += "=============================\r\n";
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            this.Close(); 
        }
    }
}
