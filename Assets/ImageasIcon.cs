using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Button : MonoBehaviour
{
    public TextAsset imageAsset;
    private Texture2D tex;
    // Start is called before the first frame update
    public void Start()
    {
        tex = new Texture2D(20, 20);
        tex.LoadImage(imageAsset.bytes);
        
    }

    void OnGUI ()
    {

        if(GUI.Button(new Rect(300,200,100,50), tex))
            {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex+1);
        }
    }

    private string GetDebuggerDisplay()
    {
        return ToString();
    }
}
