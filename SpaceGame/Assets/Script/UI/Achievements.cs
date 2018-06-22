using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Achievements : MonoBehaviour {

    public Slider[] precentageBar;
    public Text[] PrecentageText;
    public GameObject[] achievements;
    public Image[] upsideDown;
    public Sprite unlockedImage;

    private void Awake()
    {
        precentageBar[0].value = PlayerPrefs.GetInt("Jumps", 0);
        PrecentageText[0].text = (precentageBar[0].value / 10) + "%";
        precentageBar[1].value = PlayerPrefs.GetFloat("distanceTravelledPlanet", 0);
        PrecentageText[1].text = (Mathf.Round(precentageBar[1].value / 200)) + "%";
        precentageBar[2].value = PlayerPrefs.GetInt("DiedAtStart", 0);
        PrecentageText[2].text = (precentageBar[2].value * 100) + "%";
        for(int i = 0; i < achievements.Length; i++)
        {
            achievements[i].SetActive(false);
        }
        if(precentageBar[0].value >= 1000)
        {
            upsideDown[0].sprite = unlockedImage;
            achievements[0].SetActive(true);
        }
        if (precentageBar[1].value >= 20000)
        {
            upsideDown[1].sprite = unlockedImage;
            achievements[1].SetActive(true);
        }
        if (precentageBar[2].value >= 1)
        {
            upsideDown[2].sprite = unlockedImage;
            achievements[2].SetActive(true);
        }
    }
}
