using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class InteractionScript : MonoBehaviour
{

   public bool isInRange;
   public KeyCode interactKey;
   public UnityEvent interactAction;
   public GameObject Canvas;
   public shuffle _shuffle;

   public Animator anim;

   public PlayerScript ps;

   public static InteractionScript instance;

   private bool isSelectionActive = false;
    void Start()
    {
        instance = this;
    }

    void Update()
    {
        if(isInRange){
            if(Input.GetKeyDown(KeyCode.E) && isSelectionActive == false){
                _shuffle.belirle();
                Canvas.SetActive(true);
                isSelectionActive = true;
                if(isSelectionActive){
                    ps.speed=0;
                }


            }
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.CompareTag("NPC"))
        {

            isInRange = true;
            Inputdeneme.instance.furkan = collision.gameObject;
            Debug.Log("Player is now in range");
        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if(collision.gameObject.CompareTag("NPC"))
        {
            isInRange = false;
            Debug.Log("Player is not now in range");
            isSelectionActive = false;
            ps.speed = 4 ;
            anim.SetBool("oldur",false);
        }
    }

    

}
