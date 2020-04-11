using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door2 : MonoBehaviour
{
    private Animator animator;
    void Start()
    {
       animator = GetComponent <Animator>();
    }

   
    void Update()
    {
        
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            animator.SetBool("Open", true);
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            animator.SetBool("Open", false);
        }
    }
}

