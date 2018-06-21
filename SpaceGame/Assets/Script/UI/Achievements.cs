using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Achievements : MonoBehaviour {

    public Slider[] precentageBar;
    public Text[] PrecentageText;

    private void Awake()
    {
        precentageBar[0].value = PlayerPrefs.GetInt("Jumps", 0);
        PrecentageText[0].text = (precentageBar[0].value / 10) + "%";
        precentageBar[1].value = PlayerPrefs.GetFloat("distanceTravelledPlanet", 0);
        PrecentageText[1].text = (Mathf.Round(precentageBar[1].value / 200)) + "%";
        precentageBar[2].value = PlayerPrefs.GetInt("DiedAtStart", 0);
        PrecentageText[2].text = (precentageBar[2].value * 100) + "%";
    }
    private void FixedUpdate()
    {

    }
}
