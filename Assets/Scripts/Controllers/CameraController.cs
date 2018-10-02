using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{

    public GameObject player;
    public float x = 5;
    public float y = -10;
    public float z = 5; 

    private Vector3 offset;

    void Start()
    {
        offset = player.transform.position - new Vector3(5, -10, 5);
    }

    void LateUpdate()
    {
        transform.position = player.transform.position + offset;
    }
}
