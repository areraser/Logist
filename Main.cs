using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;



namespace Logist
{
    public partial class Main : Form
    {
       

        public Main()
        {
            InitializeComponent();

            
            XmlElement root = Program.doc.DocumentElement;

            Logist.Route.routes = new List<Logist.Route>();
            Logist.City.cities = new SortedSet<City>();

            foreach(XmlElement el in root.ChildNodes)
            {
                Route route=new Route(el.ChildNodes[0].InnerText);
                foreach (XmlElement city in el.ChildNodes[1].ChildNodes)
                {
                    City c=null; 

                    foreach(City tmp in Logist.City.cities)
                    {
                        if (tmp.ToString().Equals(city.InnerText))
                        {
                            c = tmp;
                            break;
                        }

                    }

                    if (c == null)
                    {
                        c = new City(city.InnerText);
                        Logist.City.cities.Add(c);

                    }

                    route.addCity(c);
                }
                Logist.Route.routes.Add(route);

            }

            setCity();

        }

        public void setCity()
        {
            this.start.Items.Clear();
            this.end.Items.Clear();

            foreach (City c in Logist.City.cities)
            {
                this.start.Items.Add(c);
                this.end.Items.Add(c);

            }
        }

        private void AllRoute(object sender, EventArgs e)
        {

            AllRoutes f = new AllRoutes(this);
            f.DrawList();
            f.Show();

        }

        private void Search(object sender, EventArgs e)
        {
            if (this.start.Text.Equals("") || this.end.Text.Equals("")) return;

            City start = null;
            City end = null;

            foreach(City tmp in Logist.City.cities)
            {
                if (tmp.ToString().Equals(this.start.Text))
                    start = tmp;

                if (tmp.ToString().Equals(this.end.Text))
                    end = tmp;

            }

            if (start == null || end == null)
                return;

            if (start.Equals(end))
            {
                return;
            }

            StopCity iter = new StopCity(start);

            SortedSet<City> drove = new SortedSet<City>();
            drove.Add(start);

            SortedSet<Route> droveRoute = new SortedSet<Logist.Route>();

            SortedSet<StopCity> now = new SortedSet<StopCity>();
            
            foreach(Route tmp in start.getRoutes())
            {

                foreach(City c in tmp.getCities())
                {
                    if (!drove.Contains(c))
                    {
                        if (c.Equals(end))
                        {

                            ShowResualt(new StopCity(c, iter));
                            return;
                        }

                        now.Add(new StopCity(c, iter));

                        
                    }
                   
                }

                droveRoute.Add(tmp);
            }

            while (now.Count != 0)
            {
                SortedSet<StopCity> next = new SortedSet<StopCity>();

                foreach(StopCity nowCity in now)
                {
                    drove.Add(nowCity);

                    foreach(Route tmp in nowCity.getRoutes())
                    {
                        if (droveRoute.Contains(tmp)) continue;
                        droveRoute.Add(tmp);

                        foreach(City c in tmp.getCities())
                        {
                            if (!drove.Contains(c) && !now.Contains(c) && !next.Contains(c) )
                            {
                                next.Add(new StopCity(c, nowCity));

                                if (c.Equals(end))
                                {
                                    ShowResualt(new StopCity(c, nowCity));
                                    return;
                                }
                            }
                        }
                    }
                }

                now = next;

            }
            ShowResualt();

        }



        void ShowResualt(StopCity stack=null)
        {
            string res = "";
            if (stack == null)
            {
                res = "Шлях не знайдено";
            }
            else
            {
                res = stack.ToString();
                StopCity tmp = stack.last;
                while (tmp != null)
                {
                    res = tmp.ToString() + "-" + res;
                    tmp = tmp.last;
                }
            }

            MessageBox.Show(res);

        }
    }
}
