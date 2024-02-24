using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class powerup : MonoBehaviour
{
    public ScoreManager sm;
    public Transform powerPos;
    
   
    void Update()
    {
        if(sm.score > 15){
            transform.position = powerPos.position;
        }
        
    }

    
}
