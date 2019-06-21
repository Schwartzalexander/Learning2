using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class GUIscript : MonoBehaviour
{
    int clickCounter = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnGUI()
    {
        GUI.Box(new Rect(5, 5, 80, 20), "Score: " + clickCounter);
        if (GUI.Button(new Rect(5, 30, 80, 20), "Click me!"))
        {
            clickCounter++;
        }
        if (GUI.Button(new Rect(5, 60, 80, 20), "Reset"))
        {
            SceneManager.LoadScene("SampleScene");
        }

    }
}
