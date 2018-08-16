using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace ObserverPattern
{
    //Events
    public abstract class BoxEvents
    {
        //public abstract string GetJumpForce();
        public abstract Vector3 getcoordinate();
    }


   /* public class JumpLittle : BoxEvents
    {
        public override string GetJumpForce()
        {

            return "alex";
        }
    }


    public class JumpMedium : BoxEvents
    {
        public override string GetJumpForce()
        {
            return "josh";
        }
    }


    public class JumpHigh : BoxEvents
    {
        public override string GetJumpForce()
        {
            return "name";
        }
    }*/
    public class CubeCheck : BoxEvents
    {
        /*public override string GetJumpForce()
        {
            return "works";
        }*/
        public override Vector3 getcoordinate()
        {

            //this is supossed to return a variable that stores a vector 3
            Vector3 cubePosition1;
            cubePosition1 = new Vector3(4, 1, 4);
            
            return cubePosition1;
        }
    }
}