using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IsColliding : MonoBehaviour
{
    public string[] tags;
    public GameObject explosion;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter(Collider other)
    {
        foreach(string tag in tags)
        {
            if (other.tag == tag)
            {
                Instantiate(explosion, transform.position, Random.rotation);
                Destroy(gameObject);
            }

        }

    }
}
