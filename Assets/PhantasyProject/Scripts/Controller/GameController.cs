using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
    PlayerInput input = new PlayerInput();

    [SerializeField] PlayerFacade player;
    [SerializeField] CameraFacade cam;

    void Update()
    {
        player.rotator.LookAt(input.axisVector, cam.horizontalForward.horizontalForward);
        player.view.ApplyRotation();
        player.mover.Move(input.axisVector, cam.horizontalForward.horizontalForward);
        player.view.ApplyPosition();
    }

    void LateUpdate()
    {
        cam.mover.Move(player.trans.position + Vector3.up * PlayerParameter.lookedHeight, input.subAxisVector);
        cam.view.ApplyPosition();
        cam.rotator.LookAt(cam.trans.position, player.trans.position + Vector3.up * PlayerParameter.lookedHeight);
        cam.view.ApplyRotation();
    }
}
