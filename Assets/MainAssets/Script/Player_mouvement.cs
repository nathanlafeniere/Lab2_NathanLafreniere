using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_mouvement : MonoBehaviour
{
    [SerializeField] private float _vitesse;
   

    private Rigidbody _rb;
    // Start is called before the first frame update
    private void Start()
    {
        this.transform.position = new Vector3(-0.037f, 0.51f, -44.78f);
        _vitesse = 600f;
        _rb = GetComponent<Rigidbody>();
    }

    private void FixedUpdate()
    {
        Mouvement_joueur();
        
    }
    // Update is called once per frame
    private void Update()
    {
        
    }

    private void Mouvement_joueur()
    {
        float positionX = Input.GetAxis("Horizontal");
        float positionZ = Input.GetAxis("Vertical");

        Vector3 direction = new Vector3(positionX, 0f, positionZ);
        _rb.AddForce(_rb.velocity = direction * Time.fixedDeltaTime * _vitesse);
    }

    public void finPartie()
    {
        this.gameObject.SetActive(false);
    }
}
