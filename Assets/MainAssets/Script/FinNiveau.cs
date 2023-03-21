using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FinNiveau : MonoBehaviour
{

    //Attribut
    private GestionJeu _gameManager;
    private bool _touche = false;
    // Start is called before the first frame update
    private void Start()
    {

        _gameManager = FindObjectOfType<GestionJeu>();
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
            if (no_scene == 1)
            {
                if (!_touche)
                {
                    gameObject.GetComponent<MeshRenderer>().material.color = Color.green;

                    _touche = true;
                    _gameManager.FinJeu();
                }

            }
            else
            {
                SceneManager.LoadScene(no_scene + 1);
            }

        }
    }
}
