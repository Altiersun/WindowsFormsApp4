using System;
using System.Windows.Forms;
using WindowsFormsApp4;

namespace WindowsFormsApp4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void LoadForm(Form frm)
        {
            panelMain.Controls.Clear();
            frm.TopLevel = false;
            frm.Dock = DockStyle.Fill;
            panelMain.Controls.Add(frm);
            frm.Show();
        }

        private void btnIncome_Click(object sender, EventArgs e)
        {
            LoadForm(new FormIncome());
            lblHeader.Text = "수입내역";
        }

        private void btnBudget_Click(object sender, EventArgs e)
        {
            LoadForm(new FormBudget());
            lblHeader.Text = "예산관리";
        }

        private void btnExpense_Click(object sender, EventArgs e)
        {
            LoadForm(new FormExpense());
            lblHeader.Text = "지출내역";
        }

        private void btnStats_Click(object sender, EventArgs e)
        {
            LoadForm(new FormStats());
            lblHeader.Text = "자료통계";
        }
    }
}
