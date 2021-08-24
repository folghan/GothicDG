using UnityEngine;
using UnityEngine.SceneManagement; 

public class NewGame : MonoBehaviour
{
    void Start()
    {
        PlayerPrefs.SetString("Ekwipunek", "StaryMiecz(Clone)_0_true");
        SceneManager.SetActiveScene(SceneManager.GetSceneByName("New Game"));
    }
}
