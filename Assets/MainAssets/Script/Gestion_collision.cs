using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gestion_collision : MonoBehaviour
{

    private bool _touche;
    // Start is called before the first frame update
    private void Start()
    {
        _touche = false;
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            if (!_touche)
            {
                gameObject.GetComponent<MeshRenderer>().material.color = Color.red;
                _touche = true;
            }
        }
    }
}
