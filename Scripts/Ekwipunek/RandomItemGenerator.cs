using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEditor;

public class RandomItemGenerator : MonoBehaviour
{

    public GameObject ItemPrefab;
    public GameObject EqManager;

    public List<string> Items = new List<string>();
    int dmg;
    public int strength;
    public int agility;
    void Awake(){

        EqManager = GameObject.Find("Panel Ekwipunek");

        Items.Add("Uriziel_BD");
        Items.Add("Kilof_BD");
        Items.Add("StaryMiecz_BJ");
        Items.Add("KrótkiŁuk_Ł");
        //Items.Add("KuszaŁowcySmoków_K");
        Items.Add("LekkaKusza_K");
        Items.Add("UluMulu_BD");
        Items.Add("DługiŁuk_Ł");
        Items.Add("ŁukŚmierci_Ł");
        Items.Add("PogromcaOrków_Ł");
        Items.Add("ZemstaGorna_BD");
        Items.Add("WściekłaStal_BD");
        Items.Add("PięśćTrolla_BD");
        Items.Add("OstrzeNajemnika_BD");
        Items.Add("MściwaStal_BD");
        Items.Add("WrzaskBerserkera_BJ");
        Items.Add("MieczZwycięstwa_BJ");
    }

    public void GenerateRandomItem(){
        string RandomItem = Items[Random.Range(0, Items.Count)];
        //Debug.Log(RandomItem);
        string[] itemData = RandomItem.Split('_');
        string RandomItemName = itemData[0];
        string RandomItemType = itemData[1];
        EqManager.gameObject.GetComponent<EqManager>().onNewItem(CreateNewItem(RandomItemName, RandomItemType));
    }

    string CreateNewItem(string ItemName, string itemType){
        GameObject[] Items;
        Items = GameObject.FindGameObjectsWithTag("Item");
        int itemID = Items.Length;
        GameObject NewItem = Instantiate(ItemPrefab);
        while(true){
            if(GameObject.Find(ItemName + "_" + itemID)){
                itemID++;
            }else{
                break;
            }
        }
        NewItem.name = ItemName + "_" + itemID;
        NewItem.transform.SetParent(GameObject.Find("Panel Ekwipunek").transform);
        NewItem.transform.localScale = new Vector3(1,1,1);
        NewItem.GetComponent<ItemController>().itemName = NewItem.name;
        NewItem.GetComponent<ItemController>().itemType = itemType;
        NewItem.transform.GetChild(0).GetComponent<SpriteRenderer>().sprite = Resources.Load<Sprite>(ItemName);
        if(NewItem.transform.GetChild(0).GetComponent<SpriteRenderer>().sprite == null){
            NewItem.transform.GetChild(0).GetComponent<SpriteRenderer>().sprite = Resources.Load<Sprite>("DefaultTexture");
        }
        NewItem.transform.GetChild(1).GetComponent<TextMesh>().text = ItemName;
        int level = Random.Range(1, 50);
        switch(itemType){
            case "BJ":{
                NewItem.transform.GetChild(2).GetChild(3).gameObject.SetActive(false);
                dmg = Random.Range(1,11) * level / 2;
                strength = Random.Range(1,6) * level / 2;
                NewItem.transform.GetChild(2).GetChild(2).GetChild(0).GetComponent<Text>().text = strength.ToString();
                break;
            }
            case "BD":{
                NewItem.transform.GetChild(2).GetChild(3).gameObject.SetActive(false);
                dmg = Random.Range(2,21) * level / 2;
                strength = Random.Range(1,16) * level / 2;
                NewItem.transform.GetChild(2).GetChild(2).GetChild(0).GetComponent<Text>().text = strength.ToString();
                break;
            }
            case "Ł":{
                NewItem.transform.GetChild(2).GetChild(2).gameObject.SetActive(false);
                dmg = Random.Range(2,16) * level / 2;
                agility = Random.Range(1,16) * level / 2;
                NewItem.transform.GetChild(2).GetChild(3).GetChild(0).GetComponent<Text>().text = agility.ToString();
                break;
            }
            case "K":{
                NewItem.transform.GetChild(2).GetChild(3).gameObject.SetActive(false);
                dmg = Random.Range(3,31) * level / 2;
                strength = Random.Range(1,16) * level / 2;
                NewItem.transform.GetChild(2).GetChild(2).GetChild(0).GetComponent<Text>().text = strength.ToString();
                break;
            }
        }
        NewItem.transform.GetChild(2).GetChild(1).GetChild(0).GetComponent<Text>().text = dmg.ToString();

        return NewItem.name;
    }

}
