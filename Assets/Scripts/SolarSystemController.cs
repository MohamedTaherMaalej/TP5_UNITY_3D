using System;
using UnityEngine;

public class SolarSystemController : MonoBehaviour
{
    public Transform sun; 
    public Transform mercury;
    public Transform venus;
    public Transform earth;
    public Transform mars;
    public Transform jupiter;
    public Transform saturn;
    public Transform uranus;
    public Transform neptune;


    private void Start()
    {



        PlanetManager.current.OnTimeChange += UpdatePosition;


    }


    /*
    private void Update()
    {
        DateTime currentDateTime = DateTime.Now; 
        UpdatePosition(currentDateTime);
    }*/

    public void UpdatePosition(DateTime t)
    {
        UpdatePlanetPosition(PlanetData.Planet.Mercury, t, mercury);
        UpdatePlanetPosition(PlanetData.Planet.Venus, t, venus);
        UpdatePlanetPosition(PlanetData.Planet.Earth, t, earth);
        UpdatePlanetPosition(PlanetData.Planet.Mars, t, mars);
        UpdatePlanetPosition(PlanetData.Planet.Jupiter, t, jupiter);
        UpdatePlanetPosition(PlanetData.Planet.Saturn, t, saturn);
        UpdatePlanetPosition(PlanetData.Planet.Uranus, t, uranus);
        UpdatePlanetPosition(PlanetData.Planet.Neptune, t, neptune);
    }

    private void UpdatePlanetPosition(PlanetData.Planet planet, DateTime t, Transform planetTransform)
    {
        Vector3 planetPosition = PlanetData.GetPlanetPosition(planet, t);
        planetTransform.position = planetPosition;
    }
}
