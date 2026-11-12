using TMPro;
using UnityEngine;
using UnityEngine.UI;

/// <summary>
/// Cambia de modo de movimiento con la tecla M y enseña su nombre durante 2 segundos.
/// </summary>
public class MovementTypes : MonoBehaviour
{
    [SerializeField] private MovementStats currentStats;
    [SerializeField] private MovementStats[] availableMovements;
    private int currentMovementIndex = 0;

    [SerializeField] private Image movementImage;
    [SerializeField] private TMP_Text movementText;

    private float displayTime = 0f;

    // Start is called before the first frame update
    /// <summary>Empieza con el primer modo y oculta el cartel.</summary>
    void Start()
    {
        currentStats = availableMovements[currentMovementIndex];
        movementImage.gameObject.SetActive(false);
        movementText.gameObject.SetActive(false);
    }

    // Update is called once per frame
    /// <summary>Cambia de modo al pulsar M y oculta el cartel cuando se acaba su tiempo.</summary>
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.M))
        {
            ChangeMovementMode();
        }

        displayTime -= Time.deltaTime;
        if (displayTime <= 0)
        {
            movementImage.gameObject.SetActive(false);
            movementText.gameObject.SetActive(false);
        }
    }

    /// <summary>
    /// Pasa al siguiente modo de la lista (vuelve al primero después del último), enseña su
    /// nombre y se lo pasa a <see cref="Movement.UpdateStats"/>.
    /// </summary>
    private void ChangeMovementMode()
    {
        currentMovementIndex++;

        if (currentMovementIndex >= availableMovements.Length)
        {
            currentMovementIndex = 0;
        }

        currentStats = availableMovements[currentMovementIndex];

        movementText.text = "Mode: " + currentStats.name;
        movementImage.gameObject.SetActive(true);
        movementText.gameObject.SetActive(true);

        displayTime = 2f;

        FindObjectOfType<Movement>().UpdateStats(currentStats);
    }
}
