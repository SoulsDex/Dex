using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fall : MonoBehaviour
{
    Rigidbody ourRigidBody;
    // Start is called before the first frame update
    void Start()
    {
        ourRigidBody = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()

        
    {

        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            ourRigidBody.AddExplosionForce(500, transform.position + Vector3.down + Vector3.back, 2);
        }
 
   
    }


    private void OnCollisionEnter(Collision collision)
    {
        print("ouch");
    }


}

