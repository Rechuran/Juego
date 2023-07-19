using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Experimental.Playables;
using UnityEngine.Rendering;

public class DestruccionBala : MonoBehaviour
{
    [SerializeField] private float daño;

    private void OnTriggerEnter2D(Collider2D collision)
    {

        if (collision.CompareTag("Limites"))
        {
            Destroy(gameObject);
        }
        else if (collision.CompareTag("Enemigo"))
        {
            collision.GetComponent<Enemigo>().TomarDaño(daño);
            Destroy(gameObject);
        }
        else if (collision.CompareTag("Boss"))
        {
            collision.GetComponent<EnemyBoss1>().TomarDaño(daño);
            Destroy(gameObject);
        }

    }

}