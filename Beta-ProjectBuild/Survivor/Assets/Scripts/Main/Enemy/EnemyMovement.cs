using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    public Transform player;

    private Rigidbody2D enem;
    private Vector2 movement;

    public float enemSpeed = 4;
   
    void Start()
    {
        enem = this.GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 direction = player.position - transform.position;
        direction.Normalize();
        movement = direction;
        
    }

    private void FixedUpdate()
    {
        moveEnemy(movement);
    }

    void moveEnemy(Vector2 direction)
    {
        enem.MovePosition((Vector2)transform.position + (direction * enemSpeed * Time.deltaTime));
    }
}
