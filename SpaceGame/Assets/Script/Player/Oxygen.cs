using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Oxygen : MonoBehaviour {

    private float oxygenTime = 50;
    private float roundUp;
    //public Text oxygenDisplay;
    public Slider timerSlide;
    public Animator oxygen;
    public Animator oxygenSpecial;
    private CircleCollider2D oxygenCollider;
    private void FixedUpdate()
    {
        timerSlide.value = oxygenTime;
        roundUp = Mathf.Round(oxygenTime);
        oxygenTime -= Time.deltaTime;
       
        if(oxygenTime <= 0)
        {
            SceneManager.LoadScene("gameOver");
            return;
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "Oxygen")
        {
            oxygen = collision.gameObject.GetComponent<Animator>();
            oxygen.Play("Oxygen");
            oxygenCollider = collision.gameObject.GetComponent<CircleCollider2D>();
            oxygenCollider.enabled = false;
            if (oxygenTime <= 30)
            {
                Destroy(collision.gameObject, 0.3f);
                oxygenTime = 30;
                return;
            }
            if(oxygenTime > 30 && oxygenTime < 40)
            {
                Destroy(collision.gameObject, 0.3f);
                oxygenTime = 40;
                return;
            }
            if(oxygenTime > 40 && oxygenTime < 50)
            {
                oxygenTime = 50;
                Destroy(collision.gameObject, 0.3f);
                return;
            }
        }
        if(collision.gameObject.tag == "Oxygen Special")
        {
            oxygenCollider = collision.gameObject.GetComponent<CircleCollider2D>();
            oxygenCollider.enabled = false;
            oxygenSpecial = collision.gameObject.GetComponent<Animator>();
            Destroy(collision.gameObject, 0.3f);
            oxygenSpecial.Play("Oxygen");
            oxygenTime = 50;
            return;
        }
        else
        {
            return;
        }
    }

}
