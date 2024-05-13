using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Vibrator : MonoBehaviour
{


    public void PressButton()
    {
        Handheld.Vibrate();
    }
}
