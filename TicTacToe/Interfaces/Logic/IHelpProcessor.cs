using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe.Interfaces.Logic
{
    public interface IHelpProcessor : IMenuElement
    {
        IHelpEntity Help { get; set; }
        void Write();
    }
}
