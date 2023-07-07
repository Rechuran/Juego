using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using System;
using UnityEditor;
using UnityEngine.SearchService;
using System.Runtime.CompilerServices;

public class ManuGameOver : MonoBehaviour
{
    // Start is called before the first frame update

    [SerializeField] private GameObject menuGameOver;
    private HUD hud;

    public void ActivarMenu()
    {
        menuGameOver.SetActive(true);
    }
    
    public void Reinicar()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    public void ManuPrincipal(string nombre)
    {
        SceneManager.LoadScene(nombre);
    }

    public void Salir()
    {
        UnityEditor.EditorApplication.isPlaying = false;
        Application.Quit();
    }
}
