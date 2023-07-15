using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Enemigo : MonoBehaviour
{
    [SerializeField] private float vida;


    public void TomarDaño(float daño)
    {
        vida -= daño;

        if (vida <= 0) 
        {
            Destroy(gameObject);
        }
    }
}

