using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mover : MonoBehaviour
{
    #region Fields
    protected float velocity = 10f;
    protected Vector3 direction;
    Rigidbody2D rb;
    #endregion

    #region Properties

    #endregion

    #region Methods
    // Start is called before the first frame update
    protected virtual void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        rb.velocity = direction * velocity;
    }
    #endregion

}
