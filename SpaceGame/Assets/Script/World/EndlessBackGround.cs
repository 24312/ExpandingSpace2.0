using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndlessBackGround : MonoBehaviour
{
    public float scrollSpeed = 0.5f;
    public Renderer rend;
    void Start()
    {
        rend = GetComponent<Renderer>();
    }
    void FixedUpdate()
    {
        //Debug.Log(rend.material.mainTextureOffset);
        float offset = Time.time * scrollSpeed;
        rend.material.mainTextureOffset = new Vector2(offset, 0);
    }

    /*

    public Transform[] BackGrounds;
   
    public Transform Player;


    [SerializeField]
    private float currentXpos = 11.99f;

    [SerializeField]
    private float layerWidth = 11.99f;
    [SerializeField]
    private float spawnOffset = 2.3f;

    private int index = 0;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void FixedUpdate()
    {
        Debug.Log(spawnOffset);
        Debug.DrawLine(new Vector3(spawnOffset, -10, 0), new Vector3(spawnOffset, 10, 0));
        if (Player.position.x >= spawnOffset)
        {
            MoveBackGround();
        }
    }

    public void MoveBackGround()
    {
        int modulodedIndex = index % BackGrounds.Length;
        Vector3 newPosition = new Vector3(BackGrounds[modulodedIndex].position.x + (layerWidth * BackGrounds.Length),
            BackGrounds[modulodedIndex].position.y, BackGrounds[modulodedIndex].position.z);

        BackGrounds[modulodedIndex].position = newPosition;

        index++;

        spawnOffset += layerWidth;
    }*/
}
