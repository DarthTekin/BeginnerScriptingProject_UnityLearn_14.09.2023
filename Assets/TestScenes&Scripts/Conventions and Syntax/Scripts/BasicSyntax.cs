using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BasicSyntax : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        //This line is there to tell me x position of my object

        /*Hi there!
         * this is two lines!
         * */
        Debug.Log(transform.position.x);

        if (transform.position.x <= 5)
        {
            Debug.Log("I' m about to hit the ground!");
        }
    }
}
