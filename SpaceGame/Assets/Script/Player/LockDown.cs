using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class LockDown : MonoBehaviour {

    private Transform player;

    private PlayerMovement setDead;

    private void Awake()
    {
        player = GetComponent<Transform>();
    }
    private void FixedUpdate()
    {
        if(player.position.x <= -10)
        {
            setDead = GetComponent<PlayerMovement>();
            setDead.ifDead = true;
            setDead.Constraints();
            return;
        }
        if(player.position.y > 7)
        {
            setDead = GetComponent<PlayerMovement>();
            setDead.ifDead = true;
            setDead.Constraints();
            return;
        }
        if(player.position.y < -7)
        {
            setDead = GetComponent<PlayerMovement>();
            setDead.ifDead = true;
            setDead.Constraints();
            return;
        }
    }

}
