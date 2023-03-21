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
        _amplitude = 3;
    }
    // Update is called once per frame
    private void Update()
    {
        transform.position = new Vector3(0f, Mathf.Sin(Time.time) + _amplitude + _positionInitiale, 0f);
    }
}
