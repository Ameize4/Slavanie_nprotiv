using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform player;
    public float offsetX;

    void Update()
    {
        transform.position =
            new Vector3(player.position.x + offsetX, transform.position.y, transform.position.z); 
    }
}