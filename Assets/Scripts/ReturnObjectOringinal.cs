using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class ReturnToOriginalLocation : MonoBehaviour
{
    public Vector3 originalLocation;

    private void Start()
    {
        originalLocation = transform.position;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("TeleportObject"))
        {
            // Volver a la ubicación original
            transform.position = originalLocation;
        }
    }
}
