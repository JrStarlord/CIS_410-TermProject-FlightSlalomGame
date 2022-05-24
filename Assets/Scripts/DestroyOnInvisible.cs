using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOnInvisible : MonoBehaviour
{
    public bool destroySelf = true;
    public GameObject[] destroyObjects;

    void OnBecomeInvisible()
    {
        if(destroySelf)
        {
            Destroy(gameObject);
        }
        foreach(GameObject obj in destroyObjects)
        {
            Destroy(obj);
        }
    }
}
