using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class MovimientoCursor : MonoBehaviour
{
    
    private int vidas = 3;
    public Text textoVidas;
    public Text texto;
    public GameObject cursor;
    
    // Start is called before the first frame update
    void Start()
    {
        //hace el cursor invisible
        Cursor.visible = false;
        
        //impide que el cursor salga de la pantalla
        Cursor.lockState = CursorLockMode.Confined;
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
    
    //Colisiones
    private void OnCollisionEnter2D(Collision2D collision)
    {
        //Colision con el enemigo
        if (collision.gameObject.tag == "Enemigo")
        {
            //Restar vidas
            vidas--;
            textoVidas.text = "Vidas:" + vidas;

            //si las vidas llegan a cero game over
            if (vidas <= 0)
            {
                Time.timeScale = 0f;
                texto.text = "Game over";
                Debug.Log("Game over");
            
                //hace el cursor visible
                Cursor.visible = true;
            }
        }
        
        //Colision con power ups
        else  if (collision.gameObject.tag == "PowerUp")
        {
            //El power up de tamaño
            if (collision.gameObject.name == "Tamaño")
            {
                cursor.transform.localScale = new Vector3(0.1f, 0.1f, 0.1f);
            }
        }
        
        //Recoger vida
        else if (collision.gameObject.tag == ("Vida"))
        {
            vidas++;
            textoVidas.text = "Vidas:" + vidas;
        }
    }
}
