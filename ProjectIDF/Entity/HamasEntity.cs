using ProjectIDF.Base;

namespace ProjectIDF.Entity
{
    internal class HamasEntity : Organization
    {
        public HamasEntity(string name, string establishment, string commander, List<string> attackOptions) :
            base(name, establishment, commander, attackOptions)
        {}
        
    }
}       