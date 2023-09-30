using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUp : MonoBehaviour
{
    public AudioSource sistemaAudio; 
    
    //Que se elimine al colisionar
    private void OnCollisionEnter2D(Collision2D collision)
    {
        sistemaAudio.Play();
        
        if (collision.gameObject.tag == "Player")
        {
            Destroy(this.gameObject);
        }
    }
}
