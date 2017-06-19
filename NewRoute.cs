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
    public partial class NewRoute : Form
    {
        AllRoutes refer;
        public NewRoute(AllRoutes refer)
        {
            InitializeComponent();
            this.refer = refer;
        }

        private void AddClick(object sender, EventArgs e)
        {
            if (this.Name.Text == "" || this.Cities.Text == "") return;

            XmlElement r = Program.doc.CreateElement("route");
            Program.doc.DocumentElement.AppendChild(r);
            XmlElement name = Program.doc.CreateElement("name");
            name.InnerText = this.Name.Text;
            r.AppendChild(name);
            XmlElement cities = Program.doc.CreateElement("cities");
            r.AppendChild(cities);
            foreach (string c in this.Cities.Text.Split(' '))
            {
                XmlElement city = Program.doc.CreateElement("city");
                city.InnerText = c;
                cities.AppendChild(city);
            }

            Program.doc.Save("Logistic.xml");

            Route tmp = new Route(this.Name.Text);
            Logist.Route.routes.Add(tmp);
            foreach (string c in this.Cities.Text.Split(' '))
            {
                City tmpCity = null;

                foreach(City a in Logist.City.cities)
                {
                    if (a.ToString().Equals(c))
                    {
                        tmpCity = a;
                        break;
                    }
                }

                if (tmpCity == null)
                {
                    tmpCity = new City(c);
                }

                tmp.addCity(tmpCity);
                Logist.City.cities.Add(tmpCity);
            }

            refer.addRow();

            this.Close();
        }
    }
}
