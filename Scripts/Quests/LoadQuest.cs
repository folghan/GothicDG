using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LoadQuest : MonoBehaviour
{
    //Lista przyjętych questów w formacie TRESC_NAGRODA_ZLECENIODAWCA
    public GameObject QuestManager2;
    void OnEnable(){
        //Debug.Log(this.name);
        foreach(string Quest in QuestManager2.GetComponent<QuestManager2_0>().AllQuests){
            string[] Quest2 = Quest.Split('_');
            if(Quest2[2] == this.name){
                this.transform.GetChild(1).GetChild(0).GetComponent<Text>().text = Quest2[0];
            }
        }
    }

    public void AcceptTheQuest(){
        string TheQuest = "";
        foreach(string Quest in QuestManager2.GetComponent<QuestManager2_0>().AllQuests){
            string[] Quest2 = Quest.Split('_');
            if(Quest2[2] == this.name){
                TheQuest = Quest2[0] + "_" + Quest2[1] + "_" + Quest2[2];
            }
        }
         
        QuestManager2.GetComponent<QuestManager2_0>().AcceptedQuests.Add(TheQuest);
        this.transform.GetChild(2).GetComponent<Button>().interactable = false;
        this.transform.GetChild(2).GetChild(0).GetComponent<Text>().text = "Zadanie przyjęte!";

    }
}
