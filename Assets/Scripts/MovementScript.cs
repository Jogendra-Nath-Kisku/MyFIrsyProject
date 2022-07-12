﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        transform.position = new Vector3(0, 0, 0);
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.D))
        {
        transform.position += new Vector3(1, 0, 0);
        }
        if(Input.GetKeyDown(KeyCode.A))
        {
        transform.position -= new Vector3(1, 0, 0);
        }
        if(Input.GetKeyDown(KeyCode.W))
        {
            transform.position += new Vector3(0, 1, 0);
        }
        if(Input.GetKeyDown(KeyCode.S))
        {
            transform.position -= new Vector3(0, 1, 0);
        }    
        // deactivates and activates visibility of object
        if (Input.GetKeyDown(KeyCode.M))
        {
            if(GetComponent<MeshRenderer>().enabled)
            {
                GetComponent<MeshRenderer>().enabled = false;
            }
            else
            {
                GetComponent<MeshRenderer>().enabled = true;
            }
        }    
        
    }
}
