using SimpleInjectorTest.Utils;
using System;
using System.Windows.Forms;

namespace SimpleInjectorTest.WinForm
{
    public partial class frmRegexTester : Form
    {
        private readonly IRegexTester regexTester;

        public frmRegexTester(IRegexTester regexTester)
        {
            InitializeComponent();
            this.regexTester = regexTester;
        }

        private void btnCheck_Click(object sender, EventArgs e)
        {
            if (regexTester.IsNumberRegex(txtInput.Text))
                MessageBox.Show("Numara girildi");
            else
                MessageBox.Show("Numara disinda bilgi girildi");
        }
    }
}
