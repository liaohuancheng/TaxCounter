using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TaxCounter
{
    public partial class Form1 : Form
    {
        private const decimal EXEMPTION_VALUE = 5000m;
        private static Context context = new Context();
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtNetPayment.Clear();
            txtTaxableIncome.Clear();
            txtTax.Clear();
            if (String.IsNullOrEmpty(txtPayroll.Text))
            {
                MessageBox.Show("请输入工资");
            }
            else if (String.IsNullOrEmpty(txtFund.Text))
            {
                MessageBox.Show("请输入四金");
            }
            string strPayroll = this.txtPayroll.Text;
            string strFund = this.txtFund.Text;
            decimal payroll = decimal.Parse(strPayroll);
            decimal fund = decimal.Parse(strFund);
            decimal income = payroll - fund - EXEMPTION_VALUE;
            decimal tax = context.Calculate(income);
            decimal netPayment = payroll - fund - tax;

            txtNetPayment.Text = netPayment.ToString();
            txtTaxableIncome.Text = income.ToString();
            txtTax.Text = tax.ToString();
        }
            
    }
}
    
