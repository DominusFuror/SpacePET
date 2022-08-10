using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BuffBehh : MonoBehaviour
{
    [SerializeField] float speed;
    private void Start()
    {
        Destroy(this.gameObject, 30);
    }
    void Update()
    {
        this.transform.position += Vector3.up * -speed * Time.deltaTime;


    }
}
