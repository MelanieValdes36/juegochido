using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ramas : MonoBehaviour
{
    // Este método se llama cuando el collider del objeto Player entra en contacto con otro collider
    private void OnTriggerEnter(Collider other)
    {
        // Verifica si el objeto con el que ha entrado en contacto es la Rama
        if (other.CompareTag("Rama"))
        {
            // Destruye el objeto Rama
            Destroy(other.gameObject);
        }
    }
}