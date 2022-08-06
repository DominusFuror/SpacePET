using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletBech : MonoBehaviour
{

    [SerializeField] float bulletSpeed;
    private void Update()
    {
        this.transform.position += bulletSpeed * this.transform.up * Time.deltaTime;

    }
}
