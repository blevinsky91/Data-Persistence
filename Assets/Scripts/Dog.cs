using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dog : MonoBehaviour
{
    public float moveSpeed = 5f;
    private Vector3 randomDirection;

    void OnAwake()
    {
        randomDirection = new Vector3(Random.Range(-1f, 1f), 0f, Random.Range(-1f, 1f)).normalized;
    }

    void Update()
    {
        Bark();
        Move();
    }

    public virtual void Bark()
    {
        Debug.Log("Woof Woof!");
    }

   public void Move()
    {
        transform.Translate(randomDirection * moveSpeed * Time.deltaTime);

        if (transform.position.magnitude > 10f)
        {
            randomDirection = new Vector3(Random.Range(-1f, 1f), 0f, Random.Range(-1f, 1f)).normalized;
        }
    }
}
