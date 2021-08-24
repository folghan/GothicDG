using UnityEngine;
using UnityEngine.UI;

public class NameManager : MonoBehaviour
{
    public InputField imie;
    public Button zatwierdz;
    public string nick;

    public void ready(){
        nick = imie.text;
        PlayerPrefs.SetString("nick", nick);
        PlayerPrefs.SetInt("exp", 0);
        PlayerPrefs.SetInt("level", 1);
        PlayerPrefs.SetInt("strength", 5);
        PlayerPrefs.SetInt("agility", 5);
        PlayerPrefs.SetInt("hp", 100);
        PlayerPrefs.SetInt("mana", 10);
        PlayerPrefs.SetInt("pktnauki", 0);
        PlayerPrefs.SetInt("walkajednoreczna", 0);
        PlayerPrefs.SetInt("walkadwureczna", 0);
        PlayerPrefs.SetInt("strzelanieluk", 0);
        PlayerPrefs.SetInt("strzelaniekusza", 0);
        PlayerPrefs.SetInt("kragmagii", 0);
        PlayerPrefs.SetInt("ZadaniaSO", 0);
        PlayerPrefs.SetInt("ZadaniaNO", 0);
        PlayerPrefs.SetInt("ZadaniaONB", 0);
        PlayerPrefs.SetInt("BrylkiRudy", 0);
        PlayerPrefs.SetInt("CzarneBrylkiRudy", 0);
        PlayerPrefs.SetString("Gildia", "Brak");
        PlayerPrefs.SetString("Ekwipunek", "StaryMiecz(Clone)_0_False");
        PlayerPrefs.SetString("BronGlowna", "");
        PlayerPrefs.SetString("BronDystansowa", "");
    }

    void Update()
    {
        if(imie.text != ""){
            zatwierdz.interactable = true;
        }else{
            zatwierdz.interactable = false;
        }
    }
}

/*
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
 */