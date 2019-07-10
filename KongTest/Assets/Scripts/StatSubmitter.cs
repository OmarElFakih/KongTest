using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StatSubmitter : MonoBehaviour
{
    public int value;
    public string statName;
    public InputField field;


    public void EditValue() {
        bool converted = int.TryParse(field.text, out value);
    }

    public void SubmitValue() {

        Application.ExternalCall("kongregate.stats.submit", statName, value);

        Debug.Log(value + " submitted");
      
    }

}
