using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemScript : MonoBehaviour
{
    public GameObject GameManager;
    public GameObject EqManager2_0;

    void Start(){
        EqManager2_0 = GameObject.Find("EqManager");
        GameManager = GameObject.Find("GameManager");
    }

    public void RemoveItem(){
        this.name = this.name + "(removed)";
        EqManager2_0.GetComponent<EqManager2_0>().GenerateNewEqCache();
    }

    public bool CheckIfAbleToEqiup(int recived_type){
        switch(recived_type){
            case 1:{
                if(GameManager.GetComponent<GameManager>().strength >= this.transform.GetChild(2).GetComponent<ItemParameter>().strength){
                    return true;
                }else{
                    Debug.Log("Za mało atrybutu SIŁA!");
                    this.transform.GetChild(3).gameObject.SetActive(true);
                    return false;
                }
                //break;
            }
            case 2:{
                if(GameManager.GetComponent<GameManager>().strength >= this.transform.GetChild(2).GetComponent<ItemParameter>().strength){
                    return true;
                }else{
                    Debug.Log("Za mało atrybutu SIŁA!");
                    this.transform.GetChild(3).gameObject.SetActive(true);
                    return false;
                }
                //break;
            }
            case 3:{
                if(GameManager.GetComponent<GameManager>().agility >= this.transform.GetChild(2).GetComponent<ItemParameter>().agility){
                    return true;
                }else{
                    Debug.Log("Za mało atrybutu ZRĘCZNOŚĆ!");
                    this.transform.GetChild(4).gameObject.SetActive(true);
                    return false;
                }
                //break;
            }
            case 4:{
                if(GameManager.GetComponent<GameManager>().strength >= this.transform.GetChild(2).GetComponent<ItemParameter>().strength){
                    return true;
                }else{
                    Debug.Log("Za mało atrybutu SIŁA!");
                    this.transform.GetChild(3).gameObject.SetActive(true);
                    return false;
                }
                //break;
            }
            case 5:{
                if(GameManager.GetComponent<GameManager>().mana >= this.transform.GetChild(2).GetComponent<ItemParameter>().mana){
                    return true;
                }else{
                    Debug.Log("Za mało atrybutu MANA!");
                    return false;
                }
                //break;
            }
            case 6:{
                if(GameManager.GetComponent<GameManager>().kragmagii >= this.transform.GetChild(2).GetComponent<ItemParameter>().magic){
                    return true;
                }else{
                    Debug.Log("Za mało atrybutu KRĄG MAGII!");
                    return false;
                }
                //break;
            }
            default: return false;
        }
        
    }
}
