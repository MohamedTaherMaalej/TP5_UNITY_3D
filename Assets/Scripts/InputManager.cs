using UnityEngine;
using UnityEngine.InputSystem;

public class InputManager : MonoBehaviour
{
    public void OnMove(InputAction.CallbackContext context)
    {
        // Cette méthode est appelée lorsque l'action de déplacement est déclenchée.
        Vector2 direction = context.ReadValue<Vector2>();
        // Faites quelque chose avec la direction (déplacement de la caméra, etc.).
    }

    public void OnRotate(InputAction.CallbackContext context)
    {
        // Cette méthode est appelée lorsque l'action de rotation est déclenchée.
        float rotation = context.ReadValue<float>();
        // Faites quelque chose avec la rotation (rotation des planètes, etc.).
    }

    // Ajoutez d'autres méthodes pour d'autres actions.


    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
}
