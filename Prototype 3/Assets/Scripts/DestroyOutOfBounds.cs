using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOutOfBounds : MonoBehaviour
{
    public float leftBouds = 15;

    // Update is called once per frame
    void Update()
    {
        if(transform.position.x < leftBouds)
        {
            DestroyOutOfBounds(this.gameObject);
        }
    }
}
