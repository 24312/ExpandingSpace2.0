using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour {

    Rigidbody2D Player;
    Animator animations;
    public bool canJump = false;
    public float jetPackJump = 0.2f;
    public float jumpForceMedium = 3;
    public float jumpForceMax = 6f;
    public float playerSpeedLeft = -4f;
    public float playerSpeedRight = 4f;
    int temp = 1;
    Quaternion zeroRotation;
    
    public ParticleSystem walkPartic;
    public ParticleSystem jumpPartic;
    public ParticleSystem jetpackPartic;

    private Gravity gravity;
    private UnlockAchievements setIt;

    private void Awake()
    {
        setIt = GetComponent<UnlockAchievements>();
        Player = GetComponent<Rigidbody2D>();
        gravity = GetComponent<Gravity>();
        animations = GetComponent<Animator>();
        playerSpeedLeft = PlayerPrefs.GetFloat("Dificulty", -4);
        playerSpeedRight = PlayerPrefs.GetFloat("Dificulty", -4);
    }
    private void OnCollisionStay2D(Collision2D other)
    {
        if(other.gameObject.tag == "Planet")
        {
            if(canJump == false)
            {
                canJump = true;
            }
            RandomMove("Enable");
            return;
        }
        else
        {
            return;
        }
    }
    // Update is called once per frame
    void FixedUpdate()
    {
        if (Input.GetKey(KeyCode.Space))
        {
            
            jetpackPartic.Play();
            if (canJump == true)
            {
                Player.AddForce((15f * jetPackJump) * transform.up, ForceMode2D.Impulse);
                canJump = false;
                animations.Play("Jump");
                jumpPartic.Play();
                setIt.SetAchievements(1);
            }
            else
            {
                Player.AddForce((1 * jetPackJump) * transform.up, ForceMode2D.Impulse);
                animations.Play("Jump");
            }
            
        }
        if (Input.GetKeyUp(KeyCode.Space))
            jetpackPartic.Stop();

        if (canJump == true)
        {
            animations.Play("Walk");
            walkPartic.Play();
            jetpackPartic.Stop();
        }
        if (canJump == false)
            walkPartic.Stop();

    }
    public void RandomMove(string a)
    {
        if(a == "Enable")
        {
            if(temp == 1)
            {
                Player.velocity = -transform.right * playerSpeedLeft;
            }
            //else if(temp == 2)
            //{
            //    Player.velocity = -transform.right * playerSpeedRight;
            //}
        }
        else
        {
            return;
        }
    }

}

