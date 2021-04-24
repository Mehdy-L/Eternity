using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playercontroller2 : MonoBehaviour
{
    public int Speed = 5;
    private Vector3 DirectionDeplacement = Vector3.zero;
    public int Sensi;
    public int Jump = 4;
    public int gravite = 20;
    private Animator Anim;
    public int RunSpeed = 10;
    
    private CharacterController Player;
    // Start is called before the first frame update
    void Start()
    {
        Player = GetComponent<CharacterController>();
        Anim= GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        DirectionDeplacement.z = Input.GetAxisRaw("Vertical");
        DirectionDeplacement.x = Input.GetAxisRaw("Horizontal");
        DirectionDeplacement = transform.TransformDirection(DirectionDeplacement);
        //deplacement 
        if (Input.GetKey(KeyCode.LeftShift))
        {
            Player.Move(DirectionDeplacement * Time.deltaTime * RunSpeed);
        }
        else
        {
            Player.Move(DirectionDeplacement * Time.deltaTime * Speed);
        }
        
        transform.Rotate(0, Input.GetAxisRaw("Mouse X")*10, 0);
        
        //saut

        if (Input.GetKeyDown(KeyCode.Space)&& Player.isGrounded)
        {
            DirectionDeplacement.y = Jump;
            Anim.SetTrigger("Jumping");
        }
        
        //Gravite

        if (!Player.isGrounded)
        {
            DirectionDeplacement.y -= gravite * Time.deltaTime;
        }

        //Animation
        if (Input.GetKey(KeyCode.W) & ! Input.GetKey(KeyCode.LeftShift))
        {
            Anim.SetBool("Walk", true);
            Anim.SetBool("Run", false);
        }
        if (Input.GetKey(KeyCode.W) & Input.GetKey(KeyCode.LeftShift))
        {
            Anim.SetBool("Walk", false);
            Anim.SetBool("Run", true);
        }
        if (!Input.GetKey(KeyCode.W))
        {
            Anim.SetBool("Walk", false);
            Anim.SetBool("Run", false);
        }



    }
}
