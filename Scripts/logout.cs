using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class logout : MonoBehaviour
{
    public void wyloguj(){
        PlayerPrefs.SetInt("Zalogowano", 0);
    }
}
