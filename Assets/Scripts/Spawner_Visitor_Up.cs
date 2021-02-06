using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner_Visitor_Up : Spawner_Visitor
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
        Vector3 spawnPosition = new Vector3(-4, ScreenUtils.ScreenBottom - colliderHalfWidth - 1.5f);

        GameObject randomVisitor = Instantiate(randomVisitorPrefab, spawnPosition, Quaternion.identity);
        randomVisitor.AddComponent<Mover_Up>();
        randomVisitor.GetComponent<Visitor_Bee_Colorless>().enabled = true;

        
    }
    #endregion

}
