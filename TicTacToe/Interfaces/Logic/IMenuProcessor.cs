using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe.Interfaces.Logic
{
    public interface IMenuProcessor
    {
        IMenu Menu { get; set; }
        IMenuElement Choosed { get; set; }
        void Start();
        void Chose();
    }
}
