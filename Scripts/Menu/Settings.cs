using UnityEngine;
using UnityEngine.SceneManagement; 
using UnityEngine.UI;

public class Settings : MonoBehaviour
{

    public GameObject VolumeSlider;
    public GameObject Volume;
    int volumeValue;

    void Start()
    {
        float SetVolumeValue = PlayerPrefs.GetFloat("volume", 1);
        SetVolumeValue *= 100;
        VolumeSlider.GetComponent<Slider>().value = SetVolumeValue;
        volumeValue = (int)VolumeSlider.GetComponent<Slider>().value;
        Volume.GetComponent<Text>().text = volumeValue + "%";
    }

    public void ChangeVolume(){
        float volume = VolumeSlider.GetComponent<Slider>().value;
        volume = volume/100;
        PlayerPrefs.SetFloat("volume", volume);
        volumeValue = (int)VolumeSlider.GetComponent<Slider>().value;
        Volume.GetComponent<Text>().text = volumeValue + "%";
    }

    public void CurrentVolume(){
        volumeValue = (int)VolumeSlider.GetComponent<Slider>().value;
        Volume.GetComponent<Text>().text = volumeValue + "%";
    }

}
