using UnityEngine;

/// <summary>
/// Mantiene el objeto sin girar: en cada fotograma le quita la rotación.
/// </summary>
public class ContantRotationReset : MonoBehaviour
{
    /// <summary>Pone la rotación a <c>Quaternion.identity</c>.</summary>
    void Update()
    {
        transform.rotation = Quaternion.identity;
    }
}
