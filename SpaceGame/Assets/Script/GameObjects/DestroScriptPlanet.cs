using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DestroScriptPlanet : MonoBehaviour
{

    //SceneController controller;
    private PlayerMovement constraints;


    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Player")
        {
            constraints = other.gameObject.GetComponent<PlayerMovement>();
            constraints.Constraints();
            constraints.ifDead = true;
            return;
        }
        else if (other.tag == "Destroyer")
        {
            return;
        }
        else if (other.tag == "Planet")
        {
            return;
        }
        if (other.gameObject.transform.parent)
        {
            Destroy(other.gameObject.transform.parent.gameObject);
        }
        else
        {
            Destroy(other.gameObject);
        }
    }

}
