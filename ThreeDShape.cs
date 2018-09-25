using System;

namespace Object
{
    //Implementing an abstract class
    abstract class ThreeDShape
    {
        //public read-only property for Sphere
        public readonly Sphere sphere;

        //Overloaded Constructor
        public ThreeDShape (Sphere s)
        {
            sphere = s;
        }

        //Default Constructor
        public ThreeDShape ()
        {

        }

        //Overriding the ToString method that is inherited from System.Object
        public override string ToString() 
        {
            string sphereInfo = String.Format("The Sphere: {0}", this.sphere);
            return sphereInfo;
        }

        public abstract double calcVolume();
        
    }
}
