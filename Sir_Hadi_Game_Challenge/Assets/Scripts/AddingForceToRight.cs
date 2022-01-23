using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AddingForceToRight : MonoBehaviour
{
    public Rigidbody RbObjectR;
    public Rigidbody RbObjectL;
    // Start is called before the first frame update
    void Start()
    {
        RbObjectR = GetComponent<Rigidbody>();
        RbObjectL = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        RbObjectR.AddForce(Vector3.right,ForceMode.Impulse);
        RbObjectL.AddForce(Vector3.left, ForceMode.Impulse);
    }
}
