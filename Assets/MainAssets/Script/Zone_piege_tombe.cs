using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Zone_piege_tombe : MonoBehaviour
{
     private bool _estActive = false;
    [SerializeField] private List<GameObject> _listPiege = new List<GameObject>();
    private List<Rigidbody> _listeRb = new List<Rigidbody>();
    [SerializeField] private float _intensiteForce = 1000;

    private void Start()
    {
        foreach(var piege in _listPiege)
        {
            _listeRb.Add(piege.GetComponent<Rigidbody>());
        }
       
    }

    private void OnTriggerEnter(Collider other)
    {

        if (other.gameObject.tag == "Player" && !_estActive)
        {
            foreach(var rb in _listeRb)
            {
                rb.useGravity = true;
                rb.AddForce(Vector3.down * _intensiteForce);
            }
            _estActive = true;
        }
    }
}
