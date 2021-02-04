using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VisitorDownSpawner : VisitorSpawner
{
    #region Fields

    #endregion

    #region Properties

    #endregion

    #region Methods
    protected override void SpawnVisitor(GameObject randomVisitorPrefab)
    {
        Collider2D collider = randomVisitorPrefab.GetComponent<Collider2D>();
        float colliderHalfWidth = collider.bounds.extents.y;
        Vector3 spawnPosition = new Vector3(4, ScreenUtils.ScreenTop + colliderHalfWidth + 1.5f);
        randomVisitorPrefab.AddComponent<MoverDown>();

        Instantiate(randomVisitorPrefab, spawnPosition, Quaternion.identity);
    }
    #endregion

}
