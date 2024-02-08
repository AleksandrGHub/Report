namespace Report
{
    class Catalog
    {
        private Random _random = new Random();
        private List<Soldier> _soldier = new List<Soldier>();

        public Catalog()
        {
            AddSoldiers();
        }

        public void ShowDatasets()
        {
            foreach (var soldier in _soldier.Select(player => new { player.Name, player.Rank }))
            {
                Console.WriteLine($"Имя: {soldier.Name}\tзвание: {soldier.Rank}");
            }

            Console.ReadKey();
        }

        private void AddSoldiers()
        {
            int numberSoldier = 15;
            int minServiceLife = 5;
            int maxServiceLife = 15;

            List<string> names = new List<string>() { "Сергей", "Дмитрий", "Андрей", "Алексей", "Максим", "Иван", "Роман", "Евгений", "Михаил", "Артем", "Анатолий", "Владимир", "Владислав", "Вячеслав" };
            List<string> weapon = new List<string>() { "пулемет", "автомат", "револьвер", "гранатомет", "миномет", "винтовка", "пистолет" };
            List<string> ranks = new List<string>() { "рядовой", "ефрейтор", "сержант", "старшина", "лейтенант", "капитан", "майор", "подполковник", "полковник" };

            for (int i = 0; i < numberSoldier; i++)
            {
                _soldier.Add(new Soldier(names[_random.Next(names.Count)], weapon[_random.Next(weapon.Count)], ranks[_random.Next(ranks.Count)], _random.Next(minServiceLife, maxServiceLife)));
            }
        }
    }
}