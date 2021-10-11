using SimpleInjector;
using SimpleInjector.Diagnostics;
using SimpleInjectorTest.DependencyManager;
using System;
using System.Windows.Forms;

namespace SimpleInjectorTest.WinForm
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            RegisterWindowsForms();
            Application.Run(new frmMainForm());
        }

        private static void  RegisterWindowsForms()
        {
            var types = DependencyContainer.Container.GetTypesToRegister<Form>(typeof(Program).Assembly);

            foreach (var type in types)
            { 
                var registration = Lifestyle.Transient.CreateRegistration(type, DependencyContainer.Container);

                registration.SuppressDiagnosticWarning(DiagnosticType.DisposableTransientComponent, 
                    "Windows Formlari dispose etmeyi unutmayin");

                DependencyContainer.Container.AddRegistration(type, registration);
            }
        }
    }
}
