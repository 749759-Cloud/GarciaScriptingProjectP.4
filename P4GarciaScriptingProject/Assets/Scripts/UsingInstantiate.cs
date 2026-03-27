using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UsingInstantiate : MonoBehaviour
{
    public Rigidbody bulletPrefab;
    public Rigidbody barellEnd;


    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            Rigidbody rocketInstance;
            bulletInstance = Instantiate(bulletPrefab, barellEnd.position, barellEnd.rotation) as Rigidbody;
            bulletInstance.AddForce(barellEnd.forward * 500);
        }
    }
}
