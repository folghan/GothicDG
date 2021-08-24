using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement; 
using UnityEngine.Video;

public class MainScreenScript : MonoBehaviour
{

    public GameObject ekwipunek;
    public GameObject postac;
    public GameObject DziennikZadan;
    public GameObject GlownyInterfejs;
    public GameObject InterfejsStaryOboz;
    public GameObject InterfejsNowyOboz;
    public GameObject InterfejsObozNaBagnie;
    public string nick;
    public float GameVolume;
    public GameObject[] Soundtrack;
    public GameObject[] PlayerNick;

    public VideoPlayer jebaitedVid;
    public GameObject jebaitedObj;
    bool jebaited;

    void Start()
    {
        nick = PlayerPrefs.GetString("nick", "NaN");
        GameVolume = PlayerPrefs.GetFloat("volume", 1);
        Soundtrack = GameObject.FindGameObjectsWithTag("Music");
        PlayerNick = GameObject.FindGameObjectsWithTag("Nick");
        foreach(GameObject music in Soundtrack){
            music.GetComponent<AudioSource>().volume = GameVolume;
        }
        foreach(GameObject nick1 in PlayerNick){
            nick1.GetComponent<Text>().text = nick;
        }
        jebaited = false;
    }

    void Update()
    {
        if((jebaited)&&(jebaitedVid.isPrepared)){
            if(!jebaitedVid.isPlaying){
                GameObject.Find("Audio Source").GetComponent<AudioSource>().volume = GameVolume;
                jebaitedObj.SetActive(false);
            }
        }
    }

    public void Jebaited(){
        GameObject.Find("Audio Source").GetComponent<AudioSource>().volume = 0;
        jebaitedObj.SetActive(true);
        jebaited = true;
    }
    public void StaryOboz(){
        GlownyInterfejs.SetActive(false);
        InterfejsStaryOboz.SetActive(true);
    }
    public void PowrotStaryOboz(){
        GlownyInterfejs.SetActive(true);
        InterfejsStaryOboz.SetActive(false);
    }
    public void NowyOboz(){
        GlownyInterfejs.SetActive(false);
        InterfejsNowyOboz.SetActive(true);
    }
    public void PowrotNowyOboz(){
        GlownyInterfejs.SetActive(true);
        InterfejsNowyOboz.SetActive(false);
    }
    public void ObozNaBagnie(){
        GlownyInterfejs.SetActive(false);
        InterfejsObozNaBagnie.SetActive(true);
    }
    public void PowrotObozNaBagnie(){
        GlownyInterfejs.SetActive(true);
        InterfejsObozNaBagnie.SetActive(false);
    }

    public void OtworzPostac(){
        postac.SetActive(true);
    }
    public void ZamknijPostac(){
        postac.SetActive(false);
    }
    public void OtworzEkwipunek(){
        ekwipunek.SetActive(true);
    }
    public void ZamknijEkwipunek(){
        ekwipunek.SetActive(false);
    }
    public void OtworzDziennikZadan(){
        DziennikZadan.SetActive(true);
    }
    public void ZamknijDziennikZadan(){
        DziennikZadan.SetActive(false);
    }
    public void PowrotDoMenu(){
        SceneManager.LoadScene("Main Menu");
    }
}
