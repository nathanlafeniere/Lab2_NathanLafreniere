using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GestionJeu : MonoBehaviour
{
    
    //Attribut
    private int _pointage;
    static private float _time;
    private Player_mouvement _player;


    //Methode private

    // Start is called before the first frame update
    private void Start()
    {
        InstructionDepart();
        _pointage = 0;
        _time = 0;
        _player = FindObjectOfType<Player_mouvement>();
    }

    private static void InstructionDepart()
    {
        Debug.Log("*** Course � obstacle");
        Debug.Log("Le but du jeu est d'atteindre la zone d'arriv�e le plus rapidement possible");
        Debug.Log("Pour y arriver vous avez besion de trouver une cl� cach� dans chaque niveau");
        Debug.Log("Chaque contact avec un obstacle entra�nera une p�nalit�");
    }

    // Update is called once per frame
    private void Update()
    {
        _time = Time.fixedTime;
        
    }

    public void AugmenterCollision()
    {
        _pointage++;
        Debug.Log("Nombre d'accrochages : " + _pointage);
    }

    //methode public
    public void AugmenterPointage()
    {
        _pointage++;
        Debug.Log("Nombre d'accrochages : " + _pointage);
    }

    public void FinJeu()
    {
        Debug.Log("Niveau termin�");
        Debug.Log("Temps : " + _time + " p�nalit� supplementaire : " + _pointage + " Temps total : " + (_time + _pointage));
        _player.finPartie();
    }
}
