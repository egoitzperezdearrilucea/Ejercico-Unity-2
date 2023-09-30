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
    private GameObject[] enemigos;
    public AudioSource sistemaAudio; 
    
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
                sistemaAudio.Play();
                Time.timeScale = 0f;
                texto.text = "Game over";
                Debug.Log("Game over");
            
                //hace el cursor visible
                Cursor.visible = true;
            }
        }
        
        //Colision con power ups
  
        //El power up de tamaño
        else if (collision.gameObject.tag == "TamañoJugador")
        {
            cursor.transform.localScale = new Vector3(0.1f, 0.1f, 0.1f);
        }
        
        //El power up de tamaño enemigo
        else if (collision.gameObject.tag == "TamañoEnemigo")
        {
            enemigos = GameObject.FindGameObjectsWithTag("Enemigo");
            foreach (var enemigo in enemigos)
            {
                enemigo.transform.localScale = new Vector3(0.5f, 0.5f, 0.5f);
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
