using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using jp.hateblo.neoria.Utility;

public class PlayerInput
{

    const string hAxisName = "Horizontal";
    const string vAxisName = "Vertical";
    const string hSubAxisName = "SubHorizontal";
    const string vSubAxisName = "SubVertical";

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

    public Vector2 subAxisVector
    {
        get
        {
            return new Vector2(
                Input.GetAxis(hSubAxisName),
                Input.GetAxis(vSubAxisName)
            );
        }
    }
}
