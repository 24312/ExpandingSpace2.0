using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Oxygen : MonoBehaviour {

    private float oxygenTime = 25;
    private float roundUp;
    //public Text oxygenDisplay;
    public Slider timerSlide;
    public Animator oxygen;
    public Animator oxygenSpecial;
    private CircleCollider2D oxygenCollider;
    private PlayerMovement setDead;

    private void FixedUpdate()
    {
        timerSlide.value = oxygenTime;
        roundUp = Mathf.Round(oxygenTime);
        oxygenTime -= Time.deltaTime;
       
        if(oxygenTime <= 0)
        {
            setDead = GetComponent<PlayerMovement>();
            setDead.ifDead = true;
            setDead.Constraints();
            return;
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        
        if (collision.gameObject.tag == "Oxygen")
        {
            oxygen = collision.gameObject.GetComponent<Animator>();
            oxygen.Play("Oxygen");
            oxygenCollider = collision.gameObject.GetComponent<CircleCollider2D>();
            oxygenCollider.enabled = false;
            Destroy(collision.gameObject, 0.3f);
            if (oxygenTime < 15)
                oxygenTime += 10;
            else
                oxygenTime = 25;
        }
        if(collision.gameObject.tag == "Oxygen Special")
        {
            oxygenCollider = collision.gameObject.GetComponent<CircleCollider2D>();
            oxygenCollider.enabled = false;
            oxygenSpecial = collision.gameObject.GetComponent<Animator>();
            Destroy(collision.gameObject, 0.3f);
            oxygenSpecial.Play("Oxygen");
            oxygenTime = 25;
            return;
        }
        else
        {
            return;
        }
    }

}
