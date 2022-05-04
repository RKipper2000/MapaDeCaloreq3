using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;

public class APISpawn : MonoBehaviour {
    // Start is called before the first frame update
    string url = "http://localhost:3000/lastProm";
    public GameObject sensorG;

    void Start() {
        StartCoroutine("GetSensor");
    }

    // Update is called once per frame
    void Update() {
        
    }

    [System.Serializable]
    public class Sensor {
        public string medicion, fecha, hora, x, y;

    }

    [System.Serializable]
    public class RootSensors {
        public Sensor[] sensors;
    }

    IEnumerator GetSensor() {

        while (true) {
            //counter += 0.01f;

            using (UnityWebRequest www = UnityWebRequest.Get(url)) {
                yield return www.SendWebRequest();
                if (www.result != UnityWebRequest.Result.Success)  {
                    Debug.Log("Result is " + www.result);
                    Debug.Log(www.error);
                }
                else
                {
                    Debug.Log(www.responseCode);
                    Debug.Log(www.downloadHandler.text);
                    RootSensors json = JsonUtility.FromJson<RootSensors>(("{\"sensors\":" + www.downloadHandler.text + "}"));

                    foreach (var sensor in json.sensors)
                    {
                        Debug.Log("Sensor creado!!");
                        //Vector3 position = new Vector3(float.Parse(sensor.x), float.Parse(sensor.y), (-2.1f - counter));
                        //Instantiate(sensorG, position, Quaternion.Euler(-55,0,0));
                        //var sensorinfo = sensorG.GetComponent<sensor>();
                        //sensorinfo.medicion = sensor.medicion;
                        
                    }
                }
            }


            yield return new WaitForSeconds(2);

        }


    }
}