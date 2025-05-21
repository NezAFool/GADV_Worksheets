using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AsteroidColourTinter : MonoBehaviour
{
    private bool oringinal = true;
void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (oringinal)
            {
                // Access the SpriteRenderer component
                SpriteRenderer spriteRenderer = GetComponent<SpriteRenderer>();

                // Change the color to blue
                spriteRenderer.color = Color.blue;
                oringinal = false;
            }
            else
            {
                SpriteRenderer spriteRenderer = GetComponent<SpriteRenderer>();

                // Change the color to blue
                spriteRenderer.color = Color.white;
                oringinal = true;
            }
        }
    }

}
