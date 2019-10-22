using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayerCamera : MonoBehaviour
{
    public GameObject player;

    private Vector3 _offset;

    void Start()
    {
        _offset = new Vector3(1.25f, 2.8f, 0);
    }

    void Update()
    {
        transform.position = player.transform.position + _offset;
        transform.LookAt(player.transform);
    }
}
