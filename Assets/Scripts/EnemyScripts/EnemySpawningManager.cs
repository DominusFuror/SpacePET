using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawningManager : MonoBehaviour
{

    Vector3 rightSpawnPoint = new Vector3(-27, 40, 0);
    Vector3 leftSpawnPoint = new Vector3(27, 40, 0);


    [SerializeField] GameObject firstEnemy;
    [SerializeField] GameObject buffx2;
    [SerializeField] GameObject buffx3;
    [SerializeField] GameObject ultimateBuff;
   
   
    private void Start()
    {
        StartCoroutine(EnemySpawnCycle());
    }
    IEnumerator EnemySpawnCycle()
    {

        yield return new WaitForSeconds(1);

        Instantiate(buffx2, new Vector3(-12, 40, 0), Quaternion.identity);

        #region First Pattern
        for (int i = 0; i < 8; i++)
        {
            var temp = Instantiate(firstEnemy, rightSpawnPoint, Quaternion.identity);
            temp.GetComponent<EnemyBeh>().StartMove(1, 1);

            temp = Instantiate(firstEnemy, leftSpawnPoint, Quaternion.identity);
            temp.GetComponent<EnemyBeh>().StartMove(-1 ,1 );

            yield return new WaitForSeconds(1);

        }
        #endregion

        yield return new WaitForSeconds(1);

        #region Second Pattern 
        for (int i = 0; i < 8; i++)
        {

            var temp = Instantiate(firstEnemy, rightSpawnPoint, Quaternion.identity);
            temp.GetComponent<EnemyBeh>().StartMove(1, 2);

            temp = Instantiate(firstEnemy, leftSpawnPoint, Quaternion.identity);
            temp.GetComponent<EnemyBeh>().StartMove(-1, 2);

            yield return new WaitForSeconds(1);

          

        }
        yield return new WaitForSeconds(3);

        #endregion
        #region Third Pattern 
        for (int i = 0; i < 8; i++)
        {

            var temp = Instantiate(firstEnemy, rightSpawnPoint, Quaternion.identity);
            temp.GetComponent<EnemyBeh>().StartMove(1, 3);
             temp = Instantiate(firstEnemy, rightSpawnPoint, Quaternion.identity);
            temp.GetComponent<EnemyBeh>().StartMove(1, 4);
            temp = Instantiate(firstEnemy, rightSpawnPoint, Quaternion.identity);
            temp.GetComponent<EnemyBeh>().StartMove(-1, 3);
            temp = Instantiate(firstEnemy, rightSpawnPoint, Quaternion.identity);
            temp.GetComponent<EnemyBeh>().StartMove(-1, 4);


            yield return new WaitForSeconds(0.5f);

         

        }
        #endregion

        yield break;
    }

    
}

