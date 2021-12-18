using kennel.Data;
using kennel.Menu;
using kennel.MockDatas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kennel
{
    class Application : IApplication
    {
        public IMockData MockData { get; set; }
        public IDatabaseUsingLists Db { get; set; }
        public IMainMenu MainMenu { get; set; }
        public Application(IMainMenu mainMenu, IDatabaseUsingLists databaseUsingLists, IMockData mockData)
        {
            Db = databaseUsingLists;

            MockData = mockData;

            MainMenu = mainMenu;
        }

        public void Run()
        {
            MockData.GenerateCustomer();

            while (true)
            {
                MainMenu.Show();
                MainMenu.GetInput();
            }
        }

    }
}
 