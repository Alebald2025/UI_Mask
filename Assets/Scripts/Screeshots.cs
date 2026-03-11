using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;
using UnityEngine.UI;

public class Screeshots : MonoBehaviour
{
    [SerializeField] RawImage screenshot;
    [SerializeField] string screenShotName = "wazaa.png";

    public void tomarCaptura()
    {
        ScreenCapture.CaptureScreenshot(screenShotName, 2);
        Debug.Log(screenShotName);
    }

    public void mostrarCaptura()
    {
        string path = Application.dataPath + "/" + screenShotName;
        if (File.Exists(path))
        {
            byte[] fileData = File.ReadAllBytes(path);
            Texture2D tex = new Texture2D(2, 2);
            tex.LoadImage(fileData);
            screenshot.texture = tex;
        }
    }
}
