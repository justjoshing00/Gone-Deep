using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class coordinatecheck : MonoBehaviour {
    Vector3 Position;
    Vector3 cubePosition1;

    
    




        // Update is called once per frame 

        private void Start()
        {

            transform.position = new Vector3(3, 1, 4);
            Position = transform.position;// wasted variable, unused 
            cubePosition1 = new Vector3(4, 1, 4);


        }
        void Update()
        {
            if ( transform.position == cubePosition1)
            {
                Debug.Log("we did it");
            }
        }
    }

