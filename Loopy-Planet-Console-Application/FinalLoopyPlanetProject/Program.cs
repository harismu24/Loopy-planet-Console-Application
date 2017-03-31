using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalLoopyPlanetProject
{
    class Program
    {
        static void Main(string[] args)
        {
            bool end = true;
            while (end == true)
            { //Declare Variables 

                double weight = 0;
                int menuChoice = 0;
                double ratio = 0;
                string Destination = "";

                // Console Menu 
                //All planets are defined to their numbers 
                Console.WriteLine("Please Choose a Planet");
                Console.WriteLine("------------------------");
                Console.WriteLine("1. Jupiter   2. Mars.   3. Mercury");
                Console.WriteLine("4. Neptune   5. Pluto   6. Saturn");
                Console.WriteLine("7. Uranus    8. Venus   9. Quit");
                Console.WriteLine("\n\n");


                Console.Write("Enter Your Planet ");
                menuChoice = int.Parse(Console.ReadLine());


//Switch statement // switch will find out what will happen with each choice and work accordingly 
                switch (menuChoice)
                {//Planet gravity factors
                    case 1:
                        ratio = 2.64;
                        Destination = "Jupiter";
                        break;

                    case 2:
                        ratio = 0.38;
                        Destination = "Mars";
                        break;

                    case 3:
                        ratio = 0.37;
                        Destination = "Mercury";
                        break;

                    case 4:
                        ratio = 1.12;
                        Destination = "Neptune";
                        break;

                    case 5:
                        ratio = 0.04;
                        Destination = "Pluto";
                        break;

                    case 6:
                        ratio = 1.15;
                        Destination = "Saturn";
                        break;

                    case 7:
                        ratio = 1.15;
                        Destination = "Uranus";
                        break;

                    case 8:
                        ratio = 0.88;
                        Destination = "Venus";
                        break;
                    case 9:
                        end = false;
                        break;

                    default:
                        break;
                }
                Console.WriteLine("\nYour Planet is: " + Destination);
                //User enters the weight on earth 
                Console.Write("\nYou May Enter Your Weight in Pounds Now: ");
                weight = double.Parse(Console.ReadLine());//Conversion of user input to double value

                double FinalW = 0;

                // Formula to calculate the weight on each planet 
                FinalW = (ratio * weight);

//This function will print the resulting weight and planet name.
                Console.WriteLine
("\n Weight on Earth " + weight + " pounds, which is " + FinalW + " Pounds on " + Destination + "\n");

                //Ask the user if want to Continue to find weight on new planet
                Console.WriteLine("Do you want continue?");
                



            }
            if (end == false)
            {
                end = false;
            }
        }
    }
}
