using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;


public class API : MonoBehaviour {
    public GameObject puntos;
    void Start() {
        StartCoroutine(GetData());
    }

    [SerializeField] public string sectorNum;

    [System.Serializable]
    public class Lectura {
        public double valor, latitud, longitud;
    }

    [System.Serializable]
    public class lecturaslist {
        public Lectura[] lectura;
    }

    //[SerializeField] public lecturaslist mylecturaslist = new lecturaslist();
    //Lectura[] mylecturaslist;

    string results;
    public double Mapx(double value) {
        double  to1 = -100.29235084639414;
        double  from1 = -100.30783537136;
        double  from2 = -423.3;
        double  to2 = 408.9;
        return (value - from1) / (to1 - from1) * (to2 - from2) + from2;
    }

    public double Mapy(double value) {
        double  to1 =   25.728408037838058;
        double  from1 = 25.71530179910215;
        double  from2 = -441.4;
        double  to2 = 438.4;
        return (value - from1) / (to1 - from1) * (to2 - from2) + from2;
    }

    
    IEnumerator GetData() {
        while(true) {
            string sensorreq = "localhost:3000/api/getDataBySector/" + sectorNum;
            //+ sectorNum.ToString();
            //Debug.Log(sensorreq);
            UnityWebRequest www = UnityWebRequest.Get(sensorreq);
            yield return www.SendWebRequest();

            if (www.result != UnityWebRequest.Result.Success) {
                Debug.Log(www.error);
            }
            else {
                results = www.downloadHandler.text;
                //Debug.Log("Hola" + results);
                lecturaslist mylecturaslist = JsonUtility.FromJson<lecturaslist>(("{\"lectura\":" + www.downloadHandler.text + "}"));
                
                foreach (var lecture in mylecturaslist.lectura) {
                    lecture.latitud = Mapx(lecture.latitud);
                    lecture.longitud = Mapy(lecture.longitud);
                    Instantiate(puntos, new Vector3(((float)lecture.latitud), (float)lecture.longitud), Quaternion.identity);
                    var sensorinfo = puntos.GetComponent<puntos>();
                    sensorinfo.setValor(lecture.valor);
                    Debug.Log("Se crea lectura");
                }
            }
            yield return new WaitForSeconds(1);
        }

        

        //Debug.Log(lecture.latitud);
    }
    /*
    IEnumerator GetSensor() {

        while (true) {

            using (UnityWebRequest www = UnityWebRequest.Get("localhost:3000/api/getDataBySector/" + sectorNum)) {
                yield return www.SendWebRequest();
                if (www.result != UnityWebRequest.Result.Success)  {
                    Debug.Log("Result is " + www.result);
                    Debug.Log(www.error);
                }
                else
                {
                    Debug.Log(www.responseCode);
                    Debug.Log(www.downloadHandler.text);
                    lecturaslist json = JsonUtility.FromJson<lecturaslist>(("{\"sensors\":" + www.downloadHandler.text + "}"));

                    foreach (var sensor in json.lectura)
                    {
                        Debug.Log("Sensor creado!!");
                        Vector3 position = new Vector3(float.Parse(sensor.x), float.Parse(sensor.y), (-2.1f - counter));
                        Instantiate(sensorG, position, Quaternion.Euler(-55,0,0));
                        //var sensorinfo = sensorG.GetComponent<sensor>();
                        //sensorinfo.medicion = sensor.medicion;
                        
                    }
                }
            }


            yield return new WaitForSeconds(2);

        }


    }
    */
}
