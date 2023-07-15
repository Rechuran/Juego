using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEditor.Experimental.GraphView;
using UnityEngine;
using UnityEngine.SceneManagement;
using System;
public class GameManager : MonoBehaviour
{

    [SerializeField] private GameObject menuGameOver;
    [SerializeField] private GameObject jugador;
    public Arma arma;
    public static GameManager Instance { get; private set; }
    private int vidas = 3;

    
    
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

            jugador.SetActive(false); 
            arma.enabled = false;
            menuGameOver.SetActive(true);
            
        }
        else
        {
            vidas -= 1;
            hud.DesactivarVidas(vidas);
        }
        
    }
    


}
