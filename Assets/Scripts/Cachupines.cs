using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class Cachupines : MonoBehaviour
{
    private int rescatados;
    public Text puntuacionText;

    private void Start()
    {
        rescatados = 0;
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            rescatados++;
            puntuacionText.text = rescatados.ToString();
            Destroy(gameObject);
        }
    }
}
