using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fight : MonoBehaviour
{
    public GameObject enemyPrefab;
    public GameObject enemy2Prefab;
    CharacterStats enemyStats;
    CharacterStats playerStats;

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Spawning objects");

        GameObject enemy = Instantiate(enemyPrefab) as GameObject;
        GameObject player = Instantiate(enemy2Prefab) as GameObject;

        enemyStats = new CharacterStats();
        playerStats = new CharacterStats();

        // set character stats based on charcter 

    
        enemy.transform.position = new Vector3(26,0,-77);
        player.transform.position = new Vector3(26,0,-77);


    }

    // deal damage to player 
    void OnTriggerEnter(Collider obj){
        // allow enemy damage to be inflicted on opponent
        Debug.Log("Colided with big man");
        playerStats.DealDamage(enemyStats);
        enemyStats.DealDamage(playerStats);
    }

    void determineEnemyStats(GameObject enemy){
        if (enemy.tag == "Golemn"){
            enemyStats.damage = 40;
        }
    }
}