using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Networking;

public class Login : MonoBehaviour
{
    //bool connection = false;
    string DownloadedData;
    public GameObject PanelKonto;
    public GameObject ErrorPanel;
    public GameObject InputLogin;
    public GameObject InputPassword;

    public string Nick;
    public string Email;
    public int Level;
    public int Exp;
    public int Strength;
    public int Agility;
    public int Hp;
    public int Mana;
    public int Punkty_nauki;
    public int Walka_Bronia_Jednoreczna;
    public int Walka_Bronia_Dwureczna;
    public int Strzelanie_Z_Luku;
    public int Strzelanie_Z_Kuszy;
    public int Krag_Magii;
    public int Zadania_Dla_SO;
    public int Zadania_Dla_NO;
    public int Zadania_Dla_ONB;
    public string Gildia;
    public int BrylkiRudy;
    public int CzarneBrylkiRudy;

    public void LogMeIn(){
        string logintext = InputLogin.transform.GetChild(2).GetComponent<Text>().text;
        string passwordtext = InputPassword.transform.GetChild(2).GetComponent<Text>().text;
        InputLogin.transform.GetChild(2).GetComponent<Text>().text = "";
        InputPassword.transform.GetChild(2).GetComponent<Text>().text = "";

        StartCoroutine(LoginToTheGame(logintext, passwordtext));
        
    }


    IEnumerator LoginToTheGame(string logintext2, string passwordtext2){
        UnityWebRequest players = UnityWebRequest.Get("http://localhost/GothicDG/login.php");
       
        yield return players.SendWebRequest();

        if (players.isNetworkError || players.isHttpError){
            ErrorPanel.SetActive(true);
            ErrorPanel.transform.GetChild(0).GetComponent<Text>().text = "Error: " + players.error;
            Debug.Log(players.error);
            //connection = false;
        }else{
            //connection = true;
            ErrorPanel.SetActive(true);
            ErrorPanel.transform.GetChild(0).GetComponent<Text>().text = "Sprawdzanie danych...";

            List<IMultipartFormSection> LoginData = new List<IMultipartFormSection>();
            LoginData.Add(new MultipartFormDataSection("login", logintext2));
            LoginData.Add(new MultipartFormDataSection("password", passwordtext2));

            players = UnityWebRequest.Post("http://localhost/GothicDG/login.php", LoginData);

            yield return players.SendWebRequest();

            DownloadedData = players.downloadHandler.text;

            Debug.Log(DownloadedData);

            if(DownloadedData == "1"){
                ErrorPanel.transform.GetChild(0).GetComponent<Text>().text = "Error: błędny login lub hasło!";
            }else{
                string[] editedData = DownloadedData.Split('-');

                //ErrorPanel.transform.GetChild(0).GetComponent<Text>().text = "Zalogowano pomyślnie! Witaj " + editedData[1] + "!";

                PanelKonto.SetActive(true);
                ErrorPanel.SetActive(false);

                Nick = editedData[1];
                Email = editedData[2];
                Level = int.Parse(editedData[3]);
                Exp = int.Parse(editedData[4]);
                Strength = int.Parse(editedData[5]);
                Agility = int.Parse(editedData[6]);
                Hp = int.Parse(editedData[7]);
                Mana = int.Parse(editedData[8]);
                Punkty_nauki = int.Parse(editedData[9]);
                Walka_Bronia_Jednoreczna = int.Parse(editedData[10]);
                Walka_Bronia_Dwureczna = int.Parse(editedData[11]);
                Strzelanie_Z_Luku = int.Parse(editedData[12]);
                Strzelanie_Z_Kuszy = int.Parse(editedData[13]);
                Krag_Magii = int.Parse(editedData[14]);
                Zadania_Dla_SO = int.Parse(editedData[15]);
                Zadania_Dla_NO = int.Parse(editedData[16]);
                Zadania_Dla_ONB = int.Parse(editedData[17]);
                Gildia = editedData[18];
                BrylkiRudy = int.Parse(editedData[19]);
                CzarneBrylkiRudy = int.Parse(editedData[20]);

                PlayerPrefs.SetString("nick", Nick);
                PlayerPrefs.SetString("email", Email);
                PlayerPrefs.SetInt("exp", Exp);
                PlayerPrefs.SetInt("level", Level);
                PlayerPrefs.SetInt("strength", Strength);
                PlayerPrefs.SetInt("agility", Agility);
                PlayerPrefs.SetInt("hp", Hp);
                PlayerPrefs.SetInt("mana", Mana);
                PlayerPrefs.SetInt("pktnauki", Punkty_nauki);
                PlayerPrefs.SetInt("walkajednoreczna", Walka_Bronia_Jednoreczna); 
                PlayerPrefs.SetInt("walkadwureczna", Walka_Bronia_Dwureczna);
                PlayerPrefs.SetInt("strzelanieluk", Strzelanie_Z_Luku);
                PlayerPrefs.SetInt("strzelaniekusza", Strzelanie_Z_Kuszy);
                PlayerPrefs.SetInt("kragmagii", Krag_Magii);
                PlayerPrefs.SetInt("ZadaniaSO", Zadania_Dla_SO);
                PlayerPrefs.SetInt("ZadaniaNO", Zadania_Dla_NO);
                PlayerPrefs.SetInt("ZadaniaONB", Zadania_Dla_ONB);
                PlayerPrefs.SetInt("BrylkiRudy", BrylkiRudy);
                PlayerPrefs.SetInt("CzarneBrylkiRudy", CzarneBrylkiRudy);
                PlayerPrefs.SetString("Gildia", Gildia);
                PlayerPrefs.SetString("Ekwipunek", "StaryMiecz(Clone)_0_False");
                PlayerPrefs.SetString("BronGlowna", "");
                PlayerPrefs.SetString("BronDystansowa", "");


                InputLogin.transform.parent.parent.gameObject.SetActive(false);

                PlayerPrefs.SetInt("Zalogowano", 1);
            }

        }

        //Debug.Log(players);

       /*if(!players){
           Debug.Log("Error while connecting to the server");
           connection = false;
       }else{
           Debug.Log("Succesfully connected to the server");
           connection = true;
       }*/
    }
}
