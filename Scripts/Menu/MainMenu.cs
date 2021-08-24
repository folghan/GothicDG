using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement; 

public class MainMenu : MonoBehaviour
{
    float GameVolume;
    int Zalogowano;
    public Button wczytaj;
    public Texture2D kursor;
    public GameObject login;
    public GameObject haslo;
    public GameObject zaloguj;

    public GameObject PanelKonto;
    public GameObject MainOptions;

    int ilosc_znakow;
    string replace_password;

    

    void Start(){
        GameVolume = PlayerPrefs.GetFloat("volume", 1);
        GameObject.Find("Background Music").GetComponent<AudioSource>().volume = GameVolume;
        if(PlayerPrefs.HasKey("nick")){
            wczytaj.interactable = true;
        }
        
        Cursor.SetCursor(kursor, Vector2.zero, CursorMode.ForceSoftware);
    }
    void Awake(){
        if(PlayerPrefs.HasKey("Zalogowano")){
            Zalogowano = PlayerPrefs.GetInt("Zalogowano", 0);
        }
        if(Zalogowano == 1){
            MainOptions.SetActive(false);
            PanelKonto.SetActive(true);
        }
    }
    void Update(){
        GameVolume = PlayerPrefs.GetFloat("volume", 1);
        GameObject.Find("Background Music").GetComponent<AudioSource>().volume = GameVolume;

        /*if((login.transform.GetChild(2).GetComponent<Text>().text != "")&&(haslo.transform.GetChild(2).GetComponent<Text>().text != "")){
            zaloguj.GetComponent<Button>().interactable = true;
        }else{
            zaloguj.GetComponent<Button>().interactable = false;
        }

        if(haslo.transform.GetChild(2).GetComponent<Text>().text != ""){
            ilosc_znakow = haslo.transform.GetChild(2).GetComponent<Text>().text.Length;
            replace_password = "";
            while(ilosc_znakow > 0){
                replace_password = replace_password + "*";
                ilosc_znakow--;
            }
            haslo.transform.GetChild(3).GetComponent<Text>().text = replace_password;
        }else{
            haslo.transform.GetChild(3).GetComponent<Text>().text = "";
        } */

    }
    public void Loadgame(){
        SceneManager.LoadScene("Glowny Interfejs");
    }
}
