using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MapGenerator : MonoBehaviour
{
    public GameObject[] canyonSegment;
    public int zPos = 550;
    public bool creatingSection = false;
    public int secNum;

    // Update is called once per frame
    void Update()
    {
        if (creatingSection == false)
        {
            creatingSection = true;
            StartCoroutine(GenerateSection());
        }
    }

    IEnumerator GenerateSection()
    {
        //secNum = Random.range(0, 3);
        secNum = 1;
        Instantiate(canyonSegment[secNum], new Vector3(0, 0, zPos), Quaternion.identity);
        zPos += 550;
        yield return new WaitForSeconds(2);
    }
}
