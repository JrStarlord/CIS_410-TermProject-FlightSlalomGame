using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    GroundSpawner groundSpawner;

    void Start()
    {
        groundSpawner = GameObject.FindObjectOfType<GroundSpawner>();
    }

    void OnTriggerExit (Collider other)
    {
        groundSpawner.SpawnTile();
        Destroy(gameObject, 5);
    }

}
