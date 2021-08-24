using UnityEngine;
using UnityEngine.SceneManagement; 

public class SceneChanger : MonoBehaviour
{
    public Scene scena;

    public void Ustawienia(){
        SceneManager.LoadScene("Settings", LoadSceneMode.Additive);
    }
    public void NowaGra(){
        SceneManager.LoadScene("New Game", LoadSceneMode.Additive);
    }

    public void Intro(){
        SceneManager.LoadScene("Intro");
    }

    public void Powrot(){
        SceneManager.UnloadSceneAsync(SceneManager.GetActiveScene().name);
    }
    public void PowrotDoMenu(){
        SceneManager.LoadScene("Main Menu");
    }
}
