using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class Projectile : MonoBehaviour
{
    [Header("---Projectile Settings---")]
    public float Velocity = 1000;
    public Transform projectileSpawner;
    public GameObject projectilePrefab;
    public float projectileLifeTime = 5;

    private void Start()
    {
        Velocity = 1000;
    }
    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        { 
            GameObject projectileInstance = Instantiate(projectilePrefab, projectileSpawner.position, projectileSpawner.rotation);
            projectileInstance.GetComponent<Rigidbody>().AddForce(projectileSpawner.transform.forward * Velocity);
            Destroy(projectileInstance, projectileLifeTime);
            
        }
    }
}