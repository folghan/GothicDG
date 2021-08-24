using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EqManager2_0 : MonoBehaviour
{
    string EqSave = "StaryMiecz(Clone)_0_True";
    string EqCache;
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
    public GameObject DlugiLuk;
    public GameObject PiescTrolla;
    public GameObject CiezkaKusza;
    public GameObject WrzaskBerserkera;
    public List<string> EqItems = new List<string>(); //Ta lista i tak nie ma znaczenia, służy jedynie do podejrzenia zawartości PlayerPrefsa
    public List<string> Items = new List<string>();

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

        {
            Items.Add("Uriziel");
            Items.Add("Kilof");
            Items.Add("StaryMiecz");
            Items.Add("KrotkiLuk");
            //Items.Add("KuszaŁowcySmoków_K");
            Items.Add("LekkaKusza");
            Items.Add("CiezkaKusza");
            //Items.Add("UluMulu_BD");
            Items.Add("DlugiLuk");
            //Items.Add("ŁukŚmierci_Ł");
            //Items.Add("PogromcaOrków_Ł");
            Items.Add("ZemstaGorna");
            //Items.Add("WściekłaStal_BD");
            Items.Add("PiescTrolla");
            Items.Add("OstrzeNajemnika");
            Items.Add("MsciwaStal");
            Items.Add("WrzaskBerserkera");
            Items.Add("MieczZwyciestwa");
        }

        Ekwipunek.SetActive(true);
        LoadEQ();
        Ekwipunek.SetActive(false);
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
                    case "DługiŁuk(Clone)":{
                        GameObject LoadedItem = Instantiate(DlugiLuk);
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
            //EqCache = EqSave;
            //EqCache = PlayerPrefs.GetString("Ekwipunek", EqSave);
            //string[] items = EqCache.Split('-');
            //Ekwipunek.SetActive(true);
            //Debug.Log(PlayerPrefs.GetString("Ekwipunek", "ERROR"));
            //Ekwipunek.SetActive(false);
            EqSave = "";
            Debug.Log("FOREACH HAS ENDED");
        }
        string ZapisEq = "";
        GameObject[] AllItems = GameObject.FindGameObjectsWithTag("Item");
        foreach(GameObject item in AllItems){
            string SelectedItem = item.name;
            string id = item.transform.GetChild(2).GetComponent<ItemParameter>().id.ToString();
            string isEquipped = item.transform.GetChild(2).GetComponent<ItemParameter>().isEquipped.ToString();
            ZapisEq += SelectedItem + "_" + id + "_" + isEquipped + "-";
        }
        EqCache = ZapisEq;
        Debug.Log("EQCACHE1: " + EqCache);
    }

    public void CreateNewItem(){
        string NewItem = Items[Random.Range(0, Items.Count)];
        Debug.Log(NewItem);
        GameObject GeneratedItem = null;
        int GeneratedItemId = 0;
        switch(NewItem){
            case "StaryMiecz":{
                GeneratedItem = Instantiate(StaryMiecz);
                break;
            }
            case "Kilof":{
                GeneratedItem = Instantiate(Kilof);
                break;
            }
            case "Uriziel":{
                GeneratedItem = Instantiate(Uriziel);
                break;
            }
            case "ZemstaGorna":{
                GeneratedItem = Instantiate(ZemstaGorna);
                break;
            }
            case "PiescTrolla":{
                GeneratedItem = Instantiate(PiescTrolla);
                break;
            }
            case "MsciwaStal":{
                GeneratedItem = Instantiate(MsciwaStal);
                break;
            }
            case "MieczZwyciestwa":{
                GeneratedItem = Instantiate(MieczZwyciestwa);
                break;
            }
            case "LekkaKusza":{
                GeneratedItem = Instantiate(LekkaKusza);
                break;
            }
            case "KrotkiLuk":{
                GeneratedItem = Instantiate(KrotkiLuk);
                break;
            }
            case "OstrzeNajemnika":{
                GeneratedItem = Instantiate(OstrzeNajemnika);
                break;
            }
            case "CiezkaKusza":{
                GeneratedItem = Instantiate(CiezkaKusza);
                break;
            }
            case "WrzaskBerserkera":{
                GeneratedItem = Instantiate(WrzaskBerserkera);
                break;
            }
            case "DlugiLuk":{
                GeneratedItem = Instantiate(DlugiLuk);
                break;
            }
        }
        
        string[] items = EqCache.Split('-');
        foreach(string item in items){
            string[] SelectedItem = item.Split('_');
            if(SelectedItem[0] == GeneratedItem.name){
                GeneratedItemId++;
                GeneratedItem.transform.GetChild(2).GetComponent<ItemParameter>().id = GeneratedItemId;
            }
        }
        EqCache += GeneratedItem.name + "_" + GeneratedItemId + "_" + "False-";

        Ekwipunek.SetActive(true);
        GameObject[] EqSlots = GameObject.FindGameObjectsWithTag("eqslot");
        foreach(GameObject EqSlot in EqSlots){
            if(EqSlot.transform.childCount == 0){
                    GeneratedItem.transform.SetParent(EqSlot.transform, false);
                    break;
            }
        }
        Ekwipunek.SetActive(false);
            
        
    }

    public void GenerateNewEqCache(){
        string ZapisEq = "";
        GameObject[] AllItems = GameObject.FindGameObjectsWithTag("Item");
        foreach(GameObject item in AllItems){
            string SelectedItem = item.name;
            string id = item.transform.GetChild(2).GetComponent<ItemParameter>().id.ToString();
            string isEquipped = item.transform.GetChild(2).GetComponent<ItemParameter>().isEquipped.ToString();
            ZapisEq += SelectedItem + "_" + id + "_" + isEquipped + "-";
        }
        EqCache = ZapisEq;
        ReGenerateEq();
    }
    void ReGenerateEq(){
        Ekwipunek.SetActive(true);
        GameObject[] AllItems = GameObject.FindGameObjectsWithTag("Item");
        foreach(GameObject item in AllItems){
            Destroy(item);
        }
        EqSave = EqCache;
        //LoadEQ();
        StartCoroutine(ReLoadEQ());
        

    }
    private IEnumerator ReLoadEQ(){
        while(true){
            yield return new WaitForSeconds(0.001f);
            LoadEQ();
            break;
        }//
    }
}

//GameObject NewItem = Instantiate(ItemPrefab);