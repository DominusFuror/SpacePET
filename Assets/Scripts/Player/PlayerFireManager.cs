using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerFireManager : MonoBehaviour
{

    [SerializeField] GameObject lowBullet, bigBullet;




    float attackRate = 1;
    float timer = 0;
    private void Update()
    {
        timer += Time.deltaTime;

        if (timer >= attackRate)
        {

            timer -= attackRate;

            Instantiate(lowBullet, this.transform.position, this.transform.rotation);

        }


        
    }

}
