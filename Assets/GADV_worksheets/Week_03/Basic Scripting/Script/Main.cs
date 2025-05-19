using System;
using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class Main : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Player player = new Player(10);
        player.TakeDamage(3);

        Projectile projectile = new Projectile(0f);
        projectile.Fire();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
