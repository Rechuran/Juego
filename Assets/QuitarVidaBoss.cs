using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuitarVidaBoss : MonoBehaviour
{

    private Animator animator;

    private void Start()
    {
        animator = GetComponent<Animator>();
    }
    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            animator.SetBool("Collider", true);    
            GameManager.Instance.PerderVida();
            Destroy(gameObject);

        } else if (other.gameObject.CompareTag("Limites"))
        {
            animator.SetBool("Collider", true);
            Destroy(gameObject);


        }
    }

}