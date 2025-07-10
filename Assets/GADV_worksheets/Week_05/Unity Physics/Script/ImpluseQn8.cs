using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ImpluseQn8 : MonoBehaviour
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
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            Pulse = new Vector3(0, 0, Force);
            rb.AddForce(Pulse, ForceMode.Impulse);
        }
        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            Pulse = new Vector3(0, 0, -Force);
            rb.AddForce(Pulse, ForceMode.Impulse);
        }
        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            Pulse = new Vector3(-Force, 0, 0);
            rb.AddForce(Pulse, ForceMode.Impulse);
        }
        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            Pulse = new Vector3(Force, 0, 0);
            rb.AddForce(Pulse, ForceMode.Impulse);
        }
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Pulse = new Vector3(0, Force, 0);
            rb.AddForce(Pulse, ForceMode.Impulse);
        }
    }
}
