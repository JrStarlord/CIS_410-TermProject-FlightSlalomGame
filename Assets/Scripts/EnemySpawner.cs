using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    [SerializeField] public GameObject[] EnemyPrefabs;
    public int enemyVerticalOffset = Random.Range(1,40);

    private Transform playerTransform;
    private float spawnZ = 500.0f;
    private int numEnemiesOnScreen = 6;
    private List<GameObject> activeEnemies = new List<GameObject>();
    private float safeZone = 600.0f;
    private int lastPrefabIndex = 0;

    private int enemyCount = 0;

    private void LateUpdate()
    {
        if (playerTransform.position.z - safeZone > (spawnZ - numEnemiesOnScreen * 1))
        {
            SpawnTile();
            DeleteTile();
        }
    }

    private void DeleteTile()
    {
        Destroy(activeEnemies[0]);
        activeEnemies.RemoveAt(0);
    }

    private void SpawnTile(int prefabIndex = -1)
    {
        GameObject goGoGadgit;
        if (prefabIndex == -1)
            goGoGadgit = Instantiate(EnemyPrefabs[RandomPrefabIndex()]) as GameObject;
        else
            goGoGadgit = Instantiate(EnemyPrefabs[prefabIndex]) as GameObject;


        goGoGadgit.transform.SetParent(transform);
        goGoGadgit.transform.position = new Vector3(Vector3.forward.x * spawnZ, Vector3.forward.y * spawnZ - enemyVerticalOffset, Vector3.forward.z * spawnZ);


        spawnZ += spawnZ;
        activeEnemies.Add(goGoGadgit);
        enemyCount++;
    }
    private int RandomPrefabIndex()
    {
        if (EnemyPrefabs.Length <= 1)
        {
            return 0;
        }
        int randomIndex = lastPrefabIndex;
        while (randomIndex == lastPrefabIndex)
        {
            randomIndex = Random.Range(0, EnemyPrefabs.Length);
        }
        lastPrefabIndex = randomIndex;
        return randomIndex;
    }
}
