using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour {
    
    public float turnSpeed = 150f;
    public float movementSpeed = 15f;

    private void Update()
    {

        float x = Input.GetAxisRaw("Horizontal") * Time.deltaTime * movementSpeed;
        float z = Input.GetAxisRaw("Vertical")* Time.deltaTime * turnSpeed;

        transform.Rotate(0, x, 0);
        transform.Translate(0, 0, z);
    }
}
