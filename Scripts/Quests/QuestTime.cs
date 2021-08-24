using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class QuestTime : MonoBehaviour
{
    public float TimeLeft;
    public bool QuestEnded;
    void Start()
    {
        //Debug.Log("TEST1");
        QuestEnded = false;
        this.transform.GetChild(2).gameObject.GetComponent<Text>().text = "chuj";
    }
    void Update(){
        if(this.transform.GetChild(1).gameObject.GetComponent<Text>().text != "Brak zadań."){
            this.transform.GetChild(2).gameObject.SetActive(true);
            QuestEnded = false;
        }else{
            this.transform.GetChild(2).gameObject.SetActive(false);
            QuestEnded = true;
        }
        if(!QuestEnded){
            TimeLeft -= Time.deltaTime;
            int minuty = Mathf.FloorToInt(TimeLeft / 60);
            int sekundy = Mathf.FloorToInt(TimeLeft % 60); 
            this.transform.GetChild(2).gameObject.GetComponent<Text>().text = string.Format("{0:00}:{1:00}", minuty, sekundy);
        }
        if(TimeLeft <= 0){
            QuestEnded = true;
            TimeLeft = 0f;
            this.transform.GetChild(2).gameObject.GetComponent<Text>().text = "Zadanie ukończone!";
        }
    }
}
