using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FinNiveau : MonoBehaviour
{

    //Attribut
    private GestionJeu _gameManager;
    private GestionTemps _temps;
    private bool _touche = false;
    private int _finNiveau1Collision;
    private float _finNiveau1Temps;
    private int _finNiveau2Collision;
    private float _finNiveau2Temps;
    private int _finNiveau3Collision;
    private float _finNiveau3Temps;


    // Start is called before the first frame update
    private void Start()
    {

        _gameManager = FindObjectOfType<GestionJeu>();
        _temps = FindObjectOfType<GestionTemps>();
        _touche = false;
    }

    // Update is called once per frame
    private void Update()
    {
        if (_touche)
        {
            if (Input.GetKey(KeyCode.Escape))
            {
                Application.Quit();
            }
        }
    }

    private void Awake()
    {
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

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            int no_scene = SceneManager.GetActiveScene().buildIndex;
            if (no_scene == 2)
            {
                if (!_touche)
                {
                    gameObject.GetComponent<MeshRenderer>().material.color = Color.green;
                    _finNiveau3Collision = _gameManager.GetPointage() - (_finNiveau2Collision+_finNiveau1Collision);
                    _finNiveau3Temps = _temps.GetTemps() - (_finNiveau2Temps + _finNiveau1Temps);
                    _touche = true;
                    _gameManager.FinJeu();
                }

            }
            if (no_scene == 0)
            {
                if (!_touche)
                {
                    _finNiveau1Collision = _gameManager.GetPointage();
                    Debug.Log(_finNiveau1Collision);
                    _finNiveau1Temps = _temps.GetTemps();
                    Debug.Log("here");
                    SceneManager.LoadScene(no_scene + 1);
                }
            }
            if (no_scene == 1)
            {
                if (!_touche)
                { 
                    _finNiveau2Collision = _gameManager.GetPointage() - _finNiveau1Collision;
                    _finNiveau2Temps = _temps.GetTemps() - _finNiveau1Temps;
                    
                    SceneManager.LoadScene(no_scene + 1);
                }
            }

        }
    }

    public int GetNiveau1Collision()
    {
        return _finNiveau1Collision;
    }
    public int GetNiveau2Collision()
    {
        return _finNiveau1Collision;
    }
    public int GetNiveau3Collision()
    {
        return _finNiveau3Collision;
    }

    public float GetNiveau1Temps()
    {
        return _finNiveau1Temps;
    }

    public float GetNiveau2Temps()
    {
        return _finNiveau2Temps;
    }
    public float GetNiveau3Temps()
    {
        return _finNiveau3Temps;
    }

}
