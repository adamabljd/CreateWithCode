using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerX : MonoBehaviour
{
    public GameObject dogPrefab;
    public float spawnWaitTime = 0f;
    public float waitDuration = 0.4f;

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (Time.time > spawnWaitTime)
            {
                Instantiate(dogPrefab, transform.position, dogPrefab.transform.rotation);
                spawnWaitTime = Time.time + waitDuration;
            }
        }


    }
}
