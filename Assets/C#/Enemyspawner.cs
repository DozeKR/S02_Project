using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemyspawner : MonoBehaviour
{
    public Transform[] spawnPoint;

    float timer;

    void Awake(){
        spawnPoint = GetComponentsInChildren<Transform>(); 
    }

    void Update(){
        timer += Time.deltaTime;
        
        if(timer > 0.5f){
            timer = 0f;
            Spawn();
        }
    }

    void Spawn(){
        GameObject enemy = GameManager.instance.em.Get(Random.Range(0, 2));
        enemy.transform.position = spawnPoint[Random.Range(1, spawnPoint.Length)].position;
    }
}
