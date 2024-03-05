using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pitbull : Dog
{
    void OnAwake()
    {
        Bark();
    }

    public override void Bark()
    {
        Debug.Log("Bark Bark");
    }
}
