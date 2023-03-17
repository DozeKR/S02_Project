using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemyspawner : MonoBehaviour
{
    public Transform[] spawnPoint;
    public SpawnData[] spawnData;

    int level;

    float timer;

    void Awake(){
        spawnPoint = GetComponentsInChildren<Transform>(); 
    }

    void Update(){
        timer += Time.deltaTime;
        level = Mathf.FloorToInt(GameManager.instance.gameTime / 10f);
        
        if(timer > spawnData[level].spawnTime){
            timer = 0f;
            Spawn();
        }
    }

    void Spawn(){
        GameObject enemy = GameManager.instance.em.Get(0);
        enemy.transform.position = spawnPoint[Random.Range(1, spawnPoint.Length)].position;
        enemy.GetComponent<Enemy>().Init(spawnData[level]);
    }
}

[System.Serializable]
public class SpawnData
{
    public float spawnTime;
    public int enemyType;
    public int enemyhealth;
    public float enemyspeed;
}