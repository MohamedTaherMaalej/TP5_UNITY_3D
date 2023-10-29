using UnityEngine;
using UnityEngine.UI;

public class TrajectoryUIController : MonoBehaviour
{
    public GameObject planetTrajectories; // L'objet parent des trajectoires des planètes.
    public Toggle toggleTrajectories; // L'élément d'UI pour activer/désactiver les trajectoires.

    private void Start()
    {
        // Associez la fonction OnToggleTrajectories à l'événement de bascule de l'UI.
        toggleTrajectories.onValueChanged.AddListener(OnToggleTrajectories);
    }

    private void OnToggleTrajectories(bool isOn)
    {
        // Activez ou désactivez l'objet parent des trajectoires des planètes en fonction de l'état de la bascule.
        planetTrajectories.SetActive(isOn);
    }
}
