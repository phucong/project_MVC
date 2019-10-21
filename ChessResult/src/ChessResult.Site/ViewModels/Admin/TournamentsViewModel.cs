using ChessResult.Core.Models;
using System.Collections.Generic;
using System.Linq;

namespace ChessResult.Site.ViewModels.Admin
{
    public class TournamentsViewModel
    {
        public TournamentsViewModel(IEnumerable<Tournament> tournaments)
        {
            Tournaments = tournaments.ToList();
        }

        public IReadOnlyList<Tournament> Tournaments { get;  }
    }
}