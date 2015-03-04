using UnityEngine;
using System.Collections;

public class SceneFadeInOut : MonoBehaviour 
{
    public float fadeSpeed = 3f;

    bool sceneStarting = true;

    void Awake()
    {
        GetComponent<GUITexture>().pixelInset = new Rect(0f, 0f, Screen.width, Screen.height);
    }

    void Update()
    {
        if (sceneStarting){
            StartScene();
        }
    }

    void FadeToClear()
    {
        GetComponent<GUITexture>().color = Color.Lerp(GetComponent<GUITexture>().color, Color.clear, fadeSpeed = Time.deltaTime);
    }

    void FadeToBlack()
    {
        GetComponent<GUITexture>().color = Color.Lerp(GetComponent<GUITexture>().color, Color.black, fadeSpeed = Time.deltaTime);
    }

    void StartScene()
    {
        FadeToClear();

        if (GetComponent<GUITexture>().color.a == 0.05f)
        {
            GetComponent<GUITexture>().enabled = false;
        }
    }

    public void EndScene()
    {
        GetComponent<GUITexture>().enabled = true;

        FadeToBlack();
    }
}
