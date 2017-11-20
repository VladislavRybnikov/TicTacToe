using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TicTacToe.Interfaces;

namespace TicTacToe.Entities
{
    public class HelpEntity : IHelpEntity
    {
        public string Text { get; set; }
        public HelpEntity(string text)
        {
            Text = text;
        }
    }
}
