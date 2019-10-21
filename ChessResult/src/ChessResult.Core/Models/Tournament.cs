using System;
using System.Collections.Generic;
using System.Text;

namespace ChessResult.Core.Models
{
    public class Tournament
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string LastUpdate { get; set; }
        public int FederationId { get; set; }
    }
}
