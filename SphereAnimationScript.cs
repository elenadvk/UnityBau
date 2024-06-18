using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SphereAnimationScript : MonoBehaviour
{
    private Animator characterAnimator;
    public AudioSource tickSource;

    void Start()
    {
        tickSource = GetComponent<AudioSource>();
    }
    
    private void Awake()
    {
        characterAnimator = GetComponent<Animator>();
    }
    private void Update()
    {
        if (Input.GetKeyUp(KeyCode.L))
            characterAnimator.SetTrigger("SphereAnimTrigger");
    }
    
    void OnTriggerEnter(Collider destroy_player)
    {
        Debug.Log(destroy_player.gameObject);
        if (destroy_player.gameObject.CompareTag("DestroyEnemy"))
        {
            tickSource.Play();
            Destroy(destroy_player.gameObject);
        }
    }


}