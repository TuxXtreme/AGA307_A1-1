using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBeh : MonoBehaviour
{
    public EnemyType type;
    public int Health;
    float moveDistance = 500;
    private void Start()
    {
        SetUp();
    }
    void Update()
    {
     if(Input.GetKeyDown(KeyCode.Space))
        {
            StartCoroutine(Move());
        }
    if(Input.GetKeyDown(KeyCode.H))
        {
            hit();
        }
    }
    private void OnCollisionEnter(Collision other)
    {
        if (other.collider.tag == "Projectile")
        {
            hit();
            Destroy(GetComponent<MeshRenderer>());
        }
    }
    void SetUp()
    {
        switch(type)
        {
            case EnemyType.Archer:
                Health = 10;
                break;
            case EnemyType.OneHanded:
                Health = 20; 
                break;
            case EnemyType.TwoHanded:
                Health = 30;
                break;
        }
    }
    void hit()
    {
        GameEvents.OneEnemyHit(this);
        Health-= 5;
        if(Health <= 0)
        {
            Die();
        }
    }

    void Die()
    {
        GameEvents.OneEnemyDie(this);
        StopAllCoroutines();
        GameManeger.instance.AddScore(100);
        Destroy(this.gameObject);
    }
    IEnumerator Move()
    { 
        for(int i = 0; i < moveDistance; i++)
        {
            transform.Translate(Vector3.forward * Time.deltaTime);
            yield return null;
        }
        yield return new WaitForSeconds(3);
        transform.Rotate(Vector3.up * 180);
        yield return null;
        StartCoroutine(Move());
    }
}
