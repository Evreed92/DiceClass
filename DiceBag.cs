using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace DiceRoller
{
    internal class DiceBag
    {
        
        //public int[] NumberOfDice = { 0, 1, 1, 1, 1, 1, 1, 0 };
       
        public Die d2 = new Die(2);
        public Die d4 = new Die(4);
        public Die d6 = new Die(6);
        public Die d8 = new Die(8);
        public Die d10 = new Die(10);
        public Die d12 = new Die(12);
        public Die d20 = new Die(20);
        public Die d100 = new Die(100);

       /* public void AddDice(string die, int number)
        {
            switch (die)
            {
                case "d2":
                    NumberOfDice[0] += number;
                    break;
                case "d4":
                    NumberOfDice[1] += number;
                    break;
                case "d6":
                    NumberOfDice[2] += number;
                    break;
                case "d8":
                    NumberOfDice[3] += number;
                    break;
                case "d10":
                    NumberOfDice[4] += number;
                    break;
                case "d12":
                    NumberOfDice[5] += number;
                    break;
                case "d20":
                    NumberOfDice[6] += number;
                    break;
                case "d100":
                    NumberOfDice[7] += number;
                    break;
                default:
                    //Add Error Handling here
                    break;
            }

        }
        public void RemoveDice(string die, int number)
        {
            switch (die)
            {
                case "d2":
                    NumberOfDice[0] -= number;
                    if (NumberOfDice[0] < 0) NumberOfDice[0] = 0;
                    break;
                case "d4":
                    NumberOfDice[1] -= number;
                    if (NumberOfDice[1] < 0) NumberOfDice[1] = 0;
                    break;
                case "d6":
                    NumberOfDice[2] -= number;
                    if (NumberOfDice[2] < 0) NumberOfDice[2] = 0;

                    break;
                case "d8":
                    NumberOfDice[3] -= number;
                    if (NumberOfDice[3] < 0) NumberOfDice[3] = 0;

                    break;
                case "d10":
                    NumberOfDice[4] -= number;
                    if (NumberOfDice[4] < 0) NumberOfDice[4] = 0;

                    break;
                case "d12":
                    NumberOfDice[5] -= number;
                    if (NumberOfDice[5] < 0) NumberOfDice[5] = 0;

                    break;
                case "d20":
                    NumberOfDice[6] -= number;
                    if (NumberOfDice[6] < 0) NumberOfDice[6] = 0;

                    break;
                case "d100":
                    NumberOfDice[7] -= number;
                    if (NumberOfDice[7] < 0) NumberOfDice[7] = 0;

                    break;
                default:
                    //Add Error Handling here
                    break;
            }

        }
       */
       
    }
}



