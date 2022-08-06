using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBeh : MonoBehaviour
{
    Animator animator;

    private void Start()
    {

       animator =  this.GetComponent<Animator>();
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        print("SD");
        if (collision.gameObject.CompareTag("playerBullet"))
        {

            Destroy(collision.gameObject);
            animator.Play("EnemyDestroyAnimation");

        }
    }

    
}
