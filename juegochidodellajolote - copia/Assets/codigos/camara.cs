using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camara : MonoBehaviour
{
    public Transform jugador; // Referencia al objeto jugador que la cámara seguirá
    public Vector3 offset; // Offset opcional para ajustar la posición de la cámara con respecto al jugador

    void Update()
    {
        if (jugador != null)
        {
            // Establecer la posición de la cámara igual a la posición del jugador más el offset
            transform.position = jugador.position + offset;
        }
    }
}