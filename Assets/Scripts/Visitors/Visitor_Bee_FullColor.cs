using System;
using System.Linq;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Visitor_Bee_FullColor : Visitor_Bee
{
    #region Fields

    #endregion

    #region Properties

    #endregion

    #region Methods
    protected override void SetSpriteColorsValues()
    {
        foreach (string key in colors.Keys.ToList())
        {
            colors[key] = true;
        }
    }

    protected override void ChangeColor(string bulletColor)
    {
        try
        {
            colors[oppositeColors[bulletColor]] = false;
        }
        catch (Exception error)
        {
            Debug.LogWarning(error.Message);
        }

    }
    #endregion

}
