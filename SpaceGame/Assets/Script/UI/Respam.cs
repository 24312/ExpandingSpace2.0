using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Respam : MonoBehaviour {

    private Button respawn;
    public GameObject[] btns;
    private void Awake()
    {
        for(int i = 0; i < btns.Length; i++)
        {
            btns[i].SetActive(false);
        }
        respawn = GetComponent<Button>();
        respawn.onClick.AddListener(Respawn);
    }
    public void Respawn()
    {
        Application.LoadLevel(Application.loadedLevel);
    }
}
