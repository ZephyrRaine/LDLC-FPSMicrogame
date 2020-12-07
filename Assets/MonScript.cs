using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MonScript : MonoBehaviour
{
    // Assign a Rigidbody component in the inspector to instantiate
    public Rigidbody projectile;

    private void Start()
    {
        Debug.Log("Lancement du programme.");
    }

    void Update()
    {
        // Ctrl was pressed, launch a projectile
        if (Input.GetButtonDown("Fire1"))
        {
            // Instantiate the projectile at the position and rotation of this transform
            Rigidbody clone;
            clone = Instantiate(projectile, transform.position, transform.rotation);

            // Give the cloned object an initial velocity along the current
            // object's Z axis
            clone.velocity = transform.TransformDirection(Vector3.back * 45);
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log("Il y a une collision !");
    }
}
