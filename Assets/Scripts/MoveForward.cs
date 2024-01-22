using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveForward : MonoBehaviour
{
    public float speed = 40.0f;
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        //apply a forward vector to objects
        transform.Translate(Vector3.forward * Time.deltaTime * speed);
    }
}
