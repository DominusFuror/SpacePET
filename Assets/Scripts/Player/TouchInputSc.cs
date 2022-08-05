using System.Globalization;
using System.Runtime.InteropServices;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;




public class TouchInputSc : MonoBehaviour
{
   

    Vector2 touchPosition;


    public Vector2 GetTouchPosition(){

        return touchPosition;




    }

    void Update(){



        if(Input.touchCount!=0){

        
            Touch lastTouch =  Input.GetTouch(Input.touchCount);

            touchPosition = lastTouch.position;



        }


    }

}
