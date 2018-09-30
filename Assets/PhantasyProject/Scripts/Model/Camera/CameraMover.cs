using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMover
{

    public Vector3 hoge { get; private set; }

    const float distance = -5f;

    public void Move(Vector3 targetPos)
    {
        hoge = targetPos + Vector3.forward * distance;
    }
}
