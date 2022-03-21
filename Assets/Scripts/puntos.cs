using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class puntos
{
    public float latitud, longitud, valor;
    public int x, y;
    string zona = "Undefined";

    void Start(float lat, float lon, float v)
    {
        latitud = lat;
        longitud = lon;
        valor = v;
        // conversion
    }

    public Vector3 GetPosition()
    {
        return new Vector3(latitud, longitud);
    }

    public string getZona()
    {
        return zona;
    }

    public void setZona(string z)
    {
        zona = z;
    }

    public void setValor(float v)
    {
        valor = v;
    }

    public float getValor()
    {
        return valor;
    }
}


