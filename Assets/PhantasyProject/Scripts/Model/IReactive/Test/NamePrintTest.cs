using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NamePrintTest : MonoBehaviour, IReactive
{
    public void React()
    {
        Debug.Log(gameObject.name);
    }
}
