using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Enemigo : MonoBehaviour
{
    [SerializeField] private float vida;


    public void TomarDa�o(float da�o)
    {
        vida -= da�o;

        if (vida <= 0) 
        {
            Destroy(gameObject);
        }
    }
}

