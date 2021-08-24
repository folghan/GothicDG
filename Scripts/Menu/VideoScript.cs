using UnityEngine;
using UnityEngine.Video;
using UnityEngine.SceneManagement; 
using UnityEngine.UI;

public class VideoScript : MonoBehaviour
{

    public VideoPlayer intro;
    public Text loading;
    public Text skip;
    float IntroVolume;

    void Start(){
        PlayerPrefs.SetInt("Zalogowano", 0);
        IntroVolume = PlayerPrefs.GetFloat("volume", 1);
        intro.GetComponent<VideoPlayer>().SetDirectAudioVolume(0,IntroVolume);
    }

    void Update()
    {
        if(intro.isPrepared){
            loading.enabled = false;
            skip.enabled = true;
            check();
        }
        if(Input.GetKey(KeyCode.Space)){
            Skip();
        }
    }
    void check(){

        if(!intro.isPlaying){
            Skip();
        }
    }
    public void Skip(){
        SceneManager.LoadScene("Main Menu");
    }
}
