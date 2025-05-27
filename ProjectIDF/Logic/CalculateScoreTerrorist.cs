using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProjectIDF.Enums;

namespace ProjectIDF.Logic
{
    internal class CalculateScore
    {

        public static int CalculateScoreTerrorist(List<WeaponsEnum> TypeWeapons,int rank)
        {
            int sumScoreWeapons = 0;

            foreach(WeaponsEnum  weapon in TypeWeapons)
            {
                sumScoreWeapons += GetScorePerWeapons(weapon);
            }
            int sumScore = rank * sumScoreWeapons;

            return sumScore;
        }

        private static int GetScorePerWeapons(WeaponsEnum  weapons)
        {
           switch(weapons)
            {
                case WeaponsEnum.AK47:
                    return 3;
                  
                case WeaponsEnum.GUN:
                    return 2;
                   
                case WeaponsEnum.KNIFE:
                    return 1;
                   
                case WeaponsEnum.M16:
                    return 3;
                  
                default:
                    return 0;
                  


            }
        }
    }
}
