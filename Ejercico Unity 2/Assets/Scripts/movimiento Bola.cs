using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movimientoBola : MonoBehaviour
{
    public float velocidad = 5f;
    // Start is called before the first frame update
    void Start()
    {
        //Le da el impulso inicial a la bola
        GetComponent<Rigidbody2D>().velocity = Vector2.up * velocidad;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
