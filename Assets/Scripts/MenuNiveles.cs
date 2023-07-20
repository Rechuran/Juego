using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuNiveles : MonoBehaviour
{
    // Start is called before the first frame update
    public void Nivel1()
    {
        SceneManager.LoadScene("Nivel 1");
    }

    public void Nivel2()
    {
        SceneManager.LoadScene("Nivel 2");
    }
}
