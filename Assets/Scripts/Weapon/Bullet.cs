using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    #region Fields


    // values
    Vector2 direction;
    string color;
    float velocity;
    #endregion

    #region Properties
    public string Color
    {
        get { return color; }
        set { color = value; }
    }

    public Vector2 Direction
    {
        get { return direction; }
        set { direction = value; }
    }

    public float Velocity
    {
        get { return velocity; }
    }

    #endregion

    #region Methods
    // Start is called before the first frame update
    void Start()
    {
        velocity = 20f;
        direction = transform.right;
    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnCollisionEnter2D(Collision2D coll)
    {
        Destroy(gameObject);
    }
    #endregion

}
