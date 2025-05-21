using ProjectIDF.Base;

namespace ProjectIDF.Enemy
{
    internal class Hamas : Organization
    {
        public Hamas(string name, string establishment, string commander, List<string> attackOptions) :
            base(name, establishment, commander, attackOptions)
        {}
        
    }
}       