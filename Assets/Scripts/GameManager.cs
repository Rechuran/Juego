using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEditor.Experimental.GraphView;
using UnityEngine;
using UnityEngine.SceneManagement;

using System;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance { get; private set; }
    private int vidas = 3;

    public event EventHandler MuerteJugador;
    
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
        vidas -= 1;

        if (vidas == 0)
        {
            MuerteJugador?.Invoke(this, EventArgs.Empty);
        }
        hud.DesactivarVidas(vidas);
    }
    


}
