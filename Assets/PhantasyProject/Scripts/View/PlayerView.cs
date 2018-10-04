using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerView : MonoBehaviour
{
    public PlayerMover mover { get; set; }
    public PlayerRotator rotator { get; set; }

    Transform myTrans;

    void Awake()
    {
        myTrans = transform;
    }

    public void ApplyPosition()
    {
        myTrans.position += mover.moveVector;
    }
    public void ApplyRotation()
    {
        myTrans.rotation = rotator.rotation;
    }
}
