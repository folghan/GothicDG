using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EqManager2_0Backup : MonoBehaviour
{
    string EqSave = "StaryMiecz(Clone)_0_True";
    public GameObject Ekwipunek;
    public GameObject StaryMiecz;
    public GameObject Kilof;
    public GameObject OstrzeNajemnika;
    public GameObject MsciwaStal;
    public GameObject MieczZwyciestwa;
    public GameObject ZemstaGorna;
    public GameObject Uriziel;
    public GameObject KrotkiLuk;
    public GameObject LekkaKusza;
    public List<string> EqItems = new List<string>(); //Ta lista i tak nie ma znaczenia, służy jedynie do podejrzenia zawartości PlayerPrefsa

    //PLAYER,PREFS - ITEMNAME_ID_isEquipped-

    void Start(){
        //Debug.Log(StaryMiecz.name);
        //PlayerPrefs.SetString("Ekwipunek", "StaryMiecz_0_true-Kilof_1_false-StaryMiecz_2_false-Uriziel_3_false-LekkaKusza_4_true"); //do usuniecia
        EqSave = PlayerPrefs.GetString("Ekwipunek", "StaryMiecz(Clone)_0_True");
        Debug.Log(EqSave);
        string[] items = EqSave.Split('-');
        foreach(string LoadingItem in items){
            EqItems.Add(LoadingItem);
        }
    }

    public void LoadEQ(){
        GameObject[] EqSlots = GameObject.FindGameObjectsWithTag("eqslot");
        if(EqSave != ""){
            Debug.Log("IF EQSAVE PASSED");
            string[] items = EqSave.Split('-');
            int i = 0;
            foreach(string item in items){
                Debug.Log("FOREACH HAS STARTED");
                string[] SelectedItem = item.Split('_');
                Debug.Log(SelectedItem[0]);
                switch(SelectedItem[0]){
                    case "StaryMiecz(Clone)":{
                        GameObject LoadedItem = Instantiate(StaryMiecz);
                        LoadedItem.name = SelectedItem[0];
                        int ItemId = int.Parse(SelectedItem[1]);
                        Debug.Log(ItemId);
                        LoadedItem.transform.GetChild(2).GetComponent<ItemParameter>().id = ItemId;
                        foreach(GameObject EqSlot in EqSlots){
                            if(EqSlot.transform.childCount == 0){
                                LoadedItem.transform.SetParent(EqSlot.transform, false);
                                break;
                            }
                        }
                        if(SelectedItem[2] == "True"){
                            LoadedItem.transform.GetChild(2).GetComponent<ItemParameter>().isEquipped = true;
                        }
                        i++;
                        break;
                    }
                    case "Kilof(Clone)":{
                        GameObject LoadedItem = Instantiate(Kilof);
                        LoadedItem.name = SelectedItem[0];
                        int ItemId = int.Parse(SelectedItem[1]);
                        Debug.Log(ItemId);
                        LoadedItem.transform.GetChild(2).GetComponent<ItemParameter>().id = ItemId;
                        foreach(GameObject EqSlot in EqSlots){
                            if(EqSlot.transform.childCount == 0){
                                LoadedItem.transform.SetParent(EqSlot.transform, false);
                                break;
                            }
                        }
                        if(SelectedItem[2] == "True"){
                            LoadedItem.transform.GetChild(2).GetComponent<ItemParameter>().isEquipped = true;
                        }
                        i++;
                        break;
                    }
                    case "OstrzeNajemnika(Clone)":{
                        GameObject LoadedItem = Instantiate(OstrzeNajemnika);
                        LoadedItem.name = SelectedItem[0];
                        int ItemId = int.Parse(SelectedItem[1]);
                        Debug.Log(ItemId);
                        LoadedItem.transform.GetChild(2).GetComponent<ItemParameter>().id = ItemId;
                        foreach(GameObject EqSlot in EqSlots){
                            if(EqSlot.transform.childCount == 0){
                                LoadedItem.transform.SetParent(EqSlot.transform, false);
                                break;
                            }
                        }
                        if(SelectedItem[2] == "True"){
                            LoadedItem.transform.GetChild(2).GetComponent<ItemParameter>().isEquipped = true;
                        }
                        i++;
                        break;
                    }
                    case "MsciwaStal(Clone)":{
                        GameObject LoadedItem = Instantiate(MsciwaStal);
                        LoadedItem.name = SelectedItem[0];
                        int ItemId = int.Parse(SelectedItem[1]);
                        Debug.Log(ItemId);
                        LoadedItem.transform.GetChild(2).GetComponent<ItemParameter>().id = ItemId;
                        foreach(GameObject EqSlot in EqSlots){
                            if(EqSlot.transform.childCount == 0){
                                LoadedItem.transform.SetParent(EqSlot.transform, false);
                                break;
                            }
                        }
                        if(SelectedItem[2] == "True"){
                            LoadedItem.transform.GetChild(2).GetComponent<ItemParameter>().isEquipped = true;
                        }
                        i++;
                        break;
                    }
                    case "MieczZwyciestwa(Clone)":{
                        GameObject LoadedItem = Instantiate(MieczZwyciestwa);
                        LoadedItem.name = SelectedItem[0];
                        int ItemId = int.Parse(SelectedItem[1]);
                        Debug.Log(ItemId);
                        LoadedItem.transform.GetChild(2).GetComponent<ItemParameter>().id = ItemId;
                        foreach(GameObject EqSlot in EqSlots){
                            if(EqSlot.transform.childCount == 0){
                                LoadedItem.transform.SetParent(EqSlot.transform, false);
                                break;
                            }
                        }
                        if(SelectedItem[2] == "True"){
                            LoadedItem.transform.GetChild(2).GetComponent<ItemParameter>().isEquipped = true;
                        }
                        i++;
                        break;
                    }
                    case "ZemstaGorna(Clone)":{
                        GameObject LoadedItem = Instantiate(ZemstaGorna);
                        LoadedItem.name = SelectedItem[0];
                        int ItemId = int.Parse(SelectedItem[1]);
                        Debug.Log(ItemId);
                        LoadedItem.transform.GetChild(2).GetComponent<ItemParameter>().id = ItemId;
                        foreach(GameObject EqSlot in EqSlots){
                            if(EqSlot.transform.childCount == 0){
                                LoadedItem.transform.SetParent(EqSlot.transform, false);
                                break;
                            }
                        }
                        if(SelectedItem[2] == "True"){
                            LoadedItem.transform.GetChild(2).GetComponent<ItemParameter>().isEquipped = true;
                        }
                        i++;
                        break;
                    }
                    case "Uriziel(Clone)":{
                        GameObject LoadedItem = Instantiate(Uriziel);
                        LoadedItem.name = SelectedItem[0];
                        int ItemId = int.Parse(SelectedItem[1]);
                        Debug.Log(ItemId);
                        LoadedItem.transform.GetChild(2).GetComponent<ItemParameter>().id = ItemId;
                        foreach(GameObject EqSlot in EqSlots){
                            if(EqSlot.transform.childCount == 0){
                                LoadedItem.transform.SetParent(EqSlot.transform, false);
                                break;
                            }
                        }
                        if(SelectedItem[2] == "True"){
                            LoadedItem.transform.GetChild(2).GetComponent<ItemParameter>().isEquipped = true;
                        }
                        i++;
                        break;
                    }
                    case "KrotkiLuk(Clone)":{
                        GameObject LoadedItem = Instantiate(KrotkiLuk);
                        LoadedItem.name = SelectedItem[0];
                        int ItemId = int.Parse(SelectedItem[1]);
                        Debug.Log(ItemId);
                        LoadedItem.transform.GetChild(2).GetComponent<ItemParameter>().id = ItemId;
                        foreach(GameObject EqSlot in EqSlots){
                            if(EqSlot.transform.childCount == 0){
                                LoadedItem.transform.SetParent(EqSlot.transform, false);
                                break;
                            }
                        }
                        if(SelectedItem[2] == "True"){
                            LoadedItem.transform.GetChild(2).GetComponent<ItemParameter>().isEquipped = true;
                        }
                        i++;
                        break;
                    }
                    case "LekkaKusza(Clone)":{
                        GameObject LoadedItem = Instantiate(LekkaKusza);
                        LoadedItem.name = SelectedItem[0];
                        int ItemId = int.Parse(SelectedItem[1]);
                        Debug.Log(ItemId);
                        LoadedItem.transform.GetChild(2).GetComponent<ItemParameter>().id = ItemId;
                        foreach(GameObject EqSlot in EqSlots){
                            if(EqSlot.transform.childCount == 0){
                                LoadedItem.transform.SetParent(EqSlot.transform, false);
                                break;
                            }
                        }
                        if(SelectedItem[2] == "True"){
                            LoadedItem.transform.GetChild(2).GetComponent<ItemParameter>().isEquipped = true;
                        }
                        i++;
                        break;
                    }
                }
            }
            EqSave = "";
            Debug.Log("FOREACH HAS ENDED");
        }
    }
}

//GameObject NewItem = Instantiate(ItemPrefab);