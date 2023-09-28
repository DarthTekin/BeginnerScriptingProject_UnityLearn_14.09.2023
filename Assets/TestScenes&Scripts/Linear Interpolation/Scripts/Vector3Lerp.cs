using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Vector3Lerp : MonoBehaviour
{
    Vector3 startVector = Vector3.zero;
    Vector3 endVector = new Vector3(10f, 10f, 10f);
    float turnspeed = 25f;
    Renderer renderer;
    MeshRenderer meshRenderer;
    Material material;

    // Start is called before the first frame update
    void Start()
    {
        transform.position = Vector3.Lerp(startVector, endVector, .5f);
        meshRenderer = GetComponent<MeshRenderer>();
        //material = GetComponent<Material>();
        meshRenderer.material.color = Color.Lerp(Color.blue, Color.black, 0.5f * Time.deltaTime);
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(Vector3.up * -turnspeed * Time.deltaTime);
        //meshRenderer.material.color = Color.Lerp(Color.blue, Color.black, 0.5f * Time.deltaTime);
    }
}
