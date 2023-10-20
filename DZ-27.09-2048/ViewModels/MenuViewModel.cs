using DZ_27._09_2048.Commands;
using DZ_27._09_2048.ViewModels.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DZ_27._09_2048.ViewModels
{
    public class MenuViewModel : ViewModel
    {
        public NavigationCommand NavigateToGamePage {  get => new(NavigateToPage, new Uri("../View/Pages/GamePage.xaml", UriKind.RelativeOrAbsolute)); }

    }
}
