using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControls : MonoBehaviour

    
{

    void Update()
    {
        float xThrow = Input.GetAxis("Horizontal");


        float yThrow = Input.GetAxis("Vertical");
        Debug.Log(xThrow + "," + yThrow);

    }
}
