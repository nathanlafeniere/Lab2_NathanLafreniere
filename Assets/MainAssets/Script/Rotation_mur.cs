using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotation_mur : MonoBehaviour
{
    [SerializeField] private float _vitesseRotation = 5f;


    private void FixedUpdate()
    {
        transform.Rotate(0f, _vitesseRotation, 0f);
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
