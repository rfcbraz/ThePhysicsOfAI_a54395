using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class MoveShell : MonoBehaviour
{

    float speed = 1.0f  ;
    void Start()
    {
        
    }
    

    void Update()
    {
        this.transform.Translate(0, 0, Time.deltaTime * speed);
    }
}
