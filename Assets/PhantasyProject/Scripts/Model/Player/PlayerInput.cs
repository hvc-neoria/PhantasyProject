using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using jp.hateblo.neoria.Utility;

public class PlayerInput
{

    const string hAxisName = "Horizontal", vAxisName = "Vertical";
    public Vector2 axisVector
    {
        get
        {
            return SmoothAxisCalculator.GridableToCirclable(
                    Input.GetAxis(hAxisName),
                    Input.GetAxis(vAxisName)
                );
        }
    }
}
