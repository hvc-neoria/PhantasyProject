using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
    PlayerInput input = new PlayerInput();
    PlayerMover playerMover = new PlayerMover();
    [SerializeField] Transform playerTrans;

    [SerializeField] CameraHorizontalForward cameraHorizontalForward;
    CameraMover cameraMover = new CameraMover();

    [SerializeField] PlayerView playerView;
    [SerializeField] CameraView cameraView;

    void Awake()
    {
        playerView.mover = playerMover;
        cameraView.mover = cameraMover;
    }

    void Update()
    {
        playerMover.Move(input.axisVector, cameraHorizontalForward.horizontalForward);
        playerView.ApplyPosition();
    }

    void LateUpdate()
    {
        cameraMover.Move(playerTrans.position);
        cameraView.ApplyPosition();
    }
}
