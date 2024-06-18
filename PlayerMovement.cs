using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public Transform Cube;
    public Transform Plane2;
    public float speed;
    public int k;
    public Camera[] cameras;
    private int currentCamera=0;

    // public Vector3 direction;  

    private CharacterController characterController;
    void Start()
    {
        characterController = GetComponent<CharacterController>();
        k = 0;
    }

    void Update()
    {
        if(Input.GetKeyUp(KeyCode.E))
        {
            cameras[currentCamera].tag = "Untagged";
            cameras[currentCamera].enabled = false;
            currentCamera = (currentCamera + 1)%2;
            cameras[currentCamera].tag = "MainCamera";
            cameras[currentCamera].enabled = true;
        }
        if (Input.GetKeyUp(KeyCode.A))
        {
            GetComponent<Rigidbody>().velocity = new Vector3(0,0,speed);
        }
        if (Input.GetKeyUp(KeyCode.W))
        {
            // transform.Translate(direction); так падает
            GetComponent<Rigidbody>().velocity = new Vector3(speed,0,0); 
        }
        if (Input.GetKeyUp(KeyCode.S))
        {
            GetComponent<Rigidbody>().velocity = new Vector3(-speed,0,0);
        }
        if (Input.GetKeyUp(KeyCode.D))
        {
            GetComponent<Rigidbody>().velocity = new Vector3(0,0,-speed);
        }
    }
    void OnTriggerEnter(Collider destroy_player)
    {
        if (destroy_player.gameObject.CompareTag("Destroy"))
        {
            Destroy(gameObject);
        }
    }

}
