using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Script1 : MonoBehaviour
{
    //setar o target
    public Transform targt;
    //tempo e velocidade
    public float t;
    public float speed;
    
    void start()
    {

    }

    //update is called once per frame
    void FixedUpdate()
    {
        //setar as posiçoes e mover do ponto a ao ponto b
        Vector3 a = transform.position;
        Vector3 b = targt.position;
        transform.position = Vector3.MoveTowards(a, b, speed);
    }
}
