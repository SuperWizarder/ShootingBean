using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform player;

    public Vector3 upCam;
    void Update()
    {
        upCam = new Vector3(0, 1, 0);

        transform.position = player.transform.position + upCam;
    }
}
