using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerFireManager : MonoBehaviour
{

    [SerializeField] GameObject lowBullet, bigBullet;


    int mode = 1;

    float attackRate = 1;
    float timer = 0;
    private void Update()
    {
        timer += Time.deltaTime;

        if (timer >= attackRate)
        {

           if(mode == 1)
            {
                timer -= attackRate;

                Instantiate(lowBullet, this.transform.position, this.transform.rotation);
            }
           if ( mode == 2)
            {

                timer -= attackRate;

                Instantiate(lowBullet, this.transform.position - Vector3.right, this.transform.rotation);
                Instantiate(lowBullet, this.transform.position +  Vector3.right, this.transform.rotation);
            }

        }


        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {

        if (collision.gameObject.CompareTag("buffx2"))
        {

            mode = 2;
            Destroy(collision.gameObject);
        }



    }

}
