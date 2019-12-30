using Microsoft.VisualBasic.ApplicationServices;
using System.Windows;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FluCreate
{
    class SingleWarpInstanceApp: WindowsFormsApplicationBase
    {
        private MainWindow main;
       public SingleWarpInstanceApp()
        {
            this.IsSingleInstance = true;
        }

        protected override bool OnStartup(Microsoft.VisualBasic.ApplicationServices.StartupEventArgs eventArgs)
        {
            Application app = new Application();
            main = new MainWindow();
            app.Run(main);
            bool tag = base.OnStartup(eventArgs);
            return tag;
        }

        protected override void OnStartupNextInstance(StartupNextInstanceEventArgs eventArgs)
        {
            main.Show();
        }
    }
}
