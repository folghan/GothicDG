using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class QuestParameter : MonoBehaviour
{

    /*public GameObject zleceniodawca_panel;
    public GameObject QuestManager;
    public GameObject[] ExistingQuests;
    public bool isDefault;
    public bool isSet;

    void Awake()
    {
        if(this.transform.GetChild(1).GetComponent<Text>().text == "Brak zadań."){
            isDefault = true;
        }else{
            Assign();
        }
    }
    void Assign(){
        QuestManager.GetComponent<QuestManager>().ActivateAll();
        ExistingQuests = GameObject.FindGameObjectsWithTag("Quest");
        Debug.Log(this.name);
        int i = 0;
        foreach(GameObject ThisQuest in ExistingQuests){
            string[] bufor = QuestManager.GetComponent<QuestManager>().Questy[i].Split('_');
            string text = bufor[0];
            string panel = bufor[1];
            if(this.name == ThisQuest.name){
                //zleceniodawca_panel = QuestManager.PaneleDialogowe1[]
                Debug.Log(panel);
                zleceniodawca_panel = GameObject.Find(panel);
            }
            i++;
        }
        QuestManager.GetComponent<QuestManager>().DeActivateAll();
    }
    void Update(){
        if(this.name == "Quest_0"){
            if(this.transform.GetChild(1).GetComponent<Text>().text != "Brak zadań."){
                //Debug.Log("ZMIANA QUESTA_0");
                isDefault = false;
                if(!isSet){
                    Assign();
                    isSet = true;
                }
                

            }else{
                isSet = false;
                isDefault = true;
                zleceniodawca_panel = null;
            }
        }else{
            isDefault = false;
        }
    }*/
}
