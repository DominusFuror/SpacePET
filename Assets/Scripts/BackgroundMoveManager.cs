using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundMoveManager : MonoBehaviour
{
   

   [SerializeField] List<GameObject> backGroundImages = new List<GameObject>();
    Transform parent;
    public float speed;
    int currentLowestBG=4;
     int currentHighestBG = 1;
   void Start(){



     parent = backGroundImages[0].transform.parent;
   }

  

   
    
    
    void Update()
    { 
       foreach(var item in backGroundImages){

         item.transform.position+= (Vector3)Vector2.up * Time.deltaTime * -speed;
       }


        if(backGroundImages[currentLowestBG-1].transform.position.y <=-80){


            backGroundImages[currentLowestBG-1].transform.position = backGroundImages[currentHighestBG-1].transform.position+ Vector3.up *40;
            currentHighestBG = currentLowestBG;
            currentLowestBG--;

            if(currentLowestBG<=0) {
              currentLowestBG=4;
              
            }

            

        }


    }
}
