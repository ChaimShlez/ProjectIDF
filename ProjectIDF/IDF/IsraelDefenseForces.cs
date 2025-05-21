using ProjectIDF.Base;

namespace ProjectIDF.IDF
{
    internal class IsraelDefenseForces : Organization
    {
        public IsraelDefenseForces(string name, string establishment, string commander, List<string> attackOptions) :
            base(name, establishment, commander, attackOptions)
        {}
        
    }
}

