using System;

namespace Command
{
    public class Program
    {
        static void Main(string[] args)
        {
            // Create an action to store.
            var lasercannon = new LaserCannon();

            // Create an object to store the action.
            var ship = new Ship(lasercannon);

            // Create an object to execute the action in the object.
            var player = new Player(ship);

            // Execute command.
            player.ExecuteCommand();
            player.ExecuteCommand();

            // Inpect result.
            Console.ReadKey();
        }
    }
}