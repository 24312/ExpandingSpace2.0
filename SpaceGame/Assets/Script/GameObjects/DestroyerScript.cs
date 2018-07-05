using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DestroyerScript : MonoBehaviour {

    //SceneController controller;
    public GameObject[] obj;
    public GameObject imageWarning;
    public GameObject[] currentPlanets;
    public Transform planetSpawner;
    private PlayerMovement constraints;
    

    private void OnCollisionEnter2D(Collision2D other)
    {
        
        if(other.gameObject.tag == "Player")
        {
            constraints = other.gameObject.GetComponent<PlayerMovement>();
            constraints.Constraints();
            constraints.ifDead = true;
            return;
        }
        else if (other.gameObject.tag == "Destroyer")
        {
            return;
        }
        else if(other.gameObject.tag == "Planet")
        {
            Destroy(other.gameObject);
            //doet build map soms 2 keer of hellemaal niet....
            //BuildMap();
            return;

        }
        else if(other.gameObject.tag == "BlackHole")
        {
            imageWarning.SetActive(false);
            Destroy(other.gameObject);
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
    private void FixedUpdate()
    {
        currentPlanets = GameObject.FindGameObjectsWithTag("Planet");
        if (currentPlanets.Length < 3)
            BuildMap();
    }
    public void BuildMap()
    {
            Vector2 spawnLocation = new Vector2(planetSpawner.position.x + Random.Range(1,3), 4 - Random.Range(1, 8));
            GameObject holes = Instantiate(obj[Random.Range(0, obj.GetLength(0))], spawnLocation, Quaternion.identity);
    }

}
