using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Visitor : MonoBehaviour
{
    #region Fields
    protected Dictionary<string, bool> colors;
    protected Dictionary<string, string> oppositeColors;

    protected SpriteRenderer sr;
    float velocity;
    #endregion

    #region Properties

    #endregion

    #region Methods
    void Awake()
    {
        sr = GetComponent<SpriteRenderer>();

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

    // Start is called before the first frame update
    protected virtual void Start()
    {
        AddSpriteColors();
        ChangeSpriteColor();
    }

    
    
    // Update is called once per frame
    void Update()
    {

    }

    protected abstract void ChangeSpriteColor(string bulletColor = default);
    protected abstract void AddSpriteColors();

    void OnCollisionEnter2D(Collision2D coll)
    {
        Bullet bullet = coll.gameObject.GetComponent<Bullet>();
        ChangeSpriteColor(bullet.Color);
    }

    void OnBecameInvisible()
    {
        Destroy(gameObject);
    }
    #endregion

}
