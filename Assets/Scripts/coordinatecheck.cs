using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class coordinatecheck : MonoBehaviour {

    
    




        // Update is called once per frame 

        private void Start()
        {

            transform.position = new Vector3(3, 1, 4);
        }
        void Update()
        {
            if (transform.position( == Vector3(4,1,4))
            {
                Debug.Log("we did it");
            }
        }
    }

