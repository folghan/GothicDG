using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ItemParameter : MonoBehaviour
{
    public int minDmg; //od tej wartosci liczone sa obrazenia (minDmg * (strenght||agility/10))
    public int maxDmg; //maksymalna wartość obrażeń jakie można uzyskać
    public int strength; //wymagana siła
    public int agility; //wymagana zręczność
    public int mana; //wymagana mana
    public int magic; //wymagany krąg magii
    public int type; //1-jednoreczna 2-dwureczna 3-luk 4-kusza 5-zwoj 6-runa
    public int id;
    public bool isEquipped;

    public GameObject GameManager;

    void Start(){
        GameManager = GameObject.Find("GameManager");
    }

    void Update(){
        if((this.transform.parent.gameObject == GameManager.GetComponent<GameManager>().MainWeapon)||(this.transform.parent.gameObject == GameManager.GetComponent<GameManager>().SecondaryWeapon)){
            this.transform.parent.GetComponent<Image>().color = new Color32(0,219,255,100);
        }else{
            this.transform.parent.GetComponent<Image>().color = new Color32(255,255,255,100);
        }
    }
    void OnMouseOver(){
        if(Input.GetMouseButtonDown(0)){
            if(isEquipped){
                isEquipped = false;
                ChangeStatus();
            }else{
                isEquipped = this.transform.parent.GetComponent<ItemScript>().CheckIfAbleToEqiup(type);
                if(isEquipped){
                    /*if(GameManager.GetComponent<GameManager>().MainWeapon != null){
                        GameManager.GetComponent<GameManager>().MainWeapon.transform.GetChild(2).GetComponent<ItemParameter>().isEquipped = false;
                    }*/
                    switch(type){
                        case 1:
                        case 2:{
                            if(GameManager.GetComponent<GameManager>().MainWeapon != null){
                                GameManager.GetComponent<GameManager>().MainWeapon.transform.GetChild(2).GetComponent<ItemParameter>().isEquipped = false;
                            }
                            break;
                        }
                        case 3:
                        case 4:{
                            if(GameManager.GetComponent<GameManager>().SecondaryWeapon != null){
                                GameManager.GetComponent<GameManager>().SecondaryWeapon.transform.GetChild(2).GetComponent<ItemParameter>().isEquipped = false;
                            }
                            break;
                        }
                    }
                    ChangeStatus();
                }
                
            }
        }else if(Input.GetMouseButtonDown(1)){
            this.transform.parent.GetComponent<ItemScript>().RemoveItem();
        }
    }

    

    //void DeEquip(){
        //isEquipped = false;
        //ChangeStatus();
    //}

    public void ChangeStatus(){
        if(isEquipped){
            //GameManager.GetComponent<GameManager>().
            switch(type){
                case 1:{
                    GameManager.GetComponent<GameManager>().MainWeapon = this.transform.parent.gameObject;
                    break;
                }
                case 2:{
                    GameManager.GetComponent<GameManager>().MainWeapon = this.transform.parent.gameObject;
                    break;
                }
                case 3:{
                    GameManager.GetComponent<GameManager>().SecondaryWeapon = this.transform.parent.gameObject;
                    break;
                }
                case 4:{
                    GameManager.GetComponent<GameManager>().SecondaryWeapon = this.transform.parent.gameObject;
                    break;
                }
            }
            //this.transform.parent.GetComponent<Image>().color = new Color32(0,219,255,100); //equip
        }else{
            switch(type){
                case 1:{
                    GameManager.GetComponent<GameManager>().MainWeapon = null;
                    break;
                }
                case 2:{
                    GameManager.GetComponent<GameManager>().MainWeapon = null;
                    break;
                }
                case 3:{
                    GameManager.GetComponent<GameManager>().SecondaryWeapon = null;
                    break;
                }
                case 4:{
                    GameManager.GetComponent<GameManager>().SecondaryWeapon = null;
                    break;
                }
            }
            //this.transform.parent.GetComponent<Image>().color = new Color32(255,255,255,100); //deequip
        }
    }

}

//PLAYER,PREFS - ITEMNAME_isEquipped-