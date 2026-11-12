using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Valores de un tipo de movimiento (suelo, salto y aire). Es un <c>ScriptableObject</c>:
/// hay un archivo por cada modo de movimiento y se cambian en el juego con la tecla M.
/// </summary>
[CreateAssetMenu]

//Uno para cada tipo de salto, un una lista

public class MovementStats : ScriptableObject
{
    /// <summary>Aceleración horizontal en el suelo.</summary>
    [Header("Ground")]
    public float groundAcceleration;
    /// <summary>Velocidad horizontal máxima en el suelo.</summary>
    public float maxGroundHorizontalSpeed;
    /// <summary>Fricción que frena al personaje en el suelo.</summary>
    public float groundHorizontalFriction;
    /// <summary>Saltos extra que se pueden dar en el aire.</summary>
    [Header("Jump")]
    public float onAirJumps;
    /// <summary>Velocidad vertical que se aplica al saltar.</summary>
    public float jumpStrength;
    /// <summary>Tiempo máximo, en segundos, que se puede mantener W para saltar más alto.</summary>
    public float maxJumpTime;
    /// <summary>Aceleración horizontal en el aire.</summary>
    [Header("Air")]
    public float airAcceleration;
    /// <summary>Velocidad horizontal máxima en el aire.</summary>
    public float maxAirHorizontalSpeed;

    /// <summary>Velocidad vertical por debajo de la cual se considera que está en lo alto del salto.</summary>
    public float yVelocityLowGravityThreshold;
    /// <summary>Velocidad máxima de caída.</summary>
    public float maxFallSpeed;
    /// <summary>Fricción que frena al personaje en el aire.</summary>
    public float airFriccion;
    /// <summary>Gravedad mientras sube.</summary>
    public float risingtGravity;
    /// <summary>Gravedad en lo alto del salto.</summary>
    public float peakGravity;
    /// <summary>Gravedad mientras cae.</summary>
    public float fallingGravity;

}
