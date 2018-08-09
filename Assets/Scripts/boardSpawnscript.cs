using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class boardSpawnscript : MonoBehaviour {

    public Transform Board;
	// Use this for initialization
	void Start ()
    {



       Instantiate(Board, transform.position, transform.rotation);
    }
	
	
}
