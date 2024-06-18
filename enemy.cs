using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemy : MonoBehaviour
{
    float speed = 3;
    float attackDistance = 10;

    Transform target;
    
    void Start()
    {
        target = GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>();
    }


    void FixedUpdate()
    {
        if (Vector3.Distance(transform.position, target.position) < attackDistance)
        {
            transform.position = Vector3.MoveTowards(transform.position, target.position, speed * Time.fixedDeltaTime);
        }
        
    }
    void OnTriggerEnter(Collider destroy_player)
    {
        if (destroy_player.gameObject.CompareTag("Destroy"))
        {
            Destroy(gameObject);

            //генерация новых
            Instantiate(gameObject, transform.position + new Vector3(Random.Range(-5, 5), 0, Random.Range(-5, 5)), transform.rotation);

        }

    }


}
