﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerFocusArea : MonoBehaviour
{
    const string tagName = "FocusTarget";
    public Collider nearestCollider
    {
        get
        {
            Collider result = null;
            float min = 0;
            foreach (var col in colliders)
            {
                float dis = Vector3.Distance(transform.position, col.transform.position);
                if (!result)
                {
                    min = dis;
                    result = col;
                }
                if (dis < min)
                {
                    min = dis;
                    result = col;
                }
            }
            return result;
        }
    }
    List<Collider> colliders = new List<Collider>();

    void OnTriggerEnter(Collider collider)
    {
        if (collider.CompareTag(tagName))
        {
            colliders.Add(collider);
        }
    }
    void OnTriggerExit(Collider collider)
    {
        if (collider.CompareTag(tagName))
        {
            colliders.Remove(collider);
        }
    }
}
