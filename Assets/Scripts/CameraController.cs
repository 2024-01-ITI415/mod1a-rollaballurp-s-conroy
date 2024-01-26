using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
//Player GameObject

    public GameObject player;

//Distance between camera and player

    private Vector3 offset;

    // Start is called before the first frame update
    void Start()
    {
// Calculate initial offset between camera's position
        offset = transform.position - player.transform.position;
    }

    // Update is called once per frame
    void LateUpdate()
    {
// Maintain same offset between camera and player
        transform.position = player.transform.position + offset;
    }
}
