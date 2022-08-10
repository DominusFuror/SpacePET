using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerFireManager : MonoBehaviour
{

    [SerializeField] GameObject lowBullet, bigBullet;
    [SerializeField] AudioSource AudioSource;


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
         

                Instantiate(lowBullet, this.transform.position, this.transform.rotation);
            }
           if ( mode == 2)
            {

       

                Instantiate(lowBullet, this.transform.position - Vector3.right, this.transform.rotation);
                Instantiate(lowBullet, this.transform.position +  Vector3.right, this.transform.rotation);
            }
            if (mode == 3)
            {
 

                Instantiate(lowBullet, this.transform.position + Vector3.right * 2, this.transform.rotation);
                Instantiate(lowBullet, this.transform.position  , this.transform.rotation);
                Instantiate(lowBullet, this.transform.position - Vector3.right * 2, this.transform.rotation);
            }
            if (mode == 4)
            {

        

                Instantiate(lowBullet, this.transform.position + Vector3.right * 2, this.transform.rotation);
                Instantiate(lowBullet, this.transform.position, this.transform.rotation);
                Instantiate(lowBullet, this.transform.position - Vector3.right * 2, this.transform.rotation);

                Instantiate(lowBullet, this.transform.position, Quaternion.Euler(0,0,10));
                Instantiate(lowBullet, this.transform.position, Quaternion.Euler(0,0,-10));
               
            }
            timer -= attackRate;
            AudioSource.Play();
        }


        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {

        if (collision.gameObject.CompareTag("buffx2"))
        {
            attackRate *= 0.6f;
            mode = 2;
            Destroy(collision.gameObject);
        }
        if (collision.gameObject.CompareTag("buffx3"))
        {
            attackRate *= 0.6f;
            mode = 3;
            Destroy(collision.gameObject);
        }
        if (collision.gameObject.CompareTag("ultimateBuff"))
        {

            mode = 4;
            attackRate *= 0.6f;
            Destroy(collision.gameObject);
        }


    }

}
