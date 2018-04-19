using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PolymorphismCircularShapesLib;
using MetroFramework;


namespace IntroToPolymorphism
{
    public partial class Form1 : MetroFramework.Forms.MetroForm
    {
        List<CircularShapes>circularShapesList = new List<CircularShapes>();
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCreateCircle_Click(object sender, EventArgs e)
        {
            Random rand = new Random();
            double radius = rand.Next(2, 20) + rand.NextDouble();
            //create a circle
            Circle circle = new Circle(radius);
            circularShapesList.Add(circle);
            Display(circle);
        }

        private void btnCreateCylinder_Click(object sender, EventArgs e)
        {
            Random rand = new Random();
            double radius = rand.Next(2, 20) + rand.NextDouble();
            double height = rand.Next(3, 30) + rand.NextDouble();

            Cylinder cylinder = new Cylinder(radius,height);
            circularShapesList.Add(cylinder);
            Display(cylinder);
        }

        private void btnCreateShpere_Click(object sender, EventArgs e)
        {
            Random rand = new Random();
            double radius = rand.Next(2, 20) + rand.NextDouble();

            Sphere sphere = new Sphere(radius);
            circularShapesList.Add(sphere);
            Display(sphere);
        }

        private void btnCreateCone_Click(object sender, EventArgs e)
        {
            Random rand = new Random();
            double radius = rand.Next(2, 20) + rand.NextDouble();
            double height = rand.Next(3, 30) + rand.NextDouble();

            Cone cone = new Cone(radius, height);
            circularShapesList.Add(cone);
            Display(cone);
        }

        private void Display(CircularShapes cs)
        {
            string[] items =
            {
                cs.GetType().Name,
                cs.R.ToString("f3"), 
                cs.H.ToString("f3"),
                cs.Perimeter().ToString("f3"),
                cs.Area().ToString("f3"),
                cs.Volume().ToString("f3")
            };
            ListViewItem lvi = new ListViewItem(items);
            //add the row to the listview
            listView1.Items.Add(lvi);
            //cause the listview1 to scroll to the bottom
            //by making the last item visible
            listView1.EnsureVisible(listView1.Items.Count - 1);
        }
    }
}
