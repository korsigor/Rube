using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour
{
    Rigidbody2D rigidbody2d;

    void Awake()
    {
      rigidbody2d = GetComponent<Rigidbody2D>();
    }

    public void Launch(Vector2 direction, float force)
    {
        rigidbody2d.AddForce(direction * force);
   }

    void Update()
    {
        if (transform.position.magnitude > 30.0f)
        {
            Destroy(gameObject);
        }
    }

    void OnCollisionEnter2D(Collision2D other)
    {
        enemymove e = other.collider.GetComponent<enemymove>();
        if (e != null)
        {
            e.Fix();
        }
        
        Destroy(gameObject);
    }     
}
