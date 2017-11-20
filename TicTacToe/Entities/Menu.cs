using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TicTacToe.Interfaces;
using TicTacToe.Interfaces.Logic;

namespace TicTacToe.GameLogic
{
    public class Menu : IMenu
    {
        public List<IMenuElement> Elements { get; set; }
        public Menu()
        {
            Elements = new List<IMenuElement>();
        }
    }
}
