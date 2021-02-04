using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletColorMarker : MonoBehaviour
{
    #region Fields
    bool isColoring = false;
    bool timer = false;
    float startTime;
    string color;
    SpriteRenderer sr;
    #endregion

    #region Properties
    public string Color
    {
        get { return color; }
    }

    public Color SpriteColor
    {
        get { return sr.color; }
    }
    #endregion

    #region Methods
    // Start is called before the first frame update
    void Start()
    {
        sr = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        // Changing bullet color controller (Start)
        bool wPressed = Input.GetAxis("Shoot_red") > 0;
        bool dPressed = Input.GetAxis("Shoot_blue") > 0;
        bool aPressed = Input.GetAxis("Shoot_yellow") > 0;


        if (!wPressed && !dPressed && !aPressed)
            isColoring = false;

        if (!timer && (wPressed || dPressed || aPressed))
        {
            timer = true;
            startTime = Time.time;
        }

        if (timer && Time.time - startTime > 0.05)
        {
            timer = false;

            if (wPressed && dPressed)
            {

                ChangeSelfColor("violet");
            }
            else if (wPressed && aPressed)
            {
                ChangeSelfColor("orange");
            }

            else if (aPressed && dPressed)
            {
                ChangeSelfColor("green");
            }

            else if (wPressed)
            {
                ChangeSelfColor("red");
            }

            else if (dPressed)
            {
                ChangeSelfColor("blue");
            }

            else if (aPressed)
            {
                ChangeSelfColor("yellow");
            }


        }
        // Changing bullet color controller (End)
    }

    void ChangeSelfColor(string color)
    {
        if (!isColoring)
        {
            isColoring = true;

            if (color == "violet")
            {
                this.color = "violet";
                sr.color = new Color32(127, 0, 255, 255);
            }
            else if (color == "orange")
            {
                this.color = "orange";
                sr.color = new Color32(252, 147, 3, 255);
            }
            else if (color == "green")
            {
                this.color = "green";
                sr.color = UnityEngine.Color.green;
            }
            else if (color == "red")
            {
                this.color = "red";
                sr.color = UnityEngine.Color.red;
            }
            else if (color == "blue")
            {
                this.color = "blue";
                sr.color = UnityEngine.Color.blue;
            }
            else if (color == "yellow")
            {
                this.color = "yellow";
                sr.color = UnityEngine.Color.yellow;
            }
        }
        
    }
    #endregion

}
