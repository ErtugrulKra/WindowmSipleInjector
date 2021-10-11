using SimpleInjectorTest.DependencyManager;
using System;
using System.Windows.Forms;

namespace SimpleInjectorTest.WinForm
{
    public partial class frmMainForm : Form
    {
        public frmMainForm()
        {
            InitializeComponent();
        }

        private void btnValidator_Click(object sender, EventArgs e)
        {
            using (var form =  DependencyContainer.Container.GetInstance<frmRegexTester>())
            {
                form.ShowDialog();
            }
        }
    }
}
