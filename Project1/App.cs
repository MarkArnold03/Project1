using Project1.CalculatorData;
using Project1.Data;
using Project1.ShapesData;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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


                var sel = MainMenu.showMainMenu();
                if (sel == 0)
                {

                    break;
                }
                switch (sel)
                {
                    case 1:

                        while (true)
                        {
                            Console.Clear();
                            var shapeChoice = ShapesMainMenu.ShapeMainMenu();

                            switch (shapeChoice)
                            {
                                case 1:
                                    Console.Clear();
                                    ShapesMenu.ShapeMenu(dbContext);
                                    break;
                                case 2:
                                    Console.Clear();
                                    ShapesMainMenu.ShowAll(dbContext);
                                    break;
                                case 3:
                                    Console.Clear();
                                    ShapesMainMenu.UpdateShape(dbContext);
                                    break;
                                case 4:
                                    Console.Clear();
                                   ShapesMainMenu.DeleteShape(dbContext);
                                    break;
                                case 5:
                                    break;
                                default:
                                    Console.WriteLine("Invalid choice.");
                                    break;
                            }

                            if (shapeChoice == 0)
                            {
                                Console.Clear();
                                break;
                            }
                        }
                        break;
                    case 2:
                        while (true)
                        {


                            Console.Clear();
                            var input = CalculatorMainMenu.CalculatorsMainMenu();
                            switch (input)
                            {
                                case 1:
                                    Console.Clear();
                                    CalculatorMenu.CalculatorsMenu(dbContext);
                                    break;
                                case 2:
                                    Console.Clear();
                                    CalculatorMainMenu.ShowCalculations(dbContext);
                                    break;
                                case 3:
                                    Console.Clear();
                                    CalculatorMainMenu.UpdateCalculations(dbContext);
                                    break;
                                case 4:
                                    Console.Clear();
                                    CalculatorMainMenu.DeleteCalculation(dbContext);
                                    break;
                                case 5:
                                    break;
                                default:
                                    Console.WriteLine("Invalid choice.");
                                    break;
                            }
                            if (input == 0)
                            {
                                Console.Clear();
                                break;
                            }

                        }
                        break;

                }

            }
        }
    }
    
}
