using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletSpawnController : MonoBehaviour
{
    #region Fields
    [SerializeField]
    GameObject bulletPrefab;

    Bullet bulletScript;
    Sprite[] bulletColorSprites;

    bool isShooting;
    float startTime;
    bool timer = false;
    #endregion

    #region Methods
    void Awake()
    {
        isShooting = false;
    }
    void Start()
    {
        /* sprites[0] - blue,
           sprites[1] - green,
           sprites[2] - orange,
           sprites[3] - red,
           sprites[4] - violet,
           sprites[5] - yellow */

        bulletColorSprites = Resources.LoadAll<Sprite>("Bullets");

    }

    void Update()
    {
        bool wPressed = Input.GetAxis("Shoot_red") > 0; // note, not keydown
        bool dPressed = Input.GetAxis("Shoot_blue") > 0;
        bool aPressed = Input.GetAxis("Shoot_yellow") > 0;

        
        if (!wPressed && !dPressed && !aPressed)
            isShooting = false;

        if (!timer && (wPressed || dPressed || aPressed))
        {
            timer = true;
            startTime = Time.time;
        }

        if (timer && Time.time - startTime > 0.05)
        {
            timer = false;
            if (wPressed && dPressed)
                InstantiateBullet("violet", 4);
            else if (wPressed && aPressed)
                InstantiateBullet("orange", 2);
            else if (aPressed && dPressed)
                InstantiateBullet("green", 1);
            else if (wPressed)
                InstantiateBullet("red", 3);
            else if (dPressed)
                InstantiateBullet("blue", 0);
            else if (aPressed)
                InstantiateBullet("yellow", 5);
        }
        
    }

    public GameObject InstantiateBullet(string color = "red", int idx = 3)
    {
        if (!isShooting)
        {
            isShooting = true;

            GameObject bullet = Instantiate(bulletPrefab, transform.position, Quaternion.identity);
            SpriteRenderer bulletSr = bullet.GetComponent<SpriteRenderer>();

            bulletScript = bullet.GetComponent<Bullet>();
            bulletScript.Color = color;
            bulletSr.sprite = bulletColorSprites[idx];
            return bullet;
        }
        return null;
            
    }
    #endregion

}
