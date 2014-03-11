using UnityEngine;
using System.Collections;

public class EnterNextLevel : MonoBehaviour {
    public string levelname;

    void OnTriggerEnter2D(Collider2D other)
    {
        Application.LoadLevel(levelname);
    }
}
