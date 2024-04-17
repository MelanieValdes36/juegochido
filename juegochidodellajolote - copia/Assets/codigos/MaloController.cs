using UnityEngine;

public class MaloController : MonoBehaviour
{
    public Transform player; // Referencia al transform del jugador
    public float followDistance = 10f; // Distancia a partir de la cual el enemigo comenzará a seguir al jugador
    public float moveSpeed = 5f; // Velocidad de movimiento del enemigo

    private bool isFollowing = false; // Bandera que indica si el enemigo está siguiendo al jugador

    void Update()
    {
        // Calcular la distancia entre el jugador y el enemigo
        float distanceToPlayer = Vector3.Distance(transform.position, player.position);

        // Verificar si el jugador está dentro del rango de seguimiento
        if (distanceToPlayer <= followDistance)
        {
            isFollowing = true;
        }
        else
        {
            isFollowing = false;
        }

        // Si el enemigo está siguiendo al jugador, moverlo hacia el jugador
        if (isFollowing)
        {
            // Calcular la dirección hacia la que debe moverse el enemigo
            Vector3 directionToPlayer = (player.position - transform.position).normalized;

            // Mover al enemigo en la dirección del jugador
            transform.Translate(directionToPlayer * moveSpeed * Time.deltaTime);
        }
    }
}