using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logist
{
    class StopCity : City
    {
        public StopCity last { get; }
        public StopCity(City city, StopCity last=null) : base(city.ToString())
        {
            this.routes = city.getRoutes();
            this.last = last;
        }
    }
}
