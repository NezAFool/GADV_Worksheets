using System;
using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;

public class Main : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Player player = new Player(10);
        player.TakeDamage(3);
        player.getHealth(2);
        player.TakeDamage(1);

        Projectile projectile = new Projectile(0f);
        projectile.Fire();
        ScoreTracker score1 = new ScoreTracker(10);
        TreasureChest ancient = new AncientChest();
        ancient.Unlock();
        ancient.shake();
        
        

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
