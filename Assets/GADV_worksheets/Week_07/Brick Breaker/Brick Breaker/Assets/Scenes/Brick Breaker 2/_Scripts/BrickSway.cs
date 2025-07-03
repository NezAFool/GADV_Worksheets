using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BrickSway : MonoBehaviour
{

    private float moveSpeed = 2f;  // Speed of horizontal movement
    public float moveLimit = 3f;  // Maximum distance from start pos
    private Vector3 startPos;
    public int direction = 1;  // 1 = right, -1 = left

    float initialXPos;
    float factor = 5f;

    void Start()
    {
        initialXPos = transform.position.x;   
    }

    // Update is called once per frame
    void Update()
    {
        //float newX = initialXPos + Mathf.Sin(Time.time) * factor;
        //transform.position = new Vector3(newX, transform.position.y, transform.position.z);

        transform.position += new Vector3(direction * moveSpeed * Time.deltaTime, 0, 0);
        if (Mathf.Abs(transform.position.x - startPos.x) >= moveLimit)
        {
            direction *= -1; // Reverse direction
        }

    }
}
