using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawningManager : MonoBehaviour
{

    Vector3 rightSpawnPoint = new Vector3(-27, 40, 0);
    Vector3 leftSpawnPoint = new Vector3(27, 40, 0);

    [SerializeField] GameObject eventSystem;

    [SerializeField] GameObject firstEnemy;
    [SerializeField] GameObject buffx2;
    [SerializeField] GameObject buffx3;
    [SerializeField] GameObject ultimateBuff;
   
   
    private void Start()
    {
        Application.targetFrameRate = 60;
        StartCoroutine(EnemySpawnCycle());
    }
    IEnumerator EnemySpawnCycle()
    {

        yield return new WaitForSeconds(1);

        Instantiate(buffx2, new Vector3(-12, 40, 0), Quaternion.identity);

        #region First Pattern
        for (int i = 0; i < 10; i++)
        {
            var temp = Instantiate(firstEnemy, rightSpawnPoint, Quaternion.identity);
            temp.GetComponent<EnemyBeh>().StartMove(1, 1);

            temp = Instantiate(firstEnemy, leftSpawnPoint, Quaternion.identity);
            temp.GetComponent<EnemyBeh>().StartMove(-1 ,1 );

            yield return new WaitForSeconds(0.8f);

        }
        #endregion

        yield return new WaitForSeconds(2);
        Instantiate(buffx3, new Vector3(-8, 40, 0), Quaternion.identity);
        #region Second Pattern 
        for (int i = 0; i < 10; i++)
        {

            var temp = Instantiate(firstEnemy, rightSpawnPoint, Quaternion.identity);
            temp.GetComponent<EnemyBeh>().StartMove(1, 2);

            temp = Instantiate(firstEnemy, leftSpawnPoint, Quaternion.identity);
            temp.GetComponent<EnemyBeh>().StartMove(-1, 2);

            yield return new WaitForSeconds(0.8f);

          

        }
        yield return new WaitForSeconds(5);

        #endregion
        Instantiate(ultimateBuff, new Vector3(2, 40, 0), Quaternion.identity);
        yield return new WaitForSeconds(2);
        #region Third Pattern 
        for (int i = 0; i < 12; i++)
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
        yield return new WaitForSeconds(6);
        eventSystem.GetComponent<DialogManager>().StartDialog();
        

        yield break;
    }

    
}

