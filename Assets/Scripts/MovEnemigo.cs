using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Animations;

public class MovEnemigo : MonoBehaviour
{
    public float velocidadMovimiento = 3f;
    public float rangoActivacion = 5f;
    public Transform jugador;

    private bool estaActivo = false;
    private Vector3 direccionMovimiento;
    private HUD hud;

    public Patrullar patrullar;

    public bool getActivo()
    {
        return estaActivo;
    }
    private void Start()
    {
        jugador = GameObject.FindGameObjectWithTag("Player").transform;
    }

    private void Update()
    {
        float distanciaJugador = Vector3.Distance(transform.position, jugador.position);

        if (!estaActivo && distanciaJugador < rangoActivacion)
        {
            patrullar.enabled = false;
            estaActivo = true;

        }

        if (estaActivo)
        {
            MoverEnemigo();
        }
    }

    private void MoverEnemigo()
    {
        if (jugador != null)
        {
            direccionMovimiento = (jugador.position - transform.position).normalized;
        }
        else
        {
            direccionMovimiento = Random.insideUnitCircle.normalized;
        }

        transform.position += direccionMovimiento * velocidadMovimiento * Time.deltaTime;
    }


}
