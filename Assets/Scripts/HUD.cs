using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System;
using System.Runtime.CompilerServices;

public class HUD : MonoBehaviour
{
    public GameObject[] vidas;
    [SerializeField] private GameObject menuGameOver;
    private GameObject enemigo;

    private void Start()
    {
        enemigo = GameObject.FindGameObjectWithTag("Enemigo");
    }
    public void DesactivarVidas(int indice)
    {

        if (indice <= 0)
        {
            menuGameOver.SetActive(true);
            Destroy(enemigo);
        }
        if (indice >= 0)
        {
            vidas[indice].SetActive(false);
        }
        

    }

    public void ActivarVida(int indice)
    {
        vidas[indice].SetActive(true);
    }
    // Start is called before the first frame update


}
