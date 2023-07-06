using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEditor.Experimental.GraphView;
using UnityEngine;

public class GameManager : MonoBehaviour
{

    private int vidas = 3;
    public static GameManager Instance
    {
        get;
        private set;
    }
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

    public void perderVida()
    {
        vidas -= 1;
        hud.DesactivarVidas(vidas);
    }
    


}
