using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuitarVida : MonoBehaviour
{
    public MovEnemigo estatico;
    public float tiempo = 1f;
    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            estatico.enabled = false;
            GameManager.Instance.PerderVida();
            StartCoroutine(DetenerPorTiempo(tiempo));
            
        }
    }

    private IEnumerator DetenerPorTiempo(float tiempo)
    {
        yield return new WaitForSeconds(tiempo);
        estatico.enabled = true;
    }
}