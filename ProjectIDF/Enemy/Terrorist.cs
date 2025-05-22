using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProjectIDF.Enums;


namespace ProjectIDF.Enemy

{
    internal class Terrorist
    {
        private string Name;
        private int Rank;
        private bool StatusLife;
        private List<WeaponsEnum> TypeWeapon;
        
        public Terrorist(string name, int rank, bool statusLife, List<WeaponsEnum> typeWeapon)
        {
            Name = name;
            Rank = rank;
            StatusLife = statusLife;
            TypeWeapon = typeWeapon;
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

        public List<WeaponsEnum> MyProperty
        {
            get { return TypeWeapon; }
            set { TypeWeapon = value; }
        }

    }
}
