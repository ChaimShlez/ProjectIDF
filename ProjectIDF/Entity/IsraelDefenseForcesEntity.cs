using ProjectIDF.Base;

namespace ProjectIDF.Entity
{
    internal class IsraelDefenseForcesEntity : Organization
    {
        public IsraelDefenseForcesEntity(string name, string establishment, string commander, List<string> attackOptions) :
            base(name, establishment, commander, attackOptions)
        {}
        
    }
}

