using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner_Visitor_Down : Spawner_Visitor
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

        GameObject randomVisitor = Instantiate(randomVisitorPrefab, spawnPosition, Quaternion.identity);
        randomVisitor.AddComponent<Mover_Down>();
        randomVisitor.GetComponent<Visitor_Bee_FullColor>().enabled = true;
    }
    #endregion

}
