using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using jp.hateblo.neoria.Utility;

[System.Serializable]
public class CameraMover
{
    public Vector3 position { get; private set; }

    float degPerSec = 180f;

    const float radius = -5f;
    float xzDeg = 90f;
    float yDeg;

    public void Move(Vector3 targetPos, Vector2 input)
    {
        xzDeg += input.y * degPerSec * Time.deltaTime;
        xzDeg = Mathf.Clamp(xzDeg, 1f, 179f);
        yDeg += input.x * degPerSec * Time.deltaTime;
        Vector3 sphericalPos = SphericalCoordinater.SphericalCoordinate(radius, xzDeg, yDeg);
        position = targetPos + sphericalPos;
    }
}
