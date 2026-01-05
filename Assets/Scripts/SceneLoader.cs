using UnityEngine;
using UnityEngine.SceneManagement; // Necessario per gestire le scene

public class SceneLoader : MonoBehaviour
{
    // Lista delle scene da caricare. Puoi modificarla anche dall'Inspector.
    public string[] sceneDaCaricare = new string[]
    {
        "Environment",
        "Props",
        "Lighting",
        "Audio"
    };

    void Start()
    {
        foreach (string nomeScena in sceneDaCaricare)
        {
            CaricaScenaSeNonEsiste(nomeScena);
        }
    }

    void CaricaScenaSeNonEsiste(string nomeScena)
    {
        // Controlla se la scena è già caricata per evitare doppioni
        Scene scena = SceneManager.GetSceneByName(nomeScena);

        if (!scena.isLoaded)
        {
            // Carica la scena in modalità "Additive" (si sovrappone, non sostituisce)
            SceneManager.LoadScene(nomeScena, LoadSceneMode.Additive);
            Debug.Log($"Scena '{nomeScena}' caricata.");
        }
    }
}