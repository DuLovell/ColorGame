using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorWeapon : MonoBehaviour
{
    #region Fields
    [SerializeField]
    GameObject bulletPrefab;

    GameObject bullet;
    BulletColorMarker bulletColorMarkerScript;
    #endregion

    #region Propeties

    #endregion

    #region Methods
    void Start()
    {
        bulletColorMarkerScript = transform.Find("BulletColorMarker").GetComponent<BulletColorMarker>();
    }

    void Update()
    {
        // Getting mouse position in world coordinates
        Vector3 screenMousePosition = Input.mousePosition;
        Vector3 worldMousePosition = Camera.main.ScreenToWorldPoint(screenMousePosition);

        // Getting direction Weapon should point
        Vector3 aimDirection = (worldMousePosition - transform.position).normalized;
        float angle = Mathf.Atan2(aimDirection.y, aimDirection.x) * Mathf.Rad2Deg;
        transform.eulerAngles = new Vector3(0, 0, angle);

        if (Input.GetButtonDown("Fire1"))
        {
            ShootBullet(aimDirection);
        }
    }

    private void ShootBullet(Vector3 direction)
    {
        bullet = Instantiate(bulletPrefab, transform.position, Quaternion.identity);
        
        Bullet bulletScript = bullet.GetComponent<Bullet>();
        Rigidbody2D bulletRB = bullet.GetComponent<Rigidbody2D>();
        SpriteRenderer bulletSr = bullet.GetComponent<SpriteRenderer>();

        bulletSr.color = bulletColorMarkerScript.SpriteColor;
        bulletScript.Color = bulletColorMarkerScript.Color;
        bulletRB.AddForce(direction * 20f, ForceMode2D.Impulse);
    }
    #endregion
}
