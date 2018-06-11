using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlanetObstakel : MonoBehaviour {

    //private Animator characterDeath;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "Player")
        {
            //characterDeath = collision.gameObject.GetComponent<Animator>();
            //characterDeath.Play("CharacterDeath");
            SceneManager.LoadScene("gameOver");
            return;
        }
        else if(collision.gameObject.tag == "Planet")
        {
            return;
        }
        else
        {
            return;
        }
    }
}
