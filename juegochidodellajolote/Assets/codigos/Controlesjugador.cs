using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controlesjugador : MonoBehaviour
{
    public float moveSpeed = 5f; // Velocidad de movimiento del jugador

    void Update()
    {
        // Obtener la entrada del jugador para moverse en los ejes X y Z
        float moveX = Input.GetAxis("Horizontal");
        float moveZ = Input.GetAxis("Vertical");

        // Crear el vector de movimiento basado en la entrada del jugador
        Vector3 movement = new Vector3(moveX, 0f, moveZ).normalized;

        // Mover al jugador en la dirección especificada
        transform.Translate(movement * moveSpeed * Time.deltaTime);
    }
}