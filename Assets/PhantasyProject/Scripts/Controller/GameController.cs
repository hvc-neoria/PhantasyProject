using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
    PlayerInput input = new PlayerInput();
    PlayerMover playerMover = new PlayerMover();
    PlayerRotator playerRotator = new PlayerRotator();
    [SerializeField] Transform playerTrans;

    [SerializeField] CameraHorizontalForward cameraHorizontalForward;
    [SerializeField] Transform cameraTrans;
    CameraMover cameraMover = new CameraMover();
    CameraRotator cameraRotator = new CameraRotator();

    [SerializeField] PlayerView playerView;
    [SerializeField] CameraView cameraView;

    void Awake()
    {
        playerView.rotator = playerRotator;
        playerView.mover = playerMover;
        cameraView.mover = cameraMover;
        cameraView.rotator = cameraRotator;
    }

    void Update()
    {
        playerRotator.LookAt(input.axisVector, cameraHorizontalForward.horizontalForward);
        playerView.ApplyRotation();
        playerMover.Move(input.axisVector, cameraHorizontalForward.horizontalForward);
        playerView.ApplyPosition();
    }

    void LateUpdate()
    {
        cameraMover.Move(playerTrans.position + Vector3.up * PlayerParameter.lookedHeight, input.subAxisVector);
        cameraView.ApplyPosition();
        cameraRotator.LookAt(cameraTrans.position, playerTrans.position + Vector3.up * PlayerParameter.lookedHeight);
        cameraView.ApplyRotation();
    }
}
