﻿using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform playerTransform;
    public int depth = -2;

    // Update is called once per frame
    void Update()
    {
        if (playerTransform != null)
        {
            transform.position = playerTransform.position + new Vector3(0, 4, depth);
        }
    }

    public void setTarget(Transform target)
    {
        playerTransform = target;
    }
}