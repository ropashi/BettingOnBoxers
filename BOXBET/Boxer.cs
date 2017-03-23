using System;

namespace BOXBET
{
    class Boxer
    {
        private int str,hp, maxHP;
        private string name, status;

        public Boxer()
        {
        }
        public Boxer(int rnd , string name)
        {
            this.name = name;
            str = 80 + rnd % 69;
            hp = 300 + rnd % 499;
            maxHP = hp;
            status = "eager to fight";
        }
        public override String ToString()
        {
            return name + "\n\nStrength: " + str + "\n\n" + hp +"/"+maxHP+ "\n\nStatus: " + status;
        }
        public int Punches(int rnd)
        {

            return str + rnd;
        }
        public void GetsPunched(int p)
        {
            hp = hp - p;
            
            if (hp < 400 && hp > 100)
            {
                status = "hurt";
            }
            if (hp <= 100 && hp > 0)
            {
                status = "almost finished";
            }
            if (hp <= 0)
            {

                status = "K.O.";
                str = 0;
                hp = 0;
            }
        }
        public int GetHP()
        {
            return this.hp;
        }
        public int GetMaxHP()
        {
            return maxHP;
        }
    }
}
