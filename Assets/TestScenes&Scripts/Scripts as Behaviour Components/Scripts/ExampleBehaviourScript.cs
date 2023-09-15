using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExampleBehaviourScript : MonoBehaviour
{  
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.R))
        {
            GetComponent<Renderer>().material.color = Color.red;
        }
        
        if (Input.GetKeyUp(KeyCode.G))
        {
            GetComponent<Renderer>().material.color = Color.green;
        }

        if (Input.GetKeyUp(KeyCode.B))
        {
            GetComponent<Renderer>().material.color = Color.blue;                
        }
    }
}
