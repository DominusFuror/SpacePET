using System.Globalization;
using System.Runtime.InteropServices;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;




public class TouchInputSc : MonoBehaviour
{
   
    [SerializeField]
    ShipMovement shipMovement;
    Vector2 touchPosition;


    Camera mainCamera;

 
   

   
    void Start(){


        mainCamera = Camera.main;
    }
    void Update(){



        if(Input.touchCount!=0){

        
          

            touchPosition =  Input.GetTouch(Input.touchCount-1).position;
            shipMovement.MoveShip(mainCamera.ScreenToWorldPoint(touchPosition));

            print(touchPosition);

        }


    }

}
