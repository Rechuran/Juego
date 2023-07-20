using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class ActivarBoss : MonoBehaviour
{
    [SerializeField] private GameObject boss;
    private GameObject playerGO;


    private void Start()
    {
        playerGO = GameObject.FindGameObjectWithTag("Player");

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {

        if (collision.CompareTag("Player"))
        {
            boss.SetActive(true);
        }

    }
}
