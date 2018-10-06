using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerRotator
{
    public Quaternion rotation { get; private set; }

    public void LookAt(Vector2 input, Vector3 direction)
    {
        if (Mathf.Abs(input.x) < 0.01f && Mathf.Abs(input.y) < 0.01f)
        {
            return;
        }
        var inputVector3 = new Vector3(input.x, 0, input.y);
        rotation = Quaternion.LookRotation(direction) * Quaternion.LookRotation(inputVector3);
    }
}
