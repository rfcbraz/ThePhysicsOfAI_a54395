using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shell : MonoBehaviour
{
    public GameObject explosion;

    float speed = 0f;
    float yspeed = 0f;
    float mass = 10;
    float force = 1;
    float drag = 10;
    float gravity = -9.8f;
    float gAcceleration;
    float acceleration;

    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.tag == "tank")
        {
            GameObject exp = Instantiate(explosion, this.transform.position, Quaternion.identity);
            Destroy(exp, 0.5f);
            Destroy(this.gameObject);
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        acceleration = force / mass;
        speed += acceleration * 1;
        gAcceleration = gravity/mass;
    }

    // Update is called once per frame
    void LateUpdate()
    {
        speed *= (1-Time.deltaTime * drag);
        yspeed += gAcceleration * Time.deltaTime;
        this.transform.Translate(0, yspeed, speed);
    }
}
