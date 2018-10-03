using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace jp.hateblo.neoria.Utility
{
    public static class SphericalCoordinater
    {

        public static Vector3 SphericalCoordinate(float radius, float xzDeg, float yDeg)
        {
            float xz = xzDeg * Mathf.Deg2Rad;
            float y = yDeg * Mathf.Deg2Rad;
            Vector3 result = new Vector3(
                radius * Mathf.Sin(xz) * Mathf.Sin(y),
                radius * Mathf.Cos(xz),
                radius * Mathf.Sin(xz) * Mathf.Cos(y)
            );
            return result;
        }
    }
}