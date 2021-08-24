using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Networking;

public class SEKS : MonoBehaviour
{
    //bool connection = false;
    string DownloadedData;
    public GameObject PanelKonto;
    public GameObject ErrorPanel;
    public GameObject InputLogin;
    public GameObject InputPassword;

    public void Login(){
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

                ErrorPanel.transform.GetChild(0).GetComponent<Text>().text = "Zalogowano pomyślnie! Witaj " + editedData[1] + "!";

                PanelKonto.SetActive(true);

                InputLogin.transform.parent.gameObject.SetActive(false);

                PanelKonto.transform.GetChild(0).GetChild(0).GetComponent<Text>().text = editedData[1];
                PanelKonto.transform.GetChild(0).GetChild(1).GetComponent<Text>().text = editedData[2];
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
