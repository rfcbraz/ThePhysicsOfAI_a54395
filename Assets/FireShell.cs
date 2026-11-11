using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class FireShell : MonoBehaviour
{
public GameObject bullet;
public GameObject turret;

    void CreateBullet()
    {
        Instantiate(bullet, turret.transform.position, turret.transform.rotation);
    }
    
    void CalculateTragectory()
    {
        // Calculate the trajectory of the bullet based on the turret's rotation
        // You can add your own logic here to adjust the trajectory if needed
    }

   
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            //CalculateTragectory();
            CreateBullet();
        }
    }
}
