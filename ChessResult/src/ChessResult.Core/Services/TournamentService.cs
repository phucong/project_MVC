using ChessResult.Core.Database.Criterias;
using ChessResult.Core.Models;
using Fanex.Data.Repository;
using System.Collections.Generic;

namespace ChessResult.Core.Services
{
    public interface ITournamentService
    {
        IEnumerable<Tournament> GetTournaments();
    }

    public class TournamentService : ITournamentService
    {
        private readonly IDynamicRepository dynamicRepository;

        public TournamentService(IDynamicRepository dynamicRepository)
        {
            this.dynamicRepository = dynamicRepository;
        }

        public IEnumerable<Tournament> GetTournaments()
        {
            var tournaments = dynamicRepository.Fetch<Tournament>(new GetTournamentsCriteria());

            return tournaments;
        }
    }
}