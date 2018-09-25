using System; 

namespace Object 
{
    //Sphere is a ThreeDShape
    //Derived Class
    class Sphere : ThreeDShape
    {
        //ReadWrite Property to Store radius
        public double radius;
        public double Radius
        {  
            get {return radius;}
            set {radius = value;}
        }
    
        public Sphere (double radiusSet) 
        {
            radius = radiusSet;
        }
        public Sphere()
        {
        }

        public override double calcVolume() 
        {
            double sphereVol = Math.PI * radius * radius * radius;
            return sphereVol;
        }

        public override string ToString() 
        {
            return String.Format("Sphere Information: \nRadius: {0} \nVolume: {1}",this.radius, this.calcVolume());
        }
        public static void Main()
        {
            Sphere fe = new Sphere { radius = 26.4};
            Sphere g = new Sphere { radius = 54.2};
            Console.WriteLine(fe);
            Console.WriteLine(g);
            Console.WriteLine(g.Radius);
            Sphere r = new Sphere { radius = 34};
            Console.WriteLine(g.calcVolume());
        }
    }
}