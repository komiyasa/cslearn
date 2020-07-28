using System;

namespace _10Struct
{
    struct Player{
        public string Name;
        public int Number;
        public string Position;

        public Player(int n, string s, string p)
        {
            Number = n;
            Name  = s;
            Position = p;
        }
    }

    class Team
    {
        int regularcnt;
        Player[] regular = new Player[3];
        public bool AddRegular(Player p)
        {
            if(regularcnt < regular.Length)
            {
                regular[regularcnt++] = p;
                return true;
            }
            return false;
        }
        public void ShowRegular()
        {
            foreach(Player p in regular)
            {
                if(p.Name != null)
                {
                    Console.WriteLine("{0} {1} {2}", p.Name, p.Number, p.Position);
                }
            }
        }

        public Player GetRegular(int ix)
        {
            try{
                return regular[ix];
            }
            catch
            {
                return new Player();
            }
        }
    }

    class MainClass
    {
        static void Main()
        {
            Team t = new Team();
            t.AddRegular(new Player(63,"西川", "センター"));
            t.AddRegular(new Player(1,"鈴木", "ライト"));
            t.AddRegular(new Player(7,"堂林", "ファースト"));
            t.AddRegular(new Player(18,"森下", "ピッチャー"));

            t.ShowRegular();
            Player p = t.GetRegular(1);
            Console.WriteLine(p.Name);

            p = t.GetRegular(5);
            Console.WriteLine(p.Name);
        }
    }
}