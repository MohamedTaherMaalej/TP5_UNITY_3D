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
        // Assurez-vous d'associer ces actions aux actions que vous avez définies dans le Input System.
        rotateAction.Enable();
        zoomAction.Enable();
    }

    private void Update()
    {
        // Contrôlez la rotation de la caméra en fonction de l'entrée de l'utilisateur.
        Vector2 rotationInput = rotateAction.ReadValue<Vector2>();
        RotateCamera(rotationInput);

        // Contrôlez le zoom de la caméra en fonction de l'entrée de l'utilisateur.
        float zoomInput = zoomAction.ReadValue<float>();
        ZoomCamera(zoomInput);
    }

    private void RotateCamera(Vector2 rotationInput)
    {
        // Utilisez les valeurs de rotationInput pour effectuer la rotation de la caméra.
        float rotationX = rotationInput.y * rotationSpeed;
        float rotationY = rotationInput.x * rotationSpeed;

        // Appliquez les rotations à la caméra.
        transform.Rotate(rotationX, rotationY, 0);
    }

    private void ZoomCamera(float zoomInput)
    {
        // Utilisez la valeur de zoomInput pour effectuer le zoom de la caméra.
        float zoomAmount = zoomInput * zoomSpeed;

        // Appliquez le zoom en modifiant la position de la caméra.
        transform.Translate(Vector3.forward * zoomAmount);
    }
}
