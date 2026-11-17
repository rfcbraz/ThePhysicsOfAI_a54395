using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class AIShell : MonoBehaviour
{ 
public GameObject explosion;
Rigidbody rb;

void OnCollisionEnter(Collision col)
{
    if (col.gameObject.tag == "tank")
    {
        GameObject exp = Instantiate(explosion, transform.position, Quaternion.identity);
        Destroy(exp, 0.5f);
        Destroy(this.gameObject);
    }
}

void Start()
    {
        rb = this.GetComponent<Rigidbody>();

    }

void Update()
    {
        transform.Translate(Vector3.forward * Time.deltaTime * 20f);
        this.transform.forward = rb.linearVelocity;
    }
}