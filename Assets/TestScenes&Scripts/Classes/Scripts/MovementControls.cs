using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class MovementControls : MonoBehaviour
{
    public float speed;
    public float turnSpeed;

    // Update is called once per frame
    void Update()
    {
        Movement();
    }
    void Movement()
    {
        float forwardMovement = Input.GetAxis("Horizontal") * speed * Time.deltaTime;
        float turnMovement = Input.GetAxis("Vertical") * turnSpeed * Time.deltaTime;

        transform.Translate(Vector3.forward * forwardMovement);
        transform.Rotate(Vector3.up * turnMovement);
    }
}
