using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DziennikZadan : MonoBehaviour
{
    
    public GameObject GameManager;
    public GameObject QuestManager;
    public GameObject Quest0;
    public GameObject QuestPrefab;
    public GameObject[] Quests;

    void Start()
    {
        
    }

    void OnEnable(){
        foreach(string Quest in QuestManager.GetComponent<QuestManager2_0>().AcceptedQuests){
            Quests = GameObject.FindGameObjectsWithTag("Quest");
            int QuestObjectsCount = Quests.Length;
            if(Quest0.transform.GetChild(0).GetComponent<Text>().text == "Brak zadań."){
                Quest0.transform.GetChild(0).GetComponent<Text>().text = Quest;
            }else{
                GameObject NewQuest = Instantiate(QuestPrefab);
                NewQuest.transform.SetParent(this.transform, false);
                NewQuest.transform.GetChild(0).GetComponent<Text>().text = Quest;
                Debug.Log(Quest0.GetComponent<RectTransform>().transform.localPosition.x);
                NewQuest.GetComponent<RectTransform>().transform.localPosition = new Vector3(Quests[QuestObjectsCount-1].transform.localPosition.x,Quests[QuestObjectsCount-1].transform.localPosition.y-120, Quests[QuestObjectsCount-1].transform.localPosition.z);
            }
            //QuestManager.GetComponent<QuestManager2_0>().AcceptedQuests.Remove(Quest);
            
        }
        QuestManager.GetComponent<QuestManager2_0>().AcceptedQuests.Clear();
    }
//Dobra, questy sie nie duplikuja, teraz tylko system ktory odpowiada za konczenie tych questow. Mozna zrobic czasowo, 
//albo ze trzeba sie gdzies udac, zrobic jakas minigierke, walke obleciec z jakims przeciwnikiem i potem wrocic do postaci, ktora dala questa!
//AAA i trzeba dodac dzwiek nowego poziomu xddddd

//EDIT: dobra, dodałem dźwięk nowego poziomu, dodałem komunikaty od tego, zapisu gry i potwierdzenia wyjścia z gry. W sumie można jakieś SFX
//z gothica zajebać i zrobić dźwięki zapisu, ekwipunku itp.

//EDIT2: mamy teraz nauczyciela, SFX dalej ni mo XD Zrób w końcu te zadania i potem zrób W A L K E. Damy radę jakoś tak? I przyda się zrobić
//coś z ekwipunkiem, bo w sumie też jest nieużywany w ogóle xD Przede wszystkim limiter broni wyposażonych, te jebane statystyki żeby się
//wyświetlały i takie tam xd
}
