namespace ProjectIDF.Base
{
   abstract class Organization
   {
       private string _name;
       private string _establishment;
       private string _commander;
       private List<string> _attackOptions;

       
       
       protected Organization(string name, string establishment, string commander, List<string> attackOptions)
       {
           _name = name;
           _establishment = establishment;
           _commander = commander;
           _attackOptions = attackOptions;
       }
       
       public string Name
       {
           get { return _name; }
           set { _name = value; }
       }
       
       public string Establishment
       {
           get { return _establishment; }
           set { _establishment = value; }
       }
       public string Commander
       {
           get { return _commander; }
           set { _commander = value; }
       }
       public List<string> AttackOptions
       {
           get { return _attackOptions; }
           set { _attackOptions = value; }
       }
       
 
       
       
       



   } 
}


