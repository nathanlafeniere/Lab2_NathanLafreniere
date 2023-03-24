using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GestionTemps : MonoBehaviour
{
    //Attribut
    static private float _time;
    private bool _touche;
    // Start is called before the first frame update


    void Start()
    {
        _time = 0;
        _touche = false;
    }

    // Update is called once per frame
    void Update()
    {
        _time = Time.time;
        //Debug.Log(_time);
    }
    private void OnTriggerEnter(Collider other)
    {

        if (other.gameObject.tag == "Player" && !_touche)
        {
            _time = 0;
            _touche = true;
            
        }
    }

    public float GetTemps()
    {
        return _time;
    }
}
