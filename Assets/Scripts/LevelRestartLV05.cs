using UnityEngine;
using System.Collections;

public class LevelRestartLV05 : MonoBehaviour {
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.name == "QiuFei")
        {
            Application.LoadLevel(Application.loadedLevelName);
        }
    }
}
