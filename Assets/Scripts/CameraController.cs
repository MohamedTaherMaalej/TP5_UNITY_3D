using UnityEngine;
using UnityEngine.InputSystem;

public class CameraController : MonoBehaviour
{
    public InputAction rotateAction;
    public InputAction zoomAction;

    public float rotationSpeed = 1.0f;
    public float zoomSpeed = 5.0f;

    private void Awake()
    {
        // Assurez-vous d'associer ces actions aux actions que vous avez d�finies dans le Input System.
        rotateAction.Enable();
        zoomAction.Enable();
    }

    private void Update()
    {
        // Contr�lez la rotation de la cam�ra en fonction de l'entr�e de l'utilisateur.
        Vector2 rotationInput = rotateAction.ReadValue<Vector2>();
        RotateCamera(rotationInput);

        // Contr�lez le zoom de la cam�ra en fonction de l'entr�e de l'utilisateur.
        float zoomInput = zoomAction.ReadValue<float>();
        ZoomCamera(zoomInput);
    }

    private void RotateCamera(Vector2 rotationInput)
    {
        // Utilisez les valeurs de rotationInput pour effectuer la rotation de la cam�ra.
        float rotationX = rotationInput.y * rotationSpeed;
        float rotationY = rotationInput.x * rotationSpeed;

        // Appliquez les rotations � la cam�ra.
        transform.Rotate(rotationX, rotationY, 0);
    }

    private void ZoomCamera(float zoomInput)
    {
        // Utilisez la valeur de zoomInput pour effectuer le zoom de la cam�ra.
        float zoomAmount = zoomInput * zoomSpeed;

        // Appliquez le zoom en modifiant la position de la cam�ra.
        transform.Translate(Vector3.forward * zoomAmount);
    }
}
