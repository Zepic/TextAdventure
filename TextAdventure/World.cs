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
        


        public string HandleInput(string input)
        {
            var currentLocation = _user.Location;
            string x;
            var inputLower = input.ToLower();
            if (inputLower == "1") // Location
            {
                x = getLocation(currentLocation);
            }
            else if (inputLower == "2") // go to next location
            {
                x = "Not Assigned";
            }
            else if (inputLower == "3") // Look around
            {
                x = lookAround();
            }
            else if (inputLower == "4") // Option 4
            {
                x = "Not Assigned";
            }
            else if (inputLower == "5") // 5
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
                    foreach (var locationId in location.ConnectedList)
                    {
                        x += getLocation(locationId) + "\n";
                    }
                }
            }
            return x;
        }

    }
}