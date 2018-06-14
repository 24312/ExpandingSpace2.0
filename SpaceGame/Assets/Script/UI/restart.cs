using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class restart : MonoBehaviour {

    public Button btn;

	
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

>>>>>>> 97aa26063f984047e822d1da2647d7bee45a8194

        for (int i = 0; i < Input.touchCount; ++i)
        {
            if (Input.GetTouch(i).phase == TouchPhase.Began)
            {
                SceneManager.LoadScene("Loading");
            }
        }
<<<<<<< HEAD
=======

>>>>>>> 97aa26063f984047e822d1da2647d7bee45a8194
    }

}
