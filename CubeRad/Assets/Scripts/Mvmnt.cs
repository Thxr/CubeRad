using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mvmnt : MonoBehaviour
{
    public Rigidbody rb;
    
    void FixedUpdate()
    {
        rb.AddForce(2000 * Time.deltaTime, 0, 0);
    }
}
