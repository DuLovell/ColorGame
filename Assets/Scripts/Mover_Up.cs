using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mover_Up : Mover
{
    protected override void Start()
    {
        base.Start();
        velocity = 1f;
        direction = transform.up;
    }
}
