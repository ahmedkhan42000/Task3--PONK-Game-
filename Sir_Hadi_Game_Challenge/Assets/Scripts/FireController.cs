using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireController : MonoBehaviour
{
    private float speed = 10;
    private Vector3 temp;

    // Start is called before the first frame update
    void Start()
    {

    }
     
    // Update is called once per frame
    void Update()
    {
        //transform.Translate(Vector3.up * Time.deltaTime * speed);
        temp = transform.localScale;
        temp.y = speed * Time.deltaTime + temp.y;
        transform.localScale = temp;
    }
}
