using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public string nick;
    public int exp;
    public int LevelUpExp;
    public int level;
    public int strength;
    public int agility;
    public int hp;
    public int mana;
    public int pktnauki;
    public int walkajednoreczna;
    public int walkadwureczna;
    public int strzelanieluk;
    public int strzelaniekusza;
    public int kragmagii;
    public int ZadaniaSO;
    public int ZadaniaNO;
    public int ZadaniaONB;
    public string Gildia;
    public int BrylkiRudy;
    public int CzarneBrylkiRudy;
    public float GameVolume;
    public string CurrentlyEquippedMainWeapon;
    public string CurrentlyEquippedSecondaryWeapon;

    public GameObject MainWeapon;
    public GameObject SecondaryWeapon;

    public GameObject[] Soundtrack;
    public GameObject PlayerNick;
    public GameObject IloscBrylek;
    public GameObject IloscCzarnychBrylek;
    public GameObject EqManager;
    public GameObject InventoryPanel;
    public GameObject NowyPoziomPanel;
    public GameObject ZapisGryPanel;
    public AudioSource LevelUpSound;
    
    void Start()
    {
        nick = PlayerPrefs.GetString("nick", "NaN");
        exp = PlayerPrefs.GetInt("exp", 0);
        level = PlayerPrefs.GetInt("level", 1);
        strength = PlayerPrefs.GetInt("strength", 10);
        agility = PlayerPrefs.GetInt("agility", 10);
        hp = PlayerPrefs.GetInt("hp", 100);
        mana = PlayerPrefs.GetInt("mana", 10);
        pktnauki = PlayerPrefs.GetInt("pktnauki", 10);
        walkajednoreczna = PlayerPrefs.GetInt("walkajednoreczna", 0);
        walkadwureczna = PlayerPrefs.GetInt("walkadwureczna", 0);
        strzelanieluk = PlayerPrefs.GetInt("strzelanieluk", 0);
        strzelaniekusza = PlayerPrefs.GetInt("strzelaniekusza", 0);
        kragmagii = PlayerPrefs.GetInt("kragmagii", 0);
        ZadaniaSO = PlayerPrefs.GetInt("ZadaniaSO", 0);
        ZadaniaNO = PlayerPrefs.GetInt("ZadaniaNO", 0);
        ZadaniaONB = PlayerPrefs.GetInt("ZadaniaONB", 0);
        BrylkiRudy = PlayerPrefs.GetInt("BrylkiRudy", 0);
        CzarneBrylkiRudy = PlayerPrefs.GetInt("CzarneBrylkiRudy", 0);
        Gildia = PlayerPrefs.GetString("Gildia", "Brak");
        CurrentlyEquippedMainWeapon = PlayerPrefs.GetString("BronGlowna", "");
        CurrentlyEquippedSecondaryWeapon = PlayerPrefs.GetString("BronDystansowa", ""); //ITEMNAME-TYPE-ID
        GameVolume = PlayerPrefs.GetFloat("volume", 1);
        Soundtrack = GameObject.FindGameObjectsWithTag("Music");
        PlayerNick.GetComponent<Text>().text = nick;
        foreach(GameObject music in Soundtrack){
	        music.GetComponent<AudioSource>().volume = GameVolume;
        }
    }

    void Update(){
        IloscBrylek.GetComponent<Text>().text = BrylkiRudy.ToString();
        IloscCzarnychBrylek.GetComponent<Text>().text = CzarneBrylkiRudy.ToString();
        LevelUpExp = (100 * level);// + (level * 30);
        if(exp >= LevelUpExp){
            level++;
            exp = exp - LevelUpExp;
            pktnauki += 10;
            LevelUpSound.Play();
            NowyPoziomPanel.SetActive(true);
        }
    }

    public void SaveGame(){
        PlayerPrefs.SetString("nick", nick);
        PlayerPrefs.SetInt("exp", exp);
        PlayerPrefs.SetInt("level", level);
        PlayerPrefs.SetInt("strength", strength);
        PlayerPrefs.SetInt("agility", agility);
        PlayerPrefs.SetInt("hp", hp);
        PlayerPrefs.SetInt("mana", mana);
        PlayerPrefs.SetInt("pktnauki", pktnauki);
        PlayerPrefs.SetInt("walkajednoreczna", walkajednoreczna);
        PlayerPrefs.SetInt("walkadwureczna", walkadwureczna);
        PlayerPrefs.SetInt("strzelanieluk", strzelanieluk);
        PlayerPrefs.SetInt("strzelaniekusza", strzelaniekusza);
        PlayerPrefs.SetInt("kragmagii", kragmagii);
        PlayerPrefs.SetInt("ZadaniaSO", ZadaniaSO);
        PlayerPrefs.SetInt("ZadaniaNO", ZadaniaNO);
        PlayerPrefs.SetInt("ZadaniaONB", ZadaniaONB);
        PlayerPrefs.SetInt("BrylkiRudy", BrylkiRudy);
        PlayerPrefs.SetInt("CzarneBrylkiRudy", CzarneBrylkiRudy);
        PlayerPrefs.SetString("Gildia", Gildia);
        PlayerPrefs.SetString("BronGlowna", CurrentlyEquippedMainWeapon);
        PlayerPrefs.SetString("BronDystansowa", CurrentlyEquippedSecondaryWeapon);

        //PlayerPrefs.SetString("Ekwipunek", "StaryMiecz_0_true-Kilof_1_false-StaryMiecz_2_false-Uriziel_3_false-LekkaKusza_4_true");

        string EqSave = PlayerPrefs.GetString("Ekwipunek", "");
        string[] items = EqSave.Split('-');
        InventoryPanel.SetActive(true);
        string ZapisEq = "";
        GameObject[] AllItems = GameObject.FindGameObjectsWithTag("Item");
        foreach(GameObject item in AllItems){
            string SelectedItem = item.name;
            string id = item.transform.GetChild(2).GetComponent<ItemParameter>().id.ToString();
            string isEquipped = item.transform.GetChild(2).GetComponent<ItemParameter>().isEquipped.ToString();
            ZapisEq += SelectedItem + "_" + id + "_" + isEquipped + "-";
        }
        Debug.Log(ZapisEq);
        PlayerPrefs.SetString("Ekwipunek", ZapisEq);
        //Debug.Log(PlayerPrefs.GetString("Ekwipunek", "ERROR"));
        InventoryPanel.SetActive(false);
        ZapisGryPanel.SetActive(true);
    }

    public void IncreaseStrenght(){
        strength += 1;
    }
    public void IncreaseAgility(){
        agility += 1;
    }
    public void IncreaseHP(){
        hp += 100;
    }
    public void IncreaseMana(){
        mana += 1;
    }
    public void DodajRude(){
        if(BrylkiRudy + 10 < 0){
            Debug.Log("STACKOVERFLOW");
            BrylkiRudy = 2147483647;
        }else{
            BrylkiRudy += 10;
        }
    }
    public void DodajCzarnaRude(){
        if(CzarneBrylkiRudy + 1 < 0){
            Debug.Log("STACKOVERFLOW");
            CzarneBrylkiRudy = 2147483647;
        }else{
            CzarneBrylkiRudy += 1;
        }
    }
    public void AddExp(){
        exp += 51;
    }

    public int AddStrenght(){
        if(pktnauki > 0){
            if(BrylkiRudy > 9){
                pktnauki--;
                strength++;
                BrylkiRudy-=10;
                return 0;
            }else{
                Debug.Log("Niewystarczająca ilość bryłek rudy!!!");
                return 1;
            }
        }else{
            Debug.Log("Niewystarczająca ilość punktów nauki!!!");
            return 2;
        }
    }
    public int AddStrenght5(){
        if(pktnauki > 4){
            if(BrylkiRudy > 49){
                pktnauki-=5;
                strength+=5;
                BrylkiRudy-=50;
                return 0;
            }else{
                Debug.Log("Niewystarczająca ilość bryłek rudy!!!");
                return 1;
            }
        }else{
            Debug.Log("Niewystarczająca ilość punktów nauki!!!");
            return 2;
        }
    }
    public int AddAgility(){
        if(pktnauki > 0){
            if(BrylkiRudy > 9){
                pktnauki--;
                strength++;
                BrylkiRudy-=10;
                return 0;
            }else{
                Debug.Log("Niewystarczająca ilość bryłek rudy!!!");
                return 1;
            }
        }else{
            Debug.Log("Niewystarczająca ilość punktów nauki!!!");
            return 2;
        }
    }
    public int AddAgility5(){
        if(pktnauki > 4){
            if(BrylkiRudy > 49){
                pktnauki-=5;
                strength+=5;
                BrylkiRudy-=50;
                return 0;
            }else{
                Debug.Log("Niewystarczająca ilość bryłek rudy!!!");
                return 1;
            }
        }else{
            Debug.Log("Niewystarczająca ilość punktów nauki!!!");
            return 2;
        }
    }

    public void AddExpQF(int RecivedExp){
        exp += RecivedExp;
    }
    public void AddRudeQF(int RecivedRuda){
        BrylkiRudy += RecivedRuda;
    }
    public void RemoveRudeQF(int RecivedRuda){
        BrylkiRudy -= RecivedRuda;
        if(BrylkiRudy < 1){
            BrylkiRudy = 0;
        }
    }

}
