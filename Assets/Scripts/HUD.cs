using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System;

public class HUD : MonoBehaviour
{
    public GameObject[] vidas;
    [SerializeField] private GameObject menuGameOver;

    public void DesactivarVidas(int indice)
    {

        if (indice <= 0)
        {
            menuGameOver.SetActive(true);
        }
        vidas[indice].SetActive(false);

    }

    public void ActivarVida(int indice)
    {
        vidas[indice].SetActive(true);
    }
    // Start is called before the first frame update


}
