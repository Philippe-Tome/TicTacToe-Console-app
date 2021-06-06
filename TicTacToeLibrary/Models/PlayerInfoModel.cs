using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToeLibrary.Models
{
    public class PlayerInfoModel
    {
        public string UserName { get; set; }
        public List<PlayedPositions> Locations { get; set; } = new List<PlayedPositions>();
    }
}
