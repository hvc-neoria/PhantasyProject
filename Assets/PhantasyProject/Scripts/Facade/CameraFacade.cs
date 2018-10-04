using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFacade : MonoBehaviour
{
    public CameraHorizontalForward horizontalForward { get; private set; }
    public Transform trans { get; private set; }
    public CameraMover mover { get; private set; }
    public CameraRotator rotator { get; private set; }
    public CameraView view { get; private set; }

    void Awake()
    {
        horizontalForward = GetComponent<CameraHorizontalForward>();
        trans = transform;
        mover = new CameraMover();
        rotator = new CameraRotator();
        view = GetComponent<CameraView>();

        view.mover = mover;
        view.rotator = rotator;
    }
}
