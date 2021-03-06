﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe.Interfaces.Logic
{
    public interface IGameProcessor : IMenuElement
    {
        IGrid<char> CGrid { get; set; }
        void Start();
    }
}
