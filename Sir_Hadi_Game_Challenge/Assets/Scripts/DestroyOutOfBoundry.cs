using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOutOfBoundry : MonoBehaviour
{
    private float TopBound = 15;
    private float LowBound = -2;
    private float RightBound = 7;
    private float LeftBound = -7;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.y > TopBound)
        {
            Destroy(gameObject);
        }
        if (transform.position.y < LowBound)
        {
            Destroy(gameObject);

        }
        //if (transform.position.x > LeftBound)
        //{
        //    Destroy(gameObject);
        //}

    }
}
