using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBeh : MonoBehaviour
{
    public float speed;
    Animator animator;

    Vector3 velocity;

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

     void Update()
    {

        this.transform.position += velocity * Time.deltaTime * speed;

    }


    public IEnumerator firstMovePatern (int side)
    {


        velocity = new Vector3(0.77f * side, -0.77f, 0);
        yield return new WaitForSeconds(8);
      
        velocity = Vector3.up*-1;
        yield return new WaitForSeconds(20);








    }

    
}
