using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Dificulty : MonoBehaviour {

    private Slider dificultyBar;

    private void Awake()
    {
        dificultyBar = GetComponent<Slider>();
        dificultyBar.value = PlayerPrefs.GetFloat("Dificulty", Mathf.Infinity);
        dificultyBar.onValueChanged.AddListener(delegate { ValueChangeCheck(); });
    }
    public void ValueChangeCheck()
    {
        if(dificultyBar.value == 4)
        {
            PlayerPrefs.SetFloat("Dificulty", -4);
        }
        if (dificultyBar.value == 5)
        {
            PlayerPrefs.SetFloat("Dificulty", -5);
        }
        if (dificultyBar.value == 6)
        {
            PlayerPrefs.SetFloat("Dificulty", -6);
        }
        if (dificultyBar.value == 7)
        {
            PlayerPrefs.SetFloat("Dificulty", -7);
        }
        if (dificultyBar.value == 8)
        {
           PlayerPrefs.SetFloat("Dificulty", -8);
        }
    }
}
