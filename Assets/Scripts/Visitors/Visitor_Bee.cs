using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Visitor_Bee : Visitor
{
    [SerializeField]
    Sprite beeColored;

    [SerializeField]
    Sprite beeRed;

    [SerializeField]
    Sprite beeYellow;

    [SerializeField]
    Sprite beeGray;


    protected abstract void SetSpriteColorsValues();

    protected override void AddSpriteColors()
    {
        colors.Add("orange", true);
        colors.Add("red", true);
        SetSpriteColorsValues();
    }

    protected override void ChangeSpriteColor(string bulletColor)
    {
        if (bulletColor != default)
            ChangeColor(bulletColor);

        try
        {
            // change sprite to match colors in "colors" Dictionary
            if (colors["orange"] && colors["red"])
                sr.sprite = beeColored;
            else if (!colors["orange"] && !colors["red"])
                sr.sprite = beeGray;
            else if (!colors["orange"] && colors["red"])
                sr.sprite = beeRed;
            else if (colors["orange"] && !colors["red"])
                sr.sprite = beeYellow;
        }
        catch (Exception)
        {
            
        }
        
    }

    protected abstract void ChangeColor(string bulletColor);

}
