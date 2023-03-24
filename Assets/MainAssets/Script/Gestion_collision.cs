using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class Gestion_collision : MonoBehaviour
{
    private GestionJeu _gameManager;
    private bool _touche;
    private bool _nbTouche;
    private float _temps;
    
    // Start is called before the first frame update
    private void Start()
    {
        _gameManager = FindObjectOfType<GestionJeu>();
        _touche = false;
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            if (!_touche)
            {
                gameObject.GetComponent<MeshRenderer>().material.color = Color.red;
                _gameManager.AugmenterCollision();
                _touche = true;
                _temps = Time.time + 4;
            }
        }
    }

    private void FixedUpdate()
    {
        if (_touche)
        {
            if(_temps == Time.time)
            {
                _touche = false;
                gameObject.GetComponent<MeshRenderer>().material.color = Color.yellow;
            }
            
        }
    }

    


}
