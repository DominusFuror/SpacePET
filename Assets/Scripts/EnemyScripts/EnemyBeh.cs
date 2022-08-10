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
        if (collision.gameObject.CompareTag("playerBullet"))
        {
            Destroy(collision.gameObject);
            ScoreCounter.GetScoreCounter().AddScore(20);

            animator.Play("EnemyDestroyAnimation");

        }
    }

    void OnDestroy()
    {

   
        StopAllCoroutines();
    }

     void Update()
    {

        this.transform.position += velocity * Time.deltaTime * speed;

    }


    public void StartMove(int side , int movePatern)
    {
        if (movePatern == 1) StartCoroutine(firstMovePatern(side));
        if (movePatern == 2) StartCoroutine(secondMovePatern(side));
        if (movePatern == 3) StartCoroutine(thirdMovePatter(side));
        if (movePatern == 4) StartCoroutine(fourthMovePatern(side));

    }
    
     IEnumerator firstMovePatern (int side)
    {

        velocity = new Vector3(0.77f * side, -0.77f, 0);
        yield return new WaitForSeconds(4);      
        velocity = Vector3.up*-1;
        yield return new WaitForSeconds(10);

        Destroy(this.gameObject);
        yield break;

    }
     IEnumerator secondMovePatern(int side)
    {

        velocity = new Vector3(0.77f * side, -0.77f, 0);
        yield return new WaitForSeconds(4);

        velocity = new Vector3(0.77f *- side, -0.77f, 0);
        yield return new WaitForSeconds(2);

        velocity = new Vector3(0.77f * side, -0.77f, 0);
        yield return new WaitForSeconds(2);

        velocity = new Vector3(0.77f * -side, -0.77f, 0);
        yield return new WaitForSeconds(2);

        velocity = new Vector3(0.77f * side, -0.77f, 0);
        yield return new WaitForSeconds(2);

        yield return new WaitForSeconds(20);

        Destroy(this.gameObject);
        yield break;

    }

    IEnumerator thirdMovePatter(int side)
    {

        this.transform.position = new Vector3(3 * -side, 42, 0);
        velocity = -Vector3.up;


        yield return new WaitForSeconds(20);

        Destroy(this.gameObject);
        yield break;

    }
    IEnumerator fourthMovePatern(int side)
    {

        this.transform.position = new Vector3(9 * -side, 42, 0);
        velocity = -Vector3.up;


        yield return new WaitForSeconds(20);

        Destroy(this.gameObject);
        yield break;

    }
}
