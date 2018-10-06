using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraRotator
{
    public Quaternion rotation { get; private set; }

    public void LookAt(Vector3 pos, Vector3 targetPos)
    {
        Vector3 dir = targetPos - pos;
        rotation = Quaternion.LookRotation(dir);
    }
}
