using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectCollisions : MonoBehaviour
{
    public bool hitDetection;

    // Start is called before the first frame update
    void Start()
    {
        hitDetection = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter(Collider other)
    {
        hitDetection = true;
        Destroy(gameObject);
        Destroy(other.gameObject);
    }
}
