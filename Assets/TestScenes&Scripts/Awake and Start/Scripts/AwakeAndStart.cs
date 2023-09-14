using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AwakeAndStart : MonoBehaviour
{
    private void Awake()
    {
        Debug.Log("Awake called.");    
    }

    void Start()
    {
        Debug.Log("Start called.");
    }
}
