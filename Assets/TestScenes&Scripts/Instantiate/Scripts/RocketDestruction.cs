using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RocketDestruction : MonoBehaviour
{
    //public float rocketSpeed = 10f;
    //Rigidbody rb;

    private void Awake()
    {
        //rb = GetComponent<Rigidbody>();
    }

    // Start is called before the first frame update
    void Start()
    {
        RocketMove();
    }

    void RocketMove()
    {
        //rb.AddForce(Vector3.up * rocketSpeed);
        Destroy(gameObject, 7f);
    }
}
