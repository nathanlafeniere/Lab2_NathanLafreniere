using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cle_mur_script : MonoBehaviour
{
    private bool _touche = false;
    private MurDisparition _mur;


    private void Start()
    {
        _touche = false;
        _mur = FindObjectOfType<MurDisparition>();
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            if (!_touche)
            {
                this.gameObject.SetActive(false);
                _mur.disparition();
                _touche = true;
            }
        }


        

    }

}
