using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class inputscript : MonoBehaviour
{
    List<Vector3> iList = new List<Vector3>(1);


    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Up"))
        {
            transform.Translate(Vector3.up * Time.deltaTime);

        }
        if (Input.GetButtonDown("Down"))
        {
            transform.Translate(Vector3.down * Time.deltaTime);
        }
        if (Input.GetButtonDown("Left"))
        {
            transform.Translate(Vector3.left);
            iList.Add(transform.position);
            Debug.Log(iList[0]);
        }
        if (Input.GetButtonDown("Right"))
        {
            transform.Translate(Vector3.right);
        }
        //if (Input.GetButtonDown("Word"))
        //{
           // Debug.Log("boom");
        //}
    }


}

