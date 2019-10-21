using Fanex.Data.Repository;

namespace ChessResult.Core.Database.Criterias
{
    public class GetTournamentsCriteria : CriteriaBase
    {
        public override string GetSettingKey()
            => "Tournament_GetAll";

        public override bool IsValid() => true;
    }
}
