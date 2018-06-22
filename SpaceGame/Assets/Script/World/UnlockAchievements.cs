using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UnlockAchievements : MonoBehaviour {

    public int jumps;
    float distanceTravelledPlanet;
    int died;
    int landedPlanets;
    float pulledByBlackHole;
    int pickedUpOxygen;

    private void Awake()
    {
        jumps = PlayerPrefs.GetInt("Jumps", 0);
        distanceTravelledPlanet = PlayerPrefs.GetFloat("distanceTravelledPlanet", 0);
        died = PlayerPrefs.GetInt("Died", 0);
        landedPlanets = PlayerPrefs.GetInt("LandedOnPlanets", 0);
        pulledByBlackHole = PlayerPrefs.GetFloat("PulledByBlackHole", 0);
        pickedUpOxygen = PlayerPrefs.GetInt("PickedUpOxygen", 0);
    }
    private void FixedUpdate()
    {

        if (jumps >= 300)
            Debug.Log("achievement unlocked!");
    }
    public void SetAchievements(int a)
    {
        if(a == 1)
        {
            jumps++;
            PlayerPrefs.SetInt("Jumps", jumps);
        }
        if (a == 2)
        {
            
            distanceTravelledPlanet++;
            PlayerPrefs.SetFloat("distanceTravelledPlanet", distanceTravelledPlanet);
        }
        if (a == 3)
        {
            died++;
            PlayerPrefs.SetInt("Died", died);
        }
        if (a == 4)
        {
            landedPlanets++;
            PlayerPrefs.SetInt("LandedOnPlanets", landedPlanets);
        }
        if (a == 5)
        {
            pulledByBlackHole++;
            PlayerPrefs.SetFloat("PulledBlackHoles", pulledByBlackHole);
        }
        if (a == 6)
        {
            pickedUpOxygen++;
            PlayerPrefs.SetInt("PickedUpOxygen", pickedUpOxygen);
        }
    }
}
