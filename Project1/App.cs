﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Project1.Data;
using Project1.ShapesData;
namespace Project1
{
    public class App
    {
        public void Run()
        {
            var buildApp = new Build();
            var dbContext = buildApp.BuildApp();
            while (true)
            {
                var input = MainMenu.showMainMenu();
                if (input == 0)
                {
                    break;
                }
                switch (input)
                {
                    case 1:
                        while (true)
                        {
                            Console.Clear();
                  
                        }
                    case 2:
                        while (true)
                        {
                            Console.Clear();

                        }
                }

            }
        }
    }
}
