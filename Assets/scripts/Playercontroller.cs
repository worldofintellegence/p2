using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class Playercontroller : MonoBehaviour
{
    private bool facingright = true;
    [SerializeField] float Speed =2;
    [SerializeField] GameObject gameobject;
    public ParticleSystem particalsystem;
    public ParticleSystem dirtpartical;
    private Animator Play_anim;
    private Rigidbody playerRb;
    public int force = 6;
    bool isground = true;
    public bool gameover=false;
    public float garavitymodifire;
    public AudioClip jumpaudio;
    public AudioClip crashaudio;
    private AudioSource audioSource;
    public int health = 100;
    public GameObject Gameover;
    void Start()
    {
        playerRb = GetComponent<Rigidbody>();
        Physics.gravity *= garavitymodifire;
        Play_anim = GetComponent<Animator>();
        audioSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        float x = Input.GetAxis("Horizontal");
       if(x>0)
        {

            transform.Translate(Vector3.forward * Speed * Time.deltaTime);
        }
       if(x<0)
        {
         
            transform.Translate(Vector3.forward * Speed * Time.deltaTime);
        }
        if (x > 0 && !facingright)
        {
            flip();
            
        }
       else if (x < 0 && facingright )
        {
            flip();
            
        }
        if (x==0)
        {
            Play_anim.SetBool("Grounded", true);   
        }
        if(x > 0)
        {
            Play_anim.SetBool("Static_b", true);

            Play_anim.SetFloat("Speed_f", x);
        }
        if(x<0)
        {
            Play_anim.SetBool("Static_b", true);

            Play_anim.SetFloat("Speed_f", -x);
            Debug.Log("Hello");
        }
    }
    
    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.CompareTag("Ground"))
        {
            isground = true;
            dirtpartical.Play();
        }
        if(collision.gameObject.CompareTag("Obstacle"))
        {
            gameover = true;
            Debug.Log("Game Over");
            Play_anim.SetBool("Death_b",true);
            Play_anim.SetInteger("DeathType_int", 1);
            particalsystem.Play();  
            audioSource.PlayOneShot(crashaudio, 1.0f);  
            dirtpartical.Stop();
        }
        if (collision.gameObject.CompareTag("Balls"))
        {
            Destroy(collision.gameObject);
            Takedamage();
        }
    }
    void Takedamage()
    {
        //health = health - 50;
        if(health==0)
        {
            Time.timeScale = 0;
            Gameover.SetActive(true);
        }
    }
    
    void flip()
    {
        facingright = !facingright;
        transform.Rotate(0, 180, 0);
    }
}

