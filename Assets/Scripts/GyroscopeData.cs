using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GyroscopeData : MonoBehaviour
{
    public Text gyroText;
    // Start is called before the first frame update
    void Start()
    {
        Input.gyro.enabled = true;
    }

    // Update is called once per frame
    void Update()
    {
        gyroText.text = Input.gyro.attitude.ToString();
    }
}
