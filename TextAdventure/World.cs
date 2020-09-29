using System;
using System.Collections.Generic;
using System.Xml;

namespace TextAdventure
{
    public class World
    {
        public List<Location> _locations;
        private Player _user = new Player();


        public World(params Location[] locations)
        {
            _locations = new List<Location>(locations);
        }


        public string ShowCommands()
        {
            string commands = @"1: Current Location name
2: Look at nearby roads
3: Travel to a location
4: Rest";
            return commands;
        }
        public string HandleInput(string input)
        {
            var currentLocation = _user.Location;
            string x;
            
            if (input == "1") // Location
            {
                x = getLocation(currentLocation);
            }
            else if (input == "2") // go to next location
            {
                x = lookAround();
            }
            else if (input == "3") // Look around
            {
                x = null; //GotoNextLocation();
            }
            else if (input == "4") // Option 4
            {
                x = "Not Assigned";
            }
            else if (input == "5") // 5
            {
                x = "Not Assigned";
            }

            else // Anything else
            {
                x = "Invalid command";
            }
            return x;
        }
        private string getLocation(int location)
        {
            string x = "location not found";
            foreach (var _location in _locations)
            {
                if (_location.Id == location)
                {
                    x = _location.Name;
                }
            }
            return x;
        }

        private string lookAround()
        {
            string x = "";
            foreach (var location in _locations)
            {
                if (location.Id ==_user.Location)
                {
                    x = "You see:\n";
                    foreach (var locationId in location.ConnectedList)
                    {
                        x += "Road to " + getLocation(locationId) + "\n";
                    }
                }
            }
            return x;
        }

        private string GotoNextLocation(string Input)
        {
            return null;
        }
    }
}