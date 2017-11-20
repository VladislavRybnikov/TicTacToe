using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TicTacToe.Interfaces;
using TicTacToe.Interfaces.Logic;

namespace TicTacToe.GameLogic
{
    public class HelpProcessor : IHelpProcessor
    {
        public IHelpEntity Help { get; set; }
        public HelpProcessor(IHelpEntity help)
        {
            Help = help;
        }

        public void Write()
        {
            Console.Clear();
            Console.WriteLine(Help.Text);
        }
        public override string ToString()
        {
            return "Help";
        }

        public void Execute()
        {
            Write();
            Console.ReadKey();
        }
    }
}
