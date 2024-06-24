using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyManager : MonoBehaviour
{
    public Transform[] spawnPoints = new Transform[8];
    public GameObject[] skeletons = new GameObject[8];

    public List<GameObject> enemies = new List<GameObject>();

    private void Start()
    {
        Count();
        Sum();
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
            for (int i = 0; i < spawnPoints.Length;i++) 
            { 
                GameObject enemy = Instantiate(skeletons[0], spawnPoints[i].position, spawnPoints[i].rotation);
                enemies.Add(enemy);
            }
            print("Enemy Count: " + enemies.Count);
        }
}
