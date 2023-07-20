using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.Tilemaps;

public class Patrullar : MonoBehaviour

{

    [SerializeField] private float velocidadMovimiento;
    [SerializeField] private Transform[] puntosMovimientos;
    [SerializeField] private float distanciaMinima;
    

    private SpriteRenderer spriteRenderer;

    private int numeroAleatorio;

    private bool DeteccionEnemigo;

    private bool choquePared;

    private bool isCollidingWithTilemap = false;


    void Start()
    {
        numeroAleatorio = Random.Range(0, puntosMovimientos.Length);
        spriteRenderer  = GetComponent<SpriteRenderer>();
        Girar();
    }

    private void Update()
    {
        transform.position = Vector2.MoveTowards(transform.position, puntosMovimientos[numeroAleatorio].position,velocidadMovimiento*Time.deltaTime);

        if ((Vector2.Distance(transform.position, puntosMovimientos[numeroAleatorio].position) < distanciaMinima) || choquePared)
        {

            
            numeroAleatorio = Random.Range(0,puntosMovimientos.Length);
            Girar();
            choquePared = false;

        }
    }
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
    void OnCollisionEnter2D(Collision2D other)
    {

        if (other.gameObject.CompareTag("Enemigo") || other.gameObject.GetComponent<TilemapCollider2D>())
        {
            choquePared = true;
            isCollidingWithTilemap = true;
        }
        else
        {
            choquePared = false;
            isCollidingWithTilemap = false;
        }
    }

    void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.gameObject.GetComponent<TilemapCollider2D>())
        {
            isCollidingWithTilemap = false;
        }
    }

    public bool IsCollidingWithTilemap()
    {
        return isCollidingWithTilemap;
    }

}
