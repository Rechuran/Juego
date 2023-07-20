using System.Collections;
using System.Collections.Generic;
using System.Linq.Expressions;
using Unity.VisualScripting;
using UnityEngine;

public class Enemigo : MonoBehaviour
{
    [SerializeField] private float vida;
    public GameManager gameManager;
    public void TomarDaño(float daño)
    {
        vida -= daño;

        if (vida <= 0) 
        {

            gameManager.ActivarBoss();
            Destroy(gameObject);
        }
    }
}

