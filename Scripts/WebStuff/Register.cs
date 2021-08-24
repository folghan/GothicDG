using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Networking;

public class Register : MonoBehaviour
{
    string DownloadedData;
    public GameObject ErrorPanel;
    public GameObject InputLogin;
    public GameObject InputNick;
    public GameObject InputEmail;
    public GameObject InputPassword;

    public void CreateAccount(){
        string logintext = InputLogin.transform.GetChild(2).GetComponent<Text>().text;
        string passwordtext = InputPassword.transform.GetChild(2).GetComponent<Text>().text;
        string nicktext = InputNick.transform.GetChild(2).GetComponent<Text>().text;
        string emailtext = InputEmail.transform.GetChild(2).GetComponent<Text>().text;

        /*InputLogin.transform.GetChild(2).GetComponent<Text>().text = "";
        InputPassword.transform.GetChild(2).GetComponent<Text>().text = "";
        InputNick.transform.GetChild(2).GetComponent<Text>().text = "";
        InputPassword.transform.GetChild(2).GetComponent<Text>().text = "";*/

        StartCoroutine(RegisterToTheGame(logintext, passwordtext, nicktext, emailtext));
    }

    IEnumerator RegisterToTheGame(string logintext2, string passwordtext2, string nicktext2, string emailtext2){

        UnityWebRequest players = UnityWebRequest.Get("http://localhost/GothicDG/register.php");
       
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
            LoginData.Add(new MultipartFormDataSection("email", emailtext2));
            LoginData.Add(new MultipartFormDataSection("nick", nicktext2));

            players = UnityWebRequest.Post("http://localhost/GothicDG/register.php", LoginData);

            yield return players.SendWebRequest();

            DownloadedData = players.downloadHandler.text;

            Debug.Log(DownloadedData);

            switch(DownloadedData){
                case "0":{
                    ErrorPanel.transform.GetChild(0).GetComponent<Text>().text = "Konto zostało założone pomyślnie!";
                    break;
                }
                case "1":{
                    ErrorPanel.transform.GetChild(0).GetComponent<Text>().text = "Login jest już zajęty!";
                    break;
                }
                case "2":{
                    ErrorPanel.transform.GetChild(0).GetComponent<Text>().text = "E-mail został już wykorzystany przy rejestracji innego konta!";
                    break;
                }
            }
        
        
        }
    }
}
