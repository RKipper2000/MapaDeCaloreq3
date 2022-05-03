using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;


public class API : MonoBehaviour {

    [System.Serializable]

    public class Lectura {
        public double valor;
        public double latitud;
        public double longitud;
    }

    [System.Serializable]
    public class lecturaslist {
        public Lectura[] lectura;
    }

    public lecturaslist mylecturaslist = new lecturaslist();

    public string results;

    public IEnumerator GetData() {
        string sensor = "1";
        string sensorreq = "localhost:3000/api/getDataBySector/"+sensor;
        Debug.Log(sensorreq);
        UnityWebRequest www = UnityWebRequest.Get(sensorreq);
        yield return www.Send();

        if (www.isNetworkError) {
            Debug.Log(www.error);
        }
        else {
            results = www.downloadHandler.text;

            Debug.Log("Hola" + results);

            mylecturaslist = JsonUtility.FromJson<lecturaslist>(("{\"lectura\":" + www.downloadHandler.text + "}"));
        }
    }
    void Start() {
        StartCoroutine(GetData());

    }
}
