using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
    PlayerInput input = new PlayerInput();

    PlayerFacade player;
    CameraFacade cam;

    void Awake()
    {
        player = GameObject.FindWithTag("Player").GetComponent<PlayerFacade>();
        cam = GameObject.FindWithTag("MainCamera").GetComponent<CameraFacade>();
    }

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
