using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MathfLerp : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        float result = Mathf.Lerp(3f, 5f, .5f);
        Debug.Log("Result: " + result);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
