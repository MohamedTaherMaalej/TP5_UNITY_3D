using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlanetManager : MonoBehaviour
{
    public static PlanetManager current;

    public event Action<DateTime> OnTimeChange; 

    [SerializeField]
    private UDateTime date;

    public UDateTime Date
    {
        get => date;
        set
        {
            date = value;
            TimeChanged(value.dateTime); //Fire the event
        }
    }

    private void Awake()
    {
        if (current == null)
        {
            current = this;
        }
        else
        {
            Destroy(gameObject);
        }
    }

    private void TimeChanged(DateTime newTime)
    {
        OnTimeChange?.Invoke(newTime); 
    }

    private void Start()
    {
        Date = DateTime.Now;
    }

    private void Update()
    {
        Date = Date.dateTime.AddDays(0.1);

    }
}
