using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe.Interfaces.Logic
{
    public interface IGrid<T>
    {
        int Width { get; set; }
        int Height { get; set; }
        T[,] Fields { get; set; }     
        IGamePoint StartPosition { get; set; }

        T GetField(IGamePoint point);
        void Redraw();
    }
}
