using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class puntos : MonoBehaviour
{
    public float latitud, longitud, valor;
    public float x, y;
    string zona = "Undefined";

    public puntos()
    {
        latitud = 0;
        longitud = 0;
        valor = 0;
    }

    public puntos(float lat, float lon, float v)
    {
        latitud = lat;
        longitud = lon;
        valor = v;
        // conversion
    }

    private void Start()
    {
        valor = Random.Range(0,250);
        x = transform.position.x;
        y = transform.position.y;
    }

    public string getValor()
    {
        return ("valor de " + valor);
    }
}


