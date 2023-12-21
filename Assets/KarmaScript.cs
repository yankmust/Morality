using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class KarmaScript : MonoBehaviour
{
    public int KarmaNum;

    void Start()
    {
        KarmaNum = 0;
    }
    void KarmaAdd()
    {
        KarmaNum += 10;
    }
    void KarmaSubtract()
    {
        KarmaNum = KarmaNum - 10;
    }
    
}
