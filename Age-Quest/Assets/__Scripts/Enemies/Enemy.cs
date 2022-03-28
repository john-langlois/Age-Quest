using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
public class Enemy : MonoBehaviour
{   
    // player enemy is fighting 
    public string questPlayer;
    // enemy stats 
    CharacterStats enemyStats;
    // player stats 
    CharacterStats playerStats;
    // radius of enemy vision 
    public float lookRadius = 10f;
    // enemy mesh composition 
    NavMeshAgent agent;
    // controlled player 
    Transform player; 
    
    // Start is called before the first frame update
    void Start()
    {   
        enemyStats = new CharacterStats();
        playerStats = new CharacterStats();

        // obtain player object's transform
        player = GameObject.Find(questPlayer).transform;
        // set enemy object 
        agent = GetComponent<NavMeshAgent>();

        enemyStats.health = 200;
        enemyStats.damage = 20;

        playerStats.health = 100;
        playerStats.damage = 10;
    }

    // Update is called once per frame
    void Update()
    {
        // obtain the distance between enemy and player position
        float distance = Vector3.Distance(player.position, transform.position);

        // if player is in the radius of the enemy begin to approach their position 
        if (distance <= lookRadius){
            agent.SetDestination(player.position);
        } 
        if (distance <= agent.stoppingDistance){
            // make enemy face directly towards the player
            FacePlayer();
        }
    }

    // face player when moving towards them 
    void FacePlayer(){
        // find the distance between the directions and normalize it 
        Vector3 faceDirection = (player.position - transform.position).normalized;
        // initiate a rotation towards the player in the right direction (eye to eye contact)
        Quaternion faceRotation = Quaternion.LookRotation(new Vector3(faceDirection.x , 0 , faceDirection.z));
        // assign the adjustment to the enemy 
        transform.rotation = faceRotation;
    }    

    // deal damage to player 
    void OnTriggerEnter(Collider obj){
        // allow enemy damage to be inflicted on opponent
        Debug.Log("Colided with big man");
        playerStats.DealDamage(enemyStats);
        enemyStats.DealDamage(playerStats);
    }
}
