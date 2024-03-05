using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LabRet : Dog
{
    void OnAwake()
    {
        Bark();
    }
    public override void Bark()
    {
        Debug.Log("Arf Arf");
    }
}
