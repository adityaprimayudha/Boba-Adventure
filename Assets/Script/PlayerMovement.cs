using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    private Rigidbody2D rb;
    public float playerSpeed;
    private bool isGrounded;
    private Animator anim;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        float horizontalInput = Input.GetAxis("Horizontal");
        float local = transform.localScale.x;
        rb.velocity = new Vector2(playerSpeed*horizontalInput,rb.velocity.y);
        if(horizontalInput > 0.01f){
            if(local>0){
                transform.localScale = new Vector3(local,local,local);
            }
            else if(local<0){
                transform.localScale = new Vector3(local*-1,local*-1,local*-1);
            }
        }
        else if(horizontalInput < -0.01f){
            if(local>0){
                transform.localScale = new Vector3(local*-1,local,local);
            }
            else if(local<0){
                transform.localScale = new Vector3(local,local*-1,local*-1);
            }
        }
        anim.SetBool("isWalking",horizontalInput!=0);
        if(Input.GetButtonDown("Jump") && isGrounded){
            rb.velocity = new Vector2(rb.velocity.x,playerSpeed)*3;
            anim.SetTrigger("Jump");
        }
        rb.constraints = RigidbodyConstraints2D.FreezeRotation;
    }
    void OnCollisionEnter2D(Collision2D col){
        isGrounded = true;
        Debug.Log("Grounded");
    }
    void OnCollisionExit2D(Collision2D col){
        isGrounded = false;
        Debug.Log("notGrounded");
    }
}
