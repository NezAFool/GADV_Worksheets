using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Player : MonoBehaviour
{



    Rigidbody rb;
    // Start is called before the first frame update
    void Start()
    {
 

    }
    void CheckLineOfSight()
    {
        GameObject[] enemies =  GameObject.FindGameObjectsWithTag("Enemy");
        RaycastHit hit;

        foreach (GameObject enemy in enemies)
        {
            Vector3 vec = enemy.transform.position - transform.position;
            Debug.DrawRay(transform.position, transform.TransformDirection(vec));
            if (Physics.Raycast(transform.position, vec, out hit, 30f))
            {
                if (hit.collider.gameObject.CompareTag("Enemy"))
                {
                    enemy.GetComponent<MeshRenderer>().material.color = Color.green;
                }
                else{
                    enemy.GetComponent<MeshRenderer>().material.color= Color.red;
                }
            }

        }
    }
  
    
    // Update is called once per frame
    void Update()
    {

        CheckLineOfSight();
    }
}
