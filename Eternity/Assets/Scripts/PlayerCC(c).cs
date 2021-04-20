using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCC : MonoBehaviour
{
    public float speed = 6f;
    public float jumpSpeed = 15f;
    public float gravity = 20f;
    private Vector3 moveDirection = Vector3.zero;

    CharacterController Cc;

    // Start is called before the first frame update
    void Start()
    {
        Cc = GetComponent<CharacterController>();

    }

    // Update is called once per frame
    void Update()
    {
        if (Cc.isGrounded)
        {
            moveDirection = new Vector3(0, 0, Input.GetAxis("Vertical"));
            moveDirection = transform.TransformDirection(moveDirection);
            moveDirection *= speed;

            if (Input.GetButtonDown("Jump"))
            {
                moveDirection.y = jumpSpeed;
            }
        }

        moveDirection.y -= gravity * Time.deltaTime;

        transform.Rotate(Vector3.up * Input.GetAxis("Horizontal") * Time.deltaTime * speed * 20);

        Cc.Move(moveDirection * Time.deltaTime);
    }
}
