using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OrbLaunch : MonoBehaviour
{
    public float Force = 10f;
    private Vector3 Pulse;
    Rigidbody rb;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space)) 
        {
            Pulse = new Vector3(0, 0 ,Force);
            rb.AddForce(Pulse, ForceMode.Impulse);
        }
    }
}
