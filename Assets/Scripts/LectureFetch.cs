using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;
//using Unity.JsonUtility;
//using SimpleJSON;



public class LectureFetch : MonoBehaviour {
    public class Lectura {
        float valor;
        float latitud;
        float longitud;
    }
    [SerializeField] int sectorID;

    // Start is called before the first frame update
    void Start() {
        StartCoroutine(FetchSpawn());
    }

    // Update is called once per frame
    private IEnumerator FetchSpawn() {
        while (true) {

            UnityWebRequest www = UnityWebRequest.Get("http://localhost:3000/api/getLogs");
            yield return www.Send();

            if (www.isNetworkError) {
                Debug.Log(www.error);
            }
            else {
                // Show results as text
                Debug.Log(www.downloadHandler.text);

                // Or retrieve results as binary data
                //results = www.downloadHandler.text;
            }



            string url = "http://localhost:3000/api/getDataBySector/:" + sectorID;

            UnityWebRequest data = UnityWebRequest.Get(url);
            //Lectura myObject = JsonUtility.FromJson<Lectura>(data);

            yield return new WaitForSeconds(10);
        }
    }

    void update() {

    }
}
