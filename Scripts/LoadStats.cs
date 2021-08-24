using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LoadStats : MonoBehaviour
{
    public GameObject GameManager;
    void OnEnable(){
        //Debug.Log(this.name);
        switch(this.name){
            case "Siła":{
                this.GetComponent<Text>().text = GameManager.GetComponent<GameManager>().strength.ToString();
                break;
            }
            case "Zręczność":{
                this.GetComponent<Text>().text = GameManager.GetComponent<GameManager>().agility.ToString();
                break;
            }
            case "HP":{
                this.GetComponent<Text>().text = GameManager.GetComponent<GameManager>().hp.ToString();
                break;
            }
            case "Mana":{
                this.GetComponent<Text>().text = GameManager.GetComponent<GameManager>().mana.ToString();
                break;
            }
            case "PunktyNauki":{
                this.GetComponent<Text>().text = GameManager.GetComponent<GameManager>().pktnauki.ToString();
                break;
            }
            case "WalkaBronJednoreczna":{
                this.GetComponent<Text>().text = GameManager.GetComponent<GameManager>().walkajednoreczna.ToString();
                break;
            }
            case "WalkaBronDwureczna":{
                this.GetComponent<Text>().text = GameManager.GetComponent<GameManager>().walkadwureczna.ToString();
                break;
            }
            case "StrzelanieZŁuku":{
                this.GetComponent<Text>().text = GameManager.GetComponent<GameManager>().strzelanieluk.ToString();
                break;
            }
            case "StrzelanieZKuszy":{
                this.GetComponent<Text>().text = GameManager.GetComponent<GameManager>().strzelaniekusza.ToString();
                break;
            }
            case "KrągMagii":{
                this.GetComponent<Text>().text = GameManager.GetComponent<GameManager>().kragmagii.ToString();
                break;
            }
            case "Gildia":{
                this.GetComponent<Text>().text = GameManager.GetComponent<GameManager>().Gildia;
                break;
            }
            case "Zadania SO":{
                this.GetComponent<Text>().text = GameManager.GetComponent<GameManager>().ZadaniaSO.ToString();
                break;
            }
            case "Zadania NO":{
                this.GetComponent<Text>().text = GameManager.GetComponent<GameManager>().ZadaniaNO.ToString();
                break;
            }
            case "Zadania ONB":{
                this.GetComponent<Text>().text = GameManager.GetComponent<GameManager>().ZadaniaONB.ToString();
                break;
            }
            case "Poziom":{
                this.GetComponent<Text>().text = GameManager.GetComponent<GameManager>().level.ToString();
                break;
            }
            case "CurrentExp":{
                string xp = GameManager.GetComponent<GameManager>().exp.ToString();
                xp = xp + "/";
                xp = xp + GameManager.GetComponent<GameManager>().LevelUpExp.ToString();
                this.GetComponent<Text>().text = xp;
                break;
            }
        }
    }
}
