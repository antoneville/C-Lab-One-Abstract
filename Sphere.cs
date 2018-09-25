using System; 

namespace Object 
{
    //Sphere is a ThreeDShape
    //Derived Class
    class Sphere : ThreeDShape
    {
        //ReadWrite Property to Store radius
        public double radius { get; set; }
    
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

        static void testing() 
        {
            Sphere fe = new Sphere(26.4);
            Console.WriteLine(fe);
            fe.calcVolume();
        }    
    }
}