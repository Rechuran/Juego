using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class HUD : MonoBehaviour
{

    public GameObject[] vidas;

    public void DesactivarVidas(int indice)
    {
        vidas[indice].SetActive(false);

    }

    public void ActivarVida(int indice)
    {
        vidas[indice].SetActive(true);
    }
    // Start is called before the first frame update


}
