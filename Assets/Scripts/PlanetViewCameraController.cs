using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlanetViewCameraController : MonoBehaviour
{
    public Text planetInfoText;

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;

            if (Physics.Raycast(ray, out hit))
            {
                if (hit.collider.CompareTag("Planet"))
                {
                    Transform planetTransform = hit.transform;
                    SetCameraToPlanetView(planetTransform);
                    ShowPlanetInfo(planetTransform);
                }
            }
        }
    }

    void SetCameraToPlanetView(Transform planet)
    {
        Vector3 targetPosition = planet.position;
        transform.position = targetPosition;
        transform.LookAt(planet);
    }

    void ShowPlanetInfo(Transform planet)
    {
        if (planetInfoText != null)
        {
            planetInfoText.text = "Nom de la planète : " + planet.name + "\nAutres informations..."; 
        }
    }
}
