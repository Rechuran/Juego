using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TeleportObject : MonoBehaviour
{
    public Transform destinationLocation;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            // Teleportar al jugador a la ubicación de destino
            collision.transform.position = destinationLocation.position;
        }
    }
}
