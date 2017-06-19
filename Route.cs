using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logist
{
    class Route : IComparable<Route>
    {

        public static List<Route> routes { get; set; }

        string name;
        List<City> cities;

        public Route(string name)
        {
            this.name = name;
            cities = new List<City>();
        }

        public void addCity(City city)
        {
            cities.Add(city);
            city.addRoute(this);
        }

        public string getName()
        {
            return name;
        }

        public int CompareTo(Route other)
        {
            return name.CompareTo(other.name);
        }

        public List<City> getCities()
        {
            return cities;
        }
    }
}
