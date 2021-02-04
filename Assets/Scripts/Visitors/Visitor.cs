using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Visitor : MonoBehaviour
{
    #region Fields
    protected Dictionary<string, bool> colors;
    protected Dictionary<string, string> oppositeColors;

    float velocity;
    #endregion

    #region Properties

    #endregion

    #region Methods
    // Start is called before the first frame update
    protected virtual void Start()
    {
        colors = new Dictionary<string, bool>();
        oppositeColors = new Dictionary<string, string>
        {
            ["green"] = "red",
            ["orange"] = "blue",
            ["violet"] = "yellow",
            ["red"] = "green",
            ["blue"] = "orange",
            ["yellow"] = "violet"
        };
    }

    // Update is called once per frame
    void Update()
    {

    }

    protected abstract void ChangeColor(string color);

    void OnCollisionEnter2D(Collision2D coll)
    {
        Bullet bullet = coll.gameObject.GetComponent<Bullet>();
        ChangeColor(bullet.Color);
    }
    #endregion

}
