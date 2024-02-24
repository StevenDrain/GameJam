using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Kill : MonoBehaviour
{
    // Start is called before the first frame update
    public ScoreManager sm;
    
    void Start()
    {
        sm = FindObjectOfType<ScoreManager>();
    }
    
    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.CompareTag("Enemy"))
        {
            Destroy(col.gameObject); 
            Destroy(gameObject); 
            sm.IncrementScore();
            
           
        }
        
    }
    
}
