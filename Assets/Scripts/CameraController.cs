using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    public GameObject player;
    private float camY,camZ;
    // Start is called before the first frame update
    void Start()
    {
       camY = transform.position.y;
       camZ = transform.position.z;
    }

    // Update is called once per frame
    void Update()
    {
        float camX = player.transform.position.x;       

        transform.position = new Vector3(camX, camY, camZ);
    }
}
