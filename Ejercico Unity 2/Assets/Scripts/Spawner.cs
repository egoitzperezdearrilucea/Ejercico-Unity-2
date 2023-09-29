using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Random = UnityEngine.Random;

public class Spawner : MonoBehaviour
{
    public GameObject enemigo;
    public GameObject vida;
    public GameObject powerTamaño;
    public GameObject powerTamañoEnemigo;
    public Text textoTiempo;
    private float tiempo;
    
    
    // Start is called before the first frame update
    void Start()
    {
        
      //Spawns periodicos
        InvokeRepeating("SpawnEnemigos", 15.0f, 10.0f);
        Invoke("SpawnPowerTamaño", 20f);
        Invoke("SpawnPowerTamañoEnemigo", 40f);
        
        //Spawn Inicial
        Instantiate(vida, transform.position = new Vector3(0f,0f,0f), Quaternion.identity);
        
        Instantiate(enemigo, transform.position = new Vector3(-0.5f,-1f,0f), Quaternion.identity);
        Instantiate(enemigo, transform.position = new Vector3(0.5f,-1f,0f), Quaternion.identity);
        Instantiate(enemigo, transform.position = new Vector3(-1f,0f,0f), Quaternion.identity);
        Instantiate(enemigo, transform.position = new Vector3(1f,0f,0f), Quaternion.identity);
        Instantiate(enemigo, transform.position = new Vector3(0.5f,1f,0f), Quaternion.identity);
        Instantiate(enemigo, transform.position = new Vector3(-0.5f,1f,0f), Quaternion.identity);
        
        
    }

    // Update is called once per frame
    void Update()
    {
        //Tiempo
        tiempo += Time.deltaTime;
        textoTiempo.text = "Tiempo:" + Math.Round(tiempo, 2);

    }

    //Spawn de enemigos y vida
    private void SpawnEnemigos()
    {
        Debug.Log("spawn enemigos");
            
        Instantiate(vida, transform.position = new Vector3(Random.Range(-10,10),Random.Range(-4,5),0), Quaternion.identity);

        for (int i = 0; i < Random.Range(1,5); i++)
        {
            Instantiate(enemigo, transform.position = new Vector3(Random.Range(-10,10),Random.Range(-4,5),0), Quaternion.identity);
        }
            
        
    }
    
    //Spawn de power up tamaño
    private void SpawnPowerTamaño()
    {
        Debug.Log("spawn power up tamaño");
            
        Instantiate(powerTamaño, transform.position = new Vector3(Random.Range(-10,10),Random.Range(-4,5),0), Quaternion.identity);
    }
    
    //Spawn de power up tamaño
    private void SpawnPowerTamañoEnemigo()
    {
        Debug.Log("spawn power up tamaño enemigo");
            
        Instantiate(powerTamañoEnemigo, transform.position = new Vector3(Random.Range(-10,10),Random.Range(-4,5),0), Quaternion.identity);
    }
}
