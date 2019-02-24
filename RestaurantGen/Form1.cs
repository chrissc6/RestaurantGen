using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RestaurantGen
{
    public partial class Form1 : Form
    {
        string[] Gg = new string[] { "McDonalds", "Five Guys", "Qdoba", "Captain Ds", "Gold Star Chili", "Piada", "Arbys", "Currito", "Subway", 
            "Potbelly Sandwich", "Penn Station", "Taco Casa", "Skyline Chili", "Chick-fil-A", "Rasing Canes", "Steak n Shake", "Jersey Mikes",
            "Chipotle", "Wendys", "Fusian", "Taco Bell", "Burger King", "Frischs", "White Castle", "Long John Silvers", "Jack in the Box"};
        string[] Pz = new string[] { "LaRosas", "Donatos", "Deweys", "Dominos", "Pizza Hut", "Goodfellas" };
        string[] Dn = new string[] { "PF Changs", "Rusty Bucket", "Buffalo Wild Wings", "Bonefish Grill", "J Alexanders", "Bravo",
            "Seasons 52", "Boston Market", "Panera Bread", "Cheesecake Factory", "Red Robin", "IHop", "Texas Roadhouse", "Bob Evans",
            "Waffle House", "BJs", "Frenchie Fresh" };
        int clicks = 0;

        bool GgOnly = false;
        bool PzOnly = false;
        bool DnOnly = false;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            clicks++;
            label5CLICKS.Text = clicks.ToString();

            Random rng = new Random();
            int g;
            g = rng.Next(0, 3);
            int x;
            string[] p;

            g = CheckSelect(g);
            x = GetName1(g);
            p = GetName2(g);

            int y;
            y = rng.Next(0, x);

            string c = p[y];

            label2.Text = c;
        }

        private int CheckSelect(int g)
        {
            int z = 0;

            if(GgOnly == true)
            {
                z = 0;
                return z;
            }
            else if(PzOnly == true)
            {
                z = 1;
                return z;
            }
            else if(DnOnly == true)
            {
                z = 2;
                return z;
            }
            else
            {
                z = g;
                return z;
            }
        }

        private string[] GetName2(int x)
        {
            string[] c;

            switch (x)
            {
                case 0:
                    c = Gg;
                    return c;
                case 1:
                    c = Pz;
                    return c;
                case 2:
                    c = Dn;
                    return c;
                default:
                    c = null;
                    return c;

            }
        }

        private int GetName1(int x)
        {

            switch (x)
            {
                case 0:
                    x = Gg.Length;
                    return x;
                case 1:
                    x = Pz.Length;
                    return x;
                case 2:
                    x = Dn.Length;
                    return x;
                default:
                    x = 0;
                    return x;
                    
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            GgOnly = false;
            PzOnly = false;
            DnOnly = false;

            if (comboBox1.Text == "Grab & Go")
            {
                GgOnly = true;
            }
            else if(comboBox1.Text == "Pizza")
            {
                PzOnly = true;
            }
            else if(comboBox1.Text == "Dine Out")
            {
                DnOnly = true;
            }
            else if(comboBox1.Text == "Any & All")
            {
                GgOnly = false;
                PzOnly = false;
                DnOnly = false;
            }
        }
    }
}
