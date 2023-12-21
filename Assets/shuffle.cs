using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class shuffle : MonoBehaviour
{

    public bool isInRange;
    public TextMeshProUGUI sag;
    public TextMeshProUGUI sol;
    

    public string[ ] goodwordlist = new string[]{"pray","save","spare","health","birth","love","care","peace","alive","bless","heal","meditate","polite","praise","help"};

    public string[ ] badwordlist = new string[]{"slaughter","kill","death","rampage","prey","savage","atrocity","brutal","blood","fury","fear","anger","murder","sadistic","grim"};


    public void belirle(){
        
    {

        int random = Random.Range(0, 15);
            
                
        sag.text = goodwordlist[random];
        sol.text = badwordlist[random];
        

        

    }





    }



}

 
