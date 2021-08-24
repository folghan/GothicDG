using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Nauczyciele : MonoBehaviour
{
    public GameObject GameManager;

    public void Sila(){
        int result = GameManager.GetComponent<GameManager>().AddStrenght();
        
        switch(result){
            case 0:{
                Debug.Log("Pomyslnie dodano atrybut - SIŁA");
                break;
            }
            case 1:{
                Debug.Log("ERROR - Za mało bryłek rudy!");
                this.transform.GetChild(10).gameObject.SetActive(true);
                break;
            }
            case 2:{
                Debug.Log("ERROR - Za mało punktów nauki!");
                this.transform.GetChild(9).gameObject.SetActive(true);
                break;
            }
        }
    }
    public void Sila5(){
        int result = GameManager.GetComponent<GameManager>().AddStrenght5();
        
        switch(result){
            case 0:{
                Debug.Log("Pomyslnie dodano atrybut - SIŁA");
                break;
            }
            case 1:{
                Debug.Log("ERROR - Za mało bryłek rudy!");
                this.transform.GetChild(10).gameObject.SetActive(true);
                break;
            }
            case 2:{
                Debug.Log("ERROR - Za mało punktów nauki!");
                this.transform.GetChild(9).gameObject.SetActive(true);
                break;
            }
        }
    }
    public void Zrecznosc(){
        int result = GameManager.GetComponent<GameManager>().AddAgility();
        
        switch(result){
            case 0:{
                Debug.Log("Pomyslnie dodano atrybut - ZRĘCZNOŚĆ");
                break;
            }
            case 1:{
                Debug.Log("ERROR - Za mało bryłek rudy!");
                this.transform.GetChild(10).gameObject.SetActive(true);
                break;
            }
            case 2:{
                Debug.Log("ERROR - Za mało punktów nauki!");
                this.transform.GetChild(9).gameObject.SetActive(true);
                break;
            }
        }
    }
    public void Zrecznosc5(){
        int result = GameManager.GetComponent<GameManager>().AddAgility5();
        
        switch(result){
            case 0:{
                Debug.Log("Pomyslnie dodano atrybut - ZRĘCZNOŚĆ");
                break;
            }
            case 1:{
                Debug.Log("ERROR - Za mało bryłek rudy!");
                this.transform.GetChild(10).gameObject.SetActive(true);
                break;
            }
            case 2:{
                Debug.Log("ERROR - Za mało punktów nauki!");
                this.transform.GetChild(9).gameObject.SetActive(true);
                break;
            }
        }
    }
}
