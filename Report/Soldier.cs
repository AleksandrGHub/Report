namespace Report
{
    class Soldier
    {
        public Soldier(string name, string weapon, string rank, int serviceLife)
        {
            Name = name;
            Weapon = weapon;
            Rank = rank;
            ServiceLife = serviceLife;
        }

        public string Name { get; private set; }
        public string Weapon { get; private set; }
        public string Rank { get; private set; }
        public int ServiceLife { get; private set; }
    }
}