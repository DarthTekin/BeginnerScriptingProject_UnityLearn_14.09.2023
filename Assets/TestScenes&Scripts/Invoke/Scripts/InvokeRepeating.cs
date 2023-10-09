using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InvokeRepeating : MonoBehaviour
{
    public GameObject[] targets;

    // Start is called before the first frame update
    IEnumerator Start()
    {
        InvokeRepeating("SpawnObjects", 3f, 1f);

        yield return new WaitForSeconds(10f);

        CancelInvoke("SpawnObjects");
    }

    // Update is called once per frame
    void SpawnObjects()
    {
        float x = Random.Range(-2f, 2f);
        float z = Random.Range(-2f, 2f);
        int rTarget = Random.Range(0, targets.Length);
        Instantiate(targets[rTarget], new Vector3(x, 3, z), Quaternion.identity);
    }
}
