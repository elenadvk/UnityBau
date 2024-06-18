using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject prefab;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Player"))
        {
            Instantiate(gameObject, transform.position + new Vector3(Random.Range(-5, 5), 0, Random.Range(-5, 5)), transform.rotation);
            Destroy(gameObject);
        }
    }
}
