using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;

public class Bala : MonoBehaviour
{

    [SerializeField] private float velocidad;
    [SerializeField] private float da�o;

    private void Update()
    {
        transform.Translate(Vector2.up * velocidad * Time.deltaTime);

    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Enemigo"))
        {
            other.GetComponent<Enemigo>().TomarDa�o(da�o);
            Destroy(gameObject);
        }
    }
}
