/////////////////////////////////////////////////////////////
/////////////Youtube video gevolgd///////////////////////////
/////////////////////////////////////////////////////////////


using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Loading : MonoBehaviour
{

    public GameObject loadingScreen;
    public Slider slider;
    public string LevelName;
    float progress;

    private void Start()
    {
        //LevelName = PlayerPrefs.GetString("MainGame");
   
        Debug.Log("findlevel");
        StartCoroutine(LoadAsynchronously("MainGame"));//??
    }

    //v- Waar staat dit eigenlijk voor -v\/
    IEnumerator LoadAsynchronously(string LevelName)
    {
        AsyncOperation operation = SceneManager.LoadSceneAsync("MainGame");//??
        Debug.Log("loadLevel");
        loadingScreen.SetActive(true);//Laad effect op waar
        operation.allowSceneActivation = false;
        while (!operation.isDone)
        {
            progress = Mathf.Clamp01(Mathf.Lerp(progress,operation.progress / .9f, operation.progress));//Laadscherm berekenen.
            slider.value = progress;//laadscherm tekenen
            if (slider.value > 0.99)
                operation.allowSceneActivation = true;
            yield return null;
        }

    }
}
//off ya go
