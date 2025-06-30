using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BrickSway : MonoBehaviour
{
    
    public float range = 1f;
    private bool check = true;
    private Vector2 direction = new Vector2 (0.2f, 0);
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (check)
        {
            transform.localPosition = direction;
            range -= 0.2f;
            if (range == -1f)
            {
                check = false;
            }
            Debug.Log($"{range}");
            
        }
        else 
        {
            transform.localPosition = -direction;
            range += 0.2f;
            if (range == 1f) {
                check = true;
            }
            Debug.Log($"{range}");
        }

    }
}
