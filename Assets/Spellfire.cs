using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spellfire : MonoBehaviour
{
    public float speed = 20f;
    public Rigidbody2D rb;
    public int damage = 10;

    // Start is called before the first frame update
    void Start()
    {
        rb.velocity = transform.right * speed;
    }

    void OnTriggeEnter2D (Collider2D hitInfo)
    {
        enemyhealth enemy = hitInfo.GetComponent<enemyhealth>();
        if (enemy != null)
        {
            enemy.TakeDamage(damage);
        }
        Destroy(gameObject);
    }

    
}
