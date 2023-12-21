using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Inputdeneme : MonoBehaviour
{

    public KarmaScript karmascript;
    public string name;
    public TMP_InputField input;
    public TextMeshProUGUI textDisplay;

    public TextMeshProUGUI sol;

    public TextMeshProUGUI sag;

    public GameObject furkan;

    public GameObject Canvas;

    public Animator anim;

    public bool oldur = false;

    public static Inputdeneme instance;


    

    void Start()
    {
        instance = this;
    }

    void Update()
    {
        
    }

    public void mercy(){
            karmascript.KarmaNum += 15;
            print(karmascript.KarmaNum);
            anim.SetBool("oldur",true);
            Canvas.SetActive(false);
            Destroy(furkan);
        
    }

    public void kill(){
           karmascript.KarmaNum -= 15;
           print(karmascript.KarmaNum);
           anim.SetBool("oldur",true);
           Canvas.SetActive(false);
           Destroy(furkan,2);
            
        
    }


     public void StoreName(){
        name = input.text;
        textDisplay.text = "Your Choice is" + " " + name;
        if(name == sol.text){
            kill();
            print(karmascript);
            
        }
        else if(name == sag.text){ 
            mercy();
            print(karmascript);

        }

    }


    


}
