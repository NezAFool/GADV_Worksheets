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
        bool token = true;
        bool noToken = false;
        PlayerExplode player = new PlayerExplode(10);
        player.TakeDamage(3);
        player.getHealth(2);
        player.TakeDamage(1);

        Projectile projectile = new Projectile(0f);
        projectile.Fire();
        ScoreTracker score1 = new ScoreTracker(10);
        TreasureChest ancient = new AncientChest();
        TreasureChest magic = new MagicChest();
        ancient.Unlock(token);
        ancient.shake();
        magic.Unlock(noToken);
        magic.shake();
        Explodable explodable = new Explodable();
        
        

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
