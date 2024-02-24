using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class powerup3 : MonoBehaviour
{
    public ScoreManager sm;
    public Transform powerPos;
    
   
    void Update()
    {
        if(sm.score > 300){
            transform.position = powerPos.position;
        }
        
    }

    
}
