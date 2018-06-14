using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour {

    public Transform player;
	void Update () {
        transform.position = new Vector3(player.position.x + 3, 0, -10);




        Vector3 position = transform.position;

        float vertical = transform.position.x;
        if (vertical < 0.0f)
            position.y += vertical;
        transform.position = new Vector3(player.position.x + 3, 0, -10);
    }
}
