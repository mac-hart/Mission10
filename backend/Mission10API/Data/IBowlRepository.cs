namespace Mission10API.Data
{
    public interface IBowlRepository
    {
        IEnumerable<Bowlers> GetAllBowlers();
        IEnumerable<Bowlers> GetBowlersByTeamNames(params string[] teamNames);
    }
}
