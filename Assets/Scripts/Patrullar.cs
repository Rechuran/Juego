using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.Rendering;

public class Patrullar : MonoBehaviour

{

    [SerializeField] private float velocidadMovimiento;
    [SerializeField] private Transform[] puntosMovimientos;
    [SerializeField] private float distanciaMinima;

    private SpriteRenderer spriteRenderer;

    private int numeroAleatorio;

    private bool DeteccionEnemigo;

    private bool choqueParared;

    void Start()
    {
        numeroAleatorio = Random.Range(0, puntosMovimientos.Length);
        spriteRenderer  = GetComponent<SpriteRenderer>();
        Girar();
    }

    private void Update()
    {
        transform.position = Vector2.MoveTowards(transform.position, puntosMovimientos[numeroAleatorio].position,velocidadMovimiento*Time.deltaTime);

        if ((Vector2.Distance(transform.position, puntosMovimientos[numeroAleatorio].position) < distanciaMinima) || choqueParared)
        {

            choqueParared = false;
            numeroAleatorio = Random.Range(0,puntosMovimientos.Length);
            Girar();
            
        }
    }
    // Update is called once per frame
    public void Girar()
    {
        if (transform.position.x < puntosMovimientos[numeroAleatorio].position.x)
        {
            spriteRenderer.flipX = true;
        } else
        {
            spriteRenderer.flipX = false;
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {

        if (collision.CompareTag("Limites"))
        {
            choqueParared = true;
        }
        else
        {
            choqueParared = false;
        }
    }

}
