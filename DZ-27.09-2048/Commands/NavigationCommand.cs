using DZ_27._09_2048.Commands.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace DZ_27._09_2048.Commands
{
    public class NavigationCommand : BaseCommand
    {
        private readonly Action<Page, Uri> execute;
        private readonly Uri uri;
        public NavigationCommand(Action<Page, Uri> execute, Uri uri) 
        {
            this.execute = execute;
            this.uri = uri;
        }

        public override void Execute(object parameter)
        {
            execute.Invoke((Page)parameter, uri);
        }
    }
}
