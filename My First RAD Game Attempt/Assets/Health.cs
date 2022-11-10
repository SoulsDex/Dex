using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour
{
    float currentTime = 0;
    float MAXTIME = 10;

    int myHealth = 100;


    // Start is called before the first frame update
    void Start()
    {
        currentTime = +Time.deltaTime;
        if (currentTime > MAXTIME)
            Destroy(gameObject);
    }

    // Update is called once per frame
    void Update()
    {


    }

    internal void takeDamage(int amountOfDamage)
    {

        myHealth -= amountOfDamage;
        if (myHealth <= 0)
        {
            Rigidbody myRigigBody = GetComponent<Rigidbody>();
            Destroy(myRigigBody);
            print("IM DEAD");
           
        
        }

        print("You hurt me with" + amountOfDamage.ToString());
      
    }
}
