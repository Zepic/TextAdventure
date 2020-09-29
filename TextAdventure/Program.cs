using System;
using System.Collections.Generic;

namespace TextAdventure
{
    class Program
    {
        static void Main(string[] args)
        {
            var startingField = new Location {Name = "Field", Id = 0, ConnectedList = new List<int>{4, 1}};     // connected to Town and Forrest
            var forrest = new Location {Name = "Forrest", Id = 1, ConnectedList = new List<int>{0, 5, 3}};      //connected to Field, Cave and Hills
            var wizzardTower = new Location {Name = "Wizzard Tower", Id = 2, ConnectedList = new List<int>{3}}; // connected to Hills
            var rollingHills = new Location {Name = "Rolling Hills", Id = 3, ConnectedList = new List<int>{1}}; // connected to forrest
            var friendlyTown = new Location {Name = "Rolvik", Id = 4, ConnectedList = new List<int> {0}};       //connected to Field
            var goblinCave = new Location {Name = "Goblin Cave", Id = 5, ConnectedList = new List<int> {1}};    //connected to Forrest
            var game = new World(startingField,forrest,wizzardTower,rollingHills,friendlyTown, goblinCave);

            Console.WriteLine(game.ShowCommands());
            var input = Console.ReadLine();
            var response = game.HandleInput(input);
            Console.WriteLine(response);
            
        }
    }
}
