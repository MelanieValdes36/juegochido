using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ramaaa : MonoBehaviour
{
    [SerializeField] private float cantidadPuntos;
    [SerializeField] private Puntaje puntaje;
    
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            
            puntaje.SumarPuntos(cantidadPuntos);
            Destroy(gameObject);
        }
    }
}