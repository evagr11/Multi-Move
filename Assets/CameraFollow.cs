using UnityEngine;

/// <summary>
/// Cámara que sigue al jugador con un movimiento suave.
/// </summary>
public class CameraFollow : MonoBehaviour
{
    /// <summary>Jugador al que sigue la cámara.</summary>
    public Transform player;
    /// <summary>Tiempo aproximado, en segundos, que tarda en alcanzar al jugador. Cuanto más alto, más suave.</summary>
    public float smoothness = 0.15f;
    /// <summary>Distancia entre la cámara y el jugador. Si se deja a cero, se calcula al empezar.</summary>
    public Vector3 offset; // Distancia entre la cámara y el jugador

    private Vector3 velocity = new Vector3(0, 0, 0);

    /// <summary>
    /// Si no se ha puesto distancia en el Inspector, guarda la que hay al empezar la escena.
    /// </summary>
    void Start()
    {
        if (offset == new Vector3(0, 0, 0))
        {
            offset = transform.position - player.position;
        }
    }

    /// <summary>
    /// Mueve la cámara hacia la posición del jugador más la distancia con <c>Vector3.SmoothDamp</c>.
    /// </summary>
    void Update()
    {
        Vector3 targetPosition = player.position + offset;

        // Se acerca poco a poco a la posición objetivo. SmoothDamp guarda en 'velocity'
        // la velocidad actual de la cámara para que el movimiento sea suave.
        transform.position = Vector3.SmoothDamp(transform.position, targetPosition, ref velocity, smoothness);
    }
}
