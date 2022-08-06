using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawningManager : MonoBehaviour
{

    Vector3 rightSpawnPoint = new Vector3(-27, 40, 0);
    Vector3 leftSpawnPoint = new Vector3(27, 40, 0);


    [SerializeField] GameObject firstEnemy;
    private void Start()
    {
        StartCoroutine(EnemySpawnCycle());
    }
    IEnumerator EnemySpawnCycle()
    {

        yield return new WaitForSeconds(5);

        for (int i = 0; i < 8; i++)
        {

            var temp = Instantiate(firstEnemy, rightSpawnPoint, Quaternion.identity) ;
            StartCoroutine(temp.GetComponent<EnemyBeh>().firstMovePatern(1));


            temp = Instantiate(firstEnemy, leftSpawnPoint, Quaternion.identity);
            StartCoroutine(temp.GetComponent<EnemyBeh>().firstMovePatern(-1));

            yield return new WaitForSeconds(1);

        }


        yield break;
    }

}

