using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GestionJeu : MonoBehaviour
{
    
    //Attribut
    private int _pointage;
    private float _time;
   
    private FinNiveau _end;
    


    //Methode private

    // Start is called before the first frame update
    private void Start()
    {
        _end = FindObjectOfType<FinNiveau>();
        InstructionDepart();
        _pointage = 0;
        _time = 0;
        
    }

    private static void InstructionDepart()
    {
        Debug.Log("*** Course à obstacle");
        Debug.Log("Le but du jeu est d'atteindre la zone d'arrivée le plus rapidement possible");
        Debug.Log("Pour y arriver vous avez besion de trouver une clé caché dans chaque niveau");
        Debug.Log("Chaque contact avec un obstacle entraînera une pénalité");
    }

    // Update is called once per frame
    private void Update()
    {
        _time = Time.fixedTime;
        
    }

    private void Awake()
    {
        // Vérifie si un gameObject GestionJeu est déjà présent sur la scène si oui
        // on détruit celui qui vient d'être ajouté. Sinon on le conserve pour le 
        // scène suivante.
        int nbGestionJeu = FindObjectsOfType<GestionJeu>().Length;
        if (nbGestionJeu > 1)
        {
            Destroy(gameObject);
        }
        else
        {
            DontDestroyOnLoad(gameObject);
        }
    }
    
    public void AugmenterCollision()
    {
        _pointage++;
        //Debug.Log("Nombre d'accrochages : " + _pointage);
    }

    //methode public
    

    public void FinJeu()
    {
        Debug.Log("Partie terminé");
        Debug.Log("Temps : " + _time + " pénalité supplementaire : " + _pointage + " Temps total : " + (_time + _pointage));

        Debug.Log("Résultat Niveau 1");
        Debug.Log("Temps : " + _end.GetNiveau1Temps() + " pénalité supplementaire : " + _end.GetNiveau1Collision() + " Temps total : " + (_end.GetNiveau1Temps() + _end.GetNiveau1Collision()));

        Debug.Log("Résultat Niveau 2");
        Debug.Log("Temps : " + _end.GetNiveau2Temps() + " pénalité supplementaire : " + _end.GetNiveau2Collision() + " Temps total : " + (_end.GetNiveau2Temps() + _end.GetNiveau2Collision()));

        Debug.Log("Résultat Niveau 3");
        Debug.Log("Temps : " + _end.GetNiveau3Temps() + " pénalité supplementaire : " + _end.GetNiveau3Collision() + " Temps total : " + (_end.GetNiveau3Temps() + _end.GetNiveau3Collision()));

        
    }

    public int GetPointage()
    {
         return _pointage;
    }
}
