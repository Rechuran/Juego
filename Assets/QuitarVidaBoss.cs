using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuitarVidaBoss : MonoBehaviour
{

    private Animator animator;
    private Rigidbody2D rd;

    private void Start()
    {
        animator = GetComponent<Animator>();
    }
    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Player") )
        {
   
            animacion();
            GameManager.Instance.PerderVida();
            Destroy(gameObject,0.4f);
            

        } else if (other.gameObject.CompareTag("Limites") || other.gameObject.CompareTag("Arma"))
        {
 
            animacion();
            Destroy(gameObject, 0.4f);


        }
    }

    void animacion()
    {
        animator.SetBool("Collider", true);
    }

}