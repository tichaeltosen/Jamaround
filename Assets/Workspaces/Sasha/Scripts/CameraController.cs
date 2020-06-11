﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{

    public Transform target;

    public Vector3 offset;

    public bool useOffsetValues;

    public float rotateSpeed = 1.0f;

    // Start is called before the first frame update
    void Start()
    {
        if (!useOffsetValues)
        {
            offset = target.position - transform.position;
        }

        // pivot.transform.position = target.transform.position;
        // pivot.transform.parent = target.transform;
        
    }

    // Update is called once per frame
    void LateUpdate()
    {
        //get x position of the mouse and rotate target
        float horizontal = Input.GetAxis("Mouse X") * rotateSpeed;
        target.Rotate(0, horizontal, 0);

        float vertical = Input.GetAxis("Mouse Y") * rotateSpeed;
        target.Rotate(-vertical, 0, 0);

        //move the camera based on current rotation of target and original offset
        float desiredYAngle = target.eulerAngles.y;
        float desiredXAngle = target.eulerAngles.x;

        Quaternion rotation = Quaternion.Euler(desiredXAngle, desiredYAngle, 0);
        transform.position = target.position - (rotation * offset);

        // transform.position = target.position - offset;

        transform.LookAt(target);
    }
}
