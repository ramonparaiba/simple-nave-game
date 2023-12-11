using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float moveSpeed = 15f; // Velocidade de movimento da nave

    private Rigidbody2D rb; // Referência ao Rigidbody2D da nave

    private float movement; // Valor de movimento horizontal

    void Start()
    {
        // Obter o componente Rigidbody2D
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        // Ler o input horizontal (A, D, seta esquerda, seta direita)
        movement = Input.GetAxis("Horizontal");
    }

    void FixedUpdate()
    {
        // Mover a nave horizontalmente
        rb.velocity = new Vector2(movement * moveSpeed, rb.velocity.y);
    }
}
