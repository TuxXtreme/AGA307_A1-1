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
    
        hit();
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
