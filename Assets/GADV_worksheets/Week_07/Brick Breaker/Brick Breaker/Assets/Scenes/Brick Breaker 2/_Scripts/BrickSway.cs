using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BrickSway : MonoBehaviour
{
    
    public float range = 5f;
    private bool check = true;
    private Vector2 direction = new Vector2 (0.2f, 0);
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //if (check)
        //{
        //    transform.localPosition = new Vector2 (1,0);
        //    range -= 0.5f;
        //    if (range == -1f)
        //    {
        //        check = false;
        //    }
        //    Debug.Log($"{range}");

        //}
        //else 
        //{
        //    transform.localPosition = new Vector2 (-1,0);
        //    range += 0.5f;
        //    if (range == 1f) {
        //        check = true;
        //    }
        //    Debug.Log($"{range} other way");
        //}
        transform.localPosition = new Vector3(MathF.Sin((1/2)*Time.deltaTime*range), 0);

    }
}
