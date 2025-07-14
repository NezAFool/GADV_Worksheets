using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Block : MonoBehaviour
{
    public float blockHealth = 20f;
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.relativeVelocity.magnitude > 0.5) 
        {
            blockHealth -= collision.relativeVelocity.magnitude;
        }
        if (blockHealth <= 0) 
        { 
            Destroy(gameObject);
            GameObject[] boxes = GameObject.FindGameObjectsWithTag("Boxes");
            if (boxes.Length <= 1)
            {
                SceneManager.LoadScene("Main");
            }
        }
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
