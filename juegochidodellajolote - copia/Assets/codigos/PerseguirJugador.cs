using UnityEngine;

public class PerseguirJugador : MonoBehaviour
{
    public Transform Player; // Referencia al transform del jugador
    public float velocidad; // Velocidad a la que se moverá el malo
    public float distanciaMinima; // Distancia mínima a la que el malo persigue al jugador

    private void Update()
    {
        // Comprobamos si el jugador está dentro de la distancia mínima
        if (Vector3.Distance(transform.position, Player.position) <= distanciaMinima)
        {
            // Calculamos la dirección hacia la que se moverá el malo
            Vector3 direccion = (Player.position - transform.position).normalized;
            
            // Movemos al malo en la dirección calculada
            transform.Translate(direccion * velocidad * Time.deltaTime);
        }
    }
}