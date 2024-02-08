namespace Report
{
    class Menu
    {
        private string _exitCommand = "Выход";
        private string _showDatasetsCommand = "Запрос";
        private Catalog _catalog = new Catalog();

        public void Work()
        {
            string userInput;

            do
            {
                Console.Clear();
                ShowInfo();

                userInput = Console.ReadLine();

                if (userInput == _showDatasetsCommand)
                {
                    _catalog.ShowDatasets();
                }
            }
            while (_exitCommand == userInput == false);
        }

        private void ShowInfo()
        {
            Console.WriteLine($"***************** Команды меню *****************\nПоказать данные запроса, команда: {_showDatasetsCommand}\nДля выхода введите команду: {_exitCommand}\n");
        }
    }
}