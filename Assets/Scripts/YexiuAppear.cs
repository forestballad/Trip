using UnityEngine;
using System.Collections;

public class YexiuAppear : MonoBehaviour {
    public string yexiuName;
    GameObject YeXiu;

    void OnTriggerEnter2D(Collider2D other)
    {
        YeXiu = GameObject.Find(yexiuName);
        YeXiu.GetComponent<SpriteRenderer>().color = Color.white;
    }
}
