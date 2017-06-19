using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Logist
{
    public partial class AllRoutes : Form
    {
        Main parent;
        private int i=0;
        public AllRoutes(Main parent)
        {
            InitializeComponent();
            this.parent = parent;
        }

  
        public void DrawList()
        {
            foreach(Route r in Logist.Route.routes)
            {
                Object[] mas = new object[3];
                mas[0] = ++i;
                mas[1] = r.getName();
                string list = "";
                foreach(var a in r.getCities())
                {
                    list+= a.ToString()+"-";
                }
                mas[2]=list.Substring(0, list.Length - 1);

                this.table.Rows.Add(mas);
            }

        }

        private void add(object sender, EventArgs e)
        {
            new NewRoute(this).Show();
        }

        public void addRow()
        {
            Route r = Logist.Route.routes[i];
            Object[] mas = new object[3];
            mas[0] = ++i;
            mas[1] = r.getName();
            string list = "";
            foreach (var a in r.getCities())
                {
                    list += a.ToString() + "-";
                }
            mas[2] = list.Substring(0, list.Length - 1);

            this.table.Rows.Add(mas);
            parent.setCity();
         }
        
    }
}
