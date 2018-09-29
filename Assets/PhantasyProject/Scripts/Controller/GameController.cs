using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
    PlayerInput input = new PlayerInput();
    PlayerMover mover = new PlayerMover();

    [SerializeField] CameraHorizontalForward cameraHorizontalForward;

    [SerializeField] PlayerView view;

    void Awake()
    {
        view.mover = mover;
    }

    void Update()
    {
        mover.Move(input.axisVector, cameraHorizontalForward.horizontalForward);
        view.ApplyPosition();
    }
}
