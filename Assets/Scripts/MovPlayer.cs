using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class MovPlayer : MonoBehaviour
{
    [SerializeField] private float speed = 2f;
    private Rigidbody2D playerRb;
    private Vector2 moveInput;
    private Animator playerAnimator;
    private int rescatados;
    public TextMeshProUGUI puntuacionText;
    public AudioSource audioSource;
    GameManager gameManager;
    public AudioSource audioDog;


    void Start()
    {
        playerRb = GetComponent<Rigidbody2D>();
        playerAnimator = GetComponent<Animator>();
        rescatados = 0;

    }

    // Update is called once per frame
    void Update()
    {
        
        float moveX = Input.GetAxisRaw("Horizontal");
        float moveY = Input.GetAxisRaw("Vertical");

        moveInput = new Vector2(moveX, moveY);

        playerAnimator.SetFloat("Horizontal", moveX);
        playerAnimator.SetFloat("Vertical", moveY);
        playerAnimator.SetFloat("Speed", moveInput.sqrMagnitude);

        bool isMoving = Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.D);

        if (isMoving)
        {
    
            if (!audioSource.isPlaying)
                audioSource.Play();
        }
        else
        {

            audioSource.Stop();
        }


    }

    private void FixedUpdate()
    {
        playerRb.MovePosition(playerRb.position + moveInput * speed * Time.fixedDeltaTime);
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Cachupin"))
        {
            rescatados++;
            puntuacionText.text = rescatados.ToString();
            audioDog.Play();
            Destroy(collision.gameObject);
        }
    }
}
