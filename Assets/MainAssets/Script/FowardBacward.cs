using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FowardBacward : MonoBehaviour
{
    
    [SerializeField] private float _amplitude = 1;

    Vector3 _positionInitiale;
    private float _vitesse = 10;

    private void Start()
    {
        _positionInitiale = transform.position;

    }
    // Update is called once per frame
    private void Update()
    {

        if (transform.position.z >= 43)
        {
            _amplitude = -1;
        }
        else if (transform.position.z <= -27)
        {
            _amplitude = 1;
        }

        transform.position = transform.position + new Vector3(0f, 0f, _vitesse * _amplitude * Time.deltaTime);
    }
}
