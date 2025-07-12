using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEditor.AssetImporters;
using UnityEngine;

public class CheckCollision : MonoBehaviour
{
    Rigidbody rb;
    MeshRenderer mat;
    public Color color;
    // Start is called before the first frame update
    
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        mat = GetComponent<MeshRenderer>();
    }
    public void OnCollisionEnter(Collision Sphere)
    {
        if (Sphere.gameObject.CompareTag("Sphere"))
        {
            mat.material.color = color;
            Debug.Log("Change");
        }
        
    }
    public void OnCollisionExit(Collision collision)
    {
        if (rb != null) 
        {
            mat.material.color = Color.red;
        }
    }
}
