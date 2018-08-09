using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class badColliderScript : MonoBehaviour {
   



    // Update is called once per frame 

    private void Start()
    {
        
        transform.position = new Vector3(0, 1, 0);
    }
    void Update()
    {
        if (transform.position.x == 1 && transform.position.z == 1)
        { 
            Debug.Log("we did it");
        }
    }
}
