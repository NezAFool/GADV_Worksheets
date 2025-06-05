using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerExpolde : MonoBehaviour
{
    CharacterController controller;
    public float Power = 10000.0f;
    public float Radius = 100.0f;
    public Vector3 vec = Vector3.zero;
    
    Rigidbody rb;
    
    void Start()
    {
        controller = GetComponent<CharacterController>();
        controller.detectCollisions = false;
    }
    void CheckExplode()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            Debug.Log("Boom");
            rb.AddForce(Vector3.forward, ForceMode.Force);

        }
        
    }

    
    void Update()
    {
        CheckExplode();


    }
}
