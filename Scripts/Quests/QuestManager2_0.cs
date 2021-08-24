using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuestManager2_0 : MonoBehaviour
{
    public GameObject[] PaneleDialogowe;
    public GameObject GameManager;
    //public GameObject Quest0;
    //public GameObject QuestPrefab;

    public List<string> AllQuests = new List<string>(); //Lista WSZYSTKICH dostępnych zadań
    public List<string> AcceptedQuests = new List<string>(); //Lista przyjętych questów w formacie TRESC_NAGRODA_ZLECENIODAWCA
    public List<string> lokacja = new List<string>(); //Lista dostępnych lokacji
    public List<string> coZrobic = new List<string>(); //Lista czynności do wykonania
    public List<string> czymZajac = new List<string>(); //Lista czynności do wykonania przez zleceniodawcę
    public List<string> postac = new List<string>(); //Lista polecających
    public List<string> jestes = new List<string>(); //Pochwała

    public int level;

    void Start(){ //Generowanie questów
        level = GameManager.GetComponent<GameManager>().level;
        {
            lokacja.Add("do jaskini przy południowej bramie Starego Obozu");
            lokacja.Add("do jaskini niedaleko chatki Cavalorna");
            lokacja.Add("do wierzy mgieł");
            lokacja.Add("do kanionu troli");
            lokacja.Add("na cmentarzysko orków");
            lokacja.Add("na święte ziemie orków");
            lokacja.Add("do wieży Xardasa");
            lokacja.Add("do karczmy w nowym obozie");
            lokacja.Add("do Wolnej Kopalni");
            lokacja.Add("do Starej Kopalni");
            lokacja.Add("do ruin zmiennokształtnych");
            lokacja.Add("do obozu bandytów");
            lokacja.Add("na plantację bagiennego ziela");
            lokacja.Add("do jaskini niedaleko Nowego Obozu");
            lokacja.Add("do jaskini pod kanionem");
            lokacja.Add("do chatki Cavalorna");
            lokacja.Add("do jaskini niedaleko wieży Xardasa");
            lokacja.Add("do starej wieży Xardasa");
            lokacja.Add("do starej cytadeli");
            lokacja.Add("do chatki Cor Kaloma");
            lokacja.Add("do świątyni Y'Beriona");
            lokacja.Add("do świątyni Magów Wody");
            lokacja.Add("do świątyni Magów Ognia");

            coZrobic.Add("znaleźć mój pierścień");
            coZrobic.Add("znaleźć pewien cenny pierścień");
            coZrobic.Add("znaleźć mój miecz");
            coZrobic.Add("znaleźć rzadki miecz");
            coZrobic.Add("znaleźć legendarny miecz");
            coZrobic.Add("znaleźć mój łuk");
            coZrobic.Add("znaleźć pewnien wyjątkowy łuk");
            coZrobic.Add("znaleźć moją kuszę");
            coZrobic.Add("znaleźć pewną wyjątkową kuszę");
            coZrobic.Add("znaleźć mój mieszek z rudą");
            coZrobic.Add("znaleźć moją runę");
            coZrobic.Add("przynieść mi 20 skór wilka");
            coZrobic.Add("przynieść mi 20 pazurów topielca");
            coZrobic.Add("przynieść mi 20 skór cieniostrwora");
            coZrobic.Add("przynieść mi 2 skóry trola");
            coZrobic.Add("przynieść mi 20 skór zębacza");
            coZrobic.Add("przynieść mi 5 mikstur życia");
            coZrobic.Add("przynieść mi 5 mikstur many");
            coZrobic.Add("przynieść mi 5 skrętów bagiennego ziela");
            coZrobic.Add("przynieść mi 10 butelek piwa");
            coZrobic.Add("przynieść mi 10 butelek ryżówki");
            coZrobic.Add("przynieść mi zioła lecznicze");
            coZrobic.Add("przynieść mi kilof");
            coZrobic.Add("przynieść mi 15 mięsa");
            coZrobic.Add("przynieść mi 70 milionów przejebanych na wybory, które się nie odbyły");
            coZrobic.Add("przynieść mi 6 skrzydeł krwiopijcy");
            coZrobic.Add("przynieść mi żądło krwiopijcy");
            coZrobic.Add("przynieść mi 28 ran kłutych");
            coZrobic.Add("zabić Kaczyńskiego");

            czymZajac.Add("muszę przegonić stąd paru świrów, którzy przysparzają nam sporo problemów");
            czymZajac.Add("jestem strasznie zajęty sytuacją w obozie");
            czymZajac.Add("muszę zająć się treningiem straży");
            czymZajac.Add("muszę zająć się pilnowaniem wejścia do obozu");
            czymZajac.Add("właśnie idę się zjarać bagiennym zielem");
            czymZajac.Add("muszę zająć się programowaniem tej gry");
            czymZajac.Add("jestem leniwy i mi się nie chce");
            czymZajac.Add("czeka mnie wizja od Śniącego");
            czymZajac.Add("Gomez mnie do siebie wzywa");
            czymZajac.Add("Lee mnie do siebie wzywa");
            czymZajac.Add("Y'Berion mnie do siebie wzywa");
            czymZajac.Add("trzeba wprowadzić lockdown");
            czymZajac.Add("dostałem bojowe zadanie, którego nie może wykonać nikt inny");
            czymZajac.Add("muszę naostrzyć broń i przygotować się do wyruszenia w drogę");

            postac.Add("Gomez");
            postac.Add("Angar");
            postac.Add("Diego");
            postac.Add("Gorn");
            postac.Add("Lee");
            postac.Add("Lester");
            postac.Add("Milten");
            postac.Add("Thorus");
            postac.Add("Xardas");
            postac.Add("Bezimienny");
            postac.Add("Folghan");
            postac.Add("Razjel");
            postac.Add("Krefta");
            postac.Add("Lares");
            postac.Add("Geralt");
            postac.Add("Aaron");
            postac.Add("Ian");
            postac.Add("Angar");
            postac.Add("Asghan");
            postac.Add("Merdarion");
            postac.Add("Mordrag");
            postac.Add("Myxir");
            postac.Add("Blizna");
            postac.Add("Bloodwyn");
            postac.Add("Bullit");
            postac.Add("Butch");
            postac.Add("Nefarius");
            postac.Add("Baal Orun");
            postac.Add("Baal Parvez");
            postac.Add("Cor Kalom");
            postac.Add("Cavalorn");
            postac.Add("Cipher");
            postac.Add("Cord");
            postac.Add("Corristo");
            postac.Add("Cronos");
            postac.Add("Riordian");
            postac.Add("Rodriguez");
            postac.Add("Ryżowy książe");
            postac.Add("Rączka");
            postac.Add("Damarok");
            postac.Add("Dexter");
            postac.Add("Drago");
            postac.Add("Drake");
            postac.Add("Drago");
            postac.Add("Saturas");
            postac.Add("Scatty");
            postac.Add("Fisk");
            postac.Add("Dexter");
            postac.Add("Stone");
            postac.Add("Siekacz");
            postac.Add("Szakal");
            postac.Add("Gorn");
            postac.Add("Torrez");
            postac.Add("Baal Tondral");
            postac.Add("Jarvis");
            postac.Add("Joru");
            postac.Add("Baal Kagan");
            postac.Add("Wilk");
            postac.Add("Wrzód");
            postac.Add("Kruk");
            postac.Add("Y'Berion");
            postac.Add("Lester");
            postac.Add("Lewus");
            postac.Add("Baal Lukor");

            jestes.Add("jedyną nadającą się do tej roboty osobą");
            jestes.Add("wykwalifikowanym pracownikiem typu \"przynieś, podaj, pozamiataj\"");
            jestes.Add("dobrym wojownikiem, więc raczej sobie poradzisz z tym zadaniem");
            jestes.Add("chłopcem na posyłki. Zobaczymy, czy miał rację");
            jestes.Add("typem gościa, co ma głowę na karku");
        }
        foreach(GameObject PanelDialogowy in PaneleDialogowe){
            int nagroda = (Random.Range(2,16)) * level - level/2 + 10;
            string Zleceniodawca = PanelDialogowy.name;
            string Zlecenie = "Hej ty! Mam dla ciebie zadanie. Udaj się " + lokacja[Random.Range(0, lokacja.Count)] + ", aby " + coZrobic[Random.Range(0, coZrobic.Count)] + ". Zrobiłbym to sam, ale " + czymZajac[Random.Range(0, czymZajac.Count)] + ". Zresztą, " + postac[Random.Range(0, postac.Count)] + " sam powiedział, że jesteś " + jestes[Random.Range(0, jestes.Count)] + ". Dostaniesz za to powiedzmy... " + nagroda + " bryłek rudy. Co ty na to?";
            AllQuests.Add(Zlecenie + "_" + nagroda + "_" +Zleceniodawca);
        }
    }
    public void ForceNewQuests(){
        
        AllQuests.Clear();
        level = GameManager.GetComponent<GameManager>().level;

        foreach(GameObject PanelDialogowy in PaneleDialogowe){
            int nagroda = (Random.Range(2,16)) * level - level/2 + 10;
            string Zleceniodawca = PanelDialogowy.name;
            string Zlecenie = "Hej ty! Mam dla ciebie zadanie. Udaj się " + lokacja[Random.Range(0, lokacja.Count)] + ", aby " + coZrobic[Random.Range(0, coZrobic.Count)] + ". Zrobiłbym to sam, ale " + czymZajac[Random.Range(0, czymZajac.Count)] + ". Zresztą, " + postac[Random.Range(0, postac.Count)] + " sam powiedział, że jesteś " + jestes[Random.Range(0, jestes.Count)] + ". Dostaniesz za to powiedzmy... " + nagroda + " bryłek rudy. Co ty na to?";
            AllQuests.Add(Zlecenie + "_" + nagroda + "_" +Zleceniodawca);
        }
    }
}