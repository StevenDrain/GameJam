using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class powerup2 : MonoBehaviour
{
    public ScoreManager sm;
    public Transform powerPos;
    
   
    void Update()
    {
        if(sm.score > 50){
            transform.position = powerPos.position;
        }
        
    }

    
}
