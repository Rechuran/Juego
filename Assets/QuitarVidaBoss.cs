using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuitarVidaBoss : MonoBehaviour
{

    private Animator animator;
    private Rigidbody2D rd;
    private CircleCollider2D col;

    private void Start()
    {
        animator = GetComponent<Animator>();
    }
    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            GameManager.Instance.PerderVida();
            Destroy(gameObject);
        }
        else if (other.gameObject.CompareTag("Limites"))
        {
            animacion();
            Destroy(gameObject, 0.4f);
        }

        else if (other.gameObject.CompareTag("Bullet"))
        {
            Destroy(gameObject);
        }
    }

    void animacion()
    {
        animator.SetBool("Collider", true);
    }

}