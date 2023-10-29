using UnityEngine;
using UnityEngine.InputSystem;

public class InputManager : MonoBehaviour
{
    public void OnMove(InputAction.CallbackContext context)
    {
        // Cette m�thode est appel�e lorsque l'action de d�placement est d�clench�e.
        Vector2 direction = context.ReadValue<Vector2>();
        // Faites quelque chose avec la direction (d�placement de la cam�ra, etc.).
    }

    public void OnRotate(InputAction.CallbackContext context)
    {
        // Cette m�thode est appel�e lorsque l'action de rotation est d�clench�e.
        float rotation = context.ReadValue<float>();
        // Faites quelque chose avec la rotation (rotation des plan�tes, etc.).
    }

    // Ajoutez d'autres m�thodes pour d'autres actions.


    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
}
