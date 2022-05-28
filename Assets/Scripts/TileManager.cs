using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TileManager : MonoBehaviour
{
    public GameObject[] tilePrefabs;
    public GameObject Portal;

    private Transform playerTransform;
    private float spawnZ = 0.0f;
    public float tileLength;
    private int numTilesOnScreen = 6;
    private List<GameObject> activeTiles = new List<GameObject>();
    private float safeZone = 600.0f;
    private int lastPrefabIndex = 0;

    private int tileCount = 0;

    void Start()
    {
        playerTransform = GameObject.FindGameObjectWithTag("Player").transform;

        for (int i = 0; i < numTilesOnScreen; i++)
        {
            if (i < 2)
                SpawnTile(0);
            else
                SpawnTile();

        }

    }

    private void DeleteTile()
    {
        Destroy (activeTiles [0]);
        activeTiles.RemoveAt (0);
    }

    private void Update() 
    { 
        if (playerTransform.position.z - safeZone > (spawnZ - numTilesOnScreen * tileLength))
        {
            SpawnTile();
            DeleteTile();
        }
    }


    private void SpawnTile(int prefabIndex = -1)
    {
        GameObject goGoGadgit;        
        if (prefabIndex == -1)
            goGoGadgit = Instantiate(tilePrefabs[RandomPrefabIndex()]) as GameObject;
        else
            goGoGadgit = Instantiate(tilePrefabs[prefabIndex]) as GameObject;

        if (tileCount > 5)
        {
            goGoGadgit = Instantiate(Portal) as GameObject;
        }

        goGoGadgit.transform.SetParent(transform);
        //goGoGadgit.transform.position = Vector3.forward * spawnZ;
        goGoGadgit.transform.position = new Vector3(Vector3.forward.x * spawnZ, Vector3.forward.y * spawnZ - 20, Vector3.forward.z * spawnZ);






        spawnZ += tileLength;
        activeTiles.Add(goGoGadgit);
        tileCount++;
    }
    private int RandomPrefabIndex()
    {
        if (tilePrefabs.Length <= 1)
        {
            return 0;
        }
        int randomIndex = lastPrefabIndex;
        while (randomIndex == lastPrefabIndex)
        {
            randomIndex = Random.Range(0, tilePrefabs.Length);
        }
        lastPrefabIndex = randomIndex;
        return randomIndex;
    }
}
