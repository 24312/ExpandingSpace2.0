using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour {

    public Transform player;

    private float PosXPrev;

    //private float difference = 0;

    void Start()
    {
        PosXPrev = transform.position.x;
    }
    
    void Update () {
        /*difference = transform.position.x - player.position.x;
        Debug.Log(player.position.x);
        Debug.Log(transform.position.x);
        Debug.Log(difference);
        if(player.position.x + 3 > difference)
        transform.position = new Vector3(player.position.x + 3, 0, -10);*/
        if(PosXPrev < player.position.x + 3)
        transform.position = new Vector3(player.position.x + 3, 0, -10);


    }
    void LateUpdate()
    {
        PosXPrev = transform.position.x;
    }
}
