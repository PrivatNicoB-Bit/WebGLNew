using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class widthheight : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        string screenWidth = Display.main.systemHeight.ToString();
        string screenHeight = Display.main.systemWidth.ToString();

        GetComponent<Text>().text = "Resolution : " + screenWidth + " X " + screenHeight;
    }
}
