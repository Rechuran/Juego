using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;
using System;
public class GameManager : MonoBehaviour
{

    [SerializeField] private GameObject menuGameOver;
    public static GameManager Instance { get; private set; }
    private int vidas = 3;
    private int enemigosEliminados = 0;
    [SerializeField] private GameObject portalNivel2;

    [SerializeField] private GameObject portalBoss;

    
    
    public HUD hud;
  

    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
        }
        else
        {
            Debug.Log("HOLA");
        }
    }

    public void PerderVida()
    {

        if (vidas < 1)
        {
            menuGameOver.SetActive(true);
            
        }
        else
        {
            vidas -= 1;
            hud.DesactivarVidas(vidas);
        }
        
    }

    public void ActivarBoss()
    {
        enemigosEliminados += 1;
        
        if (enemigosEliminados == 50 || enemigosEliminados == 100)
        {
            portalBoss.SetActive(true);
        }
    }

    public void cambioNivel()
    {
        portalNivel2.SetActive(true);
    }

    public static int score = 0;

}
