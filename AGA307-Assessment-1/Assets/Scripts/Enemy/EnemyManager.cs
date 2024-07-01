using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyManager : Singleton<EnemyManager>
{
    public Transform[] spawnPoints = new Transform[8];
    public GameObject[] skeletons = new GameObject[8];

    public List<GameObject> enemies = new List<GameObject>();

    private void Start()
    {
        Count();
        Sum();
        GameEvents.EnemyDie += EnemyDied;
        ShuffleList(enemies);
    }
    private void OnDestroy()
    {
        GameEvents.EnemyDie -= EnemyDied;
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.F))
        {
            SpawnEnemy();
        }
    }
    void Sum()
    {
        int target = 10;
        int total = 0;
        for (int i = 1;  i <= target; i++) 
        { 
            total = total + i;
        }
        print("Sum: " + total);
    }
    void Count()
    {
        int numIterations = 101;
        for (int i = 0; i < numIterations; i++)
        {
            print(i);
        }
    }
        void SpawnEnemy()
        {
            if (enemies.Count <= 1)
            {
                for (int i = 0; i < spawnPoints.Length; i++)
                {
                    GameObject enemy = Instantiate(skeletons[Random.Range(0, 9)], spawnPoints[i].position, spawnPoints[i].rotation);
                    enemies.Add(enemy);
                }
            }
                else
                {
                    print("Enemy Count: " + enemies.Count);
                }
        }
    void EnemyDied(EnemyBeh e)
    {
        enemies.Remove(e.gameObject);
        Debug.Log(enemies.Count);
    }
}
