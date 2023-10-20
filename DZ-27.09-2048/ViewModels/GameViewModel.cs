using DZ_27._09_2048.Commands;
using DZ_27._09_2048.Models;
using DZ_27._09_2048.ViewModels.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DZ_27._09_2048.ViewModels
{
    
    public class GameViewModel : ViewModel
    {
        private GameBoard gameBoard;
        private Random random;
        public int Score { get => gameBoard.score; private set => Set(ref gameBoard.score, value); }

        public GameViewModel()
        {
            gameBoard = new GameBoard();
            random = new Random();
        }

        public NavigationCommand NavigateToMenuPage { get => new(NavigateToPage, new Uri("View/Pages/MenuPage.xaml", UriKind.RelativeOrAbsolute)); }

    }
}
