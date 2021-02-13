using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    #region Fields
    #endregion

    #region Properties
    public string Color { get; set; }

    public Vector2 Direction { get; set; }

    public float Velocity { get; private set; }

    #endregion

    #region Methods
    // Start is called before the first frame update
    void Start()
    {
        Velocity = 20f;
        Direction = transform.right;
    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnCollisionEnter2D(Collision2D coll)
    {
        Destroy(gameObject);
    }

    void OnBecameInvisible()
    {
        Destroy(gameObject);
    }
    #endregion

}
