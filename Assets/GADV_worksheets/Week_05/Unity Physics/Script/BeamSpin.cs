using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BeamSpin : MonoBehaviour
{
    Rigidbody rb;
    public float force = 10f;
    private Vector3 Pulse;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Z))
        {
            Pulse = new Vector3(0,force,0);
            rb.AddTorque(Pulse, ForceMode.Impulse);
        }
        if (Input.GetKeyDown(KeyCode.X))
        {
            Pulse = new Vector3(0, -force, 0);
            rb.AddTorque(Pulse, ForceMode.Impulse);
        }
    }
}
