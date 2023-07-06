using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;

public class DisparosEnemigos : MonoBehaviour
{

    public Transform punto_instancia;
    public GameObject bala;
    private float tiempo;
    public float tiempo_disparo;

    void Update()
    {
        tiempo += Time.deltaTime;
        if (tiempo >= tiempo_disparo)

        
        {
            Instantiate(bala, punto_instancia.position, Quaternion.identity);
            tiempo = 0;
        }
    }

}

