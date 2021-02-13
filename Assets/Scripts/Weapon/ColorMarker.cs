using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorMarker : MonoBehaviour
{
    #region Fields
    bool isColoring = false;
    bool timer = false;
    float startTime;
    
    SpriteRenderer sr;
    Weapon_Pistol weapon_Pistol;
    #endregion

    #region Properties
    public string Color { get; private set; }

    public Color SpriteColor
    {
        get { return sr.color; }
    }
    #endregion

    #region Methods
    void Awake()
    {
        sr = GetComponent<SpriteRenderer>();
        weapon_Pistol = GetComponent<Weapon_Pistol>();
    }
    // Start is called before the first frame update
    void Start()
    {
        
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
                Color = "violet";
                sr.color = new Color32(127, 0, 255, 255);
            }
            else if (color == "orange")
            {
                Color = "orange";
                sr.color = new Color32(252, 147, 3, 255);
            }
            else if (color == "green")
            {
                Color = "green";
                sr.color = UnityEngine.Color.green;
            }
            else if (color == "red")
            {
                Color = "red";
                sr.color = UnityEngine.Color.red;
            }
            else if (color == "blue")
            {
                Color = "blue";
                sr.color = UnityEngine.Color.blue;
            }
            else if (color == "yellow")
            {
                Color = "yellow";
                sr.color = UnityEngine.Color.yellow;
            }
        }
        
    }
    #endregion

}
