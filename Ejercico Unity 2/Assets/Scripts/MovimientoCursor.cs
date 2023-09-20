using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovimientoCursor : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
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
