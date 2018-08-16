using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace ObserverPattern
{ 

public abstract class Observer
    {

        public abstract void OnNotify();
    }

public class Cube : Observer
    {
        
        //GameObject boxObj;
        GameObject cube;
    

        BoxEvents boxEvent;

        public Cube(GameObject cube, BoxEvents boxEvent)
        {
            //this.boxObj = boxobj;
            this.cube = cube;
            this.boxEvent = boxEvent;

            //cubePosition1 = new Vector3(4, 1, 4);


        }
        //What the box will do if the event fits it (will always fit but you will probably change that on your own)
        public override void OnNotify()
        {
            //Jump(boxEvent.GetJumpForce());
           
            Check(boxEvent.getcoordinate());
            

        }

        //The box will always jump in this case
        void Check(Vector3 current)// this should take a vector3 variable
        {
            if (cube.transform.position == current)
            {
                Debug.Log(current);
            }
        }
    // {
    //If the box is close to the ground
    //if (boxObj.transform.position.y < 0.55f)
    //  {
    // Debug.Log(jumpforce);
    // Debug.Log("we did it peeps");

    //boxObj.GetComponent().AddForce(Vector3.up * jumpForce);

    // }
    // }

}
}
