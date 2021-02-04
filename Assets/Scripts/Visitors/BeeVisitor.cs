using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BeeVisitor : Visitor
{
    [SerializeField]
    Sprite beeColored;
    
    [SerializeField]
    Sprite beeRed;
    
    [SerializeField]
    Sprite beeYellow;

    [SerializeField]
    Sprite beeGray;
    protected override void Start()
    {
        base.Start();
        colors.Add("yellow", true);
        colors.Add("red", true);
    }

    protected override void ChangeColor(string bulletColor)
    {
        try
        {
            // reverse color value in "colors" Dictionary
            colors[oppositeColors[bulletColor]] = false;


            // change sprite to match colors in "colors" Dictionary
            SpriteRenderer sr = GetComponent<SpriteRenderer>();
            if (colors["yellow"] && colors["red"])
                sr.sprite = beeColored;
            else if (!colors["yellow"] && !colors["red"])
                sr.sprite = beeGray;
            else if (!colors["yellow"] && colors["red"])
                sr.sprite = beeRed;
            else if (colors["yellow"] && !colors["red"])
                sr.sprite = beeYellow;
        }
        catch (System.Exception error)
        {
            Debug.LogWarning(error.Message);
        }
    }
}
