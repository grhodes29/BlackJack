using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJack
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("******************************************************************************");
            Console.WriteLine("************************  WELCOME TO CLUB 21 *********************************");
            Console.WriteLine("******************************************************************************");
            Console.WriteLine();
            Console.WriteLine();

            Console.WriteLine("How many players will be at the table?");
            int _numOfPlayers = Convert.ToInt32(Console.ReadLine());

            // declare players array and assign size
            Player[] _players = new Player[_numOfPlayers];

            // get each players name in a loop
            int counter = 0;
            while (counter < _numOfPlayers)
            {
                _players[counter] = new Player(counter + 1);

                int _playernumber = counter + 1;
                Console.WriteLine("Please enter the name for player number " + _playernumber + "?");
                _players[counter].Name = Console.ReadLine();

            }


            Console.ReadKey();


        }
    }
}
