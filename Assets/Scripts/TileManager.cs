using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TileManager : MonoBehaviour
{
    public GameObject[] tilePrefabs;

    private Transform playerTransform;
    private float spawnZ = -480.0f;
    private float tileLength = 60.0f;

    private int numTilesOnScreen = 8;

    private List<GameObject> activeTiles = new List<GameObject>();

    private float safeZone = 80.0f;

    void Start()
    {
        playerTransform = GameObject.FindGameObjectWithTag("Player").transform;

        for (int i = 0; i < numTilesOnScreen; i++)
        {
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
        goGoGadgit = Instantiate(tilePrefabs[0]) as GameObject;
        goGoGadgit.transform.SetParent(transform);
        goGoGadgit.transform.position = Vector3.forward * spawnZ;
        spawnZ += tileLength;
        activeTiles.Add(goGoGadgit);
    }
}
