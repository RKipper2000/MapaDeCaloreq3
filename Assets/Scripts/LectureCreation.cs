using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;

public class LectureCreation : MonoBehaviour {

    public int sectorNum;
    void Start() {
        StartCoroutine(SendData());
    }

    public double Mapx(double value) {
        double  to2 = -100.29235084639414;
        double  from2 = -100.30783537136;
        double  from1 = -423.3;
        double  to1 = 408.9;
        return (value - from1) / (to1 - from1) * (to2 - from2) + from2;
    }

    public double Mapy(double value) {
        double  to2 =   25.728408037838058;
        double  from2 = 25.71530179910215;
        double  from1 = -441.4;
        double  to1 = 438.4;
        return (value - from1) / (to1 - from1) * (to2 - from2) + from2;
    }

    public IEnumerator SendData() {
        while(true) {
            int hijos = this.gameObject.transform.childCount;
            Transform hijo = this.gameObject.transform.GetChild(Random.Range(0, hijos));
            double valor = Random.Range(0,100);
            if (valor > 95) valor = Random.Range(90,250);
            //double valor;
            double latitud = Mapx(hijo.position.x);
            double longitud = Mapy(hijo.position.y);
            int sensor = 1;
            string sensorreq = "localhost:3000/api/logData/" + valor.ToString() + "/" + latitud.ToString() + "/" + longitud.ToString() + "/" + sectorNum.ToString() + "/" + sensor.ToString();
            //Debug.Log(sensorreq);
            UnityWebRequest www = UnityWebRequest.Post(sensorreq, "");
            
            yield return www.SendWebRequest();

            if (www.result != UnityWebRequest.Result.Success) {
                Debug.Log(www.error);
            }
            else {
                Debug.Log("Form upload complete!");
            }
            yield return new WaitForSeconds(0.1f);
        }
    }
}
