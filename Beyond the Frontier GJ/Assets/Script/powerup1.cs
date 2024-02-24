using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class powerup1 : MonoBehaviour
{
    public ScoreManager sm;
    public Transform powerPos;
    
   
    void Update()
    {
        if(sm.score > 150){
            transform.position = powerPos.position;
        }
        
    }

    
}
