using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletBech : MonoBehaviour
{

    [SerializeField] float bulletSpeed;

    void Start()
    {

        Destroy(this.gameObject, 15);
    }

  
    private void Update()
    {
        this.transform.position += bulletSpeed * this.transform.up * Time.deltaTime;

        if (transform.position.y > 35) Destroy(this.gameObject);
    }
}
