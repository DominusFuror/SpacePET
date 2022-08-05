using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShipMovement : MonoBehaviour
{
    Transform shipTransfom; 

    void Start(){

         shipTransfom =  this.transform;
    }

    
   public void MoveShip(Vector2 newPosition){

  shipTransfom.position = newPosition;

  if(shipTransfom.position.y>=0){

    shipTransfom.position = new Vector2(shipTransfom.position.x, 0);
  }

   }

}
