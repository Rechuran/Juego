using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Disparo : MonoBehaviour
{
    [SerializeField] private Transform controlDisparo;
    [SerializeField] private GameObject bala;

    private void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            Disparar();
        }
    }

    private void Disparar()
    {
        Instantiate(bala, controlDisparo.position,controlDisparo.rotation);
    }
}
