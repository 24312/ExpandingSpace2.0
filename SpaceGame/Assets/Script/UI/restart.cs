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
    }

}
