using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class movJugador : MonoBehaviour
{ 
    [SerializeField] private float velocidadMovimiento;
    [SerializeField] private Vector2 direccion;

    private Animator Animator;

    public Rigidbody2D rb2D;

    // Start is called before the first frame update
    private void Start()
    {
        rb2D = GetComponent<Rigidbody2D>();
        Animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        direccion = new Vector2(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical")).normalized;
        Animator.SetBool("Running", Input.GetAxisRaw("Horizontal") != 0.0f);

        if (Input.GetAxisRaw("Horizontal") < 0.0f) transform.localScale = new Vector3(-1.0f, 1.0f, 1.0f);
        else if (Input.GetAxisRaw("Horizontal") > 0.0f) transform.localScale = new Vector3(1.0f, 1.0f, 1.0f);
    }

    private void FixedUpdate()
    {
        rb2D.MovePosition(rb2D.position + direccion*velocidadMovimiento*Time.fixedDeltaTime);
    }

}
