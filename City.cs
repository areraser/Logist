using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logist
{
    class City : IComparable<City>
    {
        public static SortedSet<City> cities { get; set; }

        protected string name;
        protected SortedSet<Route> routes;

        public City(string name)
        {
            this.name = name;
            routes = new SortedSet<Route>();
        }

        public int CompareTo(City obj)
        {
            return name.CompareTo(obj.name);
        }

        internal void addRoute(Route route)
        {
            routes.Add(route);
        }

        public SortedSet<Route> getRoutes()
        {
            return routes;
        }

        public override string ToString()
        {
            return this.name;
        }

    }
}
