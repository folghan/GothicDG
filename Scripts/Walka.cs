using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Walka : MonoBehaviour
{
    public GameObject GameManager;
    public GameObject PanelWalki;
    public GameObject Player;
    public GameObject Enemy;
    public GameObject CooldownPanel;
    public GameObject PanelWynik;
    public GameObject EqManager2_0;
    public GameObject InterfejsGlowny;

    string PlayerName;
    int Level;
    int CacheHP;
    int HP;
    int Strenght;
    int Agility;

    float PlayerHpPosition;
    float PlayerHpPosition1;
    float EnemyHpPosition;
    float EnemyHpPosition1;

    string EnemyName;
    int EnemyCacheHP;
    int EnemyHP;
    int EnemyStrenght;
    int EnemyAgility;
    int EnemyExp;

    GameObject MainWeapon;
    GameObject SecondaryWeapon;

    public List<string> Enemies = new List<string>();


    void Awake(){
        Enemies.Add("Młody ścierwojad-20-5-5-10");
        Enemies.Add("Ścierwojad-50-10-10-20");
        Enemies.Add("Młody wilk-40-10-10-20");
        Enemies.Add("Wilk-70-20-20-40");
        Enemies.Add("Warg-150-40-40-100");
        Enemies.Add("Krwiopijec-30-5-5-15");
        Enemies.Add("Topielec-100-35-35-70");
        Enemies.Add("Zębacz-80-60-60-120");
    }

    public void StartBattle(){
        PlayerName = GameManager.GetComponent<GameManager>().nick;
        HP = GameManager.GetComponent<GameManager>().hp;
        Level = GameManager.GetComponent<GameManager>().level;
        CacheHP = HP;
        Strenght = GameManager.GetComponent<GameManager>().strength;
        Agility = GameManager.GetComponent<GameManager>().agility;

        MainWeapon = GameManager.GetComponent<GameManager>().MainWeapon;
        SecondaryWeapon = GameManager.GetComponent<GameManager>().SecondaryWeapon;

        PlayerHpPosition = Player.transform.GetChild(1).GetChild(1).GetComponent<RectTransform>().sizeDelta.x;
        PlayerHpPosition1 = Player.transform.GetChild(1).GetChild(1).GetComponent<RectTransform>().anchoredPosition.x;

        EnemyHpPosition = Enemy.transform.GetChild(1).GetChild(1).GetComponent<RectTransform>().sizeDelta.x;
        EnemyHpPosition1 = Enemy.transform.GetChild(1).GetChild(1).GetComponent<RectTransform>().anchoredPosition.x;

        if(SecondaryWeapon == null){
            PanelWalki.transform.GetChild(1).GetComponent<Button>().interactable = false;
        }else{
            PanelWalki.transform.GetChild(1).GetComponent<Button>().interactable = true;
        }

        Player.transform.GetChild(2).GetChild(1).GetComponent<Text>().text = PlayerName;
        
        GenerateNewEnemy();

        Enemy.transform.GetChild(2).GetChild(1).GetComponent<Text>().text = EnemyName;

        CalculateHP();
    }

    void GenerateNewEnemy(){
        string RandomEnemy = Enemies[Random.Range(0, Enemies.Count)];
        string[] EnemyData = RandomEnemy.Split('-');
        EnemyName = EnemyData[0];
        EnemyHP = int.Parse(EnemyData[1]);
        EnemyCacheHP = EnemyHP;
        EnemyStrenght = int.Parse(EnemyData[2]);
        EnemyAgility = int.Parse(EnemyData[3]);
        EnemyExp = int.Parse(EnemyData[4]);

        Enemy.transform.GetChild(0).GetComponent<Image>().sprite = Resources.Load<Sprite>("Enemies/" + EnemyData[0]); //+ ".jpg");
    }

    void CalculateHP(){
        
        string SetHP = CacheHP + "/" + HP;
        
        Player.transform.GetChild(1).GetChild(2).GetComponent<Text>().text = SetHP;
        Player.transform.GetChild(1).GetChild(1).GetComponent<RectTransform>().sizeDelta = new Vector2 (PlayerHpPosition * ((float)CacheHP/(float)HP), Player.transform.GetChild(1).GetChild(1).GetComponent<RectTransform>().sizeDelta.y);
        Player.transform.GetChild(1).GetChild(1).GetComponent<RectTransform>().anchoredPosition = new Vector2(PlayerHpPosition1 - ((PlayerHpPosition - Player.transform.GetChild(1).GetChild(1).GetComponent<RectTransform>().sizeDelta.x)/2), Player.transform.GetChild(1).GetChild(1).GetComponent<RectTransform>().anchoredPosition.y);
        if(CacheHP <= 0){
            Debug.Log("PRZEGRALES");
            StopBattle(1);
        }

        string EnemySetHP = EnemyCacheHP + "/" + EnemyHP;
        Enemy.transform.GetChild(1).GetChild(2).GetComponent<Text>().text = EnemySetHP;
        Enemy.transform.GetChild(1).GetChild(1).GetComponent<RectTransform>().sizeDelta = new Vector2 (EnemyHpPosition * ((float)EnemyCacheHP/(float)EnemyHP), Enemy.transform.GetChild(1).GetChild(1).GetComponent<RectTransform>().sizeDelta.y);
        Enemy.transform.GetChild(1).GetChild(1).GetComponent<RectTransform>().anchoredPosition = new Vector2(EnemyHpPosition1 - ((EnemyHpPosition - Enemy.transform.GetChild(1).GetChild(1).GetComponent<RectTransform>().sizeDelta.x)/2), Enemy.transform.GetChild(1).GetChild(1).GetComponent<RectTransform>().anchoredPosition.y);
        if(EnemyCacheHP <= 0){
            Debug.Log("Wygrales!");
            StopBattle(0);
        }
    }

    public void MainAttack(){
        CooldownPanel.SetActive(true);
        int minDMG;
        int maxDMG;
        if(MainWeapon != null){
            minDMG = MainWeapon.transform.GetChild(2).GetComponent<ItemParameter>().minDmg;
            maxDMG = MainWeapon.transform.GetChild(2).GetComponent<ItemParameter>().maxDmg;
        }else{
            minDMG = 1;
            maxDMG = 50;
        }
        int PlayerDMG = Random.Range(minDMG, 2*Strenght);
        if(PlayerDMG > maxDMG){
            PlayerDMG = maxDMG;
        }
        PerformMainAttack(PlayerDMG);
        StartCoroutine(EnemyTurn());
    }
    public void SecondaryAttack(){
        CooldownPanel.SetActive(true);
        int minDMG = SecondaryWeapon.transform.GetChild(2).GetComponent<ItemParameter>().minDmg;
        int maxDMG = SecondaryWeapon.transform.GetChild(2).GetComponent<ItemParameter>().maxDmg;
        int PlayerDMG = Random.Range(minDMG, 2*Strenght);
        if(PlayerDMG > maxDMG){
            PlayerDMG = maxDMG;
        }
        PerformMainAttack(PlayerDMG);
        if((EnemyCacheHP > 0)&&(CacheHP > 0)){
            StartCoroutine(EnemyTurn());
        }
        
    }

    void PerformMainAttack(int RecivedDMG){
        EnemyCacheHP -= RecivedDMG;
        CalculateHP();
    }
    void PerformSecondaryAttack(int RecivedDMG){
        EnemyCacheHP -= RecivedDMG;
        CalculateHP();
    }
    void EnemyPerformMainAttack(int RecivedDMG){
        CacheHP -= RecivedDMG;
        CalculateHP();
    }
    void EnemyPerformSecondaryAttack(int RecivedDMG){
        CacheHP -= RecivedDMG;
        CalculateHP();
    }

    private IEnumerator EnemyTurn(){
        while(EnemyCacheHP > 0){
            yield return new WaitForSeconds(Random.Range(1, 3));

            //int EnemyDMG = (int)(1.5f * EnemyStrenght);
            int EnemyDMG = (int)Random.Range(EnemyStrenght/2, 1.5f*EnemyStrenght);
            EnemyPerformMainAttack(EnemyDMG);
            if(CacheHP > 0){
                CooldownPanel.SetActive(false);
            }
            //int EnemyDecision = Random.Range(0, 4)
            //LoadEQ();
            break;
        }//
    }

    void StopBattle(int Wynik){
        CooldownPanel.SetActive(true);
        PanelWynik.SetActive(true);
        if(Wynik == 0){
            if(Random.Range(0,1000) < 50){
                InterfejsGlowny.SetActive(true);
                EqManager2_0.GetComponent<EqManager2_0>().CreateNewItem();
                InterfejsGlowny.SetActive(false);
            }
            PanelWynik.transform.GetChild(0).GetComponent<Text>().text = "Zwyciężyłeś!";
            int nagroda = Random.Range(5, 30);
            PanelWynik.transform.GetChild(1).GetComponent<Text>().text = "Zdobyłeś " + nagroda + " bryłek rudy oraz " + EnemyExp + " punktów doświadczenia!";
            GameManager.GetComponent<GameManager>().AddExpQF(EnemyExp);
            GameManager.GetComponent<GameManager>().AddRudeQF(nagroda);
        }else{
            PanelWynik.transform.GetChild(0).GetComponent<Text>().text = "Przegrałeś!";
            int nagroda = Random.Range(1, 15);
            PanelWynik.transform.GetChild(1).GetComponent<Text>().text = "Utraciłeś " + nagroda + " bryłek rudy!";
            GameManager.GetComponent<GameManager>().RemoveRudeQF(nagroda);
        }
    }

    public void ResetFight(){
        Player.transform.GetChild(1).GetChild(1).GetComponent<RectTransform>().sizeDelta = new Vector2 (PlayerHpPosition, Player.transform.GetChild(1).GetChild(1).GetComponent<RectTransform>().sizeDelta.y);
        Player.transform.GetChild(1).GetChild(1).GetComponent<RectTransform>().anchoredPosition = new Vector2(PlayerHpPosition1, Player.transform.GetChild(1).GetChild(1).GetComponent<RectTransform>().anchoredPosition.y);
        Enemy.transform.GetChild(1).GetChild(1).GetComponent<RectTransform>().sizeDelta = new Vector2 (EnemyHpPosition, Enemy.transform.GetChild(1).GetChild(1).GetComponent<RectTransform>().sizeDelta.y);
        Enemy.transform.GetChild(1).GetChild(1).GetComponent<RectTransform>().anchoredPosition = new Vector2(EnemyHpPosition1, Enemy.transform.GetChild(1).GetChild(1).GetComponent<RectTransform>().anchoredPosition.y);
    }


//Zwyciężyłeś!
//Przegrałeś!
//Utraciłeś 50 bryłek rudy.
//Zdobyłeś 5 bryłek rudy oraz 150 punktów doświadczenia!
}
