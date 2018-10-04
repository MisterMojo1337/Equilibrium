using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    public float turnSpeed = 4.0f;
    public Transform player;

    private Vector3 offset;

    void Start()
    {
        offset = new Vector3(0, 20, -30);
    }

    void LateUpdate()
    {
        if (Input.GetMouseButton(0))
        {
            offset = Quaternion.AngleAxis(Input.GetAxis("Mouse X") * turnSpeed, Vector3.up) * offset;
        }
        transform.position = player.position + offset;
        transform.LookAt(player.position);
    }
}
