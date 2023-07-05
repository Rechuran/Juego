using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Teletransporte : MonoBehaviour
{
    public GameObject portalSalida;
    private GameObject playerGO;

    private void Start()
    {
        playerGO = GameObject.FindGameObjectWithTag("Player");

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        playerGO.transform.position = portalSalida.transform.position - new Vector3(0,0.7f,0);
    }
}