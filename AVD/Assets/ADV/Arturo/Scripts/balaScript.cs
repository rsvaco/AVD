using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class balaScript : MonoBehaviour
{
    // Start is called before the first frame update

    public Rigidbody rb;
    public float thrust = 100.0f;

    void Start()
    {
        rb.AddForce(0, 0, -thrust, ForceMode.Impulse);
    }

    // Update is called once per frame
    void Update()
    {
       
    }
}
