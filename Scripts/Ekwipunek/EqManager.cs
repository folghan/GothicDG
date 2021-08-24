using UnityEngine;
using UnityEngine.UI;
using System.Collections.Generic;

public class EqManager : MonoBehaviour
{
    public GameObject[] EqSlots;
    public int FreeEqSpace;
    int Iteration;
    public GameObject EqManager1;

    void Start()
    {
        EqSlots = GameObject.FindGameObjectsWithTag("eqslot");
        FreeEqSpace = EqSlots.Length;
        EqManager1.SetActive(false);
    }

    public void onNewItem(string itemName){
        EqManager1.SetActive(true);
        foreach(GameObject EqSlot in EqSlots)
        {
            if(FreeEqSpace > 0){
                if(!EqSlot.GetComponent<EqSlotParameters>().isOccupied){
                    //Debug.Log("Found an empty EQ slot");
                    EqSlot.GetComponent<EqSlotParameters>().item = GameObject.Find(itemName);
                    //Debug.Log("Assigned an item");
                    EqSlot.GetComponent<EqSlotParameters>().isOccupied = true;
                    //Debug.Log(EqSlot.GetComponent<EqSlotParameters>().isOccupied);
                    //Debug.Log("Setting occupation");
                    FreeEqSpace -= 1;
                    GameObject.Find(itemName).GetComponent<ItemController>().SlotName = GameObject.Find(EqSlot.name).name;
                    GameObject.Find(itemName).transform.position = new Vector3(EqSlot.GetComponent<EqSlotParameters>().EqSlotPosition.x + 440, EqSlot.GetComponent<EqSlotParameters>().EqSlotPosition.y + 62, -4);

                    break;
                }
            }else{
                Debug.Log("NO FREE SPACE IN EQ!");
                Destroy(GameObject.Find(itemName));
                break;
            }
        }
        EqManager1.SetActive(false);
    }
    public void onRemoveItem(string itemName, string SlotName){
        foreach(GameObject EqSlot in EqSlots)
        {
            if(FreeEqSpace != EqSlots.Length){
                if((EqSlot.GetComponent<EqSlotParameters>().isOccupied)&&(EqSlot.GetComponent<EqSlotParameters>().item == GameObject.Find(itemName))&&(EqSlot.name == GameObject.Find(itemName).GetComponent<ItemController>().SlotName)){
                    //Debug.Log("Found an occupated EQ slot");
                    EqSlot.GetComponent<EqSlotParameters>().item = null;
                    //Debug.Log("Removed an item");
                    EqSlot.GetComponent<EqSlotParameters>().isOccupied = false;
                    //Debug.Log("Setting occupation");
                    FreeEqSpace += 1;

                    Destroy(GameObject.Find(itemName));
                    
                    break;
                }else{
                    Debug.Log("THE ITEM IS NOT EQUIPPED!");
                }
            }else{
                Debug.Log("THERE ARE NO ITEMS IN EQ!");
                break;
            }
            
        }
    }
    void Update(){
        Iteration = 0;
        foreach(GameObject EqSlot in EqSlots)
        {
            if(!EqSlot.GetComponent<EqSlotParameters>().isOccupied){
                if(Iteration + 1 < EqSlots.Length){
                    if(EqSlots[Iteration + 1].GetComponent<EqSlotParameters>().isOccupied){
                        EqSlots[Iteration].GetComponent<EqSlotParameters>().item = EqSlots[Iteration + 1].GetComponent<EqSlotParameters>().item;
                        EqSlots[Iteration].GetComponent<EqSlotParameters>().isOccupied = true;

                        EqSlots[Iteration + 1].GetComponent<EqSlotParameters>().isOccupied = false;
                        EqSlots[Iteration + 1].GetComponent<EqSlotParameters>().item = null;

                        //Debug.Log(EqSlots[Iteration].GetComponent<EqSlotParameters>().item);
                        GameObject.Find(EqSlots[Iteration].GetComponent<EqSlotParameters>().item.name).GetComponent<ItemController>().transform.position = new Vector3(EqSlots[Iteration].GetComponent<EqSlotParameters>().EqSlotPosition.x + 440, EqSlots[Iteration].GetComponent<EqSlotParameters>().EqSlotPosition.y + 62, -3);

                        GameObject.Find(EqSlots[Iteration].GetComponent<EqSlotParameters>().item.name).GetComponent<ItemController>().SlotName = EqSlots[Iteration].name;
                    }
                }
                
            }
            Iteration++;
        }
    }
    void OnMouseDown(){
        //Debug.Log("Click registered");
    } 
}