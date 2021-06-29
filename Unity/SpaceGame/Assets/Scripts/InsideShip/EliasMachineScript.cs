using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

public class EliasMachineScript : MonoBehaviour
{
    public Animator animator;
    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.name == "Elias")
        {
        animator.SetBool("IsMoving", true);
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if(collision.gameObject.name == "Elias")
        {
        animator.SetBool("IsMoving", false);
        }
    }
}
