using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
    PlayerInput input = new PlayerInput();
    PlayerMover mover = new PlayerMover();

    [SerializeField] PlayerView view;

    void Awake()
    {
        view.mover = mover;
    }

    void Update()
    {
        mover.Move(input.axisVector, Vector3.forward);
        view.ApplyPosition();
    }
}
