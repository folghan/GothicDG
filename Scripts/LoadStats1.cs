using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;
using UnityEngine.SceneManagement; 

public class LoadStats1 : MonoBehaviour
{
    public GameObject MainCameraData;

    void Start(){
        this.transform.GetChild(0).GetComponent<Text>().text = PlayerPrefs.GetString("nick", "NULL");
        this.transform.GetChild(1).GetComponent<Text>().text = PlayerPrefs.GetString("email", "NULL");
        this.transform.GetChild(2).GetComponent<Text>().text = PlayerPrefs.GetInt("level", 1).ToString();
        this.transform.GetChild(3).GetComponent<Text>().text = PlayerPrefs.GetInt("BrylkiRudy", 0).ToString();
        this.transform.GetChild(4).GetComponent<Text>().text = PlayerPrefs.GetInt("CzarneBrylkiRudy", 0).ToString();
    }

    public void LoadGame(){
        /*PlayerPrefs.SetString("nick", MainCameraData.GetComponent<Login>().Nick);
        PlayerPrefs.SetInt("exp", MainCameraData.GetComponent<Login>().Exp);
        PlayerPrefs.SetInt("level", MainCameraData.GetComponent<Login>().Level);
        PlayerPrefs.SetInt("strength", MainCameraData.GetComponent<Login>().Strength);
        PlayerPrefs.SetInt("agility", MainCameraData.GetComponent<Login>().Agility);
        PlayerPrefs.SetInt("hp", MainCameraData.GetComponent<Login>().Hp);
        PlayerPrefs.SetInt("mana", MainCameraData.GetComponent<Login>().Mana);
        PlayerPrefs.SetInt("pktnauki", MainCameraData.GetComponent<Login>().Punkty_nauki);
        PlayerPrefs.SetInt("walkajednoreczna", MainCameraData.GetComponent<Login>().Walka_Bronia_Jednoreczna); 
        PlayerPrefs.SetInt("walkadwureczna", MainCameraData.GetComponent<Login>().Walka_Bronia_Dwureczna);
        PlayerPrefs.SetInt("strzelanieluk", MainCameraData.GetComponent<Login>().Strzelanie_Z_Luku);
        PlayerPrefs.SetInt("strzelaniekusza", MainCameraData.GetComponent<Login>().Strzelanie_Z_Kuszy);
        PlayerPrefs.SetInt("kragmagii", MainCameraData.GetComponent<Login>().Krag_Magii);
        PlayerPrefs.SetInt("ZadaniaSO", MainCameraData.GetComponent<Login>().Zadania_Dla_SO);
        PlayerPrefs.SetInt("ZadaniaNO", MainCameraData.GetComponent<Login>().Zadania_Dla_NO);
        PlayerPrefs.SetInt("ZadaniaONB", MainCameraData.GetComponent<Login>().Zadania_Dla_ONB);
        PlayerPrefs.SetInt("BrylkiRudy", MainCameraData.GetComponent<Login>().BrylkiRudy);
        PlayerPrefs.SetInt("CzarneBrylkiRudy", MainCameraData.GetComponent<Login>().CzarneBrylkiRudy);
        PlayerPrefs.SetString("Gildia", MainCameraData.GetComponent<Login>().Gildia);
        PlayerPrefs.SetString("Ekwipunek", "StaryMiecz(Clone)_0_False");
        PlayerPrefs.SetString("BronGlowna", "");
        PlayerPrefs.SetString("BronDystansowa", "");*/
        SceneManager.LoadScene("Glowny Interfejs");
    }
}
