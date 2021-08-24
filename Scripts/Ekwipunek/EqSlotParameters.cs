using UnityEngine;
using UnityEngine.UI;
using System.Collections.Generic;

public class EqSlotParameters : MonoBehaviour
{

    public bool isOccupied;
    public GameObject item;
    public Vector3 EqSlotPosition;

    void Awake(){
        EqSlotPosition = this.transform.position;
    }

    void Update(){
        /*if(this.transform.childCount > 0){
            isOccupied = true;
            item = this.transform.GetChild(0).gameObject;
        }else{
            isOccupied = false;
            item = null;
        }*/
    }
}
