using System.Collections;
using System.Linq;
using System.Collections.Generic;
using UnityEngine;

public class Visitor_Bee_Colorless : Visitor_Bee
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
            colors[key] = false;
        }
    }

    protected override void ChangeColor(string bulletColor)
    {
        try
        {
            colors[bulletColor] = true;
        }
        catch (System.Exception error)
        {
            Debug.LogWarning(error.Message);
        }
    }

    #endregion

}
