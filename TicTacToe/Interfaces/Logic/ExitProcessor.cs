using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe.Interfaces.Logic
{
    public class ExitProcessor : IMenuElement
    {
        public void Execute()
        {
           
        }
        public override string ToString()
        {
            return "Exit";
        }
    }
}
