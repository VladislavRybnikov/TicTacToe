using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TicTacToe.Configurations;
using TicTacToe.Entities;
using TicTacToe.GameLogic;
using TicTacToe.Interfaces.Logic;

namespace TicTacToe
{
    public class TicTacToeProcessor
    {
        private IMenuProcessor _processor;
        public TicTacToeProcessor()
        {
            Grid grid = new Grid(FieldConfig.StartPoint);
            GameProcessor game = new GameProcessor(grid);

            HelpProcessor help = new HelpProcessor(new HelpEntity(HelpHolder.text));
            Menu menu = new Menu();
            ExitProcessor exit = new ExitProcessor();
            menu.Elements.Add(game);
            menu.Elements.Add(help);
            menu.Elements.Add(exit);
            _processor = new MenuProcessor(menu);
        }
        public void Start()
        {
            _processor.Start();
        }
       
    }
}
