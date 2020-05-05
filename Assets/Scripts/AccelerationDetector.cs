using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AccelerationDetector : MonoBehaviour
{
    public Text accelerationText;
 
    void Update()
    {
        accelerationText.text = Input.acceleration.ToString();
    }
}
