using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character : MonoBehaviour
{
    
    CharacterController characterController;
    public float speed = 6.0f;
    public float jumpSpeed = 8.0f;
    public float gravity = 20.0f;
    private Vector3 moveDirection = Vector3.zero;
    public float Power = 10000.0f;
    public float Radius = 100.0f;
    public Vector3 vec = new Vector3(2,2,0);

    Rigidbody rb;
    // Start is called before the first frame update
    void Start()
    {
        characterController = GetComponent<CharacterController>();
        rb = GetComponent<Rigidbody>();

    }
    void CheckExplode()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            Debug.Log("Boom");
            rb.AddExplosionForce(Power,vec,Radius);

        }

    }
    // Update is called once per frame
    void Update()
    {

        if (characterController.isGrounded)
        {
            moveDirection = new Vector3(Input.GetAxis("Horizontal"), 0f, Input.GetAxis("Vertical"));
            moveDirection *= speed;
            if (Input.GetKeyDown(KeyCode.Space))
            {
                moveDirection.y = jumpSpeed;
            }
        }

        //Gravity
        moveDirection.y -= gravity*Time.deltaTime;
        characterController.Move(moveDirection*Time.deltaTime);
        CheckExplode();
    }
}
