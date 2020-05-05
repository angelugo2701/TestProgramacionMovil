using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextChanger : MonoBehaviour
{
    public Text text;
    public InputField inptBox;


    public void PressButton()
    {
        text.text = inptBox.text;
    }
}
