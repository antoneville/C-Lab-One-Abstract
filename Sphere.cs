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
    }
}