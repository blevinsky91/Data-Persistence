using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GermanShepard : Dog
{ 
    void OnAwake()
    {
        Bark();
    }
    public override void Bark()
    {
        Debug.Log("Ruff Ruff!");
    }
}
