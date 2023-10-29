using UnityEngine;
using UnityEngine.UI;
using System;

public class DateUIController : MonoBehaviour
{
    public InputField dateInputField;
    public Button forwardButton;
    public Button backwardButton;

    private void Start()
    {
        forwardButton.onClick.AddListener(AdvanceDate);
        backwardButton.onClick.AddListener(RewindDate);

        dateInputField.text = "";

        dateInputField.onEndEdit.AddListener(UpdateDateFromInputField);
    }

    private void AdvanceDate()
    {  
        DateTime currentDateTime = PlanetManager.current.Date.dateTime;
        DateTime newDateTime = currentDateTime.AddDays(5); // Avance de 5 jours 
        UpdateDate(newDateTime);
    }

    private void RewindDate()
    {
        DateTime currentDateTime = PlanetManager.current.Date.dateTime;
        DateTime newDateTime = currentDateTime.AddDays(-5); // Recule de 5 jours 
        UpdateDate(newDateTime);
    }

    private void UpdateDateFromInputField(string inputText)
    {
        if (DateTime.TryParse(inputText, out DateTime newDateTime))
        {
            UpdateDate(newDateTime);
        }
    }

    private void UpdateDate(DateTime newDateTime)
    {
        PlanetManager.current.Date = new UDateTime { dateTime = newDateTime };
    }
}
