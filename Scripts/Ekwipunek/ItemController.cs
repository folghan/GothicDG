using UnityEngine;
using UnityEngine.UI;
using System.Collections.Generic;

public class ItemController : MonoBehaviour
{
    public GameObject EqManager;
    public string itemName;
    public string itemType;
    public string SlotName;
    public Vector3 itemPosition;

    void Start(){
        EqManager = GameObject.Find("Interfejs Główny/Panel Główny/Panel Ekwipunek");
    }

    void OnMouseOver(){
        if(Input.GetMouseButtonDown(0)){

            string[] TestItemName = this.name.Split('_');
            if(TestItemName.Length != 1){
                Debug.Log("THIS ITEM IS ALREADY EQUIPPED!");
            }
        }
        if(Input.GetMouseButtonDown(1)){
            Debug.Log("I DETECTED A RIGHT CLICK!");
            EqManager.gameObject.GetComponent<EqManager>().onRemoveItem(itemName, SlotName);
        }
    }
    
    void OnMouseEnter(){
        this.transform.GetChild(2).gameObject.SetActive(true);
        this.transform.position = new Vector3(this.transform.position.x, this.transform.position.y, this.transform.position.z - 2);
    }
    void OnMouseExit(){
        this.transform.GetChild(2).gameObject.SetActive(false);
        this.transform.position = new Vector3(this.transform.position.x, this.transform.position.y, this.transform.position.z + 2);
    }
}
