using UnityEngine;
using UnityEngine.UI;

public class TrajectoryUIController : MonoBehaviour
{
    public GameObject planetTrajectories; // L'objet parent des trajectoires des plan�tes.
    public Toggle toggleTrajectories; // L'�l�ment d'UI pour activer/d�sactiver les trajectoires.

    private void Start()
    {
        // Associez la fonction OnToggleTrajectories � l'�v�nement de bascule de l'UI.
        toggleTrajectories.onValueChanged.AddListener(OnToggleTrajectories);
    }

    private void OnToggleTrajectories(bool isOn)
    {
        // Activez ou d�sactivez l'objet parent des trajectoires des plan�tes en fonction de l'�tat de la bascule.
        planetTrajectories.SetActive(isOn);
    }
}
