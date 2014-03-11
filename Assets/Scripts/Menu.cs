using UnityEngine;
using System.Collections;

public class Menu : MonoBehaviour {
    public int left;
    public int right;
    public int height;
    public int width;

    public Texture2D icon;

    private void OnGUI()
    {
        if (GUI.Button(new Rect(left, right, height, width), icon))
            Application.LoadLevel(Application.loadedLevelName);
    }
}
