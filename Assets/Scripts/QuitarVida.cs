using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuitarVida : MonoBehaviour
{
    public MovEnemigo estatico;
    public float tiempo = 1f;
    private Animator animator;

    private void Start()
    {
        animator = GetComponent<Animator>();
    }
    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            animator.SetBool("IsAttack", true);
            estatico.enabled = false;
            GameManager.Instance.PerderVida();
            StartCoroutine(DetenerPorTiempo(tiempo));
            

        }
    }

    private IEnumerator DetenerPorTiempo(float tiempo)
    {
        yield return new WaitForSeconds(tiempo);
        estatico.enabled = true;
        animator.SetBool("IsAttack", false);
    }
}