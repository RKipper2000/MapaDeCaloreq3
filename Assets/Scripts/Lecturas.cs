using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lecturas : MonoBehaviour
{
    List<puntos> listaDePuntos = new List<puntos>() 
    { new puntos { latitud = 1.5, longitud = 3.5 }, new puntos { latitud = 2, longitud = 7 } };
    public GameObject[] zonas;
    // dictionary 
    // Start is called before the first frame update
    void Start()
    {
        zonas = GameObject.FindGameObjectsWithTag("Zona");
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    GameObject masCercano (puntos pt)
    {

    }
    /*
     requieren: estructuras de datos (investigar dictionary)
    funcion para encontrar la zona mas cercana al punto
    forma de que los puntos declaren sus propios valores de latitud y longitud
     * */
}

