using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProjectIDF.Enums;
using ProjectIDF.Logic;


namespace ProjectIDF.Entity

{
    internal class TerroristEntity
    {
        private string Name;
        private int Rank;
        private bool StatusLife;
        private List<WeaponsEnum> TypeWeapons;
        private int Score;

        public TerroristEntity(string name, int rank, bool statusLife, List<WeaponsEnum> typeWeapons)
        {
            Name = name;
            Rank = rank;
            StatusLife = statusLife;
            TypeWeapons= typeWeapons;
            Score = CalculateScore.CalculateScoreTerrorist(TypeWeapons,Rank);
        }

       

        public string nameTrrorist
        {
            get { return Name; }
            set {Name = value; }
        }

        public int typeRank
        {
            get { return Rank; }
            set { Rank = value; }
        }

        public bool statusTrrorist
        {
            get { return StatusLife; }
            set { StatusLife = value; }
        }

        public List<WeaponsEnum> Weapons
        {
            get { return TypeWeapons; }
            set { TypeWeapons = value; }
        }

        public int GetScore
        {
            get { return Score; }
           private set { Rank = value; }
        }

    }
}
