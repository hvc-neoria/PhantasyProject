using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraView : MonoBehaviour
{

    public CameraMover mover { get; set; }

    Transform myTrans;

    void Awake()
    {
        myTrans = transform;
    }
    public void ApplyPosition()
    {
        myTrans.position = mover.hoge;
    }
}
