using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class MovimientoCursor : MonoBehaviour
{
    
    public Text texto;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }
    
    //Game over cuando colisione
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Enemigo")
        {       
            Time.timeScale = 0f;
            texto.text = "Game over";
            Debug.Log("Game over");
        }

    }

    // Update is called once per frame
    void Update()
    {
        //recoger la posicion de el cursor
        Vector3 mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        mousePosition.z = Camera.main.transform.position.z + Camera.main.nearClipPlane;
        //pasar la posicion al sprite
        transform.position = mousePosition;
        
    }
}
