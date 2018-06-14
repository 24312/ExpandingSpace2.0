using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class restart : MonoBehaviour {

    public Button btn;

	// Use this for initialization
	void Start () {
        btn.onClick.AddListener(TaskOnClick);
    }
	
    private void TaskOnClick()
    {
        SceneManager.LoadScene("Loading");
    }
    private void FixedUpdate()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            //SceneManager.LoadScene("MainGame");
            SceneManager.LoadScene("Loading");
        }
<<<<<<< HEAD
=======

        for (int i = 0; i < Input.touchCount; ++i)
        {
            if (Input.GetTouch(i).phase == TouchPhase.Began)
            {
                SceneManager.LoadScene("Loading");
            }
        }
>>>>>>> 93bd71bc932d6ea874ad542c333b2afd86571b2a
    }

}
