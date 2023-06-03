using pedraPapelTesoura.Domain.Models.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pedraPapelTesoura.Domain.Models
{
    public class Match
    {
        public int Id { get; init; }

        public bool PlayerWon { get; set; }

        public Bet PlayerBet { get; set; }

        public Bet IaBet { get; set; }
    }
}
