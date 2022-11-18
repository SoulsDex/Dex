using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gunmode : MonoBehaviour
{
       public Transform projectilelauncher;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
         if (Input.GetMouseButtonDown(0))
        {
            Transform newTransform = Instantiate(projectilelauncher, transform.position, transform.rotation);

            Rigidbody newObjectRigidBody = newTransform.GetComponent<Rigidbody>();
            newObjectRigidBody.AddExplosionForce(1000, transform.position - transform.forward - transform.up, 3);
        }
    }
}
