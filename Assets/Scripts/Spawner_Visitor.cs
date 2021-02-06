using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Spawner_Visitor : MonoBehaviour
{
    #region Fields
    [SerializeField]
    protected GameObject[] visitorPrefabs;

    Timer spawnTimer;
    
    #endregion

    #region Properties

    #endregion

    #region Methods
    // Start is called before the first frame update
    void Start()
    {
        spawnTimer = gameObject.AddComponent<Timer>();
        spawnTimer.Duration = 4f;
        spawnTimer.Run();
    }

    // Update is called once per frame
    void Update()
    {
        if (spawnTimer.Finished)
        {
            GameObject randomVisitorPrefab = visitorPrefabs[Random.Range(0, visitorPrefabs.Length)];
            SpawnVisitor(randomVisitorPrefab); 
            spawnTimer.Run();
        }
    }

    protected abstract void SpawnVisitor(GameObject randomVisitorPrefab);
    #endregion
}
