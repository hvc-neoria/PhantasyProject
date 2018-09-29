using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// todo もっと抽象化しても良さそう
public class CameraHorizontalForward : MonoBehaviour
{
    Transform myTrans;

    public Vector3 horizontalForward
    {
        get
        {
            Vector3 result = myTrans.forward;
            result.y = 0f;
            return result;
        }
    }
    void Awake()
    {
        myTrans = transform;
    }
}
