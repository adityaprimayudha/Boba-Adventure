using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    private Rigidbody2D rb;
    public float playerSpeed;
    private bool isGrounded;
    public string axis = "Horizontal";
    public string Jumpaxis = "Jump";
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
         Physics2D.IgnoreLayerCollision(6, 7);
         if (axis == "Horizontal2" && GameData.instance.isSinglePlayer)
        {
            return;
        }
        float horizontalInput = Input.GetAxis(axis);
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
        if (axis == "Horizontal"){
        anim.SetBool("isWalking",horizontalInput!=0);
        }
        if (axis == "Horizontal2"){
        anim.SetBool("isWalkingGirl",horizontalInput!=0);
        }
         if (Jumpaxis == "Jump" ){
        if(Input.GetButtonDown("Jump") && isGrounded){
            rb.velocity = new Vector2(rb.velocity.x,playerSpeed)*3;
            anim.SetTrigger("Jump");
        }
         }
        if (Jumpaxis == "Jump2" ){
        if(Input.GetButtonDown("Jump2") && isGrounded){
            rb.velocity = new Vector2(rb.velocity.x,playerSpeed)*3;
            anim.SetTrigger("jumpGirl");
        }
        }
        rb.constraints = RigidbodyConstraints2D.FreezeRotation;
    }
    void OnCollisionEnter2D(Collision2D col){
        isGrounded = true;
        //Debug.Log("Grounded");
    }
    void OnCollisionExit2D(Collision2D col){
        isGrounded = false;
        //Debug.Log("notGrounded");
    }
}
