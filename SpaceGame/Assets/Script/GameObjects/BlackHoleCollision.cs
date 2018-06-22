using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BlackHoleCollision : MonoBehaviour {
    private Collider2D planet;
    private Collider2D thisHole;
    private Rigidbody2D holeCollider;
    private void Awake()
    {
        thisHole = GetComponent<Collider2D>();
        holeCollider = GetComponent<Rigidbody2D>();
        Physics2D.IgnoreLayerCollision(8, 9);
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "Player")
        {
            SceneManager.LoadScene("gameOver");
        }
        if(collision.gameObject.tag == "Planet")
        {
            planet = collision.gameObject.GetComponent<Collider2D>();
        }
    }
}
