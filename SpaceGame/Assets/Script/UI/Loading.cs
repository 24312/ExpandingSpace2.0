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

        while (!operation.isDone)
        {
            float progress = Mathf.Clamp01(operation.progress / .9f);//Laadscherm berekenen.
            Debug.Log("slider");
            slider.value = progress;//laadscherm tekenen

            yield return null;
        }
    }
}
//off ya go
