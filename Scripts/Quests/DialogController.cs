using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DialogController : MonoBehaviour
{
    public bool isTaken;
    public bool isReady;
    
    void Awake(){
        isTaken = false;
        isReady = false;
    }
    void Update(){
        if(isReady){
            this.transform.GetChild(4).GetChild(0).GetComponent<Text>().text = "Zakończ zadanie";
            this.transform.GetChild(4).GetComponent<Button>().interactable = true;
            //PaneleDialogowe[0].transform.GetChild(4).GetChild(0).GetComponent<Text>().fontSize = 38;
            //PaneleDialogowe[0].transform.GetChild(4).GetChild(0).GetComponent<Text>().resizeTextMaxSize = 38;
        }
    }
}
