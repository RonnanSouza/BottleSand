using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sleeper : MonoBehaviour
{
    private float CreatedFrame;

    // Start is called before the first frame update
    void Start()
    {
        CreatedFrame = Time.timeSinceLevelLoad;
    }

    // Update is called once per frame
    void Update()
    {
        if (Time.timeSinceLevelLoad - CreatedFrame >= 3 && GetComponent<Rigidbody2D>().velocity.magnitude <= 0.01)
        {
            Destroy(GetComponent<Rigidbody2D>());
            Destroy(this);
        }
    }
}
