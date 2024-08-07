using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOutOfBonds : MonoBehaviour
{
    private float topBound = 6;
    private float lowerBound = -6;
    private float sideBound = 10;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.y > topBound)
        {
            Destroy(gameObject);
            
        }
        if (transform.position.y < lowerBound)
        {
            Destroy(gameObject);
        }
        if (transform.position.x > sideBound)
        {
            Destroy(gameObject);
        }
        if (transform.position.x < -sideBound)
        {
            Destroy(gameObject);
        }
    }
}
