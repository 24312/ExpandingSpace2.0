using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerMovement : MonoBehaviour {

    Rigidbody2D Player;
    Animator animations;
    public bool canJump = false;
    public float jetPackJump = 0.2f;
    public float jumpForceMedium = 3;
    public float jumpForceMax = 6f;
    public float playerSpeedLeft = -4f;
    public bool ifDead = false;
    int temp = 1;
    Quaternion zeroRotation;
    
    public ParticleSystem walkPartic;
    public ParticleSystem jumpPartic;
    public ParticleSystem jetpackPartic;
    private AudioSource walkSound;
    public AudioSource jetpackSound;

    private Gravity gravity;
    private UnlockAchievements setIt;

    private void Awake()
    {
        setIt = GetComponent<UnlockAchievements>();
        Player = GetComponent<Rigidbody2D>();
        gravity = GetComponent<Gravity>();
        animations = GetComponent<Animator>();
        walkSound = GetComponent<AudioSource>();
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
        if (ifDead == false)
        {
            if (Input.GetKey(KeyCode.Space))
            {

                jetpackPartic.Play();
                if (canJump == true)
                {
                    Player.AddForce((13 * jetPackJump) * transform.up, ForceMode2D.Impulse);
                    canJump = false;
                    animations.Play("Jump");
                    jumpPartic.Play();
                    setIt.SetAchievements(1);
                }
                else
                {
                    Player.AddForce((1 * jetPackJump) * transform.up, ForceMode2D.Impulse);
                    animations.Play("Jump");
                    if (jetpackSound.isPlaying == false)
                    {
                        jetpackSound.Play();
                    }
                }

            }
            else
            {
                //jetpackSound.Stop();
            }

            if (Input.GetKeyUp(KeyCode.Space))
                jetpackPartic.Stop();

            if (canJump == true)
            {
                animations.Play("Walk");
                walkPartic.Play();
                if(walkSound.isPlaying == false)
                {
                    walkSound.Play();
                }
                jetpackPartic.Stop();
                setIt.SetAchievements(2);
            }
            if (canJump == false)
            {
                walkSound.Stop();
                walkPartic.Stop();
            }
                
        }
        else
        {
            Player.velocity = transform.right * 0;
            walkPartic.Stop();
        }

    }
    public void RandomMove(string a)
    {
        if(a == "Enable")
        {
            if(temp == 1)
            {
                Player.velocity = -transform.right * playerSpeedLeft;
            }
        }
        else
        {
            return;
        }
    }

}

