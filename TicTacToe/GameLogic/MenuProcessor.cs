using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TicTacToe.Configurations;
using TicTacToe.Entities;
using TicTacToe.Interfaces.Logic;

namespace TicTacToe.GameLogic
{
    public class MenuProcessor : IMenuProcessor
    {
        private int _current;
        public IMenu Menu { get; set; }
        public IMenuElement Choosed { get; set; }

        public MenuProcessor(IMenu menu)
        {
            _current = 0;
            Menu = menu;
        }

        public void Chose()
        {
            throw new NotImplementedException();
        }
        public void Start()
        {
            Console.CursorVisible = false;
            Choosed = Menu.Elements[_current];
            Write();
            ConsoleKey key;
            while ((key = Console.ReadKey().Key)!= ConsoleKey.Enter)
            {
                if (key == ConsoleKey.UpArrow && _current > 0)
                {
                    _current--;
                }
                else if (key == ConsoleKey.DownArrow && _current < Menu.Elements.Count - 1)
                {
                    _current++;
                }
                Choosed = Menu.Elements[_current];
                Write();
            }
            Choosed.Execute();

        }
        private void Write()
        {
            int count = 0;
           
            ConsoleGraphic.DrawTicTacToe((GamePoint)FieldConfig.NamePoint);
            foreach (var el in Menu.Elements)
            {
                Console.SetCursorPosition(FieldConfig.StartPoint.X, FieldConfig.StartPoint.Y + count);
                if (Choosed == el)
                {
                    Console.ForegroundColor = FieldConfig.colors[2];
                    Console.Write(el.ToString());
                }
                else
                {
                    Console.ForegroundColor = FieldConfig.colors[3];
                    Console.Write(el.ToString());
                }
            
                count++;
            }
        }
    }
}
