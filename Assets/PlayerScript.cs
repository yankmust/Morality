using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScript : MonoBehaviour
{
    public float speed = 4;
    private float Move;

    public Animator anim;
    private bool isrun = false;

    private bool islookright=true;

    public Transform renderertransform;


    private Rigidbody2D rb; 
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        
    }

    void Update()
    {
        Move = Input.GetAxis("Horizontal");
        rb.velocity = new Vector2(Move * speed, rb.velocity.y );

        if(Input.GetKey(KeyCode.LeftArrow) || Input.GetKey(KeyCode.RightArrow)||Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.D) ){
            anim.SetBool("isrun",true);
            
        }
        else{
            anim.SetBool("isrun",false);
            
        }


        if(Input.GetKeyDown(KeyCode.LeftArrow) || Input.GetKeyDown(KeyCode.A)){

            if(islookright){
                islookright = false;
                renderertransform.localScale = new Vector2(-renderertransform.localScale.x, renderertransform.localScale.y);
            }

            
        }

        if(Input.GetKeyDown(KeyCode.RightArrow) || Input.GetKeyDown(KeyCode.D)){

            if(!islookright){
                islookright = true;
                renderertransform.localScale = new Vector2(-renderertransform.localScale.x, renderertransform.localScale.y);
            }

            
        }

    }


    
}
