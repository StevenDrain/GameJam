using UnityEngine;
using System.Collections;
using UnityEngine.AI;
using UnityEngine.SceneManagement;

public class EnemyMove : MonoBehaviour
{
    public GameObject playergo;
    public GameObject player;
    public NavMeshAgent agent;

    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");

    }
    void Update()
    {

        agent.destination = player.transform.position;
        
    }
    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.CompareTag("Player"))
        {
       
            SceneManager.LoadScene("Dead");
        }
    }
}