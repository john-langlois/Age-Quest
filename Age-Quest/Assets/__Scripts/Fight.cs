using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fight : MonoBehaviour
{
    public GameObject enemyPrefab;
    public GameObject enemy2Prefab;

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Spawning objects");
        GameObject enemy = Instantiate(enemyPrefab) as GameObject;
        GameObject player = Instantiate(enemy2Prefab) as GameObject;

        enemy.transform.position = new Vector3(26,0,-77);
        player.transform.position = new Vector3(26,0,-77);
    }
}