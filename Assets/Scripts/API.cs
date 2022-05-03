using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;


public class API : MonoBehaviour
{

    [System.Serializable]

    public class Lectura
    {

        public double valor;
        public double latitud;
        public double longitud;
    }

    [System.Serializable]
    public class lecturaslist
    {
        public Lectura[] lectura;
    }

    public lecturaslist mylecturaslist = new lecturaslist();



    public string results;



    public IEnumerator GetData()
    {
        string sensor = "1";
        string sensorreq = "localhost:3000/api/getDataBySector/"+sensor;
        Debug.Log(sensorreq);
        UnityWebRequest www = UnityWebRequest.Get(sensorreq);
        yield return www.Send();

        if (www.isNetworkError)
        {
            Debug.Log(www.error);
        }
        else
        {
            //Debug.Log("Success");

            // Show results as text


            // Or retrieve results as binary data
            results = www.downloadHandler.text;

            mylecturaslist = JsonUtility.FromJson<lecturaslist>(("{\"lectura\":" + www.downloadHandler.text + "}"));
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(GetData());

        





    }

    // Update is called once per frame
    void Update()
    {
        //Debug.Log(results);
        


    }
}
