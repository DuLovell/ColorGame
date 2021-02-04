using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoverDown : Mover
{
    protected override void Start()
    {
        base.Start();
        velocity = 1f;
        direction = -transform.up;
    }
}
