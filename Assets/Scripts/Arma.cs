using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UIElements;

public class Arma : MonoBehaviour
{
    private SpriteRenderer spriteRenderer;
    public new Camera camera;
    public Transform spawner;
    public GameObject bulletPrefab;
    [SerializeField] private AudioClip disparo;
    private AudioSource audioSource;


    void Start()
    {
      spriteRenderer = GetComponent<SpriteRenderer>();  
    }
    void Update()
    {
        RepSonido();
        RotateTowardsMouse();
        CheckFiring();

        
    }


    private void RepSonido()
    {
        if (Input.GetMouseButtonDown(0))
        {
         ControladorSonidos.Instance.EjecutarSonido(disparo);
        }
    }
    private void RotateTowardsMouse()
    {
        float angle = GetAngleTowardsMouse();

        transform.rotation = Quaternion.Euler(0, 0, angle);
        spriteRenderer.flipY = angle >= 90 && angle <= 270;

    }
    private float GetAngleTowardsMouse()
    {
        Vector3 mouseWorldPosition = camera.ScreenToWorldPoint(Input.mousePosition);
        Vector3 mouseDirection = mouseWorldPosition - transform.position;
        mouseDirection.z = 0;

        float angle = (Vector3.SignedAngle(Vector3.right, mouseDirection, Vector3.forward) + 360) % 360;

        return angle;
    }

    private void CheckFiring()
    {
        if (Input.GetMouseButtonDown(0))
        {

            
            GameObject bullet = Instantiate(bulletPrefab);
            bullet.transform.position = spawner.position;
            bullet.transform.rotation = transform.rotation;
            Destroy(bullet,2f);
            
            
        }
    }

}
