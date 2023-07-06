using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestruirBala : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {

        if (collision.CompareTag("Limites"))
        {

            Destroy(gameObject);
        }
    }
}