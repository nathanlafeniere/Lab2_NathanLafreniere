using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UpDown : MonoBehaviour
{
    [SerializeField] private float _amplitude;
    [SerializeField] private float _frequance;
    Vector3 _positionInitiale;


    private void Start()
    {
        _positionInitiale= transform.position;
        _amplitude = 0;
        _frequance= 0;
    }
    // Update is called once per frame
    private void Update()
    {
         for (float y = _positionInitiale.y; y < 10; y++)
        {
            transform.position = new Vector3(_positionInitiale.x, Mathf.Sin(Time.time*_frequance) + y, _positionInitiale.z);
        }
        for (float y = _positionInitiale.y; y > 0; y++)
        {
            transform.position = new Vector3(_positionInitiale.x, Mathf.Sin(Time.time * _frequance) - y, _positionInitiale.z);
        }


    }
}
