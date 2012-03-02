using System.Windows;
using Microsoft.Tools.WindowsInstallerXml.Bootstrapper;

namespace SampleApp.BA
{
    public class SampleBootstrapperApplication : BootstrapperApplication
    {
        protected override void Run()
        {
            Application app = new Application();
            CaliburnMicroBootstrapper bootstrapper = new CaliburnMicroBootstrapper(this);
            app.Run();

            this.Engine.Quit(0);
        }
    }
}
