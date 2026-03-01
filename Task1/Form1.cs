using System;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Task1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cmbTerm.Items.Add("1");
            cmbTerm.Items.Add("3");
            cmbTerm.Items.Add("6");
            cmbTerm.Items.Add("12");
            cmbTerm.SelectedIndex = 0;
        }

        private void label1_Click(object sender, EventArgs e)
        {
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            try
            {
                double depositAmount = Convert.ToDouble(textBox1.Text);

                int months = Convert.ToInt32(cmbTerm.SelectedItem);

                double annualInterestRate = 0;

                switch (months)
                {
                    case 1:
                        annualInterestRate = 5.0;
                        break;
                    case 3:
                        annualInterestRate = 7.5;
                        break;
                    case 6:
                        annualInterestRate = 9.0;
                        break;
                    case 12:
                        annualInterestRate = 12.0;
                        break;
                    default:
                        MessageBox.Show("Некоректний термін вкладу. Оберіть 1, 3, 6 або 12 місяців.", "Помилка");
                        return;
                }

                double profit = depositAmount * (annualInterestRate / 100.0) * (months / 12.0);
                double totalAmount = depositAmount + profit;

                MessageBox.Show(
                    $"Сума вкладу: {depositAmount:C2}\n" +
                    $"Термін: {months} міс.\n" +
                    $"Ставка: {annualInterestRate}%\n" +
                    $"Чистий прибуток: {profit:C2}\n" +
                    $"Загальна сума до виплати: {totalAmount:C2}",
                    "Розрахунок", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (FormatException)
            {
                MessageBox.Show("Будь ласка, введіть коректну числову суму вкладу.", "Помилка введення", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}