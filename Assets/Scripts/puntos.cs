using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class puntos : MonoBehaviour
{
    public float latitud, longitud, valor;
    public float x, y;
    //string zona = "Undefined";

    public puntos() {
        latitud = 0;
        longitud = 0;
        valor = 0;
    }

    public puntos(float lat, float lon, float val)
    {
        latitud = lat;
        longitud = lon;
        valor = val;
        // conversion
    }

    private void Start() {
        x = transform.position.x;
        y = transform.position.y;
    }

    public void setValor(double val)
    {
        valor = (float)val;
    }

    public float vlr()
    {
        return valor;
    }
}


