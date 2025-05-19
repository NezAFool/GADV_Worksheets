using System;
using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class Main : MonoBehaviour
{

    public class Projectile
    {
        private float speed = 1f;
        public void projectile(float Speed){
           speed = Speed;
        }
        private void autoFire(float Speed)
        {
            speed = Speed;
            Console.WriteLine("Speed was 0, Auto Fire speed set to 100");
        }
        private void Fire()
        {
            if (speed > 0f)
            {
                Console.WriteLine("Firing Projectile at {Projectile}");
            }
            else if (speed == 0f)
            {
                AutoFire(100f);
            }
            else
            {
                Console.WriteLine("Cannot fire: Speed too low");
            }
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        //Player player = new Player(10);
        //player.TakeDamage(3);

        Projectile projectile = new projectile(1f);
        projectile.Fire();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
