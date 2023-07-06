using System.Collections;
using System.Collections.Generic;

using UnityEngine;

public class MirarPersonaje : MonoBehaviour
{
    public Transform enemigo; // Objeto del enemigo
    public Transform personaje; // Objeto del personaje principal
    public GameObject bala; // Prefab de la bala
    public float velocidadBala; // Velocidad de la bala
    public float tiempoEntreDisparos; // Tiempo en segundos entre cada disparo
    public float distanciaDisparo; // Distancia del disparo desde el centro del enemigo

    private float tiempoUltimoDisparo; // Tiempo del último disparo

    void Update()
    {
        if (Time.time - tiempoUltimoDisparo >= tiempoEntreDisparos) // Verifica si ha pasado el tiempo suficiente desde el último disparo
        {
            Vector3 direccionDisparo = (enemigo.position- personaje.position).normalized;
            Vector3 posicionDisparo = enemigo.position + direccionDisparo * distanciaDisparo;
            GameObject nuevaBala = Instantiate(bala, posicionDisparo, Quaternion.identity);
            nuevaBala.GetComponent<Rigidbody2D>().velocity = direccionDisparo * velocidadBala; // Elimina el signo negativo para que la bala vaya en dirección del personaje
            tiempoUltimoDisparo = Time.time; // Actualiza el tiempo del último disparo
        }
    }
}
