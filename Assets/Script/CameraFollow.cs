using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour {

    [SerializeField]
    private Transform player;
    private float cameraX;
    private float cameraZ;

    public float y = 10;
    public float z = 5;

    void Update()
    {
        if (player)
        {
            cameraX = player.position.x;
            cameraZ = player.position.z;
            this.transform.position = new Vector3(cameraX, y, cameraZ + z);
        }
    }
}
