using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerX : MonoBehaviour
{
    public GameObject dogPrefab;
    public float seconds = 1.0f;

    // Update is called once per frame
    void Update()
    {
        // On spacebar press, send dog
        if (Input.GetKeyDown(KeyCode.Space) && seconds >= 1.0)
        {
            Instantiate(dogPrefab, transform.position, dogPrefab.transform.rotation);
            seconds = 0;
        }

        seconds += Time.deltaTime;
    }
}
