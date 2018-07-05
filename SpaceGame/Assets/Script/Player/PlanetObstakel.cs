using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlanetObstakel : MonoBehaviour {

    private Animator characterDeath;
    private PlayerMovement setDead;
    private EnemyMovement standStill;
    private void Awake()
    {
        standStill = GetComponent<EnemyMovement>();
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "Player")
        {
            characterDeath = collision.gameObject.GetComponent<Animator>();
            setDead = collision.gameObject.GetComponent<PlayerMovement>();
            setDead.ifDead = true;
            if(standStill != null)
            {
                standStill.checkKilled = true;
            }
            characterDeath.Play("CharacterDeath");
            Invoke("LoadScene", 2);
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
    void LoadScene()
    {
        GameObject quitBtn = GameObject.FindGameObjectWithTag("GameOver2");
        GameObject respawnBtn = GameObject.FindGameObjectWithTag("GameOver");

    }
}
