using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Endingler : MonoBehaviour
{



    public KarmaScript karmascript;
    public TimerScript time;

   
    void Start()
    {
        
    }

    void Update()
    {
        if(karmascript.KarmaNum>35){
            SceneManager.LoadScene(3);
        }
        else if(karmascript.KarmaNum<-35){
            SceneManager.LoadScene(4);
        } 



        if(time.remainingTime<1 && karmascript.KarmaNum<35 && karmascript.KarmaNum>-35){
            SceneManager.LoadScene(2);
        }



    }


}
