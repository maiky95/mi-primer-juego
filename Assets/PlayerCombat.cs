using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCombat : MonoBehaviour
{
    public Animator animator;

    public LayerMask enemyLayers;
    public Transform attackPoint;
    public float attackRange = 0.5f;
    public int attackDamage = 5;


    // Update is called once per frame
    void Update()
    {
       if (Input.GetKeyDown(KeyCode.X))
        {
            Attack();
        }
       
    }
    void Attack()
    {
        //Play an attack animation
        animator.SetTrigger("Attack");

        //Detect enemies in range of attack
        Collider2D[] hitEnemies = Physics2D.OverlapCircleAll(attackPoint.position, attackRange, enemyLayers);

        //Damage them
        foreach(Collider2D enemy in hitEnemies)
        {
            enemy.GetComponent<enemyhealth>().TakeDamage(attackDamage);
        }
    }

    void OnDrawGizmosSelected()
    {


        Gizmos.DrawWireSphere(attackPoint.position, attackRange);
    }
}

