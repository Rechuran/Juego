using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cachupines : MonoBehaviour
{

    [SerializeField] private GameManager gamemanager;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            gamemanager.cachupinRecuperado();
            Destroy(gameObject);
        }
    }
}
