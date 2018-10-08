using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerFacade : MonoBehaviour
{
    public PlayerMover mover { get; private set; }
    public PlayerRotator rotator { get; private set; }
    public Transform trans { get; private set; }
    public PlayerView view { get; private set; }
    public PlayerFocusArea focusArea { get; private set; }

    void Awake()
    {
        mover = new PlayerMover();
        rotator = new PlayerRotator();
        trans = transform;
        view = GetComponent<PlayerView>();
        focusArea = GetComponentInChildren<PlayerFocusArea>();

        view.rotator = rotator;
        view.mover = mover;
    }

}
